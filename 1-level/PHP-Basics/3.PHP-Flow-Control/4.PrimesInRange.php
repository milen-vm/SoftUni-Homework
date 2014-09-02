<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Primes In Range</title>
	</head>
	<body>
		<form method="post" action="">
			<label for="start">Strart Index:</label>
			<input type="text" name="start" id="start" id="start" autofocus="autofocus" />
			<label for="end">End:</label>
			<input type="text" name="end" id="end" />
			<input type="submit" />
		</form>
		<p>
			<?php
			if (isset($_POST['start']) && isset($_POST['end']) && 
				$_POST['start'] !== '' && $_POST['end'] !=='') {
					
				$start = intval($_POST['start']);
				$end = intval($_POST['end']);
				for ($i=$start; $i <= $end; $i++) { 
					if (checkNumberIsPime($i)) {
						?>
						<strong><?php echo $i; ?></strong>
						<?php
					} else {
						echo $i;
					}
					if ($i < $end) {
						echo ', ';
					}
				}				
			}
			function checkNumberIsPime($num)
			{
				if ($num < 2) {
					return FALSE;
				}
				$squareRoot = sqrt($num);
				for ($j=2; $j <= $squareRoot; $j++) { 
					if ($num % $j == 0) {
						return FALSE;
					}
				}
				return TRUE;
			}
			?>
		</p>
	</body>
</html>