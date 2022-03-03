
function TBfr_print3DBand(headPrinterId, iBand, topHeadPosition, leftHeadPosition, leftPosition, bandWidth, bandHeight, bandsNumber) {
    if (iBand == 1)
        $("#" + headPrinterId + 1).animate({ left: leftPosition + bandWidth, width: 0 }, "slow");
    $("#" + headPrinterId).animate({ left: leftHeadPosition + bandWidth }, "slow")
        .animate({ top: topHeadPosition - bandHeight * iBand })
        .animate({ left: leftHeadPosition }, "fast",
            function () { $("#" + headPrinterId + (iBand + 1)).animate({ left: leftPosition + bandWidth, width: 0 }, "slow"); });
    if (iBand == bandsNumber - 1)
        $("#" + headPrinterId).animate({ left: bandWidth + leftPosition }, "slow").animate({ left: leftPosition }, "fast");
}
function TBfr_printer3DInstall(headPrinterId, bandWidth, bandHeight, bandsNumber) {
    var topHeadPrinter = TBfr_ExtractFirstNumber($("#" + headPrinterId).css("top"));
    var leftHeadPrinter = TBfr_ExtractFirstNumber($("#" + headPrinterId).css("left"));
    var widthHeadPrinter = TBfr_ExtractFirstNumber($("#" + headPrinterId).css("width"));
    var heightHeadPrinter = TBfr_ExtractFirstNumber($("#" + headPrinterId).css("height"));
    var leftPosition = leftHeadPrinter + widthHeadPrinter / 2;
    var lastBand = headPrinterId;
    for (var i = 0; i < bandsNumber; i++) {
        $("#" + lastBand).before('<div id="' + headPrinterId + (i + 1) + '" style="background: #ffffff; top: ' + (topHeadPrinter + heightHeadPrinter - bandHeight * i) + 'px; left: ' + leftPosition + 'px; height: ' + bandHeight + 'px; width: ' + bandWidth + 'px; position: absolute; "></div>')
        lastBand = headPrinterId + (i + 1);
    }
    $("#" + headPrinterId).click(function () {
        for (var i = 1; i < bandsNumber; i++)
            TBfr_print3DBand(headPrinterId, i, topHeadPrinter, leftHeadPrinter, leftPosition, bandWidth, bandHeight, bandsNumber);
    });
}
