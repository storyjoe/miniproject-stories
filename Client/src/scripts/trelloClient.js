const WHITE_ICON = 'https://storyjoe.netlify.com/images/icon.png';
const BLACK_ICON = 'https://storyjoe.netlify.com/images/icon.png';
const GITHUB_ICON = 'https://storyjoe.netlify.com/images/github.png';

var boardButtonCallback = function (t) {
	return t.modal({
		title: 'Storymap',
		url: './storymap.html',
		fullscreen: true,
		actions: [{
			title: 'Visit repo @ GitHub',
			icon: GITHUB_ICON,
			url: 'https://github.com/storyjoe/miniproject-stories',
			alt: 'Git Repo',
			position: 'right',
		}]
	});
};

window.TrelloPowerUp.initialize({
	'board-buttons': function (t, opts) {
		return [{
			// we can either provide a button that has a callback function
			icon: {
				dark: WHITE_ICON,
				light: BLACK_ICON
			},
			text: 'Storymap',
			callback: boardButtonCallback,
			condition: 'edit'
		}];
	}
});