<?php
$list = $_GET['list'];
$maxSize = intval($_GET['maxSize']);
$listArr = preg_split('/\n/', $list, -1, PREG_SPLIT_NO_EMPTY);
$line = '';
echo '<ul>';
for ($i=0; $i < count($listArr); $i++) { 
	$line = trim($listArr[$i]);
	if ($line == '') {
		continue;
	}
	if (strlen($line) > $maxSize) {
		$line = substr($line, 0, $maxSize);
		$line .= '...';
	}

	echo '<li>' . htmlspecialchars($line) . '</li>';	
}
echo '</ul>';
?>