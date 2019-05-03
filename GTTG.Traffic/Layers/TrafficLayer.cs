using GTTG.Core.Drawing.Canvases;
using GTTG.Core.Drawing.Layers;
using GTTG.Model.Model.Traffic;
using GTTG.Model.ViewModel.Traffic;
using GTTG.TrafficDemo.ViewModel.Traffic;

namespace GTTG.TrafficDemo.Layers {

    public class TrafficLayer : ContentDrawingLayer {

        private readonly TrafficView<TutorialTrainView, Train> _trafficView;

        public TrafficLayer(TrafficView<TutorialTrainView, Train> trafficView) {
            _trafficView = trafficView;
        }

        protected override void OnDraw(DrawingCanvas drawingCanvas) {
            drawingCanvas.Draw(_trafficView);
        }
    }
}
