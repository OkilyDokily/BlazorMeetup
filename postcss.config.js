module.exports = {
    plugins: [
        require('tailwindcss'),
        require('autoprefixer'),
        require('@fullhuman/postcss-purgecss')({
            content: [
                './Pages/**/*.cshtml',
                './Pages/*.razor',
                './Pages/*.cshtml',
                './Pages/**/*.razor',
                './Shared/*.razor',
                //'./Src/MyProject.Web/Pages/**/.html', // This is how you add other files
            ],
            defaultExtractor: content => content.match(/[A-Za-z0-9-_:/]+/g) || []
        })
    ]
}