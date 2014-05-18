var text = "It took two police officers and an animal control officer to corral the python into a city trash container. It was pretty aggressive, Gonzales said. It definitely didn't want to go into the trash can.";
var wordToSearch = "It";
var isCaseSensitive = false;

function CountOccurenceWord(text, wordToSearch, isCaseSensitive)
{
    isCaseSensitive = isCaseSensitive || false;
    var countSearchedWord = 0;

    if (isCaseSensitive === false)
    {
        text =text.toLocaleLowerCase();
        var strArr = text.split(wordToSearch.toLowerCase()); //split is case-insensitive

        for (var str in strArr)
        {
            countSearchedWord++;
        }
        --countSearchedWord;
        jsConsole.writeLine("The count of word '" + wordToSearch + "' (case-insensitive search)  is: " + countSearchedWord)
    }
    else
    {
        var index = text.indexOf(wordToSearch);//indexOf is case-sensitive

        while (index >= 0)
        {
            countSearchedWord++;
            index = text.indexOf(wordToSearch, index + 1);
        }
        jsConsole.writeLine("The count of word '" + wordToSearch + "' (case-sensitive search)  is: " + countSearchedWord)
    }
}

CountOccurenceWord(text,wordToSearch, true);
CountOccurenceWord(text,wordToSearch);
