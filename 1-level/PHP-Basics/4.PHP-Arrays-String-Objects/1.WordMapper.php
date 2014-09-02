<?php
if (isset($_POST['text']) && $_POST['text'] != '') {
	$text = strtolower($_POST['text']);
	$text = preg_split('/\W+/', $text, -1, PREG_SPLIT_NO_EMPTY);
	$wordsCount = [];
	for ($i=0; $i < count($text); $i++) {
		$word = $text[$i]; 
		if (isset($wordsCount[$word])) {
			$wordsCount[$word]++;
		} else {
			$wordsCount[$word] = 1;
		}		
	}
}
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Word Mapper</title>
		<link href="style.css" rel="stylesheet" />
	</head>
	<body>
		<form method="post" action="">
			<textarea name="text" >The quick brows fox.!!! jumped over..// the lazy dog.!</textarea>
			<br />
			<input type="submit" value="Count words" />
		</form>
		<?php if (isset($wordsCount)): ?>
			<table>
				<tbody>
				<?php foreach ($wordsCount as $word => $count) : ?>
					<tr>
						<td><?php echo $word; ?></td>
						<td><?php echo $count; ?></td>
					</tr>
				<?php endforeach; ?>
				</tbody>
			</table>
		<?php endif; ?>
	</body>
</html>