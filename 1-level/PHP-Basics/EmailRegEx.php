<?php
$text = 'fr r milen@abv.bg, milen@com.gty.hu milen@rts .com';
$pattern = '/[\w.+]+@\w+(\.\w+)+/';
$count = preg_match_all($pattern, $text, $result);
var_dump($result);
?>