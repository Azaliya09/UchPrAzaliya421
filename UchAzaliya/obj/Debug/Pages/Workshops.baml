   M S B A M L   `   `   `  ����E  AUchAzaliya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UchAzaliya.PagesUchAzaliya.Pages  5           UchAzaliya.Pages.Workshops   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:UchAzaliya.Pages     5        N� Title$  	Workshops��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   6-   �� 5      $	��700 �6   6-   .+�5   
   �� -   5         ��Name$ BackBtn��5   !   $��1��6   $	��100��62   $��20��6>   $	��Top=�6J   $��Right=�6b   $��	0 20 60 0q�6~   .��6�   
Назад6�   A� 5   
   $��1��6   ���	#FFBB0C07$��40��63   $��40��6>   $��Right=�6J   $	��Top=�6f   $��10q�6~   (� 5   
   $��1��6   $��40��6#   $��40��6.   $��Right=�6:   $	��Top=�6V   $��20 10q�6n   .��5      ��  � ToolTip$� �Пароль должен соответствовать требованиям:
4-16 символов;
не должно быть знаков * { } | + &;
заглавные буквы и цифры��6   $��?��6�   
������� �� TextAlignment$ Center=�6�   5      �� 5   
   $��2��6   $��18(�6(   $��DemiBold"�66   $��Center=�6L   $	��Top=�6i   $��	0 20 0 10q�6�   !ПЛАНИРОВКА ЦЕХОВ6�   �� 5   
   -   5         ��Name$ WorkshopImage��5       $��1��6   $9��3/Resorces/Заготовительный цех.png��67   $	��500��6b   $	��500��6o   �� 5   
   -   5         ��Name$ 
MainCanvas��5   6    J� 	AllowDrop . }�. 
������ $��114,325,114,325q�6�   �� 5   
   $��0��6    �� Orientation$ Vertical=�6%   $��Bottom=�6<   .+�5      �� -   5        	 ��Name$	 
WorkshopCb��5      
 �� SelectedIndex$
 1��6+   $��20(�6=   $��0��6K   $��50��6[   $	��NaN��6g   $	��Top=�6s   $��10q�6�   6�   �� 5      $��Center=�6   .+�5      �� ���	#FFBB0C07$��3q�61   $	��275��6E   $	��500��6Q   $��10q�6^   ._�5      �� -   5         ��Name$ 
MenuScroll��5   #   $��Hidden=�67   $	��250��6^   $��Hidden=�6j   $	��475��6�   .��5      � -   5         �Name$ IconsWp��5   $   $��Center=�65   $	��250��6P   $	��475��6\   $��Center=�6i   5      5       5!      5"      5#      �� 5%   
   -   5        $ EditBtn��5%      $��1��6"   $	��150��62   $��20��6>   $��Center=�6J   $��Bottom=�6g   $��10q�6�   .��6�   Редактировать6�   5&      5'      