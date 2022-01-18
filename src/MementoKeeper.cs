﻿using System.Collections.Generic;
using Clustering.Objects;

namespace Clustering
{
    public class MementoKeeper : IObserver
    {
        private PlaneChart.ClusterChart _chart;
        public List<PlaneChartMemento> mems;

        public MementoKeeper(PlaneChart.ClusterChart chart)
        {
            _chart = chart;
            mems = new List<PlaneChartMemento>();
        }

        public void Update(EventType eventType, ClusteringResult result)
        {
            mems.Add(_chart.CreateMemento());
        }
    }
}