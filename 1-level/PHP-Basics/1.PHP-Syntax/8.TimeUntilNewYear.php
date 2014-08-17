<?php
$date = getdate();
$year = $date['year'];
$year += 1;
$format = 'd-m-Y G:i:s';
$now = strtotime(date($format));
$dateNewYear = strtotime("1 January $year 00:00:00");

$interval = $dateNewYear - $now;		//difference between dates in seconds
$days = floor($interval / 3600 / 24);
$hours = floor($interval / 3600);
$minutes = floor($interval / 60);

echo "Hours until new year : ${hours} <br/>";
echo "Minutes until new year : ${minutes} <br/>";
echo "Seconds until new year : ${interval} <br/>";
echo 'Days:Hours:Minutes:Seconds ' . $days . ':' . $hours % 24 . ':' . $minutes % 60 . ':' . $interval % $minutes . '<br/>';
echo '<a href="http://www.timeanddate.com/counters/newyear.html" target="_blank">Time Until New Year</a/>';
?>