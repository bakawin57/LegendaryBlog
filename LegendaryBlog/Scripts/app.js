/**
 * Created by Administrator on 2017/5/12.
 */
$(document).ready(
    function () {
        $("#d01").mouseover(function(){
            $("#d03").hide(1000);
            $("#d02_1").css("background-color","");
            $("#d02_2").css("background-color","");
            $("#d02_3").css("background-color","");
            $("#d02_4").css("background-color","");
            $("#d02_5").css("background-color","");

        }) ;
            $("#d02").mouseover(function(){
            $("#d03").show(1000);

        }) ;

        $("#d02_1").mouseover(function(){

            $("#d02_1").css("background-color","#696969");
            $("#d02_2").css("background-color","");
            $("#d02_3").css("background-color","");
            $("#d02_4").css("background-color","");
            $("#d02_5").css("background-color","");

            $("#d03_1").show(1000);
            $("#d03_2").hide(1000);
            $("#d03_3").hide(1000);
            $("#d03_4").hide(1000);
            $("#d03_5").hide(1000);

        });
        $("#d02_2").mouseover(function(){
            $("#d02_1").css("background-color","");
            $("#d02_2").css("background-color","#696969");
            $("#d02_3").css("background-color","");
            $("#d02_4").css("background-color","");
            $("#d02_5").css("background-color","");
            $("#d03_1").hide(1000);
            $("#d03_2").show(1000);
            $("#d03_3").hide(1000);
            $("#d03_4").hide(1000);
            $("#d03_5").hide(1000);

        });
        $("#d02_3").mouseover(function(){
            $("#d02_1").css("background-color","");
            $("#d02_2").css("background-color","");
            $("#d02_3").css("background-color","#696969");
            $("#d02_4").css("background-color","");
            $("#d02_5").css("background-color","");
            $("#d03_1").hide(1000);
            $("#d03_2").hide(1000);
            $("#d03_3").show(1000);
            $("#d03_4").hide(1000);
            $("#d03_5").hide(1000);

        });
        $("#d02_4").mouseover(function(){
            $("#d02_1").css("background-color","");
            $("#d02_2").css("background-color","");
            $("#d02_3").css("background-color","");
            $("#d02_4").css("background-color","#696969");
            $("#d02_5").css("background-color","");
            $("#d03_1").hide(1000);
            $("#d03_2").hide(1000);
            $("#d03_3").hide(1000);
            $("#d03_4").show(1000);
            $("#d03_5").hide(1000);

        });
        $("#d02_5").mouseover(function(){
            $("#d02_1").css("background-color","");
            $("#d02_2").css("background-color","");
            $("#d02_3").css("background-color","");
            $("#d02_4").css("background-color","");
            $("#d02_5").css("background-color","#696969");
            $("#d03_1").hide(1000);
            $("#d03_2").hide(1000);
            $("#d03_3").hide(1000);
            $("#d03_4").hide(1000);
            $("#d03_5").show(1000);

        });
    }
);


