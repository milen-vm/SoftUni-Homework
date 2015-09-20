<form action="" method="post">
    <textarea name="text" id="text" cols="30" rows="10"></textarea>
    <input type="text" name="banlist" id="banlist"/>
    <input type="submit"/>
</form>
<?php
if(isset($_POST['text']) && !empty($_POST['text'])){
    $text=$_POST['text'];
    if(!empty($_POST['banlist'])){
        $banlist=explode(', ',$_POST['banlist']);
        foreach ($banlist as $banWord) {
            $len=strlen($banWord);
           $replacement= str_pad('*',$len,'*');
            $pattern="/\b$banWord\b/";
           $text= preg_replace($pattern,$replacement,$text);
        }
    }

    echo "$text";
}
?>