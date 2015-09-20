<?php
if (isset($_POST['userName'])) {
    $userName = $_POST['userName'];
    if (!empty($userName) && !ctype_space($userName)) {
        session_start();
        $_SESSION['userName'] = $userName;
        $_SESSION['secretNumber'] = mt_rand(1, 100);
        header('Location: play.php');
        exit;
    } 
	
    $errorMsg = 'Empty name.';
}
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Register</title>
        <meta charset="UTF-8" />
    </head>
    <?php if(isset($errorMsg)) : ?>
        <h2>Error: <?= $errorMsg ?></h2>
    <?php endif ?>
    <form method="post" action="">
        Name:
        <input type="text" name="userName" />
        <input type="submit" name="submit" value="Start game" />
    </form>
</html>