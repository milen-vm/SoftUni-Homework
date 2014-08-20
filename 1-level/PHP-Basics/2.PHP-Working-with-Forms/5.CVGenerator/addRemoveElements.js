var idCompSkill = 0;
var idOtherSkill = 0;
function removeElement(id) {
	var parent = document.getElementById(id);
	var lastDiv = parent.lastChild;
	if (lastDiv.hasAttribute('id')) {
		parent.removeChild(parent.lastChild);
	};
}
function addElement(id) {
    var parent = document.getElementById(id);
    if (id == 'comp-skills') {
  		++idCompSkill;
  		var element = document.createElement('div');
  		element.setAttribute('id','comp-skills-' + idCompSkill );
  		element.innerHTML = '<input type="text" name="progr_lang[]" />' +
							'<select name="progr_skill[]">' + 
								'<option value="Beginner">Beginner</option>' +
								'<option value="Programmer">Programmer</option>' +
								'<option value="Ninja">Ninja</option>' +
							'</select>';								
  } else{
  		++idOtherSkill;
  		var element = document.createElement('div');
  		element.setAttribute('id', 'other-skills' + idOtherSkill);
  		element.innerHTML = '<input type="text" name="languages[]" id="lang" />' +
							'<select name="lang_compr[]">' + 
								'<option value="">-Comprehension-</option>' +
								'<option value="beginner">beginner</option>' +
								'<option value="intermediate">intermediate</option>' +
								'<option value="advanced">advanced</option>' +
							'</select>' +
							'<select name="lang_reading[]">' +
								'<option value="">-Reading-</option>' +
								'<option value="beginner">beginner</option>' +
								'<option value="intermediate">intermediate</option>' +
								'<option value="advanced">advanced</option>' +
							'</select>' +
							'<select name="lang_writing[]">' +
								'<option value="">-Writing-</option>' +
								'<option value="beginner">beginner</option>' +
								'<option value="intermediate">intermediate</option>' +
								'<option value="advanced">advanced</option>' +
							'</select><br />';				
  };
  parent.appendChild(element);			  
}