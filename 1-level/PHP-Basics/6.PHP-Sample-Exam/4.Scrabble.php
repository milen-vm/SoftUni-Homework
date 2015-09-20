<?php
if (isset($_GET['mainWord']) && isset($_GET['words'])) {
	$mainWordArr = json_decode($_GET['mainWord']);
	$wordsArr = json_decode($_GET['words']);
	$mainWord = '';
	foreach ($mainWordArr as $key => $value) {
		$mainWord = $value;
		preg_match('/\d+/', $key, $match);
	} 
	$mainRow = intval($match[0]);
	echo $mainRow;
	usort($wordsArr, 'sortByLength');
	//var_dump($wordsArr);
	for ($i=0; $i < count($wordsArr); $i++) { 
		$word = $wordsArr[$i];
		if (strlen($word) > strlen($mainWord)) {
			continue;
		}
		
	}
}
function sortByLength($a, $b) {
    return strlen($b)-strlen($a);
}
?>

<!DOCTYPE html>
<html>
<head>
    <title></title>
    <style>
        label, input {
            display: block;
        }
        input[type=text] {
            width: 300px;
        }
    </style>
</head>
<body>
<form method="get" action="">
    <label>First string:</label>
    <input type="text" name="mainWord" value='{"row4":"operator"}'>
    <label>Second string:</label>
    <input type="text" name="words" value='["generally","objects","system","like","need"]'>
    <input type="submit" />
</form>
</body>
</html>