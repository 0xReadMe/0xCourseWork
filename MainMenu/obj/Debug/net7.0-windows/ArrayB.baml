   M S B A M L   `   `   `  ����C  ?MainMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MainMenuMainMenu  5          MainMenu.ArrayB   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:MainMenu     5        N� Title$  ArrayB��5	      .��5      � ���	#FF36393F � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��2* �6   6,    � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   � $	��210��6   $	��150��6   $��0��6(   $��0��65   $��Bottom=�6E   $��
-30,20,0,0q�6`    5      �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   .+�5      �� $��0��6   $!��Нижняя граница��6"   $��Center=�6;   $��16(�6V   
�������$��Palatino Linotype)�6w   �� 5      -   5         ��Name$ 
lowerBound��5      $��1��6Y   $��0,0,0,0q�6g   $��16(�6x   $��Center=�6�   $��Stretch=�6�   $��30��6�   6�   �� 5      $��2��6   $#��Верхняя граница��6"   $��16(�6<   $��Stretch=�6J   $��Center=�6h   
�������$��Palatino Linotype)�6�   �� 5      -   5        $ 
upperBound��5      $��3��6Y   $��0,0,0,0q�6g   $��Center=�6x   $��30��6�   $��16(�6�   6�   5      � 5!   
   $	��210��6   $��45��6   $��1��6'   $��0��64   $��2��6E   $	��Top=�6V   $��
-30,20,0,0q�6n    5"      �� 5#      6"   .+�5%      �� -   5         ��Name$ 	FillArray��5%      $��0��6@      ButtonStyleB#��[  6N   $��	-30,0,0,0q�6t   .��6�   Заполнить6�   5&      � 5(   
   $��2��6   $��1��6    $��0��60    5)      �� 5*      $��50 �6    6.   �� 5+      6"   .+�5-      �� $��Center=�6   $��Palatino Linotype)�63   $��Center=�6R   $��18(�6o   $��20 0 0 0q�6}   
�������Массив В6�   &   System.Windows.Controls.DataGrid  5/      -   5          Name$ 
ArrayBGrid��55         AutoGenerateColumns$
 True��5/      ���	#FF1E1F22   RowBackground �	#FF36393F
�������   AlternatingRowBackground �	#FF1E1F22  DataGridStyle1#���  54      $��
20,0,20,20q�55   +   $��2��6?   $��0��6P   $��1��6`   56      57      58      