<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Sidebar Builder</title>
</head>
<body>
<form action="" method="post">
    <label for="categories">Categories:</label>
    <input type="text" name="categories" id="categories"/>

    <label for="tags">Tags:</label>
    <input type="text" name="tags" id="tags"/>

    <label for="months">Months:</label>
    <input type="text" name="months" id="months"/>

    <input type="submit" value="Generate"/>
</form>

<?php
if(isset($_POST)){
    foreach ($_POST as $key=>$values) {
        echo "<aside><h2>".ucfirst($key)."</h2><hr>";
        echo "<ul>";
            $val_array=explode(', ',$values);
        foreach ($val_array as $val) {
            echo "<li>$val</li>";
        }
        echo "</ul></aside>";
    }
}
?>
</body>
</html>