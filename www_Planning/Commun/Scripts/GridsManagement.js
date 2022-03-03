// <![CDATA[
//gestion de la fenêtre de customisation
function btnShowColumn_Click(grid) {
    if (!grid.IsCustomizationWindowVisible())
        grid.ShowCustomizationWindow();
    else
        grid.HideCustomizationWindow();
}
// gestion des exports
function ShowExportGridViewPopup(iCard) {
    document.getElementById('FModelsExportGridHiddenField').value = iCard;
    ExportDoc.Show();
}
//gestion de la fenêtre de customisation de la pivotgrid
function onCustomizationFieldsVisibleChanged(grid, btnShowColumn) {
    if (btnShowColumn != null && grid != null) {
        btnShowColumn.SetText((grid.GetCustomizationFieldsVisibility() ? "<i class='fas fa-eye-slash'></i> <i class='fas fa-list'></i> Masquer" : "<i class='fas fa-eye'></i> <i class='fas fa-list'></i> Montrer") + "<br />la liste des champs");
    }
}
function onShowCustomizationButtonClick(grid) {
    grid.ChangeCustomizationFieldsVisibility();
}
// ]]>
