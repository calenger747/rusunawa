<?php
include 'connection.php';

if(isset($_GET['id']) && isset($_GET['action'])){
        $action = $_GET['action'];
        $id = $_GET['id'];
        if($action == "approve"){
            mysqli_query($conn,"UPDATE user SET status='Diterima!' WHERE id=$id");
        }else if($action == "disapprove"){
            mysqli_query($conn,"UPDATE user SET status='Tidak Diterima' WHERE id=$id");
    }
?>