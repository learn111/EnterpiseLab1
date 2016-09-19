using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BLL.Models
{
    public class BindableModelBase : INotifyPropertyChanged
    {
        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void Set<T>(T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(Get<T>(propertyName), value))
                return;
            _properties[propertyName] = value;
            OnPropertyChanged(propertyName);
        }

        protected virtual T Get<T>([CallerMemberName] string propertyName = null)
        {
            object value;
            return _properties.TryGetValue(propertyName, out value)
                ? (value == null ? default(T) : (T) value)
                : default(T);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}