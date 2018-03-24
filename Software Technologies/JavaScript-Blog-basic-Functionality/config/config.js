const path = require('path');

module.exports = {
    rootFolder: path.normalize(path.join(__dirname, '/../')),
    database:{
        "development": {
            "username": "blogAdminUser",
            "password": "blogAdminUserPassword1234!",
            "database": "softuni_blog",
            "host": "77.78.30.214",
            "dialect": "mysql",
            "logging": false
        },
    }
};

