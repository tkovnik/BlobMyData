using System.ComponentModel;

namespace BlobMyData.Domain.Model
{
    public abstract class BaseModel<TKey> : IBaseModel<TKey>, INotifyPropertyChanged
    {
        public virtual TKey Id { get; set; }

        #region INotify

        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
