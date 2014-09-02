<?php
if (isset($_POST['text']) && isset($_POST['word'])) {
	if ($_POST['text'] != '' && $_POST['word'] != '') {
		$text = $_POST['text'];
		$word = $_POST['word'];
		$pattern = '/\b[a-zA-Z\s,’\'–\-:)(]+[\.|\?|!]/';
		$countSentences = preg_match_all($pattern, $text, $sentences);

		if ($countSentences > 0) {
			$result = '';
			foreach ($sentences[0] as $sent) {
				$pattern = '/\b' . $word . '\b/';
				$countWords = preg_match($pattern, $sent);
				
				if ($countWords > 0) {
					$result .= htmlentities($sent) . '<br />';
				}
			}
		}
	}
}
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Text Filter</title>
		<link href="style.css" rel="stylesheet" />
	</head>
	<body>
		<form method="post">
			<label for="text">Enter text:</label>
			<br />
			<textarea name="text" id="text">This is my cat! And this is my dog. We happily live in Paris - 
the most beautiful city in the world! Isn't it great? Well it is :)</textarea>
			<br />
			<label for="word">Enter word:</label>
			<br />
			<input type="text" name="word" id="word" />
			<br />
			<input type="submit" />
		</form>
		<p>
			<?php
			if (isset($result)) {
				echo $result;
			}
			?>
		</p>
	</body>
</html>
