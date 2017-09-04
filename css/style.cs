@import url(http://fonts.googleapis.com/css?family=VT323);
.flex, #clock2, #room #wall__top, #room #wall__front .view #codes #hint {
  display: flex;
  justify-content: center;
  align-items: center; }

@font-face {
  font-family: "Portico-Vintage";
  src: url("../fonts/Portico_Vintage.otf"); }
@font-face {
  font-family: "Portico-Rough";
  src: url("../fonts/Portico_Rough.otf"); }
@keyframes flicker {
  0% {
    opacity: 0.47963; }
  5% {
    opacity: 0.84002; }
  10% {
    opacity: 0.24319; }
  15% {
    opacity: 0.17795; }
  20% {
    opacity: 0.74457; }
  25% {
    opacity: 0.33484; }
  30% {
    opacity: 0.82739; }
  35% {
    opacity: 0.87029; }
  40% {
    opacity: 0.14623; }
  45% {
    opacity: 0.0032; }
  50% {
    opacity: 0.42833; }
  55% {
    opacity: 0.22013; }
  60% {
    opacity: 0.44564; }
  65% {
    opacity: 0.63165; }
  70% {
    opacity: 0.03105; }
  75% {
    opacity: 0.07892; }
  80% {
    opacity: 0.59431; }
  85% {
    opacity: 0.90383; }
  90% {
    opacity: 0.1055; }
  95% {
    opacity: 0.85941; }
  100% {
    opacity: 0.06839; } }
#clock2 {
  width: 100vw;
  height: 100vh;
  background-color: red;
  z-index: 900; }
  #clock2 .top__number {
    background-color: #000;
    color: #fff;
    font-size: 100px;
    height: 50px; }
    #clock2 .top__number span {
      margin: 0;
      padding: 0; }

#mobile__fallback {
  position: fixed;
  top: 0;
  left: 0;
  width: 100vw;
  height: 100vh;
  background-color: black;
  display: none;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  color: #d6c5a9;
  z-index: 15; }
  #mobile__fallback img {
    width: 50%;
    height: auto; }
  #mobile__fallback p {
    width: 90%;
    font-size: 14px;
    text-align: center; }
    #mobile__fallback p b {
      background-color: #d6c5a9;
      color: #031E11;
      padding: 2px; }

#preloader {
  position: fixed;
  top: 0;
  left: 0;
  width: 100vw;
  height: 100vh;
  background-color: black;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  z-index: 14;
  color: #d6c5a9; }
  #preloader svg {
    width: 30%;
    height: auto; }
    #preloader svg path {
      opacity: 0; }
    #preloader svg .st0 {
      fill: #D8C7A9; }
    #preloader svg .st1 {
      fill: #DAC8AB; }
    #preloader svg .st2 {
      fill: none;
      stroke: #D8C7A9;
      stroke-width: 14;
      stroke-miterlimit: 10; }
  #preloader #desktop-info {
    font-size: 16px;
    color: #d6c5a9;
    opacity: 0; }
  #preloader h4.pgr {
    font-size: 16px;
    border: none;
    text-align: center; }

@media only screen and (min-width: 320px) and (max-width: 1024px) {
  .preloader {
    display: none; }

  #mobile__fallback {
    display: flex; } }
* {
  box-sizing: border-box; }

body, html {
  width: 100vw;
  height: 100vh;
  margin: 0;
  padding: 0;
  overflow: hidden;
  z-index: 0;
  background: #3c3c3c;
  background-image: url(../media/stardust.png);
  background-repeat: repeat;
  color: #d6c5a9;
  font-family: 'VT323';
  font-size: 24px;
  -webkit-font-smoothing: none;
  line-height: 1.2;
  position: relative; }

h1 {
  font-size: 4rem;
  margin-bottom: 1rem;
  text-transform: uppercase; }

h4 {
  width: 100%;
  border-bottom: 2px dashed #14fdce; }

p {
  margin: 0; }

a,
a:visited {
  border-bottom: 0.2rem solid #14fdce;
  color: #14fdce;
  text-decoration: none; }

a:active,
a:focus,
a:hover {
  background-color: #14fdce;
  color: #031e11; }

.noclick {
  pointer-events: none; }

::-moz-selection {
  background-color: #d6c5a9;
  color: #031e11; }

::selection {
  background-color: #14fdce;
  color: #031e11; }

::-moz-selection {
  background-color: #14fdce;
  color: #031e11; }

::selection {
  background-color: #14fdce;
  color: #031e11; }

::-webkit-scrollbar-track {
  -webkit-box-shadow: inset 0 0 6px rgba(0, 0, 0, 0.3);
  border-radius: 10px;
  background-color: #072F1B; }

::-webkit-scrollbar {
  width: 12px;
  background-color: transparent; }

::-webkit-scrollbar-thumb {
  border-radius: 5px;
  -webkit-box-shadow: inset 0 0 6px rgba(0, 0, 0, 0.3);
  background-color: #098068; }

@keyframes turn-on {
  0% {
    transform: scale(1, 0.8) translate3d(0, 0, 0);
    -webkit-filter: brightness(30);
    filter: brightness(30);
    opacity: 1; }
  3.5% {
    transform: scale(1, 0.8) translate3d(0, 100%, 0); }
  3.6% {
    transform: scale(1, 0.8) translate3d(0, -100%, 0);
    opacity: 1; }
  9% {
    transform: scale(1.3, 0.6) translate3d(0, 100%, 0);
    -webkit-filter: brightness(30);
    filter: brightness(30);
    opacity: 0; }
  11% {
    transform: scale(1, 1) translate3d(0, 0, 0);
    -webkit-filter: contrast(0) brightness(0);
    filter: contrast(0) brightness(0);
    opacity: 0; }
  100% {
    transform: scale(1, 1) translate3d(0, 0, 0);
    -webkit-filter: contrast(1) brightness(1.2) saturate(1.3);
    filter: contrast(1) brightness(1.2) saturate(1.3);
    opacity: 1; } }
@keyframes turn-off {
  0% {
    transform: scale(1, 1.3) translate3d(0, 0, 0);
    -webkit-filter: brightness(1);
    filter: brightness(1);
    opacity: 1; }
  60% {
    transform: scale(1.3, 0.001) translate3d(0, 0, 0);
    -webkit-filter: brightness(10);
    filter: brightness(10); }
  100% {
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    transform: scale(0, 0.0001) translate3d(0, 0, 0);
    -webkit-filter: brightness(50);
    filter: brightness(50); } }
.overlay-turn-off {
  animation: turn-off 10s cubic-bezier(0.23, 1, 0.32, 1);
  animation-fill-mode: forwards; }

.overlay-turn-on {
  animation: turn-on 4s linear;
  animation-fill-mode: forwards; }

.layout {
  height: 76%;
  width: 80%;
  position: absolute;
  top: 2%;
  left: 10%;
  pointer-events: none; }

.lines {
  background: -webkit-linear-gradient(top, rgba(255, 255, 255, 0), rgba(255, 255, 255, 0) 50%, rgba(0, 0, 0, 0.2) 70%, rgba(0, 0, 0, 0.6));
  background: linear-gradient(to bottom, rgba(255, 255, 255, 0), rgba(255, 255, 255, 0) 50%, rgba(0, 0, 0, 0.2) 70%, rgba(0, 0, 0, 0.6));
  background-size: 100% 0.3rem;
  border-radius: 2rem;
  position: absolute;
  z-index: 5;
  opacity: 0.4; }

.screen {
  background-color: transparent;
  border-radius: 2rem;
  border: 1rem solid;
  border-bottom-color: #121212;
  border-left-color: #080808;
  border-right-color: #080808;
  border-top-color: #020202;
  /*box-shadow: inset 0 0 18rem black, inset 0 0 3rem black, 0 0 10rem black;*/
  box-shadow: 0px 0px 105px -4px rgba(0, 0, 0, 0.75);
  overflow: hidden;
  padding-right: 17px; }
  .screen .layer {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%; }
  .screen .output {
    -webkit-animation: crt-output 10ms infinite;
    animation: crt-output 10ms infinite;
    background-color: #212121;
    overflow-x: scroll;
    overflow-x: hidden;
    position: absolute;
    pointer-events: auto;
    padding: 1em 2em;
    text-shadow: 0rem 0.2rem 1rem #4a4643;
    box-shadow: inset 0px 0px 34px 0px rgba(0, 0, 0, 0.75);
    z-index: 1;
    text-align: center;
    color: #14fdce;
    border: 10px solid #F9A212;
    border-radius: 10px;
    transition: .2s ease-in; }
    .screen .output .content {
      width: 100%;
      height: 100%;
      opacity: 0;
      overflow-y: hidden; }
      .screen .output .content p {
        text-align: left; }
@keyframes turn-on {
  0% {
    transform: scale(1, 0.8) translate3d(0, 0, 0);
    -webkit-filter: brightness(30);
    filter: brightness(30);
    opacity: 1; }
  3.5% {
    transform: scale(1, 0.8) translate3d(0, 100%, 0); }
  3.6% {
    transform: scale(1, 0.8) translate3d(0, -100%, 0);
    opacity: 1; }
  9% {
    transform: scale(1.3, 0.6) translate3d(0, 100%, 0);
    -webkit-filter: brightness(30);
    filter: brightness(30);
    opacity: 0; }
  11% {
    transform: scale(1, 1) translate3d(0, 0, 0);
    -webkit-filter: contrast(0) brightness(0);
    filter: contrast(0) brightness(0);
    opacity: 0; }
  100% {
    transform: scale(1, 1) translate3d(0, 0, 0);
    -webkit-filter: contrast(1) brightness(1.2) saturate(1.3);
    filter: contrast(1) brightness(1.2) saturate(1.3);
    opacity: 1;
    overflow-y: scroll; } }
@keyframes turn-off {
  0% {
    transform: scale(1, 1.3) translate3d(0, 0, 0);
    -webkit-filter: brightness(1);
    filter: brightness(1);
    opacity: 1; }
  60% {
    transform: scale(1.3, 0.001) translate3d(0, 0, 0);
    -webkit-filter: brightness(10);
    filter: brightness(10); }
  100% {
    animation-timing-function: cubic-bezier(0.755, 0.05, 0.855, 0.06);
    transform: scale(0, 0.0001) translate3d(0, 0, 0);
    -webkit-filter: brightness(50);
    filter: brightness(50);
    overflow-y: hidden; } }
    .screen .output .content-turn-off {
      opacity: 0.001;
      animation: turn-off 0.3s cubic-bezier(0.23, 1, 0.32, 1);
      animation-fill-mode: forwards; }
    .screen .output .content-turn-on {
      opacity: 0.9;
      animation: turn-on 4s linear;
      animation-fill-mode: forwards; }
@keyframes crt-output {
  0% {
    opacity: 0.9; }
  50% {
    opacity: 1; } }
.panel {
  position: absolute;
  width: 40%;
  height: 18%;
  display: flex;
  justify-content: space-around;
  align-items: center;
  top: 80%;
  left: 30%;
  padding-right: 16px;
  background: #212121;
  border-radius: 1.5rem;
  border: 1rem solid;
  border-bottom-color: #121212;
  border-left-color: #080808;
  border-right-color: #080808;
  border-top-color: #020202;
  box-shadow: 0px 0px 105px -4px rgba(0, 0, 0, 0.75); }
  .panel #power {
    margin-right: 10px;
    width: 50px;
    height: 50px;
    margin-left: 10px;
    filter: brightness(0.5) grayscale(0.5);
    border-radius: 8px;
    border: none;
    transition: all .1s ease;
    outline: 0;
    background-image: url(../media/button.jpg);
    background-size: 100% 100%; }
  .panel #power:hover {
    cursor: pointer; }
  .panel #power:focus {
    outline: 0; }
  .panel .power-on {
    filter: brightness(0.9) grayscale(0) !important; }
  .panel p {
    color: #d6c5a9;
    margin: 0;
    padding: 0;
    animation: text-flicker 5s infinite; }

@keyframes text-flicker {
  0% {
    opacity: 1; }
  3.6%, 5.2%, 13.34%, 24.6%, 32.6%, 41.8%, 41.4%, 46.5%, 49.3%, 54.6%, 62.7%, 66.6%, 72.3%, 77.2%, 88.1% {
    opacity: 1; }
  3.8%, 5.4%, 13.54%, 24.8%, 32.8%, 42%, 41.6%, 46.7%, 49.5%, 54.8%, 62.9%, 66.8%, 72.5%, 77.4%, 88.3% {
    opacity: 0; }
  4%, 5.6%, 13.74%, 25%, 35%, 42.2%, 41.8%, 46.9%, 49.7%, 55%, 63.1%, 67%, 72.7%, 77.6%, 88.5% {
    opacity: 1; }
  100% {
    opacity: 1; } }
.back__button {
  position: absolute;
  top: 100px;
  right: 0px;
  width: 50px;
  height: 50px;
  font-size: 50px;
  color: #212121;
  opacity: 0; }

#room {
  width: 100vw;
  height: 100vh;
  position: fixed;
  top: 0;
  left: 0;
  background-color: #999393;
  z-index: 10;
  perspective: 1000px;
  transform-origin: center;
  transform: scale(0.3, 0.3); }
  #room .wall {
    width: 100vw;
    height: 100vh;
    position: absolute;
    transform-style: preserve-3d;
    display: flex;
    align-items: center;
    justify-content: center;
    background-image: url("../media/wall_white.jpg");
    background-repeat: repeat;
    box-shadow: inset 0px 0px 94px 0px rgba(0, 0, 0, 0.25); }
  #room #wall__left {
    left: -100vw;
    top: 0;
    transform-origin: right;
    transform: rotateY(90deg); }
  #room #wall__right {
    left: 100vw;
    top: 0;
    transform-origin: left;
    transform: rotateY(-90deg); }
  #room #wall__floor {
    left: 0;
    top: 100vh;
    transform-origin: top;
    transform: rotateX(90deg);
    background-color: #DDD5D5;
    background-image: url("../media/retina_wood.png"); }
  #room #wall__top {
    left: 0;
    top: -100vh;
    transform-origin: bottom;
    transform: rotateX(-90deg);
    background-image: url("../media/grid_darker.jpg");
    flex-direction: column; }
    #room #wall__top .light {
      width: 100%;
      height: 50px;
      margin-top: 100px;
      display: flex;
      justify-content: space-around; }
      #room #wall__top .light .light__left, #room #wall__top .light .light__right {
        width: 20%;
        height: 100%;
        background-color: #fff;
        box-shadow: 0px 0px 123px 0px white; }
      #room #wall__top .light .light__flicker {
        animation: light-flicker 31s infinite; }
  #room #wall__front .view {
    width: 100%;
    height: 100%; }
    #room #wall__front .view #clock {
      position: absolute;
      top: 50px;
      left: 100px;
      border: 2px solid #3A3A3A;
      background-color: #000;
      border-radius: 5px;
      width: 80px;
      height: 40px; }
      #room #wall__front .view #clock p {
        margin-top: 3px;
        width: 100%;
        text-align: center;
        color: #fff; }
      #room #wall__front .view #clock span {
        animation: blink 1s infinite; }
@keyframes blink {
  0%,50% {
    opacity: 0; }
  51%,100% {
    opacity: 1; } }
    #room #wall__front .view #codes {
      position: absolute;
      top: 50px;
      right: 50px;
      width: 100px;
      height: 150px; }
      #room #wall__front .view #codes #hint {
        position: absolute;
        width: 100px;
        height: 100px; }
      #room #wall__front .view #codes #dragX {
        color: #4B4B4B;
        background-image: url("../media/wall_white.jpg");
        background-repeat: repeat;
        box-shadow: 0px 0px 10px -5px rgba(0, 0, 0, 0.75);
        width: 100px;
        height: 100px; }
    #room #wall__front .view #terminal {
      position: absolute;
      width: 100vw;
      height: 100vh;
      transform-origin: 20% 80%;
      transform: scale(0.4, 0.4); }

@keyframes light-flicker {
  0% {
    opacity: 1; }
  3.6%, 5.2%, 13.34%, 24.6%, 32.6%, 41.8%, 41.4%, 46.5%, 49.3%, 54.6%, 62.7%, 66.6%, 72.3%, 77.2%, 88.1% {
    opacity: 1; }
  3.8%, 5.4%, 13.54%, 24.8%, 32.8%, 42%, 41.6%, 46.7%, 49.5%, 54.8%, 62.9%, 66.8%, 72.5%, 77.4%, 88.3% {
    opacity: 0; }
  4%, 5.6%, 13.74%, 25%, 35%, 42.2%, 41.8%, 46.9%, 49.7%, 55%, 63.1%, 67%, 72.7%, 77.6%, 88.5% {
    opacity: 1; }
  100% {
    opacity: 1; } }
#instructions {
  width: 100%;
  height: 100%;
  position: absolute;
  background-color: rgba(33, 33, 33, 0.2);
  z-index: 13; }
  #instructions .content {
    width: 80%;
    height: 80%;
    position: absolute;
    left: 10%;
    top: 10%;
    background-color: #c2bda9;
    font-family: 'Josefin Sans', sans-serif;
    text-align: left; }
    #instructions .content h2 {
      text-shadow: 5px 5px #989483;
      color: #636052;
      margin: 10px;
      margin-left: 20%; }
    #instructions .content h3 {
      width: 80%;
      background-color: #636052;
      color: #c2bda9;
      margin: 20px;
      padding: 5px;
      margin-left: 50%; }
    #instructions .content h3.trademark {
      position: absolute;
      top: 20px;
      right: 10%;
      width: auto;
      margin: 0;
      font-size: 16px; }
    #instructions .content p {
      background-color: #aaa592;
      color: #636052;
      font-size: 20px;
      width: 80%;
      margin: 8px;
      margin-left: 10%;
      padding: 5px;
      border-left: 4px solid #636052; }
      #instructions .content p span {
        margin: 5px; }
    #instructions .content p.task {
      margin: 5px;
      margin-left: 15%;
      width: 30%; }
    #instructions .content .thank__you {
      position: absolute;
      bottom: 20px;
      width: 80%;
      border-left: 4px solid #636052; }
    #instructions .content .thank__you:before {
      content: " ";
      position: absolute;
      left: -2px;
      border-left: 4px solid red; }
  #instructions .grid {
    position: absolute;
    width: 100%;
    height: 100%;
    background-image: url("../media/grid.png");
    background-repeat: repeat;
    opacity: 0.3; }
    #instructions .grid .line {
      width: 2px;
      height: 100%;
      background-color: #636052;
      position: absolute;
      transform-origin: top; }
    #instructions .grid .line:nth-child(1) {
      left: 10%; }
    #instructions .grid .line:nth-child(2) {
      left: 45%; }
    #instructions .grid .line:nth-child(3) {
      left: 90%; }

#widget {
  width: 280px;
  height: 340px;
  color: #636052;
  position: absolute;
  bottom: 20px;
  left: 20px;
  z-index: 13;
  font-family: 'Josefin Sans', sans-serif; }
  #widget span {
    position: absolute;
    left: 10px;
    bottom: 5px;
    margin: 0;
    font-size: 30px;
    z-index: 14; }
  #widget .box {
    width: 280px;
    height: 340px;
    background-color: #c2bda9;
    z-index: 13;
    position: absolute;
    bottom: 0;
    left: 0;
    transform-origin: 0% 100%;
    transform: scale(0, 0);
    box-shadow: 0px 0px 40px -10px rgba(0, 0, 0, 0.75); }
    #widget .box p {
      opacity: 0; }

/*# sourceMappingURL=style.cs.map */
