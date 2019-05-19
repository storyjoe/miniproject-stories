import xhrRequest from './request';
import _ from "lodash";

const endPoint = 'http://localhost:5000/api/board';

const getData = async (method, url) => {
	try {
		return await xhrRequest(method, url);
	} catch (e) {
		console.error(e);
	}
};

const setupData = async () => {
	const boardData = await getData('GET', endPoint);
	const parsedData = JSON.parse(boardData);
	const goals = _.map(parsedData, (goal) => {
		return {'name': goal.GoalName, 'steps': goal.Steps}
	});

	const steps = _.flatten(
		_.map(goals, (goal) => {
			return goal.steps;
		})
	);

	return {
		goals,
		steps
	};
};

export default setupData;