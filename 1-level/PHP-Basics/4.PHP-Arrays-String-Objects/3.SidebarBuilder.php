<?php
if (isset($_POST['categories']) && isset($_POST['tags']) && isset($_POST['months'])) {
	if ($_POST['categories'] != '') {
		$categories = preg_split('/[\s,]+/', $_POST['categories'], -1, PREG_SPLIT_NO_EMPTY);
	}
	if ($_POST['tags'] != '') {
		$tags = preg_split('/[\s,]+/', $_POST['tags'], -1, PREG_SPLIT_NO_EMPTY);
	}
	 if ($_POST['months'] != '') {
		$months = preg_split('/[\s,]+/', $_POST['months'], -1, PREG_SPLIT_NO_EMPTY) ;
	}
}
?>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>Sidebar Builder</title>
		<link href="style.css" rel="stylesheet" />
	</head>
	<body>
		<form method="post" action="">
			<label for="cat">Categories</label>
			<input type="text" name="categories" id="cat" autofocus="autofocus" />
			<br />
			<label for="tags">Tags</label>
			<input type="text" name="tags" id="tags" />
			<br />
			<label for="months">Months</label>
			<input type="text" name="months" id="months" />
			<br />
			<input type="submit" />
		</form>
		<div>
			<?php if (isset($categories)) : ?>
			<aside>
				<h2>Categories</h2>
				<hr />
				<ul>
				<?php for ($i=0; $i < count($categories); $i++) : ?>
					<li>
						<?php echo htmlentities($categories[$i]) ?>
					</li>
				<?php endfor; ?>
				</ul>
			</aside>
			<?php endif; 
			if (isset($tags)) : ?>
			<aside>
				<h2>Tags</h2>
				<hr />
				<ul>
				<?php for ($i=0; $i < count($tags); $i++) : ?>
					<li>
						<?php echo htmlentities($tags[$i]) ?>
					</li>
				<?php endfor; ?>
				</ul>
			</aside>
			<?php endif; 
			if (isset($months)) : ?>
			<aside>
				<h2>Months</h2>
				<hr />
				<ul>
				<?php for ($i=0; $i < count($months); $i++) : ?>
					<li>
						<?php echo htmlentities($months[$i]) ?>
					</li>
				<?php endfor; ?>
				</ul>
			</aside>
			<?php endif; ?>
		</div>
	</body>
</html>