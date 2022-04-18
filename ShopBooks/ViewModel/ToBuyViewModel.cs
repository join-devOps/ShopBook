using ShopBooks.Core;
using ShopBooks.Model.SQL;
using System.Collections.Generic;

namespace ShopBooks.ViewModel
{
    class ToBuyViewModel : CorePropertyChanged
    {
        private List<Books> _listBooks;
        public List<Books> listBooks
        {
            get => _listBooks;
            set
            {
                _listBooks = value;
                OnPropertyChanged("listBooks");
            }
        }

        public ToBuyViewModel(List<Books> books)
        {
            listBooks = books;
        }
    }
}