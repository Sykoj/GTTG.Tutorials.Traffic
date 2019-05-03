using System.Linq;
using SkiaSharp;

using GTTG.Core.Drawing.Canvases;
using GTTG.Core.Strategies.Implementations;
using GTTG.Core.Strategies.Interfaces;
using GTTG.Model.Model.Infrastructure;
using GTTG.Model.Strategies.Types;
using GTTG.Model.ViewModel.Infrastructure.Stations;
using GTTG.Model.ViewModel.Infrastructure.Tracks;

namespace GTTG.TrafficDemo.ViewModel {

    public class TutorialStationView : StrategyStationView<TutorialTrackView> {

        public TutorialStationView(Station station,
            ITrackViewFactory<TutorialTrackView> trackViewFactory,
            ISegmentRegistry<SegmentType<Track>, MeasureableSegment<SegmentType<Track>>> segmentRegistry)
            : base(station, segmentRegistry, trackViewFactory) {

            foreach (var track in TrackViews.Select(t => t.Track)) {

                Segments.Resolve(new SegmentType<Track>(track, SegmentPlacement.Lower)).HeightMeasureHelpers += MeasureSegmentHeight;
                Segments.Resolve(new SegmentType<Track>(track, SegmentPlacement.Upper)).HeightMeasureHelpers += MeasureSegmentHeight;
            }
        }

        protected override void OnDraw(DrawingCanvas drawingCanvas) {

            drawingCanvas.Canvas.DrawColor(SKColors.WhiteSmoke);
            foreach (var trackView in TrackViews) {
                drawingCanvas.Draw(trackView);
            }
        }

        private static float MeasureSegmentHeight() => 5;
    }
}
