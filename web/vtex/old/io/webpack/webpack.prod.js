/**
 * Webpack prod config
 */
import merge from 'webpack-merge';
import { commonWebpackConfig } from './webpack.common';
import UglifyJSPlugin from 'uglifyjs-webpack-plugin';
import ExtractTextPlugin from 'extract-text-webpack-plugin';

export class WebpackProdConfig {
  constructor() {
    this.resetNodeEnv();
    this.resetPlugins();
  }

  resetNodeEnv() {
    process.env.BABEL_ENV = 'production';
    process.env.NODE_ENV = 'production';
  }

  resetPlugins() {
    this.plugins = [
      new UglifyJSPlugin()
    ];
  }
}

export const prodWebpackConfig = merge(commonWebpackConfig, new WebpackProdConfig());
