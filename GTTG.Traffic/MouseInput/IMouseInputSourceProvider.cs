using System.ComponentModel;

namespace GTTG.TrafficDemo.MouseInput {

    public interface IMouseInputSourceProvider : INotifyPropertyChanged {

        /// <summary>
        /// Current <see cref="IMouseInputSource"/>. If changed, notified.
        /// </summary>
        IMouseInputSource MouseInputSource { get; }
    }
}
