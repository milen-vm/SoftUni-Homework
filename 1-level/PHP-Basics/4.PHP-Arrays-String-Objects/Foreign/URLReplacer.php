<form action=""method="post">
    <textarea name="text" id="text" cols="30" rows="10"></textarea>
    <input type="submit"/>
</form>

<?php
if(isset($_POST['text']) && !empty($_POST['text'])){
    $text=$_POST['text'];
    $pattern="/<a\s*?href\s*?=\s*?([^>]+)*>(.+?)<\/a>/";
    preg_match_all($pattern,$text,$anchors,PREG_SET_ORDER);
//    var_dump($anchors);
    foreach ($anchors as $ahref) {
        $text=  str_replace($ahref[0],"[URL=".trim($ahref[1],'\"\'')."] ".$ahref[2]."[/URL]",$text);

    }
echo $text;
}
?>