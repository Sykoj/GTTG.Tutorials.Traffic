using GTTG.Model.Model.Infrastructure;

namespace GTTG.TrafficDemo.Model {

    public class TutorialTrack : Track {

        public TrackType TrackType { get; }

        public TutorialTrack(TrackType trackType) {
            TrackType = trackType;
        }
    }
}
