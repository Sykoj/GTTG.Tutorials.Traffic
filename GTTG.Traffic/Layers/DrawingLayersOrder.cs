using System;
using System.Collections.Generic;
using System.Collections.Immutable;

using GTTG.Core.Drawing.Layers;

namespace GTTG.TrafficDemo.Layers {

    public class DrawingLayersOrder : IRegisteredLayersOrder {

        ImmutableList<Type> IRegisteredLayersOrder.DrawingLayerTypeList { get; } = new List<Type> {
            typeof(TimeLinesLayer),
            typeof(InfrastructureLayer),
            typeof(TrafficLayer),
            typeof(TimeAxisLayer)
        }.ToImmutableList();
    }
}
