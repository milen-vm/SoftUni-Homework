<?php
$text = $_GET['text'];
$hashValue = $_GET['hashValue'];
$fontSize = $_GET['fontSize'];
$style = $_GET['fontStyle'];

for ($i=0; $i < strlen($text); $i++) {
	$charCode = ord($text[$i]);
	if (($i + 1) % 2 == 0) {
		$charCode -= $hashValue;
	} else {
		$charCode += $hashValue;
	}
	$text[$i] = chr($charCode);
}
$font = ($style == 'bold') ? 'font-weight:' : 'font-style:';

echo '<p style="font-size:' . $fontSize . ';' . $font . $style . ';">' . $text . '</p>';
?>

<!DOCTYPE html>
<html>
<head>
    <title></title>
    <style>
        label, textarea, input {
            display: block;
        }
        textarea {
            width: 300px;
            height: 200px;
        }
    </style>
</head>
<body>
<form method="get" action="">
    <label>Text:</label>
    <textarea name="text">Warning: Our encryption is unbreakable and you will not be able to decrypt your information!</textarea>
    <label>Hash value:</label>
    <input type="text" name="hashValue" value="1"/>
    <label>Font size:</label>
    <input type="text" name="fontSize" value="30"/>
    <label>Font style:</label>
    <select name="fontStyle"/>
        <option value="bold">Bold</option>
        <option value="normal">Normal</option>
        <option value="italic">Italic</option>
    </select>
    <input type="submit" />
</form>
</body>
</html>