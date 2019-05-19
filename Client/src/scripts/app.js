import setupData from './dataHandler';
import initVM from './viewModel';

const runApp = async () => {
	try {
		const structuredData = await setupData();
		initVM(structuredData);
	} catch (e) {
		console.error(e);
		alert('Something went wrong...');
	}
};

export default runApp;