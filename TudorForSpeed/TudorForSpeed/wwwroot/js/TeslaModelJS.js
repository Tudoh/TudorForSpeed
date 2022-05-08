var slideIndex = 0;
carousel();

function carousel() {
  var i;
  var x = document.getElementsByClassName("perfectslideshow");
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none"; 
  }
  slideIndex++;
  if (slideIndex > x.length) {slideIndex = 1} 
  x[slideIndex-1].style.display = "block"; 
    setTimeout(carousel, 9000);
}
