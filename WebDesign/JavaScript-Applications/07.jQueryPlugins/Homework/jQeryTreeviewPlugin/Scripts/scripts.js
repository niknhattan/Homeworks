﻿/// <reference path="jquery-2.1.0.js" />
//Initially only the top items must be visible
//On item click
//If its children are hidden (collapsed), they must be made visible (expanded)
//If its children are visible (expanded), they must be made hidden (collapsed)
//Research about events
(function ($) {
    $(document).ready(function () {
        $('ul').first().treeview();
    })
})(jQuery)

