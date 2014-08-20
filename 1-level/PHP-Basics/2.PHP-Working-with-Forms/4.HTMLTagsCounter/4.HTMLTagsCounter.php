<!DOCTYPE html>
<?php
$tags_arr = file('html-tags.txt', FILE_IGNORE_NEW_LINES);	// creating array from file with all HTML tags
session_start();

if (!isset($_SESSION['count'])) {
	$_SESSION['count'] = 0;						// setting a variable for the count of inputed unique tags 
	$_SESSION['inputted_tags'] = array();		// setting a array for the already inputed tags						
	
}
if (isset($_POST['tag'])) {
	$tag = $_POST['tag'];
	
	if (in_array($tag, $tags_arr)) {						// checking the tag is in the array with all tags 
		
		if(in_array($tag, $_SESSION['inputted_tags'])) {	// checking if the tag is already inputed
			$result =  '<p>Valid HTML tag!</p>';
		} else {
			$result =  '<p>Valid HTML tag!</p>';
			$_SESSION['count']++;							// increasing count of unique tags
			array_push($_SESSION['inputted_tags'], $tag);	// adding tag to the array with inputed tags
		}		
	} else {
		$result =  '<p>Invalid HTML tag!</p>';
	}
	$result .= "<p>Score: ${_SESSION['count']}</p>";	
}
?>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>HTML Tags Counter</title>
	</head>
	<body>
		<form method="post" action="">
			<label for="tags">Enter HTML tags:</label><br />
			<input type="text" name="tag" id="tags" autofocus="autofocus" />
			<input type="submit" name="submit" value="Submit" />
		</form>
		<?php
		if (isset($result)) {
			echo $result;
		}
		?>
	</body>
</html>