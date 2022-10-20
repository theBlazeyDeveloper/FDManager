/// <reference path="../lib/bingmaps/types/MicrosoftMaps/Microsoft.Maps.All.d.ts" />

import { GetCommandMapStyle, IMapModule, IMapStyle } from "./bingmodels";

export class BingMap {
    public Modules?: IMapModule[];    
    public Map: Microsoft.Maps.Map;    
    public ZoomLevel: number;
    public MapStyle?: string;

    constructor(elementId: string, zoomLevel: number, modules?: IMapModule[], mapStyle?: string) {
        this.Map = new Microsoft.Maps.Map(elementId, {
            center: new Microsoft.Maps.Location(29.9630376, -95.7673257),            
            customMapStyle: GetCommandMapStyle(),
            zoom: zoomLevel,
        });
    }
}              