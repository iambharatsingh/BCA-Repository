window.onload =  function() { 
	changeImages();
	
}

function changeImages() {
	const images = document.querySelectorAll("#image-slider img");
	let i = 0;
	setInterval(() => {
		images[i].classList = "hide";
		i = (i + 1)%images.length;
		images[i].classList = "show";
		
	}, 1000);
}