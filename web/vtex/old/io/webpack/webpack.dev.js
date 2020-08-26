/**
 * Webpack dev config
 */
import merge from 'webpack-merge';
import { commonWebpackConfig } from './webpack.common';

export class WebpackDevConfig {
  constructor() {
    this.resetNodeEnv();
    this.resetDevtool();
  }

  resetNodeEnv() {
    process.env.BABEL_ENV = 'development';
    process.env.NODE_ENV = 'development';
  }

  resetDevtool() {
    this.devtool = 'inline-source-map';
  }
}

export const devWebpackConfig = merge(commonWebpackConfig, new WebpackDevConfig());
