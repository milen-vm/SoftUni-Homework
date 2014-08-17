<!DOCTYPE html>
<?php
if (count($_POST) == 5) {
	$amount = doubleval($_POST['amount']);
	$currency = $_POST['currency'];
	$interest = doubleval($_POST['interest']) / 12 / 100;
	$months = 12 * doubleval($_POST['period']);
	for ($i=0; $i < $months; $i++) { 
		$amount +=$amount * $interest;
	}
	$result =  $currency . ' ' . round($amount, 2);
}
?>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Calculate Interest</title>
	</head>
	<body>
		<form method="post" action="">
			<label for="amount">Enter Amount</label>
			<input type="text" name="amount" id="amount" /><br />
			<input type="radio" name="currency" value="&#36;" id="usd" />
			<label for="usd">USD</label>
			<input type="radio" name="currency" value="&#8364;" id="eur" />
			<label for="eur">EUR</label>
			<input type="radio" name="currency" value="BGN" id="bgn" />
			<label for="bgn">BGN</label><br />
			<label for="interest">Compound Interest Amount</label>
			<input type="text" name="interest" id="interest" /><br />
			<select name="period">
				<option value="0.5">6 Months</option>
				<option value="1">1 Year</option>
				<option value="2">2 Year</option>
				<option value="5">5 Year</option>
			</select>
			<input type="submit" name="submit" value="Calculate" />
			<span>
				<?php
				if (isset($result)) {
					echo $result;
				}
				?>
			</span>
		</form>
		
	</body>
</html>