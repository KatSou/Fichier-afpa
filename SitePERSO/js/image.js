$(document).ready(function() {
	$("#impact").show()
	var pos = $("#bullet").css("left");
	setInterval(function() { 
		$("#bullet").animate({left : '45px'},"fast", function() {
			$("#bullet").css("left", pos);
			$("#impact").show();
			//console.log("complete");
		});
		$("#impact").hide()
	}, 200);	
});
