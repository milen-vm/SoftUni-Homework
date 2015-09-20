<?php
if (isset($_GET['board'])) {
	$tempBoard = preg_split('/\|/', $_GET['board'], -1, PREG_SPLIT_NO_EMPTY);
	$beginning = preg_split('/\s+/', $_GET['beginning'], -1, PREG_SPLIT_NO_EMPTY);
	$startRow = intval($beginning[0]) - 1;
	$startCol = intval($beginning[1]) - 1;
	$moves = preg_split('/\s+/', $_GET['moves'], -1, PREG_SPLIT_NO_EMPTY);
	$coins = 50;
	$board = [];
	
	for ($i=0; $i < count($tempBoard); $i++) {
		$board[] =  explode(' ', trim($tempBoard[$i]));
	}
	$boardLine = $board[0][0] . $board[0][1] . $board[0][2] . $board[0][3] . 
				 $board[1][3] . $board[2][3] . $board[3][3] . $board[3][2] . 
				 $board[3][1] . $board[3][0] . $board[2][0] . $board[1][0];
		 
	if ($startRow <= $startCol) {
    	$index = $startRow + $startCol;
	} else {
	    $index = 12 - ($startRow + $startCol);
	}

	$innsCount = 0;
	$innsOwned = [];
	
	for ($i=0; $i < strlen($boardLine); $i++) { 
		if ($boardLine[$i] == 'I') {
			$innsCount++;
		}
	}
	
	$field = '';
	
	for ($i=0; $i < count($moves); $i++) { 
		$dice = intval($moves[$i]);		
		$index = ($index + $dice) % strlen($boardLine);
		$coins += count($innsOwned) * 20;
		$field = $boardLine[$index];
		
		if ($field == 'P') {
			if ($coins - 5 <= 0) {
				die('<p>You lost! You ran out of money!<p>');
			} else {
				$coins -= 5;
			}
		}
		if ($field == 'I') {
			
			if (!in_array($inn, $innsOwned)) {
				
				if ($coins >= 100) {
					$innsOwned[] = $index;
					$coins -= 100;
					
					if (count($innsOwned) == $innsCount) {
						die("<p>You won! You own the village now! You have $coins coins!<p>");
					} else {
						if ($coins <= 0) {
							die('<p>You lost! You ran out of money!<p>');
						}
					}
					
				} else {
					$coins -= 10;
					if ($coins <= 0 && $i < count($moves) - 1) {
						die('<p>You lost! You ran out of money!<p>');
					}
				}	
			}			
		}
		if ($field == 'F') {
			$coins += 20;
		}
		if ($field == 'S') {
			$i += 2;
		}
		if ($field == 'V') {
			$coins *= 10;
		}
		if ($field == 'N') {
			die("<p>You won! Nakov's force was with you!<p>");
		}		
	}
echo "<p>You lost! No more moves! You have $coins coins!<p>";
}
?>
<!DOCTYPE  html>
<html>
	<head>
		<title>IT Village</title>
	</head>
	<body>
		<form action="" method="get">
			<input type="text" name="board"/>
			<input type="text" name="beginning"/>
			<input type="text" name="moves"/>
			<input type="submit"/>
		</form>
	</body>
</html>