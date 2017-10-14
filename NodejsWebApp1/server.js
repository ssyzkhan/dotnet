var http = require('http');
var fs = require('fs');
var port = process.env.port || 1337;
http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-Type': 'text/html' });
    fs.readFile('./index.html', function (err, data) {
        res.write(data);
        res.end();
    });
    res.write('Field ');
    //res.end('Hello World\n');
}).listen(port);
//# sourceMappingURL=server.js.map