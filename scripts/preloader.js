//preloader sequence

var queue,
  vw = $(window).width();
console.log(vw);

if (vw >= 1024) {
  console.log("sunt pe desktop");
  preload();
} else {
  console.log("sunt pe mobile");
  TweenMax.staggerFromTo($("#mobile_fallback p"), 1, {
    opacity: 0
  }, {
    opacity: 1
  }, 0.1);
}



function preload() {
  // console.log("preload started");
  queue = new createjs.LoadQueue(true);
  queue.loadManifest([
    "sound/flicker.mp3",
    "sound/poweroff.ogg",
    "sound/poweron.ogg",
    "sound/click.mp3",
    "scripts/script.js"

  ]);
  queue.addEventListener('progress', progressNumber);
  queue.on('complete', introStart);
}

function progressNumber(e) {
  $("#preloader h4.pgr").html(Math.floor(e.progress * 100) + "%")
}

function introStart() {
  setTimeout(function() {
    console.log("start website");
  }, 1000);
}