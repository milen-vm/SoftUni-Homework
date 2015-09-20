<form action="" method="post">
<textarea name="input" id="" cols="30" rows="10"></textarea>
    <input type="submit" value="Count words"/>
</form>
<?php
if(isset($_POST['input']) && !empty($_POST['input'])){
?>
<table border="1">
    <tbody>

<?php
$text=$_POST['input'];
    $text=strtolower($text);
   $words= preg_split("/\W+/",$text,-1,PREG_SPLIT_NO_EMPTY);
$mapped=array_count_values($words);

    foreach ($mapped as $key => $value){
        echo "<tr><td>$key</td><td>$value</td></tr>";
    }
}
?>
    </tbody>
</table>