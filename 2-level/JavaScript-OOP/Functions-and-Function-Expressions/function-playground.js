function playground(){
    console.log('Function ' + playground.name + ' takes ' + arguments.length + ' parameter/s.');

    for (var i = 0; i < arguments.length; i++) {
      console.log((i + 1) + '. ' + arguments[i] + ' -> ' + typeof arguments[i]);
    };
    
    console.log(this.value);        // displays undefined when value is not set
    console.log();
}

playground();
playground(6, null, true);
playground(1, 5.5, 'argument');
playground(1, 5.5, 'argument', [4, 8, 9], {firstName: 'John', lastName: 'Doe'});
playground.call({value: 'some value for "this"'}, 4, true);
playground.apply(null, ['word', 4]);