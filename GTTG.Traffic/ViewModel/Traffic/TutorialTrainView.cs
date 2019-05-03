using GTTG.Model.Lines;
using GTTG.Model.Model.Traffic;
using GTTG.Model.Strategies;
using GTTG.Model.Strategies.Types;
using GTTG.Model.ViewModel.Traffic;
using GTTG.TrafficDemo.Components;

namespace GTTG.TrafficDemo.ViewModel.Traffic {

    public class TutorialTrainView : StrategyTrainView<Strategy, Train> {

        public TutorialTrainView(Train train, ITrainPath trainPath, Strategy strategyManager) 
            : base(train, trainPath, strategyManager) {

        }

        public override void UpdateTrainViewContent() {
            base.UpdateTrainViewContent();

            foreach (var trainEvent in Train.Schedule) {

                var trainEventPlacement = new TrainEventPlacement(trainEvent, AnglePlacement.Acute);
                Strategy.TrackStrategyManager.Add(trainEventPlacement, new TimeComponent(trainEvent));
            }
        }
    }
}
