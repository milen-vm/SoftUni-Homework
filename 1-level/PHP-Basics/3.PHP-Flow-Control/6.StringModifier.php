<?php
mb_internal_encoding('UTF-8');
header('Content-Type: text/html; charset=UTF-8');
if (isset($_POST['string']) && $_POST['string'] != '' && isset($_POST['modifier'])) {
	$string = $_POST['string'];
	$modifier = $_POST['modifier'];
	switch ($modifier) {
		case 'palindrome':
			$result = isPalindrome($string);
			break;
		case 'reverse':
			$result = strrev($string);
			break;
		case 'split':
			$result = implode(' ', str_split($string));
			break;
		case 'hash':
			$result = crypt($string, '$5$rounds=5000$usesomesillystringforsalt$');
			break;
		case 'shuffle':
			$result = str_shuffle($string);
			break;
	} 
}

function isPalindrome($string)
{
	$stringLower = mb_strtolower($string);
	if ($stringLower == strrev($stringLower)) {
		return htmlentities($string) . ' is a palindrome!';
	} else {
		return htmlentities($string) . ' is not a palindrome!';
	}
}
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>String Modifier</title>
	</head>
	<body>
		<form method="post" action="">
			<input type="text" name="string" autofocus="autofocus" required="required" />			
			<input type="radio" name="modifier" value="palindrome" id="pal" required="required" />
			<label for="pal">Check Palindrome</label>
			<input type="radio" name="modifier" value="reverse" id="rev" />
			<label for="rev">Reverse string</label>
			<input type="radio" name="modifier" value="split" id="spl" />
			<label for="spl">Split</label>
			<input type="radio" name="modifier" value="hash" id="hash" />
			<label for="hash">Hash String</label>
			<input type="radio" name="modifier" value="shuffle" id="shuf" />
			<label for="shuf">Shuffle String</label>
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
