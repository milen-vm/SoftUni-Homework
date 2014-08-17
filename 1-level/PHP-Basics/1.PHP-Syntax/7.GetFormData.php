<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8"/>
		<title>Get Form Data</title>
		<style>
			input {
				margin: 5px 0;
			}
		</style>
	</head>
	<body>
		<form action="" method="get">
			<input type="text" name="name" placeholder="Name..."/>
			<br/>
			<input type="text" name="age" placeholder="Age..."/>
			<br/>
			<input type="radio" name="gender" value="male" id="male"/>
			<label for="male">Male</label>
			<br/>
			<input type="radio" name="gender" value="female" id="female"/>
			<label for="female">Female</label>
			<br/>
			<input type="submit" name="submit" value="Изпращане"/>
		</form>
		<p>
			<?php
			//var_dump($_GET);
			if ((count($_GET) == 4) && isset($_GET['submit'])) {
				$name = htmlentities($_GET['name']);
				$age = htmlentities($_GET['age']);
				$gender = htmlentities($_GET['gender']);
				echo "My name is ${name}. I am ${age} years old. I am a ${gender}.";			
			}
			?>			
		</p>
	</body>
</html>