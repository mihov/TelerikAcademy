//07. Write a script that parses an URL address given in the format:

//    and extracts from it the [protocol], [server] and [resource] elements. 
//        Return the elements in a JSON object.For example from the URL 
//    http://www.devbg.org/forum/index.php the following information should be extracted:


function ReplaceText(text) {
    var json = URLToJSON(text);
    var openStrong = '<strong>';
    var closeStrong = ': </strong>';

    for (var i in json) {
        var div = document.createElement('div');
        div.innerHTML = openStrong + i + closeStrong + json[i];
        document.getElementById('result').appendChild(div);
    }
}

function URLToJSON(url) {
    var indexProtocol = url.indexOf("://");
    var protocolStr = url.substring(0, indexProtocol);
    var indexResource = url.indexOf("/", indexProtocol + 3);
    var serverStr = url.substring(indexProtocol + 3, indexResource);
    var resourceStr = url.substr(indexResource + 1);

    return {
        protocol: protocolStr,
        server: serverStr,
        resource: resourceStr,
    }
}

function onConvert() {
    var text = document.getElementById('text').value;
    document.getElementById('result').value = ReplaceText(text);
}