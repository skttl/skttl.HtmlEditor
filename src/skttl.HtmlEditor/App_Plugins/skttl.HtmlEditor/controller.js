(function () {
	"use strict";

	function skttlHtmlEditorController($scope, assetsService) {

		var vm = this;
		assetsService.loadCss("lib/ace-razor-mode/theme/razor_chrome.css");

		vm.aceOption = {
			mode: "razor",
			theme: "chrome",
			showPrintMargin: false,
			advanced: {
				fontSize: '14px',
				enableSnippets: false,
				enableBasicAutocompletion: true,
				enableLiveAutocompletion: false
			}
		}

	}

	angular.module("umbraco").controller("skttl.HtmlEditorController", skttlHtmlEditorController);
})();