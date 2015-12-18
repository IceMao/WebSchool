//banner js
window.onload = function () {

    var oUl = document.getElementsByTagName('ol')[0];
    var aLiUl = oUl.getElementsByClassName('bannerli');

    var iNum = Math.round(960 / 3);

    for (var i = 0; i < aLiUl.length; i++) {
        aLiUl[i].style.left = i * iNum + 'px';
    }

    for (var i = 0; i < aLiUl.length; i++) {
        aLiUl[i].index = i;
        aLiUl[i].onmouseover = function () {

            for (var i = 0; i < aLiUl.length; i++) {
                if (i <= this.index) {
                    startMove(aLiUl[i], { left: i * 30 });
                }
                else {
                    startMove(aLiUl[i], { left: 960 - 120 + (i - 1) * 30 });
                }
            }

        };

        aLiUl[i].onmouseout = function () {
            for (var i = 0; i < aLiUl.length; i++) {
                startMove(aLiUl[i], { left: i * iNum });
            }
        };

    }

};