var fs = require('fs');
fs.readdirSync('./routes').forEach(function (file) {
  if(file.substr(-3) == '.js') {
    console.log(file.substr(0,file.length-3));
  }
});
