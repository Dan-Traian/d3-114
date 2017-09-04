//---------------draggable ---------------------

var gridWidth = 100;


var gridHeight = 100;
Draggable.create("#dragX", {
    type:"y",
    edgeResistance:0.65,
    bounds:"#codes",
    lockAxis:true,
    throwProps:true
});

new TimelineMax()
    .fromTo($("#box"), 1, {opacity:0}, {opacity:1})
    .fromTo($("#sign path"), 1, {opacity:0}, {opacity:1})
    .staggerFromTo($("#misma path"), 1, {opacity:0}, {opacity:1},0.3)
    .fromTo($("#lower path"), 1, {opacity:0}, {opacity:1})
    .fromTo($("#desktop-info"), 1, {opacity:0}, {opacity:1},"-=1")
    // .fromTo($("#preloader"), 0.5, {opacity:1}, {opacity:0});
    .addCallback(show_instructions,"+=2")
    .timeScale(2);

function show_instructions(){
    $("#preloader").css("display","none");

    new TimelineMax()
        .fromTo($("#logo_misma"), 1, {opacity:1}, {opacity:0})
        .fromTo($("#desktop-info"), 1, {opacity:1}, {opacity:0},"-=1")
        .fromTo($(".pgr"), 1, {opacity:1}, {opacity:0},"-=1")
        .fromTo($("#preloader"), 1, {opacity:1}, {opacity:0})
        .staggerFromTo($("#instructions .grid .line"),2,{scaleY:0},{scaleY:1},1)
        .to($("#room"), 30,{scaleX:0.9, scaleY:0.9, ease: Power1.easeOut})
        // .staggerTo($("#instructions .content p span"), 0.5,{opacity:1, ease: Power1.easeOut},0.3,"-=40")
        // .to($("#instructions #last__line"), 2,{opacity:0})
        .to($("#instructions"), 2,{opacity:0})
        .timeScale(2)
        .addCallback(function(){
            startClock();
            
            $("#preloader").css("display","none");
            $("#instructions").css("display","none");
        });
        // 5+ cat tine scale in
    $("#room #wall__top .light .light__left:nth-child(1)").addClass("light__flicker");
    $("#flicker")[0].play();
    $('#flicker').prop("volume", 0);       
    $("#flicker").animate({volume: 1}, 15000);       
}

//---------------power button ------------------
var power = false;
$("#power").click(function () {
    if (power == true) {
        power = false;
        $(".output").scrollTop(0);
        console.log("stinge ecranul");
        //---------//
        // $(".frame").removeClass("start-screen");
        $("#power").removeClass("power-on");
        $(".panel div").animate({
            opacity: 0
        }, 300, "linear");
        
        //play sound
        $("#poweroff")[0].play();
         $(".output p").css("opacity","0");
         
         $(".output .content").removeClass("content-turn-on").addClass("content-turn-off");
    }
    else {
        power = true;
        $(".output").scrollTop(0);
        console.log("aprinde ecranul");
        //---------//
        // $(".frame").addClass("start-screen");
        $("#power").addClass("power-on");
        $(".panel div").animate({
            opacity: 1
        }, 300, "linear");
        
        // play sound
        
        $("#poweron")[0].play();
        $(".output .content").removeClass("content-turn-off").addClass("content-turn-on");
      

        

    }
});


// // -----------keyboard animation and sound --------
// var number_of_keys=1;
// $("#start_text").click(function(){
//     TweenMax.staggerFromTo($(".output p"), 1, {opacity:0}, {opacity:1}, 0.2 );
//     var myVar = setInterval(function(){ myTimer() }, 100);
//     function myTimer() {
//         var nr=Math.floor(Math.random() * 7) + 1; 
//         var audio = new Audio("sound/k"+nr+".ogg");
//         audio.play();
//         number_of_keys++;
//         if(number_of_keys==50){
//             myStopFunction();
//         }
//     }

//     function myStopFunction() {
//         clearInterval(myVar);
//         number_of_keys=1;
//     }
// });

//----------show/hide terminal ----
var terminalFocus = false;
$("#terminal .layout").click(function () {
    if(terminalFocus==false){
        terminalFocus = true;
        console.log("show terminal");
        TweenMax.fromTo($("#room"), 2,{scaleX:0.9,scaleY:0.9,left:0,top:0},
            {scaleX:1.8, scaleY:1.8,left:"30vw",top:"-20vh"});
        TweenMax.fromTo($("#terminal .back__button"), 0.1,{opacity:0},{opacity:1});
    }
});
$("#terminal .back__button").click(function () {
    if (terminalFocus == true) {
        terminalFocus = false;
        console.log("hide terminal");
        TweenMax.fromTo($("#room"), 1,{scaleX:1.6, scaleY:1.6,left:"30vw",top:"-20vh"},
            {scaleX:0.9,scaleY:0.9,left:0,top:0});
        TweenMax.fromTo($("#terminal .back__button"), 0.1,{opacity:1},{opacity:0});

      
    }
});

// -----------clock--------
var min=5, sec=1;
function startClock(){

    setInterval(function(){
        sec--;
        if(sec==0){
            sec=59;
            min--;
            $("#clock p").html("0"+min+"<span>:</span>"+sec);
        }
        else{
            if(sec>0&&sec<=9){
                $("#clock p").html("0"+min+"<span>:</span>0"+sec);
            }
            if(sec>9&&sec<=59){
                $("#clock p").html("0"+min+"<span>:</span>"+sec);
            }
        }

       

    },1000);
}


//------------- make the instruction words into spans-------
function makeSpan(){

    var words = $("#one_p").text().split(" ");
    $("#one_p").empty();
    $.each(words, function(i, v) {
        $("#one_p").append($("<span>").text(v));
    });

    words = $("#two_p").text().split(" ");
    $("#two_p").empty();
    $.each(words, function(i, v) {
        $("#two_p").append($("<span>").text(v));
    });

    words = $("#three_p").text().split(" ");
    $("#three_p").empty();
    $.each(words, function(i, v) {
        $("#three_p").append($("<span>").text(v));
    });
}

// 0------------------widget settings------

var settings = false;
$("#widget #settings").click(function () {
    if (settings == true) {
        settings = false;         
        new TimelineMax()
        .fromTo($("#widget .box"),0.2,{scaleY:1,scaleX:1},{scaleY:0,scaleX:0})
        .fromTo($("#widget .box p"),0.3,{opacity:1},{opacity:0},"+=0.3")
        .timeScale(1.4);
    }
    else {
        settings = true;
        new TimelineMax()
        .fromTo($("#widget .box"),1,{scaleY:0,scaleX:0},{scaleY:1,scaleX:1,ease: Power2.easeOut})
        .fromTo($("#widget .box p"),0.3,{opacity:0},{opacity:1},"+=0.3");
    
        

    }
});


// 0------------------introducing the code part------


var sequenceNr =0;
var currentSequence="";
var solution ="1332";

$("#door_code .row .key").click(function(){
    
    if(sequenceNr==0){
        currentSequence="";
    }
    if(sequenceNr<4){
        sequenceNr++;
        currentSequence=currentSequence+""+$(this).html();
        $("#sequence").html(currentSequence);
        if(sequenceNr==4){
            
            if(currentSequence==solution){
                console.log("its ok");
                $("#sequence").html("its ok");
                sequenceNr=5;

            }
            else{
                sequenceNr=0;
                $("#sequence").html("Wrong");
                console.log("its bad");
            }
        }
    }
    console.log(sequenceNr);

})