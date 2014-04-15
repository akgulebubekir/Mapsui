﻿using Mapsui.Geometries;

namespace Mapsui.Projection
{
    public interface ITransformation
    {
        int MapSRID { get; set; }
        IGeometry Transform(int fromSRID, int toSRID, IGeometry geometry);
        BoundingBox Transfrom(int fromSRID, int toSRID, BoundingBox boundingBox);
    }
}