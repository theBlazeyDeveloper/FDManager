"use strict";
/// <reference path="../lib/bingmaps/types/MicrosoftMaps/Microsoft.Maps.All.d.ts" />
Object.defineProperty(exports, "__esModule", { value: true });
exports.BingMap = void 0;
var bingmodels_1 = require("./bingmodels");
var BingMap = /** @class */ (function () {
    function BingMap(elementId, zoomLevel, modules, mapStyle) {
        this.Map = new Microsoft.Maps.Map(elementId, {
            center: new Microsoft.Maps.Location(29.9630376, -95.7673257),
            customMapStyle: (0, bingmodels_1.GetCommandMapStyle)(),
            zoom: zoomLevel,
        });
    }
    return BingMap;
}());
exports.BingMap = BingMap;
//# sourceMappingURL=bingmaps.js.map