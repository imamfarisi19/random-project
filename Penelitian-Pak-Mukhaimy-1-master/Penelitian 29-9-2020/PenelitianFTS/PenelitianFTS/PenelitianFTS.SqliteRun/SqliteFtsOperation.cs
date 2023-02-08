using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PenelitianFTS.SqliteRun
{
    public class SqliteFtsOperation
    {
        SqliteFtsContext dbContext;


        public SqliteFtsOperation()
        {
            dbContext = new SqliteFtsContext();
            // dbContext.Database.EnsureCreated();
            if (!IsTableExist())
            {
                Console.WriteLine("Create tables...");
                CreateTables();
            }
        }

        private void CreateTables()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine(@"PRAGMA foreign_keys = off;");
            sb.AppendLine(@"BEGIN TRANSACTION;");
            sb.AppendLine(@"");
            sb.AppendLine(@"CREATE TABLE BagianBuku (");
            sb.AppendLine(@"    Id             TEXT NOT NULL");
            sb.AppendLine(@"                        CONSTRAINT PK_BagianBuku PRIMARY KEY,");            
            sb.AppendLine(@"    Judul          TEXT,");
            sb.AppendLine(@"    NomorBagian    TEXT,");
            sb.AppendLine(@"    Isi            TEXT");
            sb.AppendLine(@");");
            sb.AppendLine(@"");            
            sb.AppendLine(@"CREATE VIRTUAL TABLE BagianBuku_Index USING fts5 (");
            sb.AppendLine(@"    Id, ");
            sb.AppendLine(@"    Isi");
            sb.AppendLine(@");");
            sb.AppendLine(@"");
            sb.AppendLine(@"COMMIT TRANSACTION;");
            sb.AppendLine(@"PRAGMA foreign_keys = on;");


            using (var command = dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sb.ToString();
                dbContext.Database.OpenConnection();
                // var reader = command.ExecuteReader();
                var reader = command.ExecuteNonQuery();
            }

        }

        private bool IsTableExist()
        {
            bool response = false;
            string tableName = "BagianBuku";
            using (var command = dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}';";
                dbContext.Database.OpenConnection();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    response = reader[0].ToString() == tableName;
                }
            }
            return response;
        }

        public string OAdd(BagianBuku item)
        {
            try
            {
                dbContext.BagianBukuSet.Add(item);
                dbContext.BagianBuku_indexz.Add(new BagianBuku_index()
                {
                    Id = item.Id,
                    Isi = item.Isi,
                });
                dbContext.SaveChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return "SqFT ERROR: " + ex.Message;
            }
        }

        public string ODelete(BagianBuku item)
        {
            try
            {
                Guid id = item.Id;
                dbContext.BagianBukuSet.Remove(item);
                var index1 = dbContext.BagianBuku_indexz.Find(id);
                if (index1 != null)
                    dbContext.BagianBuku_indexz.Remove(index1);
                dbContext.SaveChanges();

                return "1";
            }
            catch (Exception ex)
            {
                return "SqFT ERROR: " + ex.Message;
            }
        }

        public string OUpdate(BagianBuku item)
        {
            try
            {
                dbContext.Update(item);
                Guid id = item.Id;
                var index1 = dbContext.BagianBuku_indexz.Find(id);
                index1.Isi = item.Isi;
                dbContext.Update(index1);
                dbContext.SaveChanges();

                return "1";
            }
            catch (Exception ex)
            {
                return "SqFT ERROR: " + ex.Message;
            }
        }

        public string ODeleteAll()
        {
            try
            {
                dbContext.BagianBukuSet.RemoveRange(dbContext.BagianBukuSet);
                dbContext.BagianBuku_indexz.RemoveRange(dbContext.BagianBuku_indexz);
                dbContext.SaveChanges();

                return "1";
            }
            catch (Exception ex)
            {
                return "SqFT ERROR: " + ex.Message;
            }
        }

        
        public List<BagianBuku> Match(string key)
        {
            key = key.Trim();
            key = key.Replace("  ", " ");
            key = key.Replace(" ", " OR ");
            return MatchExact(key);
        }

        public List<BagianBuku> MatchExact(string key)
        {            
            var x = dbContext.BagianBukuSet.FromSqlRaw($"SELECT * FROM BagianBuku INNER JOIN (SELECT Id as idOrg FROM BagianBuku_index WHERE BagianBuku_index MATCH '{key}' ORDER BY rank) as t2 ON BagianBuku.Id = t2.idOrg;").ToList();
            return x;
        }

        public List<BagianBuku> GetAll()
        {
            return dbContext.BagianBukuSet.ToList();
        }

        public int Count() => dbContext.BagianBukuSet.Count();

        public int CountIndex() => dbContext.BagianBuku_indexz.Count();
    }
}
