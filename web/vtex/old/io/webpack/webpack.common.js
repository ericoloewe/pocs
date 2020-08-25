/**
 * Webpack config
 */
import path from 'path';
import { IgnorePlugin } from "webpack";
import CleanWebpackPlugin from 'clean-webpack-plugin';
import CopyWebpackPlugin from 'copy-webpack-plugin';
import ExtractTextPlugin from 'extract-text-webpack-plugin';
import * as pagesConfig from '../pages/pages.json';

export class WebpackCommonConfig {
  get rootPath() { return path.resolve(process.cwd()); }
  get sourcePath() { return path.resolve(this.rootPath, 'src'); }
  get distPath() { return path.resolve(this.rootPath, 'react'); }
  get pagesPath() { return path.resolve(this.sourcePath, 'pages'); }

  constructor() {
    this.resetContext();
    this.resetEntries();
    this.resetOutputs();
    this.resetPlugins();
    this.resetModules();
    this.resetResolve();
  }

  resetContext() {
    this.context = this.sourcePath;
  }

  resetEntries() {
    const { extensions } = pagesConfig;

    this.entry = Object.keys(extensions).reduce((p, n) => {
      const { component } = extensions[n];

      if (component == null) {
        console.warn(`There is no component configured with name ${n}`);
      } else {
        p[component] = path.resolve(this.pagesPath, component);
      }

      return p;
    }, {});
    this.entry.bootstrap = path.resolve(this.sourcePath, 'bootstrap');
  }

  resetOutputs() {
    this.output = {
      filename: '[name].js',
      path: this.distPath,
      library: "[name]",
      libraryTarget: "umd"
    };
  }

  resetPlugins() {
    this.plugins = [
      new CleanWebpackPlugin([this.distPath], { root: this.rootPath }),
      new ExtractTextPlugin('main.css'),
      new CopyWebpackPlugin([{ from: path.resolve(this.sourcePath, 'package.json'), to: path.resolve(this.distPath, 'package.json') }])
    ];
  }

  resetModules() {
    this.module = {
      rules: [
        {
          test: /\.jsx?$/,
          exclude: /node_modules/,
          loader: 'babel-loader'
        },
        {
          test: /\.json$/,
          loader: 'json-loader'
        },
        {
          test: /\.scss$/,
          use: ExtractTextPlugin.extract([
            { loader: "css-loader" },
            { loader: "sass-loader" }
          ])
        },
        {
          test: /\.(graphql|gql)$/,
          exclude: /node_modules/,
          loader: 'graphql-tag/loader',
        },
        {
          test: /\.(png|jpg|svg|gif)$/,
          use: [
            'file-loader'
          ]
        },
        {
          test: /\.(woff|woff2|eot|ttf|otf)$/,
          use: [
            'file-loader'
          ]
        }
      ]
    };
  }

  resetResolve() {
    this.resolve = {
      extensions: ['.js', '.jsx', '.json']
    };
    this.resolveLoader = {
      modules: [
        'node_modules',
        path.resolve(__dirname, 'loaders')
      ]
    };
  }
}

export const commonWebpackConfig = new WebpackCommonConfig();
