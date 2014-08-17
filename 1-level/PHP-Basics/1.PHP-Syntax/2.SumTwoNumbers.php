<?php
function sumNumbers($firstNumber, $secondNumber)
{
	$result = $firstNumber + $secondNumber;
	echo '$firstNumber + $secondNumber = ' . "$firstNumber + $secondNumber = " . number_format($result, 2, '.', '');
	echo '<br/>';		//creates a new line in a browser
}
sumNumbers(2, 5);
sumNumbers(1.567808, 0.356);
sumNumbers(1234.5678, 333);
?>