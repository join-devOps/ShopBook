   M S B A M L   `   `   `  ����D  @ShopBooks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ShopBooks.ViewShopBooks.View  5          ShopBooks.View.BooksView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ShopBooks.View     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��2��5      $��Right=�5      $��Center=�5      y�5      �� *GetSelectedBooks+.+�5      �� .+�5      �� $ 
Horizontal=�6   .+�5      �� $8��2Количество выбранных книг: ��6    �� 5      ��6    �� *Count+5      �� 5      $ 
Horizontal=�6   .+�5      �� $#��Размер покупки: ��6    �� 5       ��6    �� *Sum+5!      �� 5"      $!��Размер скидки: ��6   5#      �� 5%      $(��"Добавить в корзину��6   $��25��5&      $	��150��6   �� 5(      $(��"Просмотр в корзине��6   $��25��5)      $	��150��6   5*      �� 5,   
   -   5        $��ListView_Books��5,      $
��auto��5-       �� SelectionMode$ Multiple=�5.      $��Stretch=�51      $��1��52      $��1��6    $��2��61   $��Disabled=�53      
���   ���5/      �� *	BooksList+ �� SelectedItem 50      �� *BooksSelectedItems+ �� Mode$ OneWay=���56      �� 57      .R�58      �� ._�59      � .+�5:      � $	��175��6#   $	��690��60   .+�5<   "   �� $ 
Horizontal=�6-   $��Disabled=�5=   -   .+�5?   &   �� $��50��5@   ,   $��75��68   ��5?   ,   �� *
GetImage+5@   8   �� 5B   &   .+�5C   *   �� $ 
Horizontal=�65   .+�5D   .   �� $��12(�6R   ��68   �� *
GetTitle+6R   �� 5E   .   $	�� | ��68   $��12(�6C   �� 5F   .   $��12(�6R   ��68   �� *
GetGenre+6R   5G   +   �� 5I   *   $ 
Horizontal=�65   .+�5J   .   �� ��64   �� *	GetAuthor+5K   +   �� 5M   *   $ 
Horizontal=�65   .+�5N   .   �� $��12(�6Q   ��64   �� *
GetCount+6Q   5O   +   �� 5Q   *   $ 
Horizontal=�65   .+�5R   .   �� $��12(�6P   ��64   �� *	GetCost+6P   5S   +   5T   '   5U   #   5V      5W      5X      5Y      5[      5\      5]      