   M S B A M L   `   `   `  ����C  ?BikeShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BikeShopBikeShop  5      !    BikeShop.ProductsManagement   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:BikeShop     5        N� Title$  ProductsManagement��5	         
background N� 
Background# [  5
      .��5      � .+�5   
   �� -   5        $��textBox��5      $
��Left=�6!   $��23��6<   $��	135,4,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�5      $��	10,11,0,0q�5      $
��Wrap=�5      $��Search:��5      $	��Top=�5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGrid��5   r   $
��Left=�6   $	��252��6.   $��	10,39,0,0q�6;   $	��Top=�6N   $	��290��6f   6r   �� 5   
   
���   �$��1q�6`   $
��Left=�5      $	��247��5      $��
305,39,0,0q�6   $	��Top=�5      $	��146��6)   ���	#FFF7F3F3 � DataContext 5      �� *SelectedItem+ �� ElementName$ dataGrid��._�5      �� $��10q�6   .+�5      �� $��Product Detail��6   $
��Bold"�62   $��13(�6D   $��Center=�5      $��10q�69   �� 5      $��Title��6   �� 5      ��6   �� *Title+ �� Mode$ TwoWay=��� 5      $��Price��6   �� 5       ��6   �� *Price+$ TwoWay=��� 5!      $��Color��6   �� 5"      ��6   �� *Color+$ TwoWay=��� 5#      $��10��66   ��6   �� *Color+66   �� 5$      $��	Reference��6   �� 5%      ��6   �� *	Reference+$ TwoWay=�5&      5'      5)      5*      