<?php
$text = $_GET['text'];
$blacklist = preg_split('/\s+/', $_GET['blacklist'], -1 , PREG_SPLIT_NO_EMPTY);
$pattern = '/[A-Za-z0-9\+_-]+@[A-Za-z0-9-]+\.[A-Za-z0-9-\.]+/';
preg_match_all($pattern, $text, $emails);
$emails = $emails[0];

for ($i=0; $i < count($emails); $i++) { 
	$email = $emails[$i];
	$notCensored = TRUE;
	
	for ($j=0; $j < count($blacklist); $j++) {
		$blackMail = $blacklist[$j];
		
		if ($blackMail[0] === '*') {
			$blackMail = str_replace('*', '', $blackMail);
			$length = -1 * (strlen($blackMail));
			$subString = substr($email, $length);
			
			if ($subString === $blackMail) {
				$censorString = str_repeat('*', strlen($email));
				$text = str_replace($email, $censorString, $text);
				$notCensored = FALSE;
				break;
			}
		} elseif (strpos($email, $blackMail) !== FALSE) {
			$censorString = str_repeat('*', strlen($email));
			$text = str_replace($email, $censorString, $text);
			$notCensored = FALSE;
			break;
		 }		 
	}
	if ($notCensored) {
		$replaceString = '<a href="mailto:' . $email . '">' . $email . '</a>';
		$text = str_replace($email, $replaceString, $text);
	}
}
echo '<p>' . $text . '</p>';
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
    <textarea name="text">Hi, I'm an air-conditioner technician, so if you need any assistance you can contact me at air-conditioners@gmail.com . Secondary email: kinky_technician@yahoo.in or at naked-screwdriver@abv.bg OR pesho@dir.tk</textarea>
    <label>Blacklist:</label>
    <textarea name="blacklist">*.bg
pesho@dir.tk
*.com</textarea>
    <input type="submit" />
</form>
</body>
</html>
