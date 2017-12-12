using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfDemos.Annotations;

namespace WpfDemos
{
    public class Notifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
