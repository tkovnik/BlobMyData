using System;
using System.Collections.Generic;
using System.Text;

namespace BlobMyData.Domain.Model
{
    public class SourceFile : BaseModel<int>
    {
        private string _Name;
        private string _FullName;
        private DateTime _LastBackupDate;
        private string _Comment;
        private string _Tags;

        #region Public Properties

        public string Name
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

        public string FullName
        {
            get => _FullName;
            set
            {
                if (_FullName != value)
                {
                    _FullName = value;
                    NotifyPropertyChanged(nameof(FullName));
                }
            }
        }

        public DateTime LastBackupDate
        {
            get => _LastBackupDate;
            set
            {
                if (_LastBackupDate != value)
                {
                    _LastBackupDate = value;
                    NotifyPropertyChanged(nameof(LastBackupDate));
                }
            }
        }

        public string Comment
        {
            get => _Comment;
            set
            {
                if (_Comment != value)
                {
                    _Comment = value;
                    NotifyPropertyChanged(nameof(Comment));
                }
            }
        }

        public string Tags
        {
            get => _Tags;
            set
            {
                if (_Tags != value)
                {
                    _Tags = value;
                    NotifyPropertyChanged(nameof(Tags));
                }
            }
        }

        #endregion
    }
}
