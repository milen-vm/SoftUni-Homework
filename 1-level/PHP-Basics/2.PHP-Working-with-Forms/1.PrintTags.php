<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Print Tags</title>
	</head>
	<body>
		<p>Enter Tags:</p>
		<form method="post" action="">
			<input type="text" name="tags" autofocus="autofocus" />
			<input type="submit" name="submit" value="Submit" />
		</form>
		<p>
			<?php
			if (isset($_POST['tags'])) {
				$tags = $_POST['tags'];
				$tagsSplit = preg_split('/[\s,]+/', $tags);
				
				for ($i=0; $i < count($tagsSplit); $i++) {
					if ($tagsSplit[$i] != '') {
						echo $i . ' : ' . htmlentities($tagsSplit[$i]) . '<br />';
					} 			
				}
			}
			?>
		</p>		
	</body>
</html>