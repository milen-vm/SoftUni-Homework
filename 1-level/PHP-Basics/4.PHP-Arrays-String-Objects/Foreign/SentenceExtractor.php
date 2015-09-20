<form action="" method="post">
    <textarea name="input" id="input" cols="30" rows="10"></textarea>
    <input type="text" name="word"/>
    <input type="submit"/>
</form>

<?php
if (isset($_POST['input']) && !empty($_POST['input'])) {
    if (!empty($_POST['word'])) {
        $text = $_POST['input'];
        $word = $_POST['word'];
        $pattern = "/.*?[?!\.]/";
        preg_match_all($pattern, $text, $sentences);

        foreach ($sentences[0] as $sentence) {
            if(preg_match("/\b$word\b/",$sentence)){
                echo "$sentence<br>";
            }
        }

    }
}

?>