
 function pageLoad() {
        ShowPopup();
        setTimeout(HidePopup, 2000);
    }

function ShowPopup() {
    $find('modalpopup').show();
    //$get('Button1').click();
}

function HidePopup() {
    $find('modalpopup').hide();
    //$get('btnCancel').click();
}

pageLoad()
