<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Car Randomizer</title>
		<link href="table-style.css" rel="stylesheet" />
	</head>
	<body>
		<form method="post" action="">
			<label for="input">Enter cars</label>
			<input type="text" name="cars" id="input" autofocus="autofocus" placeholder="Enter list of cars..." />
			<input type="submit" value="Show result" />
		</form>
		<br />	
		<?php
		if (isset($_POST['cars']) && $_POST['cars'] !=='') :
			$cars = preg_split('/[\s,]+/', $_POST['cars']);
			if ($cars[0] == '') {
				return;
			}
			$count = rand(1, 5);
			$color = ['red', 'green', 'black', 'yellow', 'blue'];
		?>
		<table>
			<thead>
				<tr>
					<th>Car</th><th>Color</th><th>Count</th>
				</tr>
			</thead>
			<tbody>
				<?php
					for ($i=0; $i < count($cars); $i++) : 
				?>	
				<tr>
					<td><?php echo htmlentities($cars[$i]); ?></td>
					<td><?php echo $color[rand(0, 4)]; ?></td>
					<td><?php echo rand(1, 5); ?></td>
				</tr>
		<?php
			endfor;
		endif;
		?>
			</tbody>
		</table>		
	</body>
</html>