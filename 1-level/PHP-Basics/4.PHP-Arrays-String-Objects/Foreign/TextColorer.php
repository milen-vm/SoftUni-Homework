<html>
<head>
    <meta charset="UTF-8">
    <title>Coloring Text</title>
    <style>
        .blue{
            color: blue;
        }
        .red{
            color: red;
        }
    </style>
</head>
<body>

<form action="" method="post">
    <input type="text" name="input"/>
    <input type="submit"/>
</form>

<?php
if(isset($_POST['input']) && !empty($_POST['input'])){

    $text=$_POST['input'];
    $color="";
    $len=strlen($text);
    for($i=0;$i<$len;$i++){
        $color='blue';
        if(ord($text[$i])%2==0){
            $color='red';
        }
        echo "<span class='".$color."';>$text[$i]</span>";
    }
}
?>

</body>
</html>