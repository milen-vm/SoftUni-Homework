<?php
if (isset($_POST['text'])) {
	if ($_POST['text'] != '') {
		$text = $_POST['text'];
		$pattern = '/<a href=[\'\"]([^<>]+)[\'\"]>([^<>]+)<\/a>/';
		preg_match_all($pattern, $text);
		$text = preg_replace($pattern, '[URL=$1]$2[/URL]', $text);
	}
}
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>URL Replacer</title>
		<link href="style.css" rel="stylesheet" />
	</head>
	<body>
		<form method="post">
			<label for="text">Enter text:</label>
			<br />
			<textarea name="text" id="text"></textarea>
			<br />
			<input type="submit" />
		</form>
		<?php
		if (isset($text)) {
			echo $text;
		}
		?>
	</body>
</html>