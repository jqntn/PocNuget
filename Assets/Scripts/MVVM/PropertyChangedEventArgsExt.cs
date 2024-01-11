/*using System.ComponentModel;

namespace PocMVVM
{
    internal delegate void PropertyChangedEventHandlerExt(object sender, PropertyChangedEventArgsExt e);

    internal sealed class PropertyChangedEventArgsExt : PropertyChangedEventArgs
    {
        public object Before { get; }
        public object After { get; }

        public PropertyChangedEventArgsExt(string propertyName, object before, object after) : base(propertyName)
        {
            Before = before;
            After = after;
        }
    }
}*/

//public event PropertyChangedEventHandlerExt PropertyChangedExt;
//public void OnPropertyChanged(string propertyName, object before, object after)
//{
//    PropertyChangedExt?.Invoke(this, new PropertyChangedEventArgsExt(propertyName, before, after));
//}