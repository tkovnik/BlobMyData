using System;
using System.Collections.Generic;
using System.Text;

namespace BlobMyData.Domain.Model
{
    public class Profile : BaseModel<int>
    {
        private string _Name;
        private string _MachineName;
        private string _Description;

        private ICollection<ProfileSource> _ProfileSources;

        public virtual string Name
        {
            get => _Name;
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    NotifyPropertyChanged(nameof(Name));
                }
            }
        }

        public virtual string MachineName
        {
            get => _MachineName;
            set
            {
                if (_MachineName != value)
                {
                    _MachineName = value;
                    NotifyPropertyChanged(nameof(MachineName));
                }
            }
        }

        public virtual string Description
        {
            get => _Description;
            set
            {
                if(_Description != value)
                {
                    _Description = value;
                    NotifyPropertyChanged(nameof(Description));
                }
            }
        }

        public virtual ICollection<ProfileSource> ProfileSources
        {
            get => _ProfileSources;
            set
            {
                _ProfileSources = value;
                NotifyPropertyChanged(nameof(ProfileSources));
            }
        }
    }
}
