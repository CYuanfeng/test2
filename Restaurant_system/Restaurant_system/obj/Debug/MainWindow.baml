   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    Restaurant_system"   Restaurant_system.MainWindow   5      Hcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��968��6   $
��1360��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowState$ 	Maximized=�6[   .��5      �  � RowDefinitions 5   
   �� 5	      $	��100 �6   �� 5
      $��85 �6   �� 5      $��* �6   �� 5      $	��200 �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      $	��100 �6   6-   �� 5      $	��350 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��0��6    $
��Rest��6-   $��2��6<   $��65(�6P   $��30,0,0,0q�6^   6r   �� 5   
   -   5         ��Name$ 	topScroll��5      $��0,0,10,0q�5      $��Disabled=�5      $
��Auto=�5      $��1��5      $��0��6+   $��3��6;   .��5      �� -   5        $��	catePanel��5      
���P�� �� Orientation$ 
Horizontal=�6=   6X   5      �� 5   
   -   5        $ contentScroll��5      $��
10,10,10,0q�5      $
��Auto=�5      $��Disabled=�5      $��2��5       $��0��6+   $��3��6;   $��2��6O   .��5!      �� -   5        $��	foodPanel��5!      
����+��$ Vertical=�6B   6[   5"      �� 5#   
   -   5        $ rightContentScroll��5#      $��0,10,0,0q�5$      $
��Auto=�5%      $��Disabled=�5&      $��2��5'      $��3��6+   .��5(      �� -   5        $��orderDetailPanel��5(      
�������$ Vertical=�6C   5*      5+      �� 5,   
   -   5        $ rightTopScroll��5,      $��0,0,10,0q�5-      $��Disabled=�5.      $
��Auto=�5/      $��1��50      $��3��6+   $��3��6;   .��51      �� -   5        $��orderAddPanel��51      
���/���$ 
Horizontal=�6G   6b   52      �� 53   
   
�������$��3��6(   $
��Left=�68   $	��195��6S   $��0,5,0,0q�6`   $��3��6q   $	��Top=�6~   $	��752��6�   $ 
Horizontal=�6�   .+�54      �� -	   5        $��settlementPanel��54   %   $	��355��6   
���**��6<   �� 55      -
   5        $��
PrintPanel��55   %   $	��397��6   
��� ���67   56      58      59      