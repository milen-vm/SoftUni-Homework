<?php
if (isset($_GET['name']) && isset($_GET['gender']) && isset($_GET['pin'])) {
	$name = trim($_GET['name']);
	$gender = trim($_GET['gender']);
	$pin = trim($_GET['pin']);
	$pattern = '/^[A-Z][a-z]+\s+[A-Z][a-z]+$/';
	preg_match($pattern, $name, $matched);
	if ($name != $matched[0]) {
		die('<h2>Incorrect data</h2>');
	}
	if ($gender != 'male' && $gender != 'female') {
		die('<h2>Incorrect data</h2>');
	}
	if (strlen($pin) != 10) {
		die('<h2>Incorrect data</h2>');
	}
	$month = intval(substr($pin, 2, 2));
	$genderPin = intval(substr($pin, -2, 1));
	$checksumPin = intval(substr($pin, -1));
	$monthCheck = ($month <= 12) || ($month >= 21 && $month <= 32) || ($month >= 41 && $month <= 52);
	if (!$monthCheck) {
		die('<h2>Incorrect data</h2>');
	}
	$genderCode = $genderPin % 2 == 0 ? 'male' : 'female';
	if ($gender != $genderCode) {
		die('<h2>Incorrect data</h2>');
	}
	$multiplier = array(2, 4, 8, 5, 10, 9, 7, 3, 6);
	$sum = 0;
	for ($i=0; $i < count($multiplier); $i++) {
		$pinDigit = intval($pin[$i]); 
		$sum += $pinDigit * $multiplier[$i];
	}
	$checksum = $sum % 11 == 10 ? 0 : $sum % 11;
	if ($checksum != $checksumPin) {
		die('<h2>Incorrect data</h2>');
	}
	$result = array(
			'name' => $name,
			'gender' => $gender,
			'pin' => $pin
	);
	echo json_encode($result);
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>3. PIN Validation</title>
</head>
<body>
<form method="get" action="">
    <label>
        Name:
        <input type="text" name="name" value="Ana Ivanova"/>
    </label>
    <br />
    <label>
        male:
        <input type="radio" name="gender" value="male" />
    </label>
    <label>
        female:
        <input type="radio" name="gender" value="female" checked="checked"/>
    </label>
    <br />
    <label>
        PIN:
        <input type="text" name="pin" value="9912164756"/>
    </label>
    <br />
    <input type="submit" value="Submit"/>
</form>
</body>
</html>