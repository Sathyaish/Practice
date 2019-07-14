let $dialogBackground = $("#dialogBackground");
let $dialog = $("#dialog");
let mouseDownContext = undefined;

$(document).ready(function() {
    $("#btnShowDialog").click(showDialog);
    $(document).keyup(documentKeyUpEventHandler);
    $("#dialogTitleBarCloseButton").click(closeDialog);

    $("#dialog")
    .on("mousedown", dialogMouseDownEventHandler)
    .on("mousemove", dialogMouseMoveEventHandler)
    .on("mouseup", dialogMouseUpEventHandler);

});

function showDialog(event) {
    $dialogBackground.show();
    positionDialog();
    $dialog.show();
}

function closeDialog(event) {
    $dialog.hide();
    $dialogBackground.hide();
}

function positionDialog() {
    let position = getDialogPosition();
    
    let x = ($(window).width() - $dialog.width()) / 2;
    let y = ($(window).height() - $dialog.height()) / 2;
    
    if (position) {
        x = position.left;
        y = position.top;   
    }

    $dialog.css( {
        left: x, 
        top: y
    })

    setDialogPosition(x, y);
}

function setDialogPosition(x, y) {
    let dialogPosition = { left: x, top: y };
    let s = JSON.stringify(dialogPosition);
    localStorage.setItem("dialogPosition", s);
}

function getDialogPosition() {
    let s = localStorage.getItem("dialogPosition");
    return JSON.parse(s);
}

function documentKeyUpEventHandler(event) {
    if (event.key === "Escape") {
        closeDialog();
    }
}

function dialogMouseDownEventHandler(event) {

    if ((event.buttons & 1) === 1) {
        let $target = $(this);
        let $parent = $(this).parent();
        let $offset = $target.offset();
        let left = $offset.left;
        let top = $offset.top;
        let parentLeft = (($parent === undefined) || ($parent.prop("nodeName").toLowerCase() === "body")) ? 0 : $parent.offset().left;
        let parentTop =  (($parent === undefined) || ($parent.prop("nodeName").toLowerCase() === "body")) ? 0 : $parent.offset().top;

        let diffX = event.clientX - left;
        let diffY = event.clientY - top;

        mouseDownContext = {
            $target: $target,
            $parent: $parent,
            diffX: diffX,
            diffY: diffY,
            parentLeft: parentLeft,
            parentTop: parentTop
        };

        $target.css("cursor", "move");

        console.log("mousedown");
    }
}

function dialogMouseMoveEventHandler(event) {
    if (mouseDownContext && ((event.buttons & 1) === 1)) {
        mouseDownContext.$target.css({
            left: event.clientX - mouseDownContext.diffX - mouseDownContext.parentLeft,
            top: event.clientY - mouseDownContext.diffY - mouseDownContext.parentTop
        });

        console.log("mousemove");
    }
}

function dialogMouseUpEventHandler(event) {
    if (mouseDownContext) {
        mouseDownContext.$target.css("cursor", "default");
        mouseDownContext = undefined;
        console.log("mouseup");
    }
}