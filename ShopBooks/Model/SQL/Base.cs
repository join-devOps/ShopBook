using System.Windows.Media.Imaging;

namespace ShopBooks.Model.SQL
{
    class Base
    {
        public static Entities EM = new Entities();
    }

    public partial class Books
    {
        public string GetTitle
        {
            get => "Название: " + Title;
        }

        public string GetGenre
        {
            get => "Жанр: " + Genre;
        }

        public string GetAuthor
        {
            get => "Автор: " + Author;
        }

        public string GetCount
        {
            get => "Количество: " + CountInShop;
        }

        public string GetCost
        {
            get => "Цена: " + Cost;
        }

        //public BitmapImage GetImage
        //{
        //    get => new BitmapImage( new System.Uri("pack://application:,,,/ShowBooks.Images;component/" + Cover));
        //}

        //public string GetImage
        //{
        //    get => "pack://application:,,,/ShowBooks.Images;component/" + Cover;
        //}

        public string GetImage
        {
            get => "\\" + Cover;
        }
    }
}