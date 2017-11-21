var express = require('express');
var router = express.Router();
var debug = require('debug')('lab5:model-users');

/* GET users listing. */
router.get('/', function(req, res, next) {
  res.send('respond with a resource');
  debug('Asked to send response');
});

debug('Initialized');

module.exports = router;
