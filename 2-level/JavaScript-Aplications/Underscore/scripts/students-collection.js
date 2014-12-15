(function() {   
    $(document).ready(function() {
        $('#output-collection').val('');
        $('[name="operation"]').on('click', operationSelected);
        
        if ($('[name="operation"]:checked').val()) {
            $('[name="operation"]:checked').trigger( "click" );
        };
    });
 
    function operationSelected() {
        var outputStudents,
            operation = $(this).val(),
            inputStudents = readInput();
            
        if (inputStudents) {
            switch(operation) {
                case 'operation-1':
                    outputStudents = firstOperation(inputStudents);
                    break;
                case 'operation-2':
                    outputStudents = secondOperation(inputStudents);
                    
                    break;
                case 'operation-3':
                    outputStudents = thirdOperation(inputStudents);                   
                    break;
                case 'operation-4':
                    outputStudents = _.last(inputStudents, 5);
                    break;
                case 'operation-5':
                    outputStudents = fifthOperation(inputStudents);                    
                    break;
                default:
                    $('#output-collection').val('Invalid operation.' + operation);
                    break;
            }
            
            if (outputStudents) {
                $('#output-collection').val(JSON.stringify(outputStudents, null, 4));
            }               
        }
    }
    
    function readInput() {
        var input = $('#input-collection').val();
        if (input) {
            try {
                return JSON.parse(input);
            }
            catch(err) {
                $('#output-collection').val('Invalid input. ' + err);
            }
                                
        } else {
            $('#output-collection').val('Empty input field.');
        };        
    }
    
    // Get all students with age between 18 and 24
    function firstOperation(inputStudents) {
        var output = _.filter(inputStudents, function(st) {
            return st.age >= 18 && st.age <= 24;
        });
        
        return output;
    }
    
    // Get all students whose first name is alphabetically before their last name
    function secondOperation(inputStudents) {
        var output = _.filter(inputStudents, function(st) {
            return st.firstName.localeCompare(st.lastName) === -1;
        });
        
        return output;
    }
    
    // Get only the names of all students from Bulgaria
    function thirdOperation(inputStudents) {
        var output = _.chain(inputStudents)
            .where({country: 'Bulgaria'})
            .map(function(st) {
                return st.firstName + ' ' + st.lastName;
            }).value();
            
        return output;
    }
    
    // Get the first three students who are not from Bulgaria and are male
    function fifthOperation(inputStudents) {
        var output = _.chain(inputStudents)
            .reject(function(st) {
                return st.country === 'Bulgaria';
            })
            .where({gender: 'Male'})
            .first(3).value();
            
        return output;
    }   
})();

