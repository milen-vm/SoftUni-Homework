function traverse(selector) {
    var element = document.querySelector(selector);
    traverseElement(element, '');

    function traverseElement(element, spacing) {
        var elementId = element.getAttribute('id');
        var elementClass = element.getAttribute('class');
        var elementName = element.nodeName.toLowerCase();
        spacing = spacing || '  ';
        
        console.log(spacing + elementName + ':' +
            (elementId != undefined ? 'id="' + elementId + '"' : '') +
            (elementClass != undefined ? 'class="' + elementClass + '"' : ''));
            
        [].forEach.call(element.childNodes, function (child) {
            if (child.nodeType === document.ELEMENT_NODE) {
                traverseElement(child, spacing + '  ');
            };
        });
    }
}

traverse(".birds");