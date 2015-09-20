<?php
$board = $_GET['board'];
$piecesLetter = array('R', 'H', 'B', 'K', 'Q', 'P', ' ' );
$needLetter = TRUE;
$needDash = FALSE;
$needSlash = FALSE;
$positionOnRow = 1;
// validate board
if (strlen($board) != 127) {
	die('<h1>Invalid chess board</h1>');
}
for ($i=0; $i < strlen($board); $i++) { 
	$char = $board[$i];
	if ($needLetter) {
		
		if (in_array($char, $piecesLetter)) {
			$needLetter = FALSE;
			$needDash = TRUE;
			
		} else {
			die('<h1>Invalid chess board</h1>');
		}		
	} elseif ($needDash) {
		
		if ($char == '-') {
			$needDash = FALSE;
			$needLetter = TRUE;
			
		} else {
			die('<h1>Invalid chess board</h1>');
		}		
	} elseif ($needSlash) {
		
		if ($char == '/') {
			$needDash = FALSE;
			$needLetter = TRUE;			
		} else {
			die('<h1>Invalid chess board</h1>');
		}		
	}
	if ($positionOnRow == 15) {
		$needSlash = TRUE;
		$needLetter = FALSE;
		$needDash = FALSE;
		$positionOnRow = 0;
	} else {
		$positionOnRow++;
	}	
}
//print board and count pieces
$boardRows = preg_split('/\//', $board);
$piecesCount = [];

echo '<table>';
for ($i=0; $i < count($boardRows); $i++) { 
	$row = $boardRows[$i];
	echo '<tr>';
	
	for ($j=0; $j < strlen($row); $j += 2) {
		$piece = $row[$j];
		echo "<td>$piece</td>";
		if (empty($piecesCount[$piece])) {
			$piecesCount[$piece] = 0;
		}
		$piecesCount[$piece]++;
	}
	echo '</tr>';
}
echo '</table>';
//print JSON string
$piecesMapping = [
		'B' => 'Bishop',
		'H' => 'Horseman',
		'K' => 'King',
		'P' => 'Pawn',
		'Q' => 'Queen',
		'R' => 'Rook'
];
$piecesForPrint = [];

foreach ($piecesMapping as $pieceLeter => $piecesName) {
	$count = $piecesCount[$pieceLeter];
	if ($count > 0) {
		$piecesForPrint[$piecesName] = $count;
	}
}
echo json_encode($piecesForPrint);
?>
