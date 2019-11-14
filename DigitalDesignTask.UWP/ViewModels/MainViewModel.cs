using DigitalDesignTask.UWP.Base;

namespace DigitalDesignTask.UWP.ViewModels
{
    public class MainViewModel : Observable
    {
        private string _text;
        private string _dataMatrixText;

        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }

        public string DataMatrixText
        {
            get { return _dataMatrixText; }
            set { Set(ref _dataMatrixText, value); }
        }

        public void GenerateDataMatrix()
        {
            DataMatrixText = Text;
        }
    }
}
