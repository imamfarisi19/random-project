var mysql = require('mysql');

var con = mysql.createConnection({
	host: 'localhost',
	user: 'root',
	password: '',
	database: 'mydb'
});

con.connect(function(err) {
	if (err) throw err;
	console.log("Connected!");
	var createTable = "CREATE TABLE customers (name VARCHAR(255), address VARCHAR(255))";
	var insertInto = "INSERT INTO customers (name, address) VALUES ('Company Inc', 'Highway 37')";
	con.query(insertInto, function (err, result) {
		if (err) throw err;
		console.log("1 record inserted");
	});
});

