import {getData, setupData} from './dataHandler';
import initVM from './viewModel';

const endPoint = 'http://localhost:5000/api/board';

export const runApp = async () => {
	const boardData = await getData('GET', endPoint);
	const structuredData = setupData(boardData);
	initVM(structuredData);
};

