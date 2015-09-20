<?php
if (isset($_GET['dateOne']) && isset($_GET['dateOne'])) {	
	date_default_timezone_set('Europe/Sofia');
	$dateOne = new DateTime($_GET['dateOne']);
	$dateTwo = new DateTime($_GET['dateTwo']);	
	if ($dateOne > $dateTwo) {
		$tempDate = $dateOne;
		$dateOne = $dateTwo;
		$dateTwo = $tempDate;
	}
	$currentDate = $dateOne;
	$noThursdays = TRUE;
	while ($currentDate <= $dateTwo) {
		$dayOfweek = $currentDate->format('l');
		$date = $currentDate->format('d-m-Y');
		if ($dayOfweek === 'Thursday') {
			if ($noThursdays) {
				echo '<ol>';
				$noThursdays = FALSE;
			}
			echo "<li>$date</li>";
		}
		$currentDate = $currentDate->modify('+1 day');
	}
	if ($noThursdays) {
		echo '<h2>No Thursdays</h2>';
	} else {
		echo '</ol>';
	}
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>1. Meeting Days</title>
</head>
<body>
<form method="get" action="1.MeetingDates.php">
    <label>
        First date:
        <input type="text" name="dateOne" value="17-09-2014"/>
    </label>
    <br />
    <label>
        Second date:
        <input type="text" name="dateTwo" value="16-08-2014"/>
    </label>
    <br />
    <input type="submit" value="Submit"/>
</form>
</body>
</html>