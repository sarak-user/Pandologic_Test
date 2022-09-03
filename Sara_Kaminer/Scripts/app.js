var ViewModel = function () {
	var self = this;
	self.graph = ko.observableArray();
	self.error = ko.observable();

	var graphUri = '/api/JobViews/';

	function ajaxHelper(uri, method, data) {
		self.error(''); // Clear error message
		return $.ajax({
			type: method,
			url: uri,
			dataType: 'json',
			contentType: 'application/json',
			data: data ? JSON.stringify(data) : null
		}).fail(function (jqXHR, textStatus, errorThrown) {
			self.error(errorThrown);
		});
	}

	function getGraph() {
		ajaxHelper(graphUri, 'GET').done(function (data) {
			self.graph(data);
			myGraph = data;
		});
	}

	getGraph();
};

ko.applyBindings(ViewModel());