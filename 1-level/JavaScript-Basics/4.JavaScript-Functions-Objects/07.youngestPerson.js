function findYoungestPerson(persons) {
	var minAge = Number.MAX_VALUE;
	var youngestPerson;
	for (var i = 0; i < persons.length; i += 1) {
		if (persons[i].age < minAge) {
			minAge = persons[i].age;
			youngestPerson = persons[i];
		}
	}
	if (youngestPerson) {
		console.log('The youngest person is '+ youngestPerson.firstname +' ' + youngestPerson.lastname + '.');
	} else {
		console.log('Age is not defined.');
	}	
}
var persons = [
  { firstname : 'George', lastname: 'Kolev', age: 32}, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},
  { firstname : 'Baba', lastname: 'Ginka', age: 40}];
findYoungestPerson(persons);