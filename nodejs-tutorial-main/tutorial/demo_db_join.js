var mysql = require('mysql');

var con = mysql.createConnection({
	host: "localhost",
	user: "root",
	password: "",
	database: "mydb"
});

con.connect(function(err) {
	if (err) throw err;
	console.log("CONNECTED");
	var val = 
		[
			[1, 'John', 154],
			[2, 'Peter', 154],
			[3, 'Amy', 155],
			[4, 'Hannah', null],
			[5, 'Michael',null],

		];
	var val2 = 
		[
			[154, 'Chocolate Heaven'],
			[155, 'Tasty Lemons'],
			[156, 'Vanilla Dreams'],

		];
	var sql = "SELECT users.name AS user, products.name AS favorite FROM users JOIN products ON users.favorite_product = products.id";
	con.query(sql, function (err, result) {
		if (err) throw err;
		console.log(result);
	});

});
