import { BingMap } from "../../../../../lib/BingMaps/wwwroot/js/bing/bingmaps";

export function GetMap() {   

    var map = new BingMap('#myMap', 12);
}

/// Supported Map Types
/// Gray Scale - Microsoft.Maps.MapTypeId.grayscale
/// Aerial - Microsoft.Maps.MapTypeId.aerial
/// Road - Microsoft.Maps.MapTypeId.road
/// BirdsEye - Microsoft.Maps.MapTypeId.birdseye
/// Dark - Microsoft.Maps.MapTypeId.canvasDark
/// Light - Microsoft.Maps.MapTypeId.canvasLight

/// Supported Navigation Bar Modes
/// Square - navigationBarMode.square
/// Compact - navigationBarMode.compact