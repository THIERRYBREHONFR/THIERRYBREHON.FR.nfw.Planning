$(document).ready(function () {
    /*masquage des boutons hide et show pour TBfr_ACCORDION_GROUP_JS*/
    $(".TBfr_ACCORDION_GROUP_JS > * > .TBfr_ACCORDION_HIDE_ALL_JS").hide();
    $(".TBfr_ACCORDION_GROUP_JS > * > .TBfr_ACCORDION_SHOW_ALL_JS").hide();
    /*masquage des corps d'accordéons pour TBfr_ACCORDION_GROUP_JS, sauf le premier*/
    $(".TBfr_ACCORDION_GROUP_JS > :not(:first-child) > :not(:first-child)").hide();
    /*masquage des corps d'accordéons pour TBfr_ACCORDION_GROUP_JS, sauf le premier*/
    $(".TBfr_ACCORDION_GROUP_COLLAPSED_JS > :not(:first-child)").hide();
    /*pour TBfr_ACCORDION_GROUP_JS, un seul accordéon est ouvert à la fois*/
    $(".TBfr_ACCORDION_GROUP_JS > * > :first-child").on('click', function () {
        $(this).siblings().slideToggle(300);
        $(this).parent().siblings().find("> :not(:first-child)").slideUp(300);
    });
    /*boutons hide et show pour TBfr_ACCORDION_NOGROUP_JS*/
    $(".TBfr_ACCORDION_NOGROUP_JS > * > .TBfr_ACCORDION_HIDE_ALL_JS").show();
    $(".TBfr_ACCORDION_NOGROUP_JS > * > .TBfr_ACCORDION_SHOW_ALL_JS").hide();
    /**/
    $(".TBfr_ACCORDION_NOGROUP_JS > :not(.TBfr_ACCORDION_SHOW_ALL_JS,.TBfr_ACCORDION_HIDE_ALL_JS) > :first-child").on('click', function () {
        $(this).siblings().slideToggle(300);
    });
    $(".TBfr_ACCORDION_NOGROUP_JS > * >.TBfr_ACCORDION_HIDE_ALL_JS").on('click', function () {
        $(this).parent().siblings().find("> :not(:first-child)").slideUp(300);
        $(this).parent().find(" > .TBfr_ACCORDION_HIDE_ALL_JS").hide();
        $(this).parent().find("> .TBfr_ACCORDION_SHOW_ALL_JS").show();
    });
    $(".TBfr_ACCORDION_NOGROUP_JS > * >.TBfr_ACCORDION_SHOW_ALL_JS").on('click', function () {
        $(this).parent().siblings().find("> :not(:first-child)").slideDown(300);
        $(this).parent().find("> .TBfr_ACCORDION_HIDE_ALL_JS").show();
        $(this).parent().find("> .TBfr_ACCORDION_SHOW_ALL_JS").hide();
    });
});
