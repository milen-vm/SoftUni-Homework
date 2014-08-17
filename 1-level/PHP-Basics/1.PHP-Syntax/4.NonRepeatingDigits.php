<?php
function nonRepeatingDigits($digit) 
{
	$result = array();
	$i = 102;
	while ($i <= $digit && $i <= 987) {
		$firstDigit = floor($i) % 10;
		$secondDigit = floor($i / 10) % 10;
		$thirdDigit = floor($i / 100) % 10;
		
		if ($firstDigit !== $secondDigit &&
			$firstDigit !== $thirdDigit &&
			$secondDigit !== $thirdDigit) {
				
			array_push($result, $i);
		}
		++$i;	
	}
	if (count($result) == 0) {
		echo 'no';
	} else {
		echo implode(", ", $result);
	}
	echo '<br/><br/>';
}
nonRepeatingDigits(1234);
nonRepeatingDigits(145);
nonRepeatingDigits(15);
nonRepeatingDigits(247);
?>