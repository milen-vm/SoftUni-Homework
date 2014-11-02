var domModule = (function domModule() {    
    function appendChild(domElement, parentSelector) {
        var parent = document.querySelector(parentSelector);
        domElement.innerHTML = 'new element';
        parent.appendChild(domElement);       
    }
    
    function removeChild(parentSelector, childSelector) {
        var parent = document.querySelector(parentSelector);        
        var child = document.querySelector(childSelector);
        parent.removeChild(child);
    }
    
    function addHandler(elementSelector, event, eventHandler) {
        var element = document.querySelectorAll(elementSelector);
        
        for (var i = 0; i  < element.length; i ++) {
          element[i].addEventListener(event, eventHandler);
        };
    }
    
    function retrieveElements(elementSelector) {
        var element = document.querySelectorAll(elementSelector);
        for (var i = 0; i  < element.length; i ++) {
          console.log(element[i]);
        };
    }
    
    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveElements: retrieveElements
    };
})();
