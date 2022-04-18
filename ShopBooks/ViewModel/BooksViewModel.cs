using ShopBooks.Core;
using ShopBooks.Model.SQL;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ShopBooks.ViewModel
{
    class BooksViewModel : CorePropertyChanged
    {
        private List<Books> _BooksList;
        public List<Books> BooksList
        {
            get => _BooksList;
            set
            {
                _BooksList = value;
                OnPropertyChanged("BooksList");
            }
        }

        private bool _IsSelected = false;
        public bool IsSelected
        {
            get => _IsSelected;
            set
            {
                _IsSelected = value;
                OnPropertyChanged("IsSelected");
                OnPropertyChanged("GetSelectedBooks");
            }
        }

        private int? _Sum;
        public int? Sum
        {
            get => _Sum;
            set
            {
                _Sum = value;
                OnPropertyChanged("Sum");
                OnPropertyChanged("BooksSelectedItems");
            }
        }

        private int _Count;
        public int Count
        {
            get => _Count;
            set
            {
                _Count = value;
                OnPropertyChanged("Count");
                OnPropertyChanged("BooksSelectedItems");
            }
        }

        private Books _BooksSelectedItems;
        public Books BooksSelectedItems
        {
            get
            {
                if (_BooksSelectedItems == null)
                {
                    IsSelected = true;
                }
                else
                {
                    IsSelected = false;

                    Sum = _BooksSelectedItems.Cost;
                }

                return _BooksSelectedItems;
            }
            set
            {
                _BooksSelectedItems = value;
                OnPropertyChanged("BooksSelectedItems");
                OnPropertyChanged("GetSelectedBooks");
                OnPropertyChanged("IsSelected");
                OnPropertyChanged("Sum");
            }
        }

        public Visibility GetSelectedBooks
        {
            get => IsSelected == true ? Visibility.Visible : Visibility.Collapsed;
        }

        public BooksViewModel()
        {
            BooksList = Base.EM.Books.ToList();
        }
    }
}