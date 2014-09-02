<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Sum Of Digits</title>
		<link href="table-style.css" rel="stylesheet" />
	</head>
	<body>
		<form method="post" action="">
			<label id="input">Input string:</label>
			<input type="text" name="string" id="input" autofocus="autofocus" />
			<input type="submit" />
		</form>
		<br />
		<?php
		if (isset($_POST['string']) && $_POST['string'] !== '') :
			$strings = preg_split('/[\s,]+/', $_POST['string'], -1, PREG_SPLIT_NO_EMPTY);
		?>		
		<table>					
		<?php
			for ($i=0; $i < count($strings); $i++) {
				$str = $strings[$i];
				$digitSum = 0;
				if (is_numeric($str)) {
					if (ctype_digit($str)) {					//check is number a integer
						$digitSum = sumNumbersDigits($str);
					} else {
						$str = intval($str) . '';				//converting number to integer end then back to string
						$digitSum = sumNumbersDigits($str);
					}
				} else {
					$digitSum = 'I cannot sum that';
				}
				printTableRow($str, $digitSum);				
			}
		?>
		</table>
		<?php
		endif;
		function sumNumbersDigits($str)
		{
			$sum = 0;
			for ($j=0; $j < strlen($str); $j++) { 
				$sum += intval($str[$j]);
			}
			return $sum;
		}
		function printTableRow($str, $digitSum)
		{
		?>
		<tr>
			<td><?php echo htmlentities($str) ?></td>
			<td><?php echo $digitSum ?></td>
		</tr>
		<?php
		}
		?>	
	</body>
</html>