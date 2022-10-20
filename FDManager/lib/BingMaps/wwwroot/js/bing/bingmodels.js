"use strict";
/// <reference path="../lib/bingmaps/types/MicrosoftMaps/CustomMapStyles.d.ts" />
/// <reference path="../lib/bingmaps/types/MicrosoftMaps/Microsoft.Maps.d.ts" />
Object.defineProperty(exports, "__esModule", { value: true });
exports.GetCommandMapStyle = exports.MapLoadingOptions = exports.BingMapModels = void 0;
var BingMapModels = /** @class */ (function () {
    function BingMapModels() {
    }
    BingMapModels.prototype.GetModules = function () {
        return [
            new BingMapModule('Drawing Tools', 'Microsoft.Maps.DrawingTools'),
            new BingMapModule('Directions', 'Microsoft.Maps.Directions'),
            new BingMapModule('Spatial Math', 'Microsoft.Maps.SpatialMath'),
            new BingMapModule('Spatial Data Service', 'Microsoft.Maps.SpatialDataService'),
            new BingMapModule('Search', 'Microsoft.Maps.Search'),
            new BingMapModule('Heat Map', 'Microsoft.Maps.HeatMap'),
            new BingMapModule('Traffic', 'Microsoft.Maps.Traffic')
        ];
    };
    BingMapModels.prototype.GetColors = function () {
        return [
            new BingMapColor('rgba(255, 0, 0, .1)', '#FF0000', 'red'),
            new BingMapColor('rgba(0, 255, 0, .1)', '#00FF00', 'green'),
            new BingMapColor('rgba(0, 0, 255, .1)', '#0000FF', 'blue'),
            new BingMapColor('rgba(255, 255, 0, .1)', '#FFFF00', 'yellow'),
            new BingMapColor('rgba(255, 165, 0, .1)', '#FFA500', 'orange'),
            new BingMapColor('rgba(128, 0, 128, .1)', '#800080', 'purple'),
        ];
    };
    BingMapModels.prototype.GetCounties = function () {
        return [
            new County('Harris County, Tx'),
            new County('Montgomery County, Tx'),
            new County('Fort Bend County, Tx'),
            new County('Waller County, Tx'),
            new County('Brazoria County, Tx'),
            new County('Chambers County, Tx'),
            new County('Liberty County, Tx'),
            new County('Galvestion County, Tx'),
        ];
    };
    BingMapModels.prototype.GetHarrisCountyZipCodes = function () {
        return [
            new HarrisCountyZipCode('77429'), new HarrisCountyZipCode('77433'), new HarrisCountyZipCode('77001'), new HarrisCountyZipCode('77002'),
            new HarrisCountyZipCode('77003'), new HarrisCountyZipCode('77004'), new HarrisCountyZipCode('77005'), new HarrisCountyZipCode('77006'),
            new HarrisCountyZipCode('77007'), new HarrisCountyZipCode('77008'), new HarrisCountyZipCode('77009'), new HarrisCountyZipCode('77010'),
            new HarrisCountyZipCode('77011'), new HarrisCountyZipCode('77012'), new HarrisCountyZipCode('77013'), new HarrisCountyZipCode('77014'),
            new HarrisCountyZipCode('77015'), new HarrisCountyZipCode('77016'), new HarrisCountyZipCode('77017'), new HarrisCountyZipCode('77018'),
            new HarrisCountyZipCode('77019'), new HarrisCountyZipCode('77020'), new HarrisCountyZipCode('77021'), new HarrisCountyZipCode('77022'),
            new HarrisCountyZipCode('77023'), new HarrisCountyZipCode('77024'), new HarrisCountyZipCode('77025'), new HarrisCountyZipCode('77026'),
            new HarrisCountyZipCode('77027'), new HarrisCountyZipCode('77028'), new HarrisCountyZipCode('77029'), new HarrisCountyZipCode('77030'),
            new HarrisCountyZipCode('77031'), new HarrisCountyZipCode('77032'), new HarrisCountyZipCode('77033'), new HarrisCountyZipCode('77034'),
            new HarrisCountyZipCode('77035'), new HarrisCountyZipCode('77036'), new HarrisCountyZipCode('77037'), new HarrisCountyZipCode('77038'),
            new HarrisCountyZipCode('77039'), new HarrisCountyZipCode('77040'), new HarrisCountyZipCode('77041'), new HarrisCountyZipCode('77042'),
            new HarrisCountyZipCode('77043'), new HarrisCountyZipCode('77044'), new HarrisCountyZipCode('77045'), new HarrisCountyZipCode('77046'),
            new HarrisCountyZipCode('77047'), new HarrisCountyZipCode('77048'), new HarrisCountyZipCode('77049'), new HarrisCountyZipCode('77050'),
            new HarrisCountyZipCode('77051'), new HarrisCountyZipCode('77052'), new HarrisCountyZipCode('77053'), new HarrisCountyZipCode('77054'),
            new HarrisCountyZipCode('77055'), new HarrisCountyZipCode('77056'), new HarrisCountyZipCode('77057'), new HarrisCountyZipCode('77058'),
            new HarrisCountyZipCode('77059'), new HarrisCountyZipCode('77060'), new HarrisCountyZipCode('77061'), new HarrisCountyZipCode('77062'),
            new HarrisCountyZipCode('77063'), new HarrisCountyZipCode('77064'), new HarrisCountyZipCode('77065'), new HarrisCountyZipCode('77066'),
            new HarrisCountyZipCode('77067'), new HarrisCountyZipCode('77068'), new HarrisCountyZipCode('77069'), new HarrisCountyZipCode('77070'),
            new HarrisCountyZipCode('77071'), new HarrisCountyZipCode('77072'), new HarrisCountyZipCode('77073'), new HarrisCountyZipCode('77074'),
            new HarrisCountyZipCode('77075'), new HarrisCountyZipCode('77076'), new HarrisCountyZipCode('77077'), new HarrisCountyZipCode('77078'),
            new HarrisCountyZipCode('77079'), new HarrisCountyZipCode('77080'), new HarrisCountyZipCode('77081'), new HarrisCountyZipCode('77082'),
            new HarrisCountyZipCode('77083'), new HarrisCountyZipCode('77084'), new HarrisCountyZipCode('77085'), new HarrisCountyZipCode('77086'),
            new HarrisCountyZipCode('77087'), new HarrisCountyZipCode('77088'), new HarrisCountyZipCode('77089'), new HarrisCountyZipCode('77090'),
            new HarrisCountyZipCode('77091'), new HarrisCountyZipCode('77092'), new HarrisCountyZipCode('77093'), new HarrisCountyZipCode('77094'),
            new HarrisCountyZipCode('77095'), new HarrisCountyZipCode('77096'), new HarrisCountyZipCode('77097'), new HarrisCountyZipCode('77098'),
            new HarrisCountyZipCode('77099'), new HarrisCountyZipCode('77201'), new HarrisCountyZipCode('77202'), new HarrisCountyZipCode('77203'),
            new HarrisCountyZipCode('77204'), new HarrisCountyZipCode('77205'), new HarrisCountyZipCode('77206'), new HarrisCountyZipCode('77207'),
            new HarrisCountyZipCode('77208'), new HarrisCountyZipCode('77210'), new HarrisCountyZipCode('77212'), new HarrisCountyZipCode('77213'),
            new HarrisCountyZipCode('77215'), new HarrisCountyZipCode('77216'), new HarrisCountyZipCode('77217'), new HarrisCountyZipCode('77218'),
            new HarrisCountyZipCode('77219'), new HarrisCountyZipCode('77220'), new HarrisCountyZipCode('77221'), new HarrisCountyZipCode('77222'),
            new HarrisCountyZipCode('77223'), new HarrisCountyZipCode('77224'), new HarrisCountyZipCode('77225'), new HarrisCountyZipCode('77226'),
            new HarrisCountyZipCode('77228'), new HarrisCountyZipCode('77229'), new HarrisCountyZipCode('77230'), new HarrisCountyZipCode('77231'),
            new HarrisCountyZipCode('77233'), new HarrisCountyZipCode('77234'), new HarrisCountyZipCode('77235'), new HarrisCountyZipCode('77236'),
            new HarrisCountyZipCode('77237'), new HarrisCountyZipCode('77238'), new HarrisCountyZipCode('77240'), new HarrisCountyZipCode('77241'),
            new HarrisCountyZipCode('77242'), new HarrisCountyZipCode('77245'), new HarrisCountyZipCode('77249'), new HarrisCountyZipCode('77252'),
            new HarrisCountyZipCode('77253'), new HarrisCountyZipCode('77254'), new HarrisCountyZipCode('77256'), new HarrisCountyZipCode('77258'),
            new HarrisCountyZipCode('77259'), new HarrisCountyZipCode('77261'), new HarrisCountyZipCode('77262'), new HarrisCountyZipCode('77263'),
            new HarrisCountyZipCode('77265'), new HarrisCountyZipCode('77266'), new HarrisCountyZipCode('77270'), new HarrisCountyZipCode('77271'),
            new HarrisCountyZipCode('77272'), new HarrisCountyZipCode('77274'), new HarrisCountyZipCode('77275'), new HarrisCountyZipCode('77277'),
            new HarrisCountyZipCode('77287'), new HarrisCountyZipCode('77288'), new HarrisCountyZipCode('77289'), new HarrisCountyZipCode('77297'),
            new HarrisCountyZipCode('77299'), new HarrisCountyZipCode('77401'), new HarrisCountyZipCode('77402'), new HarrisCountyZipCode('77411'),
            new HarrisCountyZipCode('77447'), new HarrisCountyZipCode('77449'), new HarrisCountyZipCode('77450'), new HarrisCountyZipCode('77523'),
            new HarrisCountyZipCode('77484'), new HarrisCountyZipCode('77491'), new HarrisCountyZipCode('77492'), new HarrisCountyZipCode('77493'),
            new HarrisCountyZipCode('77501'), new HarrisCountyZipCode('77502'), new HarrisCountyZipCode('77503'), new HarrisCountyZipCode('77504'),
            new HarrisCountyZipCode('77505'), new HarrisCountyZipCode('77506'), new HarrisCountyZipCode('77507'), new HarrisCountyZipCode('77508'),
            new HarrisCountyZipCode('77520'), new HarrisCountyZipCode('77521'), new HarrisCountyZipCode('77522'), new HarrisCountyZipCode('77530'),
            new HarrisCountyZipCode('77532'), new HarrisCountyZipCode('77536'), new HarrisCountyZipCode('77546'), new HarrisCountyZipCode('77547'),
            new HarrisCountyZipCode('77562'), new HarrisCountyZipCode('77571'), new HarrisCountyZipCode('77572'), new HarrisCountyZipCode('77586'),
            new HarrisCountyZipCode('77587')
        ];
    };
    BingMapModels.prototype.GetCommandMapStyle = function () {
        return;
    };
    return BingMapModels;
}());
exports.BingMapModels = BingMapModels;
var BingMapColor = /** @class */ (function () {
    function BingMapColor(rgba, hexValue, name) {
        this.RGBAValue = rgba;
        this.HexValue = hexValue;
        this.Name = name;
    }
    return BingMapColor;
}());
var BingMapModule = /** @class */ (function () {
    function BingMapModule(name, library) {
        this.Name = name;
        this.Library = library;
    }
    return BingMapModule;
}());
var HarrisCountyZipCode = /** @class */ (function () {
    function HarrisCountyZipCode(zipCode) {
        this.Zipcode = zipCode;
    }
    return HarrisCountyZipCode;
}());
var County = /** @class */ (function () {
    function County(name) {
        this.Name = name;
    }
    return County;
}());
var SettingsStyle = /** @class */ (function () {
    function SettingsStyle(landColor, shadedReliefVisible) {
        this.landColor = landColor;
        if (shadedReliefVisible === null)
            this.shadedReliefVisible = false;
        else
            this.shadedReliefVisible = shadedReliefVisible;
    }
    return SettingsStyle;
}());
var MapElementStyle = /** @class */ (function () {
    function MapElementStyle(fillColor, labelColor, labelOutlineColor, labelVisible, strokeColor, visible) {
        this.fillColor = fillColor;
        this.labelColor = labelColor;
        this.labelOutlineColor = labelOutlineColor;
        this.labelVisible = labelVisible;
        this.strokeColor = strokeColor;
        this.visible = visible;
    }
    return MapElementStyle;
}());
var MapElements = /** @class */ (function () {
    function MapElements(styleElement) {
    }
    return MapElements;
}());
var MapStyleElement = /** @class */ (function () {
    function MapStyleElement(values) {
        this.Values = values;
    }
    return MapStyleElement;
}());
var MapLoadingOptions = /** @class */ (function () {
    function MapLoadingOptions() {
    }
    MapLoadingOptions.prototype.AddModule = function (module) {
        this.Modules.push(module);
    };
    MapLoadingOptions.prototype.AddStyle = function (style) {
        this.Styles.push(style);
    };
    MapLoadingOptions.prototype.GetStyles = function () {
        return this.Styles;
    };
    MapLoadingOptions.prototype.GetModules = function () {
        return this.Modules;
    };
    return MapLoadingOptions;
}());
exports.MapLoadingOptions = MapLoadingOptions;
var CommandMapStyle = /** @class */ (function () {
    function CommandMapStyle() {
    }
    return CommandMapStyle;
}());
var KeyValuePair = /** @class */ (function () {
    function KeyValuePair(key, value) {
        this.Key = key;
        this.Value = value;
    }
    return KeyValuePair;
}());
function GetCommandMapStyle() {
    return {
        "version": "1.0",
        "settings": {
            "landColor": "#0B334D"
        },
        "elements": {
            "mapElement": {
                "labelColor": "#FFFFFF",
                "labelOutlineColor": "#000000"
            },
            "political": {
                "borderStrokeColor": "#144B53",
                "borderOutlineColor": "#00000000"
            },
            "point": {
                "labelColor": "#0C4152",
                "fillColor": "#000000",
                "strokeColor": "#0C4152"
            },
            "transportation": {
                "strokeColor": "#000000",
                "fillColor": "#000000"
            },
            "highway": {
                "strokeColor": "#158399",
                "fillColor": "#000000"
            },
            "controlledAccessHighway": {
                "strokeColor": "#158399",
                "fillColor": "#000000"
            },
            "arterialRoad": {
                "strokeColor": "#157399",
                "fillColor": "#000000"
            },
            "majorRoad": {
                "strokeColor": "#157399",
                "fillColor": "#000000"
            },
            "railway": {
                "strokeColor": "#146474",
                "fillColor": "#000000"
            },
            "structure": {
                "fillColor": "#115166"
            },
            "water": {
                "fillColor": "#021019"
            },
            "area": {
                "fillColor": "#115166"
            }
        }
    };
}
exports.GetCommandMapStyle = GetCommandMapStyle;
;
//# sourceMappingURL=bingmodels.js.map