import * as ko from 'knockout';
import _ from 'lodash';

const initVM = (boardData) => {
	ko.applyBindings(new AppViewModel(boardData));
};

function AppViewModel(data) {
	const {goals, steps} = data;

	this.stepHasReleaseItem = function (stepId, releaseId) {
		const step = _.find(steps, {StepId: stepId});
		const story = _.find(step.Stories, {ReleaseId: releaseId});
		return !!story;
	};

	this.goals = ko.observableArray(goals);
}

export default initVM;