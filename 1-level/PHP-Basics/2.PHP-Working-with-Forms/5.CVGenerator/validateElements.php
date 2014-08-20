<?php
if (isset($_POST['personal_info'])) {
	$personal_info = $_POST['personal_info'];
	$i = 0;									// index for error messages
	for ($d=0; $d < 6; $d++, $i++) { 
		switch ($d) {
			case 0:
				$msg = 'error_' . $i;
				$$msg = validateElement($personal_info['First Name']);				
				break;
			case 1:
				$msg = 'error_' . $i;
				$$msg = validateElement($personal_info['Second Name']);
				break;
			case 2:
				if (!filter_var($personal_info['Email'], FILTER_VALIDATE_EMAIL)) {
					$msg = 'error_' . $i;
					$$msg = 'Invalid Email!';
				}
				break;
			case 3:
				$msg = 'error_' . $i;
				$$msg = validatePhone($personal_info['Phone Number']);					
				break;
			case 4:
				if (!isset($personal_info['Gender'])) {
					$msg = 'error_' . $i;
					$$msg = 'Select gender!';
				}
				break;
			case 5:
				if ($personal_info['Birth Date'] == '') {
					$msg = 'error_' . $i;
					$$msg = 'Enter birth date!';
				}					
				break;
			default:						
				break;
		}
	}
}
if (isset($_POST['last_work'])) {
	$last_work = $_POST['last_work'];
	$i -= 1;
	foreach ($last_work as $key => $value) {
		$i++;
		if ($value == '') {
			$msg = 'error_' . $i;
			$$msg = 'Enter data!';
		} else if ($key == 'Company Name') {
			$msg = 'error_' . $i;
			$$msg = validateElement($value, FALSE);
		}
	}
}
if (isset($_POST['progr_lang']) && isset($_POST['progr_skill'])) {
	$progr_lang = $_POST['progr_lang'];
	$progr_skill = $_POST['progr_skill'];
	$i++;
	if ($progr_lang[0] == '') {
		$msg = 'error_' . $i;
		$$msg = 'Enter programming language!';
	}
	for ($j=1; $j < count($progr_lang); $j++) { 
		if ($progr_lang[$j] == '') {
			unset($progr_lang[$j]);
			unset($progr_skill[$j]);
		}
	}
}
if (isset($_POST['languages'])) {
	$languages = $_POST['languages'];
	$lang_compr = $_POST['lang_compr'];
	$lang_reading = $_POST['lang_reading'];
	$lang_writing = $_POST['lang_writing'];
	
	$i++;
	$msg = 'error_' . $i;
	$$msg = validateElement($languages[0]);
	for ($k=1; $k < count($languages); $k++) { 
		if (validateElement($languages[$k]) == 'Invalid name!') {
			unset($languages[$k]);
			unset($lang_compr[$k]);
			unset($lang_reading[$k]);
			unset($lang_writing[$k]);
		}
	}
}		

function validateElement($info, $no_compnay = TRUE)
{
	$length = strlen($info);
	$length_bool = $length >= 2 && $length <= 20;
	if ($no_compnay) {
		$isMatch = !preg_match('/[^A-Za-z]/', $info);
	} else {
		$isMatch = !preg_match('/[^A-Za-z0-9]/', $info);
	}			
	
	if ($length_bool && $isMatch) {
		return;
	} else {
		return 'Invalid name!';
	}			
}
function validatePhone($phone)
{
	$isMatch = !preg_match('/[^0-9 +-]/', $phone);
	if ($isMatch && $phone !='') {
		return;
	} else {
		return 'Invalid phone!';
	}		
}
include 'index.php';
?>