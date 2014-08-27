<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8" />
		<title>CV Generator</title>
		<link href="styles.css" rel="stylesheet" />
		<script type="text/javascript" src="addRemoveElements.js"></script>
	</head>
	<body>
		<form method="post" action="validateElements.php">
			<fieldset>
			<legend>Personal Information</legend>
				<input type="text" name="personal_info[First Name]" placeholder="First Name" autofocus="autofocus" />
				<?php if (isset($error_0)): ?>
				<strong><?php echo $error_0; ?></strong>
				<?php endif; ?>
				<br />
				<input type="text" name="personal_info[Second Name]" placeholder="Second Name" />
				<?php if (isset($error_1)): ?>
				<strong style="color: red"><?php echo $error_1; ?></strong>
				<?php endif; ?>
				<br />
				<input type="text" name="personal_info[Email]" placeholder="Email" />
				<?php if (isset($error_2)): ?>
				<strong><?php echo $error_2; ?></strong>
				<?php endif; ?>
				<br />
				<input type="text" name="personal_info[Phone Number]" placeholder="Phone Number" />
				<?php if (isset($error_3)): ?>
				<strong><?php echo $error_3; ?></strong>
				<?php endif; ?>
				<br />
				<label for="female">Female</label>
				<input type="radio" name="personal_info[Gender]" value="Female" id="female" />
				<label for="male">Male</label>
				<input type="radio" name="personal_info[Gender]" value="Male" id="male" />
				<?php if (isset($error_4)): ?>
				<strong><?php echo $error_4; ?></strong>
				<?php endif; ?>
				<br />
				<label for="brd">Birth Date</label><br />
				<input type="date" name="personal_info[Birth Date]" id="brd" />
				<?php if (isset($error_5)): ?>
				<strong><?php echo $error_5; ?></strong>
				<?php endif; ?>
				<br />
				<label for="nat">Nationality</label><br />
				<select name="personal_info[Nationality]">
					<option value="Bulgarian">Bulgarian</option>
					<option value="Romanian">Romanian</option>
					<option value="Greek">Greek</option>
					<option value="Serbian">Serbian</option>
					<option value="Turkish">Turkish</option>
				</select>
			</fieldset>
			<fieldset>
				<legend>Last Work Position</legend>
				<label for="company">Company Name</label>
				<input type="text" name="last_work[Company Name]" id="company" />
				<?php if (isset($error_6)): ?>
				<strong><?php echo $error_6; ?></strong>
				<?php endif; ?>
				<br />
				<label for="from">From</label>
				<input type="date" name="last_work[From]" id="from" />
				<?php if (isset($error_7)): ?>
				<strong><?php echo $error_7; ?></strong>
				<?php endif; ?>
				<br />
				<label for="to">To</label>
				<input type="date" name="last_work[To]" id="to" />
				<?php if (isset($error_8)): ?>
				<strong><?php echo $error_8; ?></strong>
				<?php endif; ?>
				<br />
			</fieldset>
			<fieldset >
				<legend>Computer Skills</legend>
				<span for="pr">Programming Languages</span><br />
				<div id="comp-skills">
					<div>
						<input type="text" name="progr_lang[]" />
						<select name="progr_skill[]">
							<option value="Beginner">Beginner</option>
							<option value="Programmer">Programmer</option>
							<option value="Ninja">Ninja</option>
						</select>
						<?php if (isset($error_9)): ?>
						<strong><?php echo $error_9; ?></strong>
						<?php endif; ?>
					</div>				
				</div>			
				<input type="button" onclick="removeElement('comp-skills')" value="Remove Language" />
				<input type="button" onclick="addElement('comp-skills')" value="Add Language"/>
			</fieldset>
			<fieldset>
				<legend>Other Skills</legend>
				<span>Languages</span>
				<div id="other-skills">
					<div>						
						<input type="text" name="languages[]" id="lang" />
						<select name="lang_compr[]">
							<option value="">-Comprehension-</option>
							<option value="beginner">beginner</option>
							<option value="intermediate">intermediate</option>
							<option value="advanced">advanced</option>
						</select>
						<select name="lang_reading[]">
							<option value="">-Reading-</option>
							<option value="beginner">beginner</option>
							<option value="intermediate">intermediate</option>
							<option value="advanced">advanced</option>
						</select>
						<select name="lang_writing[]">
							<option value="">-Writing-</option>
							<option value="beginner">beginner</option>
							<option value="intermediate">intermediate</option>
							<option value="advanced">advanced</option>
						</select>
						<?php if (isset($error_10)): ?>
						<strong><?php echo $error_10; ?></strong>
						<?php endif; ?>
						<br />						
					</div>
				</div>
				<input type="button" onclick="removeElement('other-skills')" value="Remove Language" />
				<input type="button" onclick="addElement('other-skills')" value="Add Language"/><br />				
				<span>Driver's License</span><br />				
				<label for="b">B</label>
				<input type="checkbox" name="driver[]" value="B" id="b" />
				<label for="a">A</label>
				<input type="checkbox" name="driver[]" value="A" id="a" />
				<label for="c">C</label>
				<input type="checkbox" name="driver[]" value="C" id="c" />
			</fieldset>
			<input type="submit" name="submit" value="Generate CV" />
		</form>
		<div id="CVresult">
		<?php
		if (!(isset($error_1) || isset($error_2) || isset($error_3) || isset($error_4) || isset($error_5) ||
			  isset($error_6) || isset($error_7) || isset($error_8) || isset($error_9) || isset($error_10))) {
			if (isset($personal_info)) :
		?>
				<table>
					<thead>
						<tr><th colspan="2">Personal Information</th></tr>
					</thead>
					<tbody>
						<?php
						foreach ($personal_info as $key => $value) {
							echo "<tr><td>${key}</td><td>${value}</td></tr>";
						}
						?>
					</tbody>
				</table>
		<?php		
			endif;
			if (isset($last_work)) :
		?>
				<table>
					<thead>
						<tr><th colspan="2">Last Work Position</th></tr>
					</thead>
					<tbody>
						<?php
						foreach ($last_work as $key => $value) {
							echo "<tr><td>${key}</td><td>${value}</td></tr>";
						}
						?>
					</tbody>
				</table>
		<?php
			endif;
			if (isset($progr_lang)) :
		?>
				<table>
					<thead>
						<tr><th colspan="2">Computer Skills</th></tr>
					</thead>
					<tbody>
						<tr>
							<td>Programming Languages</td>
							<td>
								<table>
									<thead>
										<tr><th>Language</th><th>Skill Level</th></tr>
									</thead>
									<tbody>
										<?php
										foreach ($progr_lang as $key => $lang) {
											$level = $progr_skill[$key];
											echo "<tr><td>${lang}</td><td>${level}</td></tr>";
										}
										?>
									</tbody>
								</table>
							</td>
						</tr>
					</tbody>
				</table>
		<?php
			endif;
			if (isset($languages)) :
		?>
				<table>
					<thead>
						<tr><th colspan="2">Other Skills</th></tr>
					</thead>
					<tbody>
						<tr>
							<td>Languages</td>
							<td>
								<table>
									<thead>
										<tr><th>Language</th><th>Comprehension</th><th>Reading</th><th>Writing</th></tr>
									</thead>
									<tbody>
										<?php
										foreach ($languages as $key => $language) {
											$compr = $lang_compr[$key] != '' ? $lang_compr[$key] : '<span>unspecified</span>';
											$reading = $lang_reading[$key] != '' ? $lang_reading[$key] : '<span>unspecified</span>';
											$writing = $lang_writing[$key] != '' ? $lang_writing[$key] : '<span>unspecified</span>';
											
											echo "<tr><td>${language}</td><td>${compr}</td><td>${reading}</td><td>${writing}</td></tr>";
										}
										?>
									</tbody>
								</table>
							</td>
						</tr>
						<?php
						if (isset($_POST['driver'])) {
							$driver = $_POST['driver'];
							$categories = implode(', ', $driver);
							echo "<tr><td>Driver's license</td><td>${categories}</td></tr>";
						}
						?>
					</tbody>
				</table>
		<?php
			endif;
		}
		?>
		</div>
	</body>
</html>