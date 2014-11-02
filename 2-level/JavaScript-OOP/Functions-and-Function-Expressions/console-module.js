var specialConsole = (function() {
   function writeLine() {
       var message;
       
       if (arguments.length === 1) {
           message = arguments[0];
           console.log(message);
       } else if (arguments.length > 1) {
           // arr = Array.prototype.slice.call(arguments);     // converts object to array, but it is not necessary :)
           message = replacePlaceholders(arguments);
           console.log(message);
       }
   } 
   
   function replacePlaceholders(args) {
       var str = args[0];
       for (var i = 1; i  < args.length; i ++) {
           str = str.replace('{' + (i - 1) + '}', args[i].toString());  
       };
       
       return str;
   }
   
   return {
       writeLine: writeLine,
       writeError: writeLine,
       writeWarning: writeLine
       };
})();

specialConsole.writeLine('Message: hello');
specialConsole.writeLine('Message: {0}', 'hello');
specialConsole.writeError('Error: {0}', 'A fatal error has occurred.');
specialConsole.writeWarning('Warning: {0}', 'You are not allowed to do that!');
specialConsole.writeWarning('Warning: {0} {1}', 'You are doing it wrong', ':)');
specialConsole.writeLine();

