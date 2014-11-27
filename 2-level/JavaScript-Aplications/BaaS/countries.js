$(document).ready(function() {
	var PARSE_APP_ID = 'gck0zticPBjI1ktK5KUDxE8l1i0icMemP9lnU9hu';
	var PARSE_REST_API_KEY = 'IJEcWSKZPgWu2cEPlyKUubN4tdEYf2FTnKUzepGx';
	
	loadCountries();
	
	function loadCountries() {
		$.ajax({
			method: 'GET',
			headers: {
				'X-Parse-Application-Id': PARSE_APP_ID,
				'X-Parse-REST-API-Key': PARSE_REST_API_KEY
				},
			url: 'https://api.parse.com/1/classes/Country',
			success: function(data) {
				addContriesToDOM(data);
				successMessage('Successfully loaded data.');
			},
			error: function() {
				errorMessage('Cannot load AJAX data.');
			}
		});
	}
	
	function addContriesToDOM(data) {
		for(var c in data.results) {
			var country = data.results[c];
			var countryItem = $('<option>').text(country.name);
			countryItem.data('country', country);
			countryItem.appendTo($('#countries'));
		}
	}	
	
	$('#add-country').click(function() {
		var country = $('#country-name').val();
		if (isValidName(country)) {
			addCountry(country);
		} else {
			warningMessage('Invalid country name.');
		};
	});		
	
	function addCountry(name) {
		$.ajax({
			method: 'POST',
			headers: {
				'X-Parse-Application-Id': PARSE_APP_ID,
				'X-Parse-REST-API-Key': PARSE_REST_API_KEY
			},
			url: 'https://api.parse.com/1/classes/Country',
			data: JSON.stringify(
				{'name': name}
			),
			contentType: "application/json",
			success: function() {
				successMessage('Successfully added country.');
			},
			error: function() {
				errorMessage('Cannot add country.');
			}
		});
	}

	$('#countries').change(function() {
		var country = $('#countries').find(':selected').data('country');
		if (country) {
			$.ajax({
				method: 'GET',
				headers: {
					'X-Parse-Application-Id': PARSE_APP_ID,
					'X-Parse-REST-API-Key': PARSE_REST_API_KEY
				},
				url: 'https://api.parse.com/1/classes/Town?where={"country":{"__type":"Pointer","className":"Country","objectId":"' + country.objectId + '"}}',
				success: addTownsToDOM,
				error: function() {
					errorMessage('Cannot load towns of ' + country.name + '.');
				}
			});
		} else {
			warningMessage('Country is not selected.');
		};
		
		var countryName = $(this).val();
		$('#new-country-name').val(countryName);
	});

	$('#edit-country-name').click(function() {
		var newName = $('#new-country-name').val();
		if (isValidName(newName)) {
			editCountry(newName);
		} else {
			warningMessage('Invalid country name.');
		};		
	});
	
	function editCountry(newName) {
		var country = $('#countries').find(':selected').data('country');
		if (country) {
			$.ajax({
				method: 'PUT',
				headers: {
					'X-Parse-Application-Id': PARSE_APP_ID,
					'X-Parse-REST-API-Key': PARSE_REST_API_KEY
				},
				url: 'https://api.parse.com/1/classes/Country/' + country.objectId,
				data: JSON.stringify(
					{'name': newName}
				),
				contentType: "application/json",
				success: function() {
					successMessage('Successfully edited country name.');
				},
				error: function() {
					errorMessage('Cannot edit country name.');
				}
			});
		} else {
			warningMessage('Select a country name for editing.');
		};
	}
	
	$('#delete-country').click(function() {
		var country = $('#countries').find(':selected').data('country');
		if (country) {
			$.ajax({
				method: 'DELETE',
				headers: {
					'X-Parse-Application-Id': PARSE_APP_ID,
					'X-Parse-REST-API-Key': PARSE_REST_API_KEY
				},
				url: 'https://api.parse.com/1/classes/Country/' + country.objectId,
				success: function() {
					successMessage('Successfully deleted country.');
				},
				error: function() {
					errorMessage('Cannot delete country.');
				}
			});
		} else {
			warningMessage('Select a country for deleting.');
		};
	});	
	
	// Towns
	
	$('#towns').change(function() {
		var townName = $(this).val();
		$('#new-town-name').val(townName);
	});
	
	function addTownsToDOM(data) {
		var $towns = $('#towns');
		$towns.html('');
		for(var t in data.results) {
			var town = data.results[t];
			var townItem = $('<option>').text(town.name);
			townItem.data('town', town);
			townItem.appendTo($towns);
		}
	}

	$('#edit-town-name').click(function() {
		var newName = $('#new-town-name').val();
		if (isValidName(newName)) {
			editTown(newName);
		} else {
			warningMessage('Invalid town name.');
		};				
	});
	
	function editTown(newName) {
		var town = $('#towns').find(':selected').data('town');
		if (town) {
			$.ajax({
				method: 'PUT',
				headers: {
					'X-Parse-Application-Id': PARSE_APP_ID,
					'X-Parse-REST-API-Key': PARSE_REST_API_KEY
				},
				url: 'https://api.parse.com/1/classes/Town/' + town.objectId,
				data: JSON.stringify(
					{'name': newName}
				),
				contentType: "application/json",
				success: function() {
					successMessage('Successfully edited town name.');
				},
				error: function() {
					errorMessage('Cannot edit town name.');
				}
			});
		} else {
			warningMessage('Select a town name for editing.');
		};
	}
	
	$('#delete-town').click(function() {
		var town = $('#towns').find(':selected').data('town');
		if (town) {
			$.ajax({
				method: 'DELETE',
				headers: {
					'X-Parse-Application-Id': PARSE_APP_ID,
					'X-Parse-REST-API-Key': PARSE_REST_API_KEY
				},
				url: 'https://api.parse.com/1/classes/Town/' + town.objectId,
				success: function() {
					successMessage('Successfully deleted town.');
				},
				error: function() {
					errorMessage('Cannot delete town.');
				}
			});
		} else {
			warningMessage('Select a town for deleting.');
		};
	});
	
	$('#add-town').click(function() {
		var townName = $('#new-town-name').val();
		var country = $('#countries').find(':selected').data('country');
		if (isValidName(townName)) {
			if (country) {
				addTown(townName, country);
			} else {
				warningMessage('Select a country to add a town.');
			};
		} else {
			warningMessage('Invalid a town name.');
		};
	});
	
	function addTown(name, country) {
		$.ajax({
			method: 'POST',
			headers: {
				'X-Parse-Application-Id': PARSE_APP_ID,
				'X-Parse-REST-API-Key': PARSE_REST_API_KEY
			},
			url: 'https://api.parse.com/1/classes/Town',
			data: JSON.stringify(
				{
					'country': {
						'__type': 'Pointer',
						'className': 'Country',
						'objectId': country.objectId
					},
					'name': name
				}
			),
			contentType: "application/json",
			success: function() {
					successMessage('Successfully added town.');
				},
			error: function() {
					errorMessage('Cannot add town.');
				}
		});
	}
	
	function isValidName(str) {
		if (!str || !str.replace(/\s/g, '').length) {
		    return false;
		}
		
		return true;
	}
	
	// Messages	
	
	function errorMessage(message) {
		noty({
			text: message, 
			type: 'error',
			layout: 'topCenter',
			timeout: 5000}
		);
	}
	
	function warningMessage(message) {
		noty({
			text: message, 
			type: 'warning',
			layout: 'topCenter',
			timeout: 2000}
		);
	}
		
	function successMessage(message) {
		noty({
			text: message, 
			layout: 'topCenter',
			timeout: 2000}
		);		
	}
});
