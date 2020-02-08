const EventHandler = {
	initFunctionInvoked: 	UpdateLoadingMessage,
	initFunctionInvoking: 	UpdateLoadingMessage,
	onLogLine: 				UpdateLoadingMessage,
	loadProgress: 			UpdateProgressBarStatus
};

window.addEventListener('message', (e) => (EventHandler[e.data.eventName] || ((e) => {FallBackHandler(e)}))(e.data));

function FallBackHandler(eventData) 
{
	// console.log(eventData);	
}

function UpdateLoadingMessage(eventData) {
	var loadingText = ((eventData.type == "INIT_SESSION") ? "Initializing " + eventData.name + "." : eventData.message) || "Creating World";
	$("#loading-message").text(loadingText);
}

function UpdateProgressBarStatus(eventData) {
	if (eventData.loadFraction >= 0 && eventData.loadFraction <= 1) {

		var progress 	= Math.round(eventData.loadFraction * 100);
		var blurValue 	= Math.round((100 - progress) / 100 * 10);

		$("#progress-bar").attr("value", progress);
		$("#progress-caption").text(progress);

		$(".background-image").css({
			"filter": 			"blur(" + blurValue + "px)",
			"-webkit-filter": 	"blur(" + blurValue + "px)"
		});
	}
}