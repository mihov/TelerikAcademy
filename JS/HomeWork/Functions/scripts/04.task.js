function divCounter()
{
    var divs = document.getElementsByTagName("DIV");
    var cnt = 0;
    for (var indx in divs)
    {
        cnt++;
    }
    return divs.length;
}

jsConsole.write("Div's in current html page are:" + divCounter());
