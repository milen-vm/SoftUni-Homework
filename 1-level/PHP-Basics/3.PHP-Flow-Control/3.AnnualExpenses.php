<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Annual Expenses</title>
		<link href="table-style.css" rel="stylesheet" />
	</head>
	<body>
		<form method="post" action="">
			<label for="num">Enter number of years: </label>
			<input type="text" name="years" id="num" autofocus="autofocus" />
			<input type="submit" />
		</form>
		<br />
		<?php
		if (isset($_POST['years']) && $_POST['years'] !== '') :
			$years = $_POST['years'];
			$currentYear = intval(date('Y'));
		?>
		<table>
			<thead>
				<tr>
					<th>Year</th><th>January</th><th>February</th><th>March</th><th>April</th><th>May</th><th>June</th>
					<th>July</th><th>August</th><th>September</th><th>October</th><th>November</th><th>December</th><th>Total:</thS>
				</tr>
			</thead>
			<tbody>
				<?php
				for ($i=0; $i < $years; $i++) : 
					$total = 0;
				?>
				<tr>
					<td>
					<?php echo $currentYear - $i; ?>
					</td>
					
					<?php
					for ($j=0; $j < 12; $j++) : 
						$expense = rand(0, 999);
						$total += $expense;
						?>
						<td>
							<?php echo $expense; ?>
						</td>
						<?php
					endfor;
					?>
					<td>
						<?php echo $total; ?>
					</td>
				</tr>	
				<?php
				endfor;
				?>
			</tbody>
		</table>
		<?php
		endif;
		?>
	</body>
</html>