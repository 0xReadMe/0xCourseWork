   M S B A M L   `   `   `  ����C  ?MainMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MainMenuMainMenu  5   	       MainMenu.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MainMenu     5   	     � Title$
  Main��5   	   $	��720��6   $
��1320��6#   $	��620��60   $
��1020��6@    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�6.    � 
ResizeMode$ CanResizeWithGrip=�5
   	    � AllowsTransparency$
 True��6(   .��5      � ���	#FF36393F � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � -   5        ���	#FF1E1F22$��0��5   :   .+�5      o� $��50��6   $	��440��6   $
��Left=�6+   ���	#FF1E1F22.@�5      m� $��50��6   $��Меню��6'   $��24(�65   ���	#FFF3B424$��Palatino Linotype)�6Z   .@�5      m� -   5        ���	#FF2F3136$��Массив А��5   K   m� 5      -   5        ���	#FF2F3136$��Массив В��5   K   m� 5      -   5        ���	#FF2F3136$��Массив С��5   K   m� 5      -   5        ���	#FF2F3136$��Массив Y��5   K   m� 5      -   5        ���	#FF2F3136$��График��5   K   m� 5      -   5        ���	#FF2F3136$��
Выйти��5   I   m� 5      -   5        ���	#FF2F3136$��Открыть��5   I   m� 5      -	   5        ���	#FF2F3136$��Сохранить��5   O   5      5      �� 5       -
   5        ���	#FF1E1F22$��Palatino Linotype)�5    ,   $��Right=�6K   $��	0 0 150 0q�6g   $��50��6z   $	��147��6�   $��Справка��6�   $��24(�6�   ���	#FFF3B424 K� ZIndex$ 1��6�   $��0,0,0,0q�6�   6	  �� 5"      -   5        $��50��5"      $��50��6    $��	0 0 100 0q�6,   $��Right=�6?   ���	#FF1E1F22���	#FFF3B424$
��Bold"�6�   $��0,0,0,0q�6�   $��14(�6�   .��6�   —6�   �� 5#      -   5        $��50��5#      $��50��6    $��0 0 50 0q�6,   ���	#FF1E1F22$��Right=�6h   ���	#FFF3B424$��0,0,0,0q�6�   $
��Bold"�6�   $��16(�6�   .��6�   ⃞6�   �� 5$      -   5        $��50��5$      $��50��6    ���	#FF1E1F22$��Right=�6V   ���	#FFF3B424$��0,0,0,0q�6�   .��6�   ✖6�   5%      � 5'   
   -   5         �Name$ MenuNavigation��5'   &   ���	#FF313237$��66��5*      $	��540��6   $��1��6'   $
��Left=�5+      $ 1��6*      	GridStyle#��[  5,       5-      �� 5.      6#   �� 5/      $��5 �6    6-   �� 50      6"   �� 51      $��5 �6    6-   �� 52      6"   �� 53      $��5 �6    6-   �� 54      6"   �� 55      $��5 �6    6-   �� 56      6"   �� 57      $��5 �6    6-   �� 58      6"   �� 59      $��5 �6    6-   �� 5:      6"   �� 5;      $��5 �6    6-   �� 5<      6"   .+�5>      �� -   5         ��Name$ ArrayA��5>        ButtonStyleMain#��[ 6%   $��0��6c   $��2��6p   $��22(�6�   .��6�   А6�   �� 5?      -   5        $ ArrayB��5?      #��[ 6%   $
{�True��6c   $��2��6t   $��2��6�   $��22(�6�   .��6�   В6�   �� 5@      -   5        $ ArrayC��5@      #��[ 6%   $
{�True��6c   $��4��6t   $��2��6�   $��22(�6�   .��6�   С6�   �� 5A      -   5        $ ArrayY��5A      #��[ 6%   $
{�True��6c   $��6��6t   $��2��6�   $��22(�6�   .��6�   Y6�   �� 5B      -   5        $ GraphC��5B      #��[ 6%   $
{�True��6c   $��8��6t   $��2��6�   $��22(�6�   .��6�   
Граф6�   �� 5C      -   5        $ 
TextResult��5C      #��[ 6)   $
{�True��6k   $��10��6}   $��2��6�   $��22(�6�   .��6�   Рез6�   �� 5D      -   5        $
 Open��5D      #��[ 6#   $
{�True��6_   $��12��6q   $��2��6   $��22(�6�   .��6�   
Файл6�   �� 5E      -   5        $
 Exit��5E      #��[ 6#   $��14��6_   $��2��6m   $��22(�6}   .��6�   
Выход6�   5F       � 5H   
   -   5        	  �Name$	 MyFrame��5H      $��1��6!   
  � NavigationUIVisibility$
 Hidden=�6.   ���	#FF36393F6h   5I      5J      