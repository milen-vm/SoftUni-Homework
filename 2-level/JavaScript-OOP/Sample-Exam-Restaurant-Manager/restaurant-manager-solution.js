function processRestaurantManagerCommands(commands) {
    'use strict';
    
    var Types = {
		Boolean: typeof true,
		Number: typeof 0,
		String: typeof "",
		Object: typeof {},
		Undefined: typeof undefined,
		Function: typeof function () { }
	};
    
    Object.prototype.extend = function extend(parent) {	    
	    this.prototype = Object.create(parent.prototype);
	    this.prototype.constructor = this;
	};
	
	Object.prototype.validateNonEmptyString = function validateNonEmptyString (value, variablename) {
		if (typeof (value) != Types.String || !value) {
			throw new Error('The ' + variablename +' is required.');
		};
	};
	
	Object.prototype.validateNonNegativeNumber = function validateNonNegativeNumber(value, variablename) {
		// for some reason timeToPrepare is coming from engine like a string ?!?
		// console.log(typeof value);
		// if (typeof (value) != Types.Number) {
			// throw new Error('The ' + variablename + ' must be number.');
		// };
		
		if (value <= 0) {
			throw new Error('The ' + variablename + ' must be positive.');
		};		
	};

    var RestaurantEngine = (function () {
        var _restaurants, _recipes;

        function initialize() {
            _restaurants = [];
            _recipes = [];
        }

        var Restaurant = (function () {
            function Restaurant(name, location) {
            	this.setName(name);
            	this.setLocation(location);
            	this._recipes = [];
            }
            
            Restaurant.prototype.getName = function getName() {
            	return this._name;
            };
            
            Restaurant.prototype.setName = function setName(name) {
            	this.validateNonEmptyString(name, 'restaurant name');
            	this._name = name;
            };
            
            Restaurant.prototype.getLocation = function getLocation() {
            	return this._location;
            };
            
            Restaurant.prototype.setLocation = function setLocation(location) {
            	this.validateNonEmptyString(location, 'restaurant location');
            	this._location = location;
            };                      
            
            Restaurant.prototype.addRecipe = function addRecipe(recipe) {
            	this._recipes.push(recipe);
            };
            
            Restaurant.prototype.removeRecipe = function removeRecipe(recipe) {
            	var index = this._recipes.indexOf(recipe);
            	if (index > -1) {
				    this._recipes.splice(index, 1);
				}
            };
            
            Restaurant.prototype.toString = function toStrng() {
            	return '***** ' + this.getName() + ' - ' + this.getLocation() + ' *****\n';
            };
            
            Restaurant.prototype.printRestaurantMenu = function printMenu() {
            	var menu = this.toString();
            	if (this._recipes.length === 0) {
            		menu += 'No recipes... yet\n';
            	} else{
            		var drinks = this._recipes.filter(function(recipe) {
            			return recipe instanceof Drink;
            		});         		
            		appendRecipesToMenu('DRINKS', drinks);
            		
            		var salads = this._recipes.filter(function(recipe) {
            			return recipe instanceof Salad;
            		});         		
            		appendRecipesToMenu('SALADS', salads);
            		
            		var mainCourses = this._recipes.filter(function(recipe) {
            			return recipe instanceof MainCourse;
            		});         		
            		appendRecipesToMenu('MAIN COURSES', mainCourses);
            		
            		var desserts = this._recipes.filter(function(recipe) {
            			return recipe instanceof Dessert;
            		});         		
            		appendRecipesToMenu('DESSERTS', desserts);
            		
            	};
            	
            	function appendRecipesToMenu(title, recipes) {
            		if (recipes.length > 0) {
            			recipes.sort(function(a, b) {
            				if (a.getName() > b.getName()) {
            					return 1;
            				};
            				
            				if (a.getName() < b.getName()) {
            					return -1;
            				};
            				
            				return 0;
            			});
            			
            			menu += '~~~~~ ' + title + ' ~~~~~\n';
            			menu += recipes.join('');
            		};
            	}
            	
            	return menu;
            };
            
            return Restaurant;
        })();

        var Recipe = (function () {      	    
            function Recipe(name, price, calories, quantity, timeToPrepare, unit) {
            	if (this.constructor === Recipe) {
			    	throw new Error("Can't instantiate abstract class!");
			    }
		    
            	this.setName(name);
    	this.setPrice(price);
            	this.setCalories(calories);
            	this.setQuantity(quantity);
            	this.setTimeToPrepare(timeToPrepare);
            	this._unit = unit;
            }
            
            Recipe.prototype.getName = function getName() {
            	return this._name;
            };
            
            Recipe.prototype.setName = function setName(name) {
            	this.validateNonEmptyString(name, 'recipe name');
            	this._name = name;
            };
            
            Recipe.prototype.getPrice = function getPrice() {
            	return this._price;
            };
            
            Recipe.prototype.setPrice = function setPrice(price) {
            	this.validateNonNegativeNumber(price, 'price');
            	this._price = price;
            };
            
            Recipe.prototype.getCalories = function getCalories() {
            	return this._calories;
            };
            
            Recipe.prototype.setCalories = function setCalories(calories) {
            	this.validateNonNegativeNumber(calories, 'calories');
            	this._calories = calories;
            };
            
            Recipe.prototype.getQuantity = function getQuantity() {
            	return this._quantity;
            };
            
            Recipe.prototype.setQuantity = function setQuantity(quantity) {
            	this.validateNonNegativeNumber(quantity, 'quantity');
            	this._quantity = quantity;
            };
            
            Recipe.prototype.getTimeToPrepare = function getTimeToPrepare() {
            	return this._timeToPrepare;
            };
            
            Recipe.prototype.setTimeToPrepare = function setTimeToPrepare(timeToPrepare) {
            	this.validateNonNegativeNumber(timeToPrepare, 'time to prepare');
            	this._timeToPrepare = timeToPrepare;
            };
            
            Recipe.prototype.toString = function toString() {
            	return '==  ' + this.getName() + ' == $' + this.getPrice().toFixed(2) + 
					'\nPer serving: ' + this.getQuantity() + ' ' + this._unit + ', ' + this.getCalories() + ' kcal' +
					'\nReady in ' + this.getTimeToPrepare() + ' minutes\n';
            };
            
            return Recipe;
        })();

        var Drink = (function () {
            function Drink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
            	Recipe.call(this, name, price, calories, quantity, timeToPrepare, 'ml');
            	this._isCarbonated  = isCarbonated;
            }
            
            Drink.extend(Recipe);
            
            Drink.prototype.setCalories = function setCalories(calories) {
            	if (calories <= 0 || calories > 100) {
            		throw new Error('The calories of drink must be positive number non bigger than 100.');
            	};
            	           	
            	this._calories = calories;
            };
            
            Drink.prototype.setTimeToPrepare = function setTimeToPrepare(timeToPrepare) {
            	if (timeToPrepare <= 0 || timeToPrepare > 20) {
            		throw new Error('The time to prepare of drink must be positive number non bigger than 20.');
            	};
            	
            	this._timeToPrepare = timeToPrepare;
            };
            
            Drink.prototype.toString = function toString() {
            	var carbonated = this._isCarbonated ? 'yes' : 'no';
            	return Recipe.prototype.toString.call(this) + 'Carbonated: ' + carbonated + '\n';
            };
            
            return Drink;
        })();

        var Meal = (function () {
            function Meal(name, price, calories, quantity, timeToPrepare, isVegan) {
            	if (this.constructor === Meal) {
			    	throw new Error("Can't instantiate abstract class!");
			    }
			    
			    Recipe.call(this, name, price, calories, quantity, timeToPrepare, 'g');
			    this._isVegan = isVegan;			    			    
            }
            
            Meal.extend(Recipe);
            
            Meal.prototype.toggleVegan = function toggleVegan() {
            	this._isVegan = !this._isVegan;
            };
            
            Meal.prototype.toString = function toString() {
            	var str = this._isVegan ? '[VEGAN] ': '';            	
            	return str + Recipe.prototype.toString.call(this);
            };
            
            return Meal;
        })();

        var Dessert = (function () {
            function Dessert(name, price, calories, quantity, timeToPrepare, isVegan) {
            	Meal.call(this, name, price, calories, quantity, timeToPrepare, isVegan);           	
            	this._withSugar = true;
            }     
            
            Dessert.extend(Meal);
            
            Dessert.prototype.toggleSugar = function toggleSugar() {
            	this._withSugar = !this._withSugar;
            };
            
            Dessert.prototype.toString = function toString() {
            	var str = this._withSugar ? '' : '[NO SUGAR] ';            	           	
            	return str + Meal.prototype.toString.call(this);
            };
            
            return Dessert;
        })();

        var MainCourse = (function () {
            function MainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type) {
            	Meal.call(this, name, price, calories, quantity, timeToPrepare, isVegan);
            	this._type = type;
            }
            
            MainCourse.extend(Meal);
            
            MainCourse.prototype.toString = function toString() {
            	return Meal.prototype.toString.call(this) + 'Type: ' + this._type + '\n';
            };
            
            return MainCourse;
        })();

        var Salad = (function () {
        	function Salad(name, price, calories, quantity, timeToPrepare, containsPasta) {
        		Meal.call(this, name, price, calories, quantity, timeToPrepare, true);
        		this._containsPasta = containsPasta;
        	}
        	
        	Salad.extend(Meal);
        	
        	Salad.prototype.toggleVegan = function toggleVegan() {
        		throw new Error("Can't applay method toggleVegan to Salad class!");
            };
        	
        	Salad.prototype.toString = function toString() {
        		var pasta = this._containsPasta ? 'yes' : 'no';
        		return Meal.prototype.toString.call(this) + 'Contains pasta: ' + pasta + '\n';
        	};
        	
            return Salad;
        })();

        var Command = (function () {

            function Command(commandLine) {
                this._params = new Array();
                this.translateCommand(commandLine);
            }

            Command.prototype.translateCommand = function (commandLine) {
                var self, paramsBeginning, name, parametersKeysAndValues;
                self = this;
                paramsBeginning = commandLine.indexOf("(");

                this._name = commandLine.substring(0, paramsBeginning);
                name = commandLine.substring(0, paramsBeginning);
                parametersKeysAndValues = commandLine
                    .substring(paramsBeginning + 1, commandLine.length - 1)
                    .split(";")
                    .filter(function (e) { return true });

                parametersKeysAndValues.forEach(function (p) {
                    var split = p
                        .split("=")
                        .filter(function (e) { return true; });
                    self._params[split[0]] = split[1];
                });
            }

            return Command;
        }());

        function createRestaurant(name, location) {
            _restaurants[name] = new Restaurant(name, location);
            return "Restaurant " + name + " created\n";
        }

        function createDrink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
            _recipes[name] = new Drink(name, price, calories, quantity, timeToPrepare, isCarbonated);
            return "Recipe " + name + " created\n";
        }

        function createSalad(name, price, calories, quantity, timeToPrepare, containsPasta) {
            _recipes[name] = new Salad(name, price, calories, quantity, timeToPrepare, containsPasta);
            return "Recipe " + name + " created\n";
        }

        function createMainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type) {
            _recipes[name] = new MainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type);
            return "Recipe " + name + " created\n";
        }

        function createDessert(name, price, calories, quantity, timeToPrepare, isVegan) {
            _recipes[name] = new Dessert(name, price, calories, quantity, timeToPrepare, isVegan);
            return "Recipe " + name + " created\n";
        }

        function toggleSugar(name) {
            var recipe;

            if (!_recipes.hasOwnProperty(name)) {
                throw new Error("The recipe " + name + " does not exist");
            }
            recipe = _recipes[name];

            if (recipe instanceof Dessert) {
                recipe.toggleSugar();
                return "Command ToggleSugar executed successfully. New value: " + recipe._withSugar.toString().toLowerCase() + "\n";
            } else {
                return "The command ToggleSugar is not applicable to recipe " + name + "\n";
            }
        }

        function toggleVegan(name) {
            var recipe;

            if (!_recipes.hasOwnProperty(name)) {
                throw new Error("The recipe " + name + " does not exist");
            }

            recipe = _recipes[name];
            if (recipe instanceof Meal) {
                recipe.toggleVegan();
                return "Command ToggleVegan executed successfully. New value: " +
                    recipe._isVegan.toString().toLowerCase() + "\n";
            } else {
                return "The command ToggleVegan is not applicable to recipe " + name + "\n";
            }
        }

        function printRestaurantMenu(name) {
            var restaurant;

            if (!_restaurants.hasOwnProperty(name)) {
                throw new Error("The restaurant " + name + " does not exist");
            }

            restaurant = _restaurants[name];
            return restaurant.printRestaurantMenu();
        }

        function addRecipeToRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;

            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error("The restaurant " + restaurantName + " does not exist");
            }
            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error("The recipe " + recipeName + " does not exist");
            }

            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.addRecipe(recipe);
            return "Recipe " + recipeName + " successfully added to restaurant " + restaurantName + "\n";
        }

        function removeRecipeFromRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;

            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error("The recipe " + recipeName + " does not exist");
            }
            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error("The restaurant " + restaurantName + " does not exist");
            }

            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.removeRecipe(recipe);
            return "Recipe " + recipeName + " successfully removed from restaurant " + restaurantName + "\n";
        }

        function executeCommand(commandLine) {
            var cmd, params, result;
            cmd = new Command(commandLine);
            params = cmd._params;

            switch (cmd._name) {
                case 'CreateRestaurant':
                    result = createRestaurant(params["name"], params["location"]);
                    break;
                case 'CreateDrink':
                    result = createDrink(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["carbonated"]));
                    break;
                case 'CreateSalad':
                    result = createSalad(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["pasta"]));
                    break;
                case "CreateMainCourse":
                    result = createMainCourse(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]), params["type"]);
                    break;
                case "CreateDessert":
                    result = createDessert(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]));
                    break;
                case "ToggleSugar":
                    result = toggleSugar(params["name"]);
                    break;
                case "ToggleVegan":
                    result = toggleVegan(params["name"]);
                    break;
                case "AddRecipeToRestaurant":
                    result = addRecipeToRestaurant(params["restaurant"], params["recipe"]);
                    break;
                case "RemoveRecipeFromRestaurant":
                    result = removeRecipeFromRestaurant(params["restaurant"], params["recipe"]);
                    break;
                case "PrintRestaurantMenu":
                    result = printRestaurantMenu(params["name"]);
                    break;
                default:
                    throw new Error('Invalid command name: ' + cmdName);
            }

            return result;
        }

        function parseBoolean(value) {
            switch (value) {
                case "yes":
                    return true;
                case "no":
                    return false;
                default:
                    throw new Error("Invalid boolean value: " + value);
            }
        }

        return {
            initialize: initialize,
            executeCommand: executeCommand
        };
    }());


    // Process the input commands and return the results
    var results = '';
    RestaurantEngine.initialize();
    commands.forEach(function (cmd) {
        if (cmd != "") {
            try {
                var cmdResult = RestaurantEngine.executeCommand(cmd);
                results += cmdResult;
            } catch (err) {
                results += err.message + "\n";
            }
        }
    });

    return results.trim();
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function() {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function(line) {
            arr.push(line);
        }).on('close', function() {
            console.log(processRestaurantManagerCommands(arr));
        });
    }
})();
