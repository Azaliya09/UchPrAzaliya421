   M S B A M L   `   `   `  ����E  AUchAzaliya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UchAzaliya.PagesUchAzaliya.Pages  5      #    UchAzaliya.Pages.AddEditOrder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:UchAzaliya.Pages     5        N� Title$  AddEditOrder��5	       N� 
Background �	#FFFEF9DE.��5      � .+�5   
   �� $��Center=�6   $��Center=�62   .+�5      �� $��18(�6   $
��Bold"�6&   $��Center=�69   $��Center=�6V   $��	0 10 0 20q�6q   #!Добавление заказа6�   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�63   $��0 0 0 5q�6P   .+�5      �� $	��120��6   Артукул62   �� 5      -   5         ��Name$
 IDTb��5      ��6(   �� *Id_Component+6H   5      �� 5      $ 
Horizontal=�6   $��Center=�63   $��0 0 0 5q�6P   .+�5      �� $	��120��6   Наименование67   �� 5      -   5        $ NameTb��5      ��6*   �� *Name_Component+6L   5      �� 5      $ 
Horizontal=�6   $��Center=�63   $��0 0 0 5q�6P   .+�5      �� $	��120��6   Количество65   �� 5      -   5        $ CountTb��5      ��6+   �� *Count+6D   5      �� 5      $ 
Horizontal=�6   $��Center=�63   $��0 0 0 5q�6P   .+�5      �� $	��120��6   $
��Wrap=�6)   $��-3 0 3 0q�6=   #!Единица измерения6b   �� 5      -   5         ��Name$ 
SizeTypeCb��5      $	��180��6/    �� SelectedItem$ SizeType��6;    �� DisplayMemberPath$ Name_SizeType��6S   6w   5      �� 5      $ 
Horizontal=�6   $��Center=�63   $��0 0 0 5q�6P   .+�5      �� $	��120��6   $
��Wrap=�6*   Закупочная цена6O   �� 5       -   5        $ PriceTb��5       ��6+   �� *Cost+6C   5!      �� 5"      $ 
Horizontal=�6   $��Center=�63   $��0 0 0 5q�6P   .+�5#      �� $	��120��6   $��-3 0 3 0q�6)   Поставщик6F   �� 5$      -   5        $ 
ProviderCb��5$      $	��180��6/   $ Provider��6;   $ Name_Provider��6S   6w   5%      �� 5&      $ 
Horizontal=�6   $��Center=�63   $��0 0 0 5q�6P   .+�5'      �� $	��120��6   $
��Wrap=�6*   Срок доставки6M   �� 5(      -   5        $ DeliveryDateTb��5(      ��62   �� *Provider.DeliveryDate+6[   5)      �� 5*      $ 
Horizontal=�6   $��Center=�62   $��0 0 0 5q�6O   .+�5+      �� $	��120��6   $��-3 0 3 0q�6)   
Склад6B   �� 5,      -   5        $ WarehouseCb��5,      $	��180��60   $ 	Warehouse��6<   $ Name_Warehouse��6U   6z   5-      �� 5/      -	   5         ��Name$ SaveBtn��5/   !   $��25��6   .��6H   Сохранить6S   50      �� 52   
   -
   5        $ BackBtn��52      $	��100��6"   $��25��6.   $��10q�6:   $
��Left=�6F   $	��Top=�6a   .��6�   
Назад6�   53      54      