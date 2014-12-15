(function() {
	var jsonString = '[{"manufacturer":"BMW","model":"E92 320i","year":2011,"price":50000,"class":"Family"},' + 
	'{"manufacturer":"Porsche","model":"Panamera","year":2012,"price":100000,"class":"Sport"},' + 
	'{"manufacturer":"Peugeot","model":"305","year":1978,"price":1000,"class":"Family"}]';
	var obj = JSON.parse(jsonString);
	
	$(document).ready(function() {
		makeTable($(document.body), obj);
	});
	
	function makeTable(container, data) {
		var $table = $('<table>');
		$table.append(makeTableHead(data[0]));
		
		$.each(data, function(rowIndex, row) {
	        var $tableRow = $('<tr>');
	        $.each(row, function(key, value) {				        	
            	$tableRow.append($('<td>').text(value));
        	});
        
        	$table.append($tableRow);
	    });
	    
	    container.append($table);
	}
	
	function makeTableHead(data) {
		var $headTableRow = $('<tr>');
		$.each(data, function(key) {
			var title = capitalizeFirstLetter(key);
			$headTableRow.append($('<th>').text(title));
		});
		
		return $headTableRow;
	}
	
	function capitalizeFirstLetter(str) {
	    return str.substr(0, 1).toUpperCase() + str.substr(1);
	}
})();