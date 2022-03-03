// Fichier JScript
function ActualiserOngletChoisiById(IdSpanASelectionner, IdDiv, IdSpan)
{
   if (IdSpanASelectionner != IdSpan) 
   {
      PlierById(IdDiv);
      DesenfonceById(IdSpan);
   };
   if (IdSpanASelectionner == IdSpan)
   {
      DeplierById(IdDiv);
      EnfonceById(IdSpan);
   }
}

function DesenfonceById(cSpan)
{
   if (document.getElementById(cSpan))
     document.getElementById(cSpan).className="onglet";
}

function EnfonceById(cSpan)
{
   if (document.getElementById(cSpan))
     document.getElementById(cSpan).className="onglet_choisi";
}

function PlierById(Id) {
    if (document.getElementById(Id)) {
        document.getElementById(Id).style.visibility = "hidden";
        document.getElementById(Id).style.display = "none";
    }
}

function DeplierById(Id) {
    if (document.getElementById(Id)) {
        document.getElementById(Id).style.visibility = "visible";
        document.getElementById(Id).style.display = "block";
    }
}
