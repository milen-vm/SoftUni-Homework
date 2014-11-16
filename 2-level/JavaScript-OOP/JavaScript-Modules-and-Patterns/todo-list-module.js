var listModule = (function() {	
	'use strict';
	
	Object.prototype.extend = function extend(parent) {	    
	    this.prototype = Object.create(parent.prototype);
	    this.prototype.constructor = this;
	};
	
	
	var ListElement = (function() {
		function ListElement(title) {
			this.setTitle(title);
			return this;
		}
		
		ListElement.prototype.setTitle = function setTitle(title) {
			this.validateElemenTtitle(title);
			this._title = title;
		};
		
		ListElement.prototype.getTitle = function getTitle() {
			return this._title;
		};
		
		ListElement.prototype.validateElemenTtitle = function validateElemenTtitle(value) {
			if (value === null || value === undefined || value === '') {
				throw new Error(this.constructor.name + 'title cannot be null, empty or undefined.');
			};
			
			if (!value.replace(/\s/g, '').length) {
			    throw new Error(this.constructor.name + ' title cannot be whitespace.');
			}
		};
		
		return ListElement;
	})();	
	
	
	var Container = (function() {
		function Container(title) {		
			ListElement.call(this, title);
			return this;
		}
		
		Container.extend(ListElement);
		
		Container.prototype.addToDOM = function addToDOM() {
			var mainDiv = document.getElementById('main');
			var article = document.createElement('ARTICLE');
			article.setAttribute('id', 'container');
			article.innerHTML = '<h2>' + this.getTitle() + '</h2>\n' +
				'<div id="section-container"></div>\n' +
				'<input type="text" id="section-title" placeholder="Title..." />\n' +
				'<input type="button" id="section-add" value="New Section" onclick="addSection()" />';
			mainDiv.appendChild(article);
		};
		
		return Container;
	})();
	
	
	var Section = (function() {
		var counter = 0;
		function Section() {			
			var title = document.getElementById('section-title').value;
			ListElement.call(this, title);
			++counter;		
			this._sectionNumber = counter;
			return this;
		}
		
		Section.extend(ListElement);
		
		Section.prototype.addToDOM = function addToDOM() {
			var sectionContainer = document.getElementById('section-container');
			var section = document.createElement('section');
			section.innerHTML = '<div>\n' +
				'<h3>' + this.getTitle() + '</h3>' +
				'<div id="sect-' + this._sectionNumber + '"></div>\n' +
				'</div>' +
				'<input id="inp-' + this._sectionNumber + 
				'" type="text" class="item-title" placeholder="Add item..." />\n' +
				'<input type="button" class="item-add" value="+" onclick="addItem(' + this._sectionNumber + ')" />';
			sectionContainer.appendChild(section);
		};
		
		return Section;
	})();
	

	var Item = (function() {
		var counter = 0;
		function Item(inputId) {
			var title = document.getElementById(inputId).value;
			ListElement.call(this, title);
			++counter;
			this._itemCounter = counter;
			return this;
		}
		
		Item.extend(ListElement);
		
		Item.prototype.addToDOM = function addToDOM(sectionId) {
			var itemContainer = document.getElementById(sectionId);
			var item = document.createElement('div');
			item.innerHTML = '<input type="checkbox" id="item-' + this._itemCounter + '" />\n' +
				'<label for="item-' + this._itemCounter + '">' + this.getTitle() + '</label>';
			itemContainer.appendChild(item);
		};
		
		return Item;
	})();
	
	
	return {
		Container: Container,
		Section: Section,
		Item: Item
	};	
})();
