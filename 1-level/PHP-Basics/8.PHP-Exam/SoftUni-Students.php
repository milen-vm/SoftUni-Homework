<?php
if (isset($_GET['students'])) {	
	
	$students = preg_split('/\n/', $_GET['students'], -1, PREG_SPLIT_NO_EMPTY);
	// var_dump($students);
	$column = $_GET['column'];
	// var_dump($column);
	$order = $_GET['order'];
	// var_dump($order);
	// var_dump($students);
	$studentsArr = [];
	for ($i=0; $i < count($students); $i++) { 
		$student = preg_split('/,\s*/', $students[$i]);
		// var_dump($student);
		$tempStudent = array(
							'Id' => ($i + 1),
							'Username' => $student[0],
							'Email' => $student[1],
							'Type' => $student[2],
							'Result' => intval($student[3])
							);
		$studentsArr[] = $tempStudent;
	}
	
	if($column == 'id' && $order == 'descending') {
		usort($studentsArr, function($a, $b){
				
				return $b['Id'] - $a['Id'];
			});
	}elseif ($column == 'result' && $order == 'descending') {
		usort($studentsArr, function($a, $b){
			
				if ($a['Result'] == $b['Result']) {
					return $b['Id'] - $a['Id'];
				}
				return $b['Result'] - $a['Result'];
			});
	} elseif ($column == 'result' && $order == 'ascending') {
		usort($studentsArr, function($a, $b){
			
				if ($a['Result'] == $b['Result']) {
					return $a['Id'] - $b['Id'];
				}				
				return $a['Result'] - $b['Result'];
			});
	} elseif ($column == 'username' && $order == 'ascending') {
		usort($studentsArr, function($a, $b){
				
				if ($a['Username'] == $b['Username']) {
					return $a['Id'] - $b['Id'];
				}
				return $a['Username'] > $b['Username'];
			});
	} elseif ($column == 'username' && $order == 'descending') {
		usort($studentsArr, function($a, $b){
				
				if ($a['Username'] == $b['Username']) {
					return $b['Id'] - $a['Id'];
				}
				return $b['Username'] > $a['Username'];
			});
	}
	$result = '<table><thead><tr><th>Id</th><th>Username</th><th>Email</th><th>Type</th><th>Result</th></tr></thead>';
	
	for ($i=0; $i < count($studentsArr); $i++) { 
		
		$result .= '<tr>';
		foreach ($studentsArr[$i] as $value) {
			$result .= '<td>' . htmlspecialchars($value) . '</td>';
		}
		$result .= '</tr>';
	}
	$result .= '</table>';
	
	echo $result;
}
?>
