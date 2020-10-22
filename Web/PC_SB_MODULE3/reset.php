<?php
    require_once('./config/connection.php');
    error_reporting(0);

    header('Content-type: application/json');
    header('Access-Control-Allow-Method: POST');

    if($_SERVER["REQUEST_METHOD"] === "POST"){
        if (isset($_GET['encryptedStudentId'])) {
            $data = json_decode(file_get_contents("php://input"));
            $idHash = $_GET['encryptedStudentId'];
            if(!$data->newPassword || !$data->confNewPassword){
                http_response_code(400);
                echo json_encode(array("response" => "Mohon maaf newPassword dan confNewPassword wajib diisi"));
            }else{
                $getStudent = "SELECT id FROM student";
                
                $result = $conn->query($getStudent);

                if ($result != null) {
                    $hasil = array();
                    while($row = $result->fetch_assoc()) {
                        $hasil[] = $row;
                    }
                    foreach ($hasil as $key) {
                        if(md5($key['id']) == $idHash){
                            if($data->newPassword == $data->confNewPassword){
                                $sql = $conn->prepare("UPDATE student SET password='". md5($data->newPassword) ."' WHERE id='". $key['id'] ."'");
                                $sql->execute();
                                if ($sql) {
                                    echo json_encode(array('response' => 'Sukses mengubah kata sandi'));
                                } else {
                                    echo json_encode(array('RESPONSE' => 'Update Failed'));
                                }
                            }else{
                                http_response_code(400);
                                echo json_encode(array("response" => "Mohon maaf kata sandi dan konfirmasi kata sandi tidak cocok"));
                            }
                        }
                    }
                } else {
                    http_response_code(404);
                    echo json_encode(array("response" => "Gagal dalam mereset password"));
                }
                $conn->close();
            }
        }else if (isset($_GET['encryptedTeacherId'])) {
            $data = json_decode(file_get_contents("php://input"));
            $idHash = $_GET['encryptedTeacherId'];
            if(!$data->newPassword || !$data->confNewPassword){
                http_response_code(400);
                echo json_encode(array("response" => "Mohon maaf newPassword dan confNewPassword wajib diisi"));
            }else{
                $getStudent = "SELECT id FROM teacher";
                
                $result = $conn->query($getStudent);

                if ($result != null) {
                    $hasil = array();
                    while($row = $result->fetch_assoc()) {
                        $hasil[] = $row;
                    }
                    foreach ($hasil as $key) {
                        if(md5($key['id']) == $idHash){
                            if($data->newPassword == $data->confNewPassword){
                                $sql = $conn->prepare("UPDATE teacher SET password='". md5($data->newPassword) ."' WHERE id='". $key['id'] ."'");
                                $sql->execute();
                                if ($sql) {
                                    echo json_encode(array('response' => 'Sukses mengubah kata sandi'));
                                }
                            }else{
                                http_response_code(400);
                                echo json_encode(array("response" => "Mohon maaf kata sandi dan konfirmasi kata sandi tidak cocok"));
                            }
                        }
                    }
                } else {
                    http_response_code(404);
                    echo json_encode(array("response" => "Gagal dalam mereset password"));
                }
                $conn->close();
            }
        }
    }
?>