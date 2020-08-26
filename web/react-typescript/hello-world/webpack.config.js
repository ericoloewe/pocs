var webpack = {
    entry: "./src/index.tsx",
    // Enable sourcemaps for debugging webpack's output.
    devtool: "source-map"
};

webpack.output = {
    filename: "bundle.js",
    path: __dirname + "/build"
};

webpack.resolve = {
    // Add '.ts' and '.tsx' as resolvable extensions.
    extensions: ["", ".webpack.js", ".web.js", ".ts", ".tsx", ".js"]
};

webpack.module = {
    loaders: [
        // All files with a '.ts' or '.tsx' extension will be handled by 'awesome-typescript-loader'.
        require("./webpack/loaders/awesome-typescript-loader")
    ],
    preLoaders: [
        // All output '.js' files will have any sourcemaps re-processed by 'source-map-loader'.
        require("./webpack/pre-loaders/source-map-loader")
    ]
};

// When importing a module whose path matches one of the following, just
// assume a corresponding global variable exists and use that instead.
// This is important because it allows us to avoid bundling all of our
// dependencies, which allows browsers to cache those libraries between builds.
webpack.externals = {
    "react": "React",
    "react-dom": "ReactDOM"
};

module.exports = webpack;
