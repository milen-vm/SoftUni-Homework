<?php
if (isset($_POST['text']) && $_POST['text'] != '') {
	$text = $_POST['text'];
	$coloredChars = [];
	
	for ($i=0; $i < strlen($text); $i++) { 
		$charCode = ord($text[$i]);
		
		if ($charCode % 2 == 0) {
			$coloredChars[] = "<span>{$text[$i]} </span>";
		} else {
			$coloredChars[] = "{$text[$i]} ";
		}		
	}
}
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Text Colorer</title>
		<link href="style.css" rel="stylesheet" />
	</head>
	<body>
		<form method="post" action="">
			<textarea name="text">What a wonderful world!</textarea>
			<br />
			<input type="submit" value="Color text" />
		</form>
		<p id="blue">
			<?php 
			if (isset($coloredChars)) {
				echo implode('', $coloredChars);
			}
			?>
		</p>
	</body>
</html>