<?php
    require_once('./config/connection.php');
    error_reporting(0);

    header('Content-type: application/json');
    header('Access-Control-Allow-Method: POST');

    if($_SERVER["REQUEST_METHOD"] === "POST"){
        $data = json_decode(file_get_contents("php://input"));
        if($data){
            if(!$data->username || !$data->password){
                http_response_code(400);
                echo json_encode(array("response" => "Mohon maaf username dan password wajib diisi"));
            }else{
                $getStudent = "SELECT id FROM student WHERE email='".$data->username."' AND password='". md5($data->password) ."' LIMIT 1";
                
                $result = $conn->query($getStudent)->fetch_assoc();

                if ($result != null) {
                    $hsl = array($result);

                    $dateNow = date("Y-m-d H:i:sa");
                    $hash = md5($hsl[0]['id'].'-student-'.$dateNow);
                    $sql = $conn->prepare("INSERT INTO access_token (user_id,user_type,token,expired_at,created_at) VALUES (". $hsl[0]['id'] .", 'siswa', '$hash', 3600, '$dateNow')");
                    $sql->execute();
                    if ($sql) {
                        echo json_encode(array('token' => $hash));
                    }
                } else {
                    $getTeacher = "SELECT id FROM teacher WHERE email='".$data->username."' AND password='". md5($data->password) ."' LIMIT 1";
                    $result = $conn->query($getTeacher)->fetch_assoc();

                    if ($result != null) {
                        $hsl = array($result);

                        $dateNow = date("Y-m-d H:i:sa");
                        $hash = md5($hsl[0]['id'].'-teacher-'.$dateNow);
                        $idBaru = $hsl[0]['id'];
                        $sql = $conn->prepare("INSERT INTO access_token (user_id,user_type,token,expired_at,created_at) VALUES (". $idBaru .", 'teacher', '$hash', 3600, '$dateNow')");
                        $sql->execute();
                        if ($sql) {
                            echo json_encode(array('token' => $hash));
                        }
                    } else {
                        http_response_code(401);
                        echo json_encode(array("response" => "Mohon maaf maaf akses yang anda masukkan tidak terdaftar"));
                    }
                }
                $conn->close();
            }
        }else{
            http_response_code(400);
            echo json_encode(array("response" => "Mohon maaf username dan password wajib diisi"));
        }
    }
?>