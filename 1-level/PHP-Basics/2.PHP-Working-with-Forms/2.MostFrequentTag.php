<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Print Tags</title>
	</head>
	<body>
		<p>Enter Tags:</p>
		<form method="post" action="">
			<input type="text" name="tags" />
			<input type="submit" name="submit" value="Submit" />
		</form>
		<?php
		if (isset($_POST['tags'])) {
			$tags = $_POST['tags'];
			$tagsSplit = preg_split('/[\s,]+/', $tags);
			$tagsCount = array();
			
			for ($i=0; $i < count($tagsSplit); $i++) {
				$tag = $tagsSplit[$i];
				if ($tag != '') {					 
					if (isset($tagsCount[$tag])) {
						$tagsCount[$tag]++;
					} else {
						$tagsCount[$tag] = 1;
					}	
				} 			
			}
			arsort($tagsCount);

			foreach ($tagsCount as $key => $value) {
				echo htmlentities($key) . ' : ' . $value . '<br/>';				
			}
			reset($tagsCount);											//reset the pointer to the beginning of the array 	http://stackoverflow.com/questions/1028668/get-first-key-in-a-possibly-associative-array
			echo '<br/>Most Frequent Tag is: ' . htmlentities(key($tagsCount));		//gets the first key of the array		
		}
		?>		
	</body>
</html>