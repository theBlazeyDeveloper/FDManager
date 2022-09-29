
export function GetMap() {
    var navigationBarMode = Microsoft.Maps.NavigationBarMode;

    var map = new Microsoft.Maps.Map('#myMap',
        {
            center: new Microsoft.Maps.Location(29.9630376, -95.7673257),
            mapTypeId: Microsoft.Maps.MapTypeId.canvasDark,
            zoom: 12,
            navigationBarMode: navigationBarMode.square,
            showSearchBar: true
        });
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