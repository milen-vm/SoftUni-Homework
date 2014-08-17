<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8"/>
		<title>Information Table</title>
		<style>
			table {
				border-collapse: collapse;
				font-family: Arial, Georgia, Serif;
				margin: 0 auto;
			}
			table td {
				box-sizing: border-box;
				border: solid 1px black;
				height: 30px;
				width: 150px;
				padding: 0 10px;
			}
			td:first-child {
				background-color: #ffa100;
				font-weight: bold;
			}
			td:last-child {
				text-align: right;
			}			
		</style>
	</head>
	<body>
		<table>
			<tbody>
				<?php
				$infoGosho = array('Name' => 'Gosho',
							 	   'Phone number' => '0882-321-423',
							 	   'Age' => 24,
							 	   'Adress' => 'Hadji Dimitar');
								   
			  	$infoPesho = array('Name' => 'Pesho',
							       'Phone number' => '0884-888-888',
							  	   'Age' => 67,
							       'Adress' => 'Suhata Reka');
								   
			    function generateTable($info)
				{
					foreach ($info as $key => $value) {
						echo "<tr><td>${key}</td><td>${value}</td></tr>";
					}
				}
				generateTable($infoGosho);
				generateTable($infoPesho);
				?>
			</tbody>	
		</table>		
	</body>
</html>