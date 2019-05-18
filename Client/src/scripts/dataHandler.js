import xhrRequest from './request';
import _ from "lodash";

const getData = async (method, url) => {
	try {
		return await xhrRequest(method, url);
	} catch (e) {
		console.error(e);
	}
};

const setupData = (rawData) => {
	const parsedData = JSON.parse(rawData);
	const goals = _.map(parsedData, (goal) => {
		return {'name': goal.GoalName, 'steps': goal.Steps}
	});

	const steps = _.map(goals, (goal) => {
		return goal.steps;
	}).flat();

	return {
		goals,
		steps
	};
};

export {
	getData,
	setupData
}