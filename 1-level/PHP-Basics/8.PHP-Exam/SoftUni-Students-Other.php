 
<?php

$sortColumn = $_GET['column'];
$order = $_GET['order'];

$students = [];
$count = 1; //count is the id number. Start at 1. Cannot use array key for ID because of empty lines

foreach(explode("\n", $_GET['students']) as $key=>$line) {
    $line = trim($line);
    if (strlen($line) > 0) {
        $data = explode(',', $line); // split the comma separated data
        $students[$key]['id'] = (int)$count;
        $students[$key]['username'] = trim($data[0]);
        $students[$key]['email'] = trim($data[1]);
        $students[$key]['type'] = trim($data[2]);
        $students[$key]['result'] = (int)trim($data[3]);
        $count++;// increase ID
    }

}


//sort via array_multisort helper function
if ($order == 'descending') $sorted = array_orderby($students, $sortColumn , SORT_DESC, 'id', SORT_DESC);
else if ($order == 'ascending') $sorted = array_orderby($students, $sortColumn , SORT_ASC, 'id', SORT_ASC);



//print
echo "<table><thead><tr><th>Id</th><th>Username</th><th>Email</th><th>Type</th><th>Result</th></tr></thead>";
foreach ($sorted as $student){
    echo "<tr>";
    echo "<td>".htmlspecialchars($student['id'])."</td>";
    echo "<td>".htmlspecialchars($student['username'])."</td>";
    echo "<td>".htmlspecialchars($student['email'])."</td>";
    echo "<td>".htmlspecialchars($student['type'])."</td>";
    echo "<td>".htmlspecialchars($student['result'])."</td>";
    echo "</tr>";
}
echo "</table>";


// thank you jimpoz from array_multisort comment section php.net
// http://php.net/manual/en/function.array-multisort.php#100534
function array_orderby()
{
    $args = func_get_args();
    $data = array_shift($args);
    foreach ($args as $n => $field) {
        if (is_string($field)) {
            $tmp = array();
            foreach ($data as $key => $row)
                $tmp[$key] = $row[$field];
            $args[$n] = $tmp;
        }
    }
    $args[] = &$data;
    call_user_func_array('array_multisort', $args);
    return array_pop($args);
}