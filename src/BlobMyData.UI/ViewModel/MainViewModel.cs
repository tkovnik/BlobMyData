using GalaSoft.MvvmLight;

namespace BlobMyData.UI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string _TestHello;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            TestHello = "HELLO FROM VIEWMODEL.";
        }

        public string TestHello
        {
            get => _TestHello;
            set
            {
                if (_TestHello != value)
                {
                    _TestHello = value;
                    RaisePropertyChanged(nameof(TestHello));
                }
            }
        }
    }
}