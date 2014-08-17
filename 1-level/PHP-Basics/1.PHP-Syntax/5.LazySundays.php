<?php
$year = date('Y');
$month = date('F');
$monthDays = date('t');
$format = 'jS F, Y';
for ($i=1; $i <= $monthDays ; $i++) { 
	$date = strtotime("$i $month $year");
	if (date('l', $date) == 'Sunday') {
		echo date($format, $date) . '<br/>';
	}
}
?>