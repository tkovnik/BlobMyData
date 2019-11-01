using System;
using System.Collections.Generic;
using System.Text;

namespace BlobMyData.Domain.Model
{
    public class ProfileSource : BaseModel<int>
    {
        private string _Path;

        private ICollection<SourceFile> _Files;

        #region Public Properties

        public string Path 
        { 
            get => _Path;
            set 
            { 
                _Path = value;
                NotifyPropertyChanged(nameof(Path));
            } 
        }

        public ICollection<SourceFile> Files
        {
            get => _Files;
            set
            {
                _Files = value;
                NotifyPropertyChanged(nameof(Files));
            }
        }

        #endregion
    }
}
