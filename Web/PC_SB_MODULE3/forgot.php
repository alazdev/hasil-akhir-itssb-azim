<?php
    require_once('./config/connection.php');
    error_reporting(0);

    header('Content-type: application/json');
    header('Access-Control-Allow-Method: POST');

    if($_SERVER["REQUEST_METHOD"] === "POST"){
        $data = json_decode(file_get_contents("php://input"));
        if($data){
            if(!$data->email){
                http_response_code(400);
                echo json_encode(array("response" => "Mohon maaf email wajib diisi"));
            }else{
                
                $getStudent = "SELECT id, email FROM student WHERE email='".$data->email."' LIMIT 1";
                
                $result = $conn->query($getStudent)->fetch_assoc();

                if ($result != null) {
                    $hsl = array($result);

                    $to_email = $data->email;
                    $subject = "Reset Password";
                    $body = "Your link reset password: <a href='http://localhost/PC_SB_MODULE3/reset.php?encryptedStudentId=". md5($hsl[0]["id"]) ."'>http://localhost/PC_SB_MODULE3/reset.php?encryptedStudentId=". md5($hsl[0]["id"]) ."</a>";
                    $headers = 'From: Localhost Hosting'. "\r\n";
                    
                    if (mail($to_email, $subject, $body, $headers)) {
                        echo json_encode(array("response" => "Email berhasil dikirim ke $to_email..."));
                    } else {
                        echo json_encode(array("response" => "Email gagal dikirim..."));
                    }
                } else {
                    $getTeacher = "SELECT id, email FROM teacher WHERE email='".$data->email."' LIMIT 1";
                    $result = $conn->query($getTeacher)->fetch_assoc();

                    if ($result != null) {
                        $hsl = array($result);
    
                        $to_email = $data->email;
                        $subject = "Reset Password";
                        $body = "Your link reset password: <a href='http://localhost/PC_SB_MODULE3/reset.php?encryptedTeacherId=". md5($hsl[0]["id"]) ."'>http://localhost/PC_SB_MODULE3/reset.php?encryptedTeacherId=". md5($hsl[0]["id"]) ."</a>";
                        $headers = 'From: Localhost Hosting'. "\r\n";
                        
                        if (mail($to_email, $subject, $body, $headers)) {
                            echo json_encode(array("response" => "Email berhasil dikirim ke $to_email..."));
                        } else {
                            echo json_encode(array("response" => "Email gagal dikirim..."));
                        }
                    } else {
                        http_response_code(404);
                        echo json_encode(array("response" => "Mohon maaf email yang anda masukkan tidak terdaftar"));
                }
                $conn->close();
            }
        }else{
            http_response_code(400);
            echo json_encode(array("response" => "Mohon maaf email wajib diisi"));
        }
    }
?>