<?php
	// koneksi ke database 
	$conn = mysqli_connect("localhost", "root", "", "test1");

	// ambil data dari tabel mahasiswa / query data mahasiwa 
	$result = mysqli_query($conn, "SELECT * FROM mahasiswa");

	$row = mysqli_fetch_assoc($result)
?>

