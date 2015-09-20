<!-- 
date_default_timezone_set('Europe/Sofia');
var_dump($_GET['dateOne']);
var_dump($_GET['dateTwo']);
var_dump($_GET['holidays']);
$dateOne = strtotime($_GET['dateOne']);
$dateTwo = strtotime($_GET['dateTwo']);
$holidays = preg_split('/\s+/', $_GET['holidays'], -1, PREG_SPLIT_NO_EMPTY);
$holidays = array_map('strtotime', $holidays);

$oneDay = 24 * 60 * 60; // error whit daylight saving time, it must be '+1 day'
$noWorkdays = TRUE;

while ($dateOne <= $dateTwo) {
	$isWeekend = (date('l', $dateOne) === 'Saturday') || (date('l', $dateOne) === 'Sunday');
	$isHoliday = in_array($dateOne, $holidays);
	
	if (!$isWeekend && !$isHoliday) {
		
		if ($noWorkdays) {
			echo '<ol>';
			$noWorkdays = FALSE;
		}
		echo '<li>' . date('d-m-Y', $dateOne) . '</li>';
	}
	$dateOne += $oneDay;
}
if ($noWorkdays) {
	echo '<h2>No workdays</h2>';
} else {
	echo '</ol>';

} -->

<?php
date_default_timezone_set('Europe/Sofia');
$dateOne = new DateTime($_GET['dateOne']);
$dateTwo = new DateTime($_GET['dateTwo']);
$holidays = preg_split('/\s+/', $_GET['holidays'], -1, PREG_SPLIT_NO_EMPTY);
$noWorkdays = TRUE;
$currentDate = $dateOne;

while ($currentDate <= $dateTwo) {
	$day = $currentDate->format('l');							// gets day of week
	$isWeekend = ($day == 'Saturday') || ($day == 'Sunday');	// check whether it is a weekend
	$day = $currentDate->format('d-m-Y');						// gets date
	$isHoliday = in_array($day, $holidays);						// check whether date is in the holidays array
	
	if (!$isWeekend && !$isHoliday) {
		if ($noWorkdays) {
			echo '<ol>';
			$noWorkdays = FALSE;
		}
		echo '<li>' . $day . '</li>';
	}
	$currentDate = $currentDate->modify('+1 day');
}
if ($noWorkdays) {
	echo '<h2>No workdays</h2>';
} else {
	echo '</ol>';
}
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
            height: 200px;
        }
    </style>
</head>
<body>
<form method="get" action="">
    <label>Start date:</label>
    <input type="text" name="dateOne" value="17-12-2014"/>
    <label>End date:</label>
    <input type="text" name="dateTwo" value="31-12-2014"/>
    <label>Holidays:</label>
    <textarea name="holidays">31-12-2014
    24-12-2014
    08-12-2014</textarea>
    <input type="submit" />
    
</form>
</body>
</html>