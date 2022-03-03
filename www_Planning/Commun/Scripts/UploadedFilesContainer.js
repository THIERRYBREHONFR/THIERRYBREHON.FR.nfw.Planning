/*
* Fonction permettant de charger des fichiers
* Version 1.0
* Date : 05/05/2017
*/

function onFileUploadComplete(s, e) {
    if (e.callbackData) {
        var fileData = e.callbackData.split('µ');
        var fileName = fileData[0],
            fileNameSrv = fileData[1],
            fileSize = fileData[2];
            UploadedFilesContainer.AddFile(fileName, fileNameSrv, fileSize);
    }
}

var UploadedFilesContainer = {
    nameCellStyle: "",
    sizeCellStyle: "",
    useExtendedPopup: false,

    AddFile: function (fileName, fileNameSrv, fileSize) {
        var self = UploadedFilesContainer;
        var builder = ["<tr>"];

        builder.push("<td class='nameCell'");
        //if (self.sizeCellStyle)
        //    builder.push(" style='" + self.sizeCellStyle + "'");
        builder.push(">");
        builder.push("<input type='date' id='dateFichier' name='dateFichier' class='telechargement'");
        builder.push(" placeholder='Saisir la date de validité' required>");
        builder.push("</td>");

        builder.push("<td class='nameCell'");
        //if (self.nameCellStyle)
        //    builder.push(" style='" + self.nameCellStyle + "'");
        builder.push(">");
        builder.push("<input type='text' id='nomDocument' name='nomDocument' class='telechargement'");
        builder.push(" placeholder='Saisir le nom du document' required>");
        builder.push("</td>");

        builder.push("<td class='nameCell'");
        //if (self.nameCellStyle)
        //    builder.push(" style='" + self.nameCellStyle + "'");
        builder.push(">");
        builder.push("<input type='text' id='nomFichierCharge' name='nomFichierCharge' class='telechargement'");
        builder.push(" value='" + fileName + "'");
        builder.push(" readonly='true'>");
        builder.push("</td>");

        builder.push("<td class='nameCell'");
        //if (self.nameCellStyle)
        //    builder.push(" style='" + self.nameCellStyle + "'");
        builder.push(">");
        builder.push("<input type='text' id='fichierSrv' name='fichierSrv' class='telechargement'");
        builder.push(" value='" + fileNameSrv + "'");
        builder.push(" hidden>");
        builder.push("</td>");

        builder.push("<td class='sizeCell'");
        //if (self.sizeCellStyle)
        //    builder.push(" style='" + self.sizeCellStyle + "'");
        builder.push(">");
        builder.push(fileSize);
        builder.push("</td>");

        builder.push("</tr>");

        var html = builder.join("");
        UploadedFilesContainer.AddHtml(html);
    },
    Clear: function () {
        UploadedFilesContainer.ReplaceHtml("");
    },
    AddHtml: function (html) {
        var fileContainer = document.getElementById("uploadedFilesContainer"),
            fullHtml = html;
        if (fileContainer) {
            var containerBody = fileContainer.tBodies[0];
            fullHtml = containerBody.innerHTML + html;
        }
        UploadedFilesContainer.ReplaceHtml(fullHtml);
    },
    ReplaceHtml: function (html) {
        var builder = ["<table id='uploadedFilesContainer' class='uploadedFilesContainer'><tbody>"];
        builder.push(html);
        builder.push("</tbody></table>");
        var contentHtml = builder.join("");
        FilesRoundPanel.SetContentHtml(contentHtml);
    },
    ApplySettings: function (nameCellStyle, sizeCellStyle, useExtendedPopup) {
        var self = UploadedFilesContainer;
        self.nameCellStyle = nameCellStyle;
        self.sizeCellStyle = sizeCellStyle;
        self.useExtendedPopup = useExtendedPopup;
    }
};