const Article = require('../models').Article;
const User = require('../models').User;

module.exports = {
    createGet: (req, res) => {
        res.render('article/create');
    },

    createPost: (req, res) => {
        let articleArgs = req.body;
        let errorMsg = '';
        if (!req.isAuthenticated()) {
            errorMsg = 'You should be logged in to make articles!'
        } else if (!articleArgs.title) {
            errorMsg = 'Invalid title!';
        } else if (!articleArgs.content) {
            errorMsg = 'Invalid content!';
        }

        if (errorMsg) {
            res.render('article/create', {error: errorMsg});
            return;
        }
        articleArgs.authorId = req.user.id;
        articleArgs.date = Date.now();
        articleArgs.author = req.user.fullName;
        Article.create(articleArgs).then(article => {
            res.redirect('/');
        });
    },

    details:(req,res) => {
        let id = req.params.id;
        Article.findById(id).then(article => {
            res.render('article/details',article.dataValues)
        })
    },
    myArticles:(req, res) => {
        User.findOne({where: {id: req.user.id}}).then(user => {
            Article.findAll({where: {authorId: user.dataValues.id}}).then(article => {
                res.render('user/myArticles', {articles: article});
            });
        });
    }
};
