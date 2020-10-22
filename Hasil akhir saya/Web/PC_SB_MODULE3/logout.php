<?php
    require_once('./config/connection.php');
    error_reporting(0);

    header('Content-type: application/json');
    header('Access-Control-Allow-Method: POST');

    if($_SERVER["REQUEST_METHOD"] === "POST"){
        http_response_code(200);
        echo json_encode(array("response" => "Sukses menonaktifkan token akses dan mengembalikan ke halaman utama sebelum login"));
    }
?>