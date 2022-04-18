using ShopBooks.Core;

namespace ShopBooks.ViewModel
{
    class MainViewModel : CorePropertyChanged
    {
        private BooksViewModel _BooksVm;
        public BooksViewModel BooksVm
        {
            get => _BooksVm;
            set
            {
                _BooksVm = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            BooksVm = new BooksViewModel();
        }
    }
}