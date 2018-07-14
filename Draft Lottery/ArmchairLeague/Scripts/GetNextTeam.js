var currentDraftSlot = 12;
    
   $("#get-next-team").click(function(){
        if (currentDraftSlot != 0) {
            $.ajax({
                url: "draftlottery/getnextteam", 
                success: function(result){
                    var draftSlot = "<h3 class='draft-slot'>" + currentDraftSlot + ".</h3>";
                    var name = "<h3>" + result.Name + "</h3>";
                    var imgSrc = "<img class='circle' src='" + result.PhotoURL + "'/>";
                    var markup = "<div class='team'>" + draftSlot + imgSrc + name + "</div><br>";

                    switch(currentDraftSlot) {
                        case 12:
                            $("#row1 .col1").append(markup);
                            break;
                        case 11:
                            $("#row2 .col1").append(markup);
                            break;
                        case 10:
                            $("#row3 .col1").append(markup);
                            break;
                        case 9:
                            $("#row4 .col1").append(markup);
                            break;
                        case 8:
                            $("#row1 .col2").append(markup);
                            break;
                        case 7:
                            $("#row2 .col2").append(markup);
                            break;
                        case 6:
                            $("#row3 .col2").append(markup);
                            break;
                        case 5:
                            $("#row4 .col2").append(markup);
                            break;
                        case 4:
                            $("#row1 .col3").append(markup);
                            break;
                        case 3:
                            $("#row2 .col3").append(markup);
                            break;
                        case 2:
                            $("#row3 .col3").append(markup);
                            break;
                        case 1:
                            $("#row4 .col3").append(markup);
                            break;
                        default:
                            break;
                    }

                    currentDraftSlot -= 1;

                    removeBall();
                }
            });
        }        
    });
