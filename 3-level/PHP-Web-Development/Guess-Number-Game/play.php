<?php
if (isset($_POST['number'])) {
    $number = intval($_POST['number']);
    if ($number >= 1 && $number <= 100) {
        if (session_status() == PHP_SESSION_NONE) {
            session_start();
        }
        echo $_SESSION['secretNumber'];
        $secretNumber = $_SESSION['secretNumber'];
        if ($number < $secretNumber) {
            $message = 'Up';
        } elseif ($number > $secretNumber) {
            $message = 'Down';
        } else {
            $message = 'Congratulations, ' . htmlentities($_SESSION['userName']);
            $isWin = TRUE;
        }
    } else {
        $message = 'Invalid number';
    }
}
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Play</title>
        <meta charset="UTF-8" />
    </head>
    <body>
        <?php
        if (session_status() == PHP_SESSION_NONE) {
            session_start();
        }
        if(isset($_SESSION['userName'])) : ?>
            <form method="post" action="">
                <p>Gues secret number in range [1..100]</p>
                <input type="number" min="1" max="100" name="number" autofocus="" />
                <input type="submit" value="Try it" />
            </form>
        <?php
        else : 
            header('Location: index.php');
        endif ?>
        <?php if(isset($message)) : ?>
            <h2><?= $message ?> !</h2>
        <?php endif ?>
        <?php if(isset($isWin)) :
            session_destroy(); ?>
            <a href="index.php">[Play Again]</a>
        <?php endif ?>
    </body>
</html>