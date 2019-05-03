using GTTG.Core.Strategies.Implementations;
using GTTG.Model.Lines;
using GTTG.Model.Model.Infrastructure;
using GTTG.Model.Strategies.Types;
using GTTG.Model.ViewModel.Infrastructure.Tracks;

namespace GTTG.TrafficDemo.ViewModel {

    public class TutorialTrackView : TrackView {

        public TutorialTrackView(Track track, TrackLine trackLine, MeasureableSegment<LineType> trackLineSegment)
            : base(track, trackLine, trackLineSegment) {
        }
    }
}
