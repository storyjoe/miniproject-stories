const path = require('path');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const CopyWebpackPlugin = require('copy-webpack-plugin');
const ImageminPlugin = require('imagemin-webpack-plugin').default;
const BrowserSyncPlugin = require('browser-sync-webpack-plugin');

module.exports = {
	entry: {
		polyfill: 'babel-polyfill',
		main: './src/scripts/main.js',
		trelloClient: './src/scripts/trelloClient.js'
	},
	output: {
		path: path.resolve(__dirname, 'dist/'),
		filename: '[name].js',
	},
	module: {
		rules: [{
			test: /\.js$/,
			exclude: /node_modules/,
			use: {
				loader: "babel-loader"
			}
		},
			{
				test: /\.scss$/,
				use: [
					'style-loader',
					MiniCssExtractPlugin.loader,
					'css-loader?url=false',
					{
						loader: 'postcss-loader',
						options: {
							ident: 'postcss',
							plugins: [
								require('autoprefixer'),
							]
						}
					},
					'sass-loader'
				]
			}
		]
	},
	plugins: [
		new MiniCssExtractPlugin({
			filename: 'style.css',
		}),
		new HtmlWebpackPlugin({
			inject: false,
			hash: true,
			template: './src/index.html',
			filename: 'index.html'
		}),
		new HtmlWebpackPlugin({
			inject: false,
			hash: true,
			template: './src/storymap.html',
			filename: 'storymap.html'
		}),
		new CopyWebpackPlugin([{
			from: './src/images',
			to: './images',
			toType: 'dir'
		}]),
		new ImageminPlugin({
			test: /\.(jpe?g|png|gif|svg)$/i
		}),
		new BrowserSyncPlugin({
			host: 'localhost',
			port: 3000,
			proxy: 'http://localhost:8080/'
		})
	]
};
