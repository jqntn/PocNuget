using System.ComponentModel;

namespace MVVM
{
    internal class Model : INotifyPropertyChanged
    {
        public const string ALL = "*";
        public static readonly PropertyChangedEventArgs AllChanged = new(ALL);

        public event PropertyChangedEventHandler PropertyChanged;
    }
}