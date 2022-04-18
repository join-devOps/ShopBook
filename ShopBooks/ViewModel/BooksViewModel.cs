using ShopBooks.Core;
using ShopBooks.Model.SQL;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ShopBooks.ViewModel
{
    class BooksViewModel : CorePropertyChanged
    {
        private RelayCommand _CommandShow;
        public RelayCommand CommandShow
        {
            get => _CommandShow ?? (_CommandShow = new RelayCommand(o => 
            {
                new ToBuyViewModel(BooksSelectedItems);
            }));
        }

        private List<Books> _BooksList;
        public List<Books> BooksList
        {
            get => _BooksList;
            set
            {
                _BooksList = value;
                OnPropertyChanged();
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
            }
        }

        private int _Sum;
        public int Sum
        {
            get => _Sum;
            set
            {
                _Sum = value;
                OnPropertyChanged("Sum");
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

        private List<Books> _BooksSelectedItems;
        public List<Books> BooksSelectedItems
        {
            get
            {
                if (_BooksSelectedItems == null)
                    IsSelected = true;
                else
                {
                    IsSelected = false;
                    Count = 0;
                }

                return _BooksSelectedItems;
            }
            set
            {
                _BooksSelectedItems = value;
                OnPropertyChanged("BooksSelectedItems");
                OnPropertyChanged("GetSelectedBooks");
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