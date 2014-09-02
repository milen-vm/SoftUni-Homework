<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Square Root Sum</title>
		<link href="table-style.css" rel="stylesheet" />
	</head>
	<body>
		<table>
			<thead>
				<tr><th>Number</th><th>Square</th></tr>
			</thead>
			<tbody>
				<?php
				$sum = 0;
				for ($i=0; $i <= 100 ; $i += 2) : 
					$squareRoot = round(sqrt($i), 2);
					$sum += $squareRoot;
				?>
				<tr><td><?php echo $i; ?></td><td><?php echo round(sqrt($i), 2); ?></td></tr>
				<?php	
				endfor;
				?>
				<tr><td><strong>Total:</strong></td><td><?php echo $sum; ?></td></tr>
			</tbody>
		</table>
	</body>
</html>