<?php
$html = $_GET['html'];
$htmlArr = preg_split('/\n/', $html, -1, PREG_SPLIT_NO_EMPTY);
$tags = array('main', 'header', 'nav', 'article', 'section', 'aside', 'footer');
$htmlLine = '';
for ($i=0; $i < count($htmlArr); $i++) { 
	$htmlLine = $htmlArr[$i];
	$countDiv = preg_match('/<\s*div/', $htmlLine);
	if ($countDiv > 0) {
		//$patternID = 'id\s*=\s*"[a-z]+"';
		// $patternClass = 'class\s*=\s*"[a-z]+"';
		
		$countID = preg_match('/id\s*=\s*"[a-z]+"/', $htmlLine, $matchID);
		
		if ($countID > 0) {
			$id = $matchID[0];
			
			for ($j=0; $j < count($tags); $j++) { 
				$tag = $tags[$j];
				
				if (strpos($id, $tag) !== FALSE) {
					$htmlArr[$i] = preg_replace('/div/', $tag, $htmlArr[$i]);
					$htmlArr[$i] = preg_replace('/id\s*=\s*"[a-z]+"/', '', $htmlArr[$i]);
					$htmlArr[$i] = preg_replace('/\s*>/', '>', $htmlArr[$i]);
					$htmlArr[$i] = preg_replace('/\s+/', ' ', $htmlArr[$i]);
					
					for ($k = $i + 1; $k  < count($htmlArr); $k ++) { 
						$closeTag = $htmlArr[$k];
						$patternCloseTag = '/<\!--\s*' . $tag . '\s*-->/';
						$countCloseTag = preg_match($patternCloseTag, $closeTag);
						if ($countCloseTag > 0) {
							$htmlArr[$k] = '</' . $tag . '>';
						}
					}
				} 				
			}
		}
		$countClass = preg_match('/class\s*=\s*"[a-z]+"/', $htmlLine, $matchClass);
		
		if ($countClass > 0) {
			$class = $matchClass[0];
			
			for ($j=0; $j < count($tags); $j++) { 
				$tag = $tags[$j];
				
				if (strpos($class, $tag) !== FALSE){
					$htmlArr[$i] = preg_replace('/div/', $tag, $htmlArr[$i]);
					$htmlArr[$i] = preg_replace('/class\s*=\s*"[a-z]+"/', '', $htmlArr[$i]);
					$htmlArr[$i] = preg_replace('/\s*>/', '>', $htmlArr[$i]);
					$htmlArr[$i] = preg_replace('/\s+/', ' ', $htmlArr[$i]);
					
					for ($k = $i + 1; $k  < count($htmlArr); $k ++) { 
						$closeTag = $htmlArr[$k];
						$patternCloseTag = '/<\!--\s*' . $tag . '+\s*-->/';
						$countCloseTag = preg_match($patternCloseTag, $closeTag);
						if ($countCloseTag > 0) {
							$htmlArr[$k] = '</' . $tag . '>';
						}
					}
				}
			}
		}
	}
}

echo implode("\n", $htmlArr);

?>