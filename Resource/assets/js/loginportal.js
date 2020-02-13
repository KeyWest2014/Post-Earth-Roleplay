const EventHandler = {

};

window.addEventListener('message', (e) => (EventHandler[e.data.eventName] || ((e) => {FallBackHandler(e)}))(e.data));

function FallBackHandler(eventData) 
{
	console.log(eventData);	
}
