using System;
using System.Collections.Generic;
using System.Text;

namespace BlobMyData.Domain.Model
{
    public class BlobStorage : BaseModel<int>
    {
        private string _Name;
        private string _Description;

        public virtual string Name 
        {
            get => _Name;
            set
            {
                _Name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public virtual string Description
        {
            get => _Description;
            set
            {
                _Description = value;
                NotifyPropertyChanged(nameof(Description));
            }
        }
    }
}
