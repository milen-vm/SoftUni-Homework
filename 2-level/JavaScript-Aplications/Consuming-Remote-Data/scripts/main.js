$(document).ready(function() {
    renderTable();
    
    function renderTable() {
        service.getAllBooks(
            function(data) {
                loadBooksToTable(data.results);
            },
            function(error) {
                console.log(error);
            }
        );
    }
        
    function loadBooksToTable(books) {
        var tableBody = $('#book-lib');
        tableBody.html('');
        $.each(books, function(_, book) {
            var row = $('<tr>').attr('data-id', book.objectId),
                title = $('<td>').text(book.title).attr({'class': 'title', 'title': 'Click to edit'}),
                author = $('<td>').text(book.author).attr({'class': 'author', 'title': 'Click to edit'}),
                isbn = $('<td>').text(book.isbn).attr({'class': 'isbn', 'title': 'Click to edit'}),
                button = $('<td>').html('<input type="button" class="delete-book" value="Delete" />');
            row.append(title)
               .append(author)
               .append(isbn)
               .append(button);
           tableBody.append(row);
        });  
    }
    
    $('#add-book').click(function() {
        var title = $('#title').val(),
            author = $('#author').val(),
            isbn = $('#isbn').val(),
            book = {
                'title': title,
                'author': author,
                'isbn': isbn
            };
         
        service.postBook(
            book,
            function() {
                setTimeout(renderTable, 500);
            },
            function(error) {
                console.log(error);
            }
        );
        
        $('#title').val('');
        $('#author').val('');
        $('#isbn').val('');
    });
    
    $('#book-lib').on('click', '.delete-book', function() {
        var $tableRow = $(this).parent().parent(),
            objectId = $tableRow.attr('data-id');

        service.deleteBook(
            objectId,
            function() {
                $tableRow.remove();
            },
            function(error) {
                console.log(error);
            }
        );
    });
    
    $('#book-lib').on('click', 'td:not(:last-child)', function(ev) {
        var $td = $(this),
            oldValue = $td.text(),
            newValue = prompt("Please enter new value:", oldValue),
            elementName = $td.attr('class'),
            $tableRow = $td.parent(),
            objectId = $tableRow.attr('data-id'),
            data = {};
        data[elementName] = newValue;
        if (newValue && oldValue != newValue) {
            service.putBook(
                objectId,
                data,
                function() {
                    renderTable();
                },
                function(error) {
                    console.log(error);
                }
            );
        };
    });
});
