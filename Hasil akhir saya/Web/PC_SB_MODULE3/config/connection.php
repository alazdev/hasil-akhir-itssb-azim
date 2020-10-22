<?php
    try{
        $servername = "localhost";
        $username = "root";
        $password = "";
        $dbname = "PC_SB_MODULE3";
        
        $conn = new mysqli($servername, $username, $password, $dbname);
    }catch(Exception $e){
        echo "Connection Error";
    }
?>