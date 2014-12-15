(function() {   
    $(document).ready(function() {
        $('#output-collection').val('');
        $('[name="operation"]').on('click', operationSelected);
        
        if ($('[name="operation"]:checked').val()) {
            $('[name="operation"]:checked').trigger( "click" );
        };
    });
 
    function operationSelected() {
        var outputBooks,
            operation = $(this).val(),
            inputBooks = readInput();
            
        if (inputBooks) {
            switch(operation) {
                case 'operation-1':
                    outputBooks = firstOperation(inputBooks);                    
                    break;
                case 'operation-2':
                    outputBooks = secondOperation(inputBooks);
                    break;
                case 'operation-3':
                    outputBooks = thirdOperation(inputBooks);
                    break;
                default:
                    $('#output-collection').val('Invalid operation.' + operation);
                    break;
            }
            
            if (outputBooks) {
                $('#output-collection').val(JSON.stringify(outputBooks, null, 4));
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
    
    // Group all books by language and sort them by author (if two books have the same author, sort by price)
    function firstOperation(inputBooks) {
        var output = _.chain(inputBooks)                
            .sortBy(function(book) {
                return book.author + ' ' + book.price;
            })
            .groupBy('language').value();
        
        return output;
    }
    
    // Get the average book price for each author
    function secondOperation(inputBooks) {
        var output = _.chain(inputBooks)
            .groupBy('author')
            .map(function(books, author, list) {
                var sum = 0,
                    averagePrice = {};
                _.each(books, function(book) {
                    var price = book.price.replace(/,/g, '.');
                    sum += parseFloat(price);
                });
                
                averagePrice[author] = (sum / books.length).toFixed(2);
                
                return averagePrice;
            }).value();
                        
        return output;
    }
    
    // Get all books in English or German, with price below 30.00, and group them by author
    function thirdOperation(inputBooks) {
        var output = _.chain(inputBooks)
            .filter(function(book) {
            return (book.language === 'English' || book.language === 'German') && parseFloat(book.price)<30.00;
            })
            .groupBy('author').value();
        
        return output;
    }
})();

