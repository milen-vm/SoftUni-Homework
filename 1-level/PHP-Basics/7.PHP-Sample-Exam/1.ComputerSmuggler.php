<?php
if (isset($_GET['list'])) {
	$list = preg_split('/,\s+/', $_GET['list'], -1, PREG_SPLIT_NO_EMPTY);
	
	$prices = array('CPU' => 85,
					'ROM' => 45,
					'RAM' => 35,
					'VIA' => 45);
					
	$bought = array('CPU' => 0,
					'ROM' => 0,
					'RAM' => 0,
					'VIA' => 0);
					
	for ($i=0; $i < count($list); $i++) { 
		$bought[$list[$i]]++;
	}
	
	$spent = calculateSpent($prices, $bought);
	asort($bought);
	$assembledComp = reset($bought);
	$income = $assembledComp * 420;
	$leftParts = calculateLeftParts($bought, $assembledComp);
	$countLeftParts = array_sum($leftParts);
	$incomeUnusedParts = calculateIncom($leftParts, $prices);
	$balance = $income + $incomeUnusedParts - $spent;
	echo '<ul>';
	echo "<li>$assembledComp computers assembled</li>";
	echo "<li>$countLeftParts parts left</li>";
	echo '</ul>';
	if ($balance > 0) {
		echo "<p>Nakov gained $balance leva</p>";
	} else {
		echo "<p>Nakov lost $balance leva</p>";
	}	
}

function calculateSpent($prices, $bought) 
{
	$spent = 0;
	foreach ($bought as $part => $amount) {
		if ($amount < 5) {
			$spent += $amount * $prices[$part];
		} else {
			$spent += $amount * $prices[$part] / 2;
		}
	}
	return $spent;
}
function calculateLeftParts($bought, $assembledComp) 
{
	$leftParts = [];
	foreach ($bought as $part => $amount) {
		$leftParts[$part] = $amount - $assembledComp;
	}
	return $leftParts;
}
function calculateIncom($leftParts, $prices)
{
	$income = 0;
	foreach ($leftParts as $part => $amount) {
		if ($amount == 0) {
			continue;
		}
		$income += $amount * $prices[$part] / 2;
	}
	return $income;
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Nakov's Affairs</title>
</head>
	<body>
		<form method="get" action="">
			<label for="listParts">Parts:</label>
			<input id="listParts" type="text" name="list"/>
			<input type="submit"/>
		</form>
	</body>
</html>