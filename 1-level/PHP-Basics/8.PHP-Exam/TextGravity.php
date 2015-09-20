<?php
$text = $_GET['text'];
$lineLength = $_GET['lineLength'];
$charArr = [];
$index = 0;
$tempArr = array_fill(0, $lineLength, ' ');

for ($i=0; $i < strlen($text); $i++) { 
	$tempArr[$index] = $text[$i];
	$index++;
	if ($index == ($lineLength) || $i == (strlen($text) - 1)) {
		$charArr[] = $tempArr;
		$tempArr = array_fill(0, $lineLength, ' ');
		$index = 0;
	}
}
for ($i = count($charArr) - 1; $i  > 0; $i--) { 
	
	for ($j= count($charArr[$i]) - 1; $j >= 0; $j--) { 
		
		// $condition = $charArr[$i][$j] == ' ';
		if ($charArr[$i][$j] == ' ') {
			
			$tempChar = $charArr[$i][$j];
			
			for ($k=$i - 1; $k >= 0; $k--) { 
				if ($charArr[$k][$j] != ' ') {
					$charArr[$i][$j] = $charArr[$k][$j];
					$charArr[$k][$j] = $tempChar;
					break;
				}
			}
		}
		
	}
}
// var_dump($charArr);
echo '<table>';
for ($i=0; $i < count($charArr); $i++) { 
	echo '<tr>';
	for ($j=0; $j < count($charArr[$i]); $j++) { 
		echo '<td>' . htmlspecialchars($charArr[$i][$j]) . '</td>';
	}
	echo '</tr>';
}
echo '<table>';
?>

