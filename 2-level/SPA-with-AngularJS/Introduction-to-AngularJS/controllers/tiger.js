app.controller('Tiger', function($scope) {
    var tiger = {
        'Name': 'Pesho',
        'Born': 'Asia',
        'BirthDate': 2006,
        'Live': 'Sofia Zoo'
    };
       
    var urlPhoto = 'http://tigerday.org/wp-content/uploads/2013/04/tiger.jpg';
    var style = {
        'head': {},
        'list': {},
        'textContainer': {},
        'title': {},
        'item': {},
        'div': {}
    };
    
    style.head = {
        'font-weigh': 'bold',
        'text-align': 'center',
        'margin': '0',
        'text-transform': 'uppercase'
    };
    
    style.list = {
        'list-style-type': 'none',
        'padding': '0',
        'width': '220px' 
    };
    
    style.textContainer = {
        'color': '#2C3E50',
        'dispaly': 'inline-block',
        'background-color': '#CACACA',
        'padding': '15px'
    };
    
    style.title = {
        'font-weight': 'bold',
        'margin-bottom': '10px'
    };
    
    style.item = {
        'padding': '0 0 10px 10px' 
    };
    
    style.div = {
        'margin': '0',
        'width': '49%',
        'display': 'inline-block',
        'vertical-align': 'top'
    };
    
    $scope.tiger = tiger;
    $scope.urlPhoto = urlPhoto;
    $scope.style = style;
});
