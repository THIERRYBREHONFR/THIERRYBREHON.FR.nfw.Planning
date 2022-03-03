// remplace la touche return par tab et invalide le retour arrière
function navigate(e) {
    if (window.event) { // pour vieille version de internet
        var e = window.event;
        if (e.keyCode == 13 && !e.shiftKey) e.keyCode = 9;
        else if (e.keyCode == 8) e.keyCode = 0;
    }
    var doPrevent;
    if (e && e.keyCode == 8) {
        var d = e.srcElement || e.target;
        if ((d.tagName.toUpperCase() == 'INPUT' && (d.type.toUpperCase() == 'TEXT' || d.type.toUpperCase() == 'PASSWORD'))
            || d.tagName.toUpperCase() == 'TEXTAREA') {
            doPrevent = d.readOnly || d.disabled;
        }
        else doPrevent = true;
    }

    if (doPrevent) e.preventDefault();
}
function TBfr_ExtractFirstNumber(string) {
    var result;
    for (var len = string.length; len > 0 && isNaN(result = Number(string.substr(0, len))); len--);
    return result;
}
