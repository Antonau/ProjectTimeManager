   M S B A M L   `   `   `  ����E  AClientSide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ClientSide
ClientSide  5   	       ClientSide.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ClientSide     5   	     � Title$  Projects Time Manager��5   	   $	��350��6'   $	��500��64    � WindowStartupLocation$ CenterScreen=�6@   .��5	      � $��
10,0,10,10q�6   ��5
   
   �� 5       �� ImageSource$ Images/background.png��6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5#   
   �� $��0��6      headerTextStyle#��[  6    .��6J   Projects Time Manager5%      �� 5'   
   $��1��6   $��1��6!     listHeaderStyle#��[ 6.   ._�5(      ��   listHeaderTextStyle#��[ 6   .��6A   	Employees6L   5)      �� 5*   
   -   5        $��employeesComboBox��5*      $��1��6,   $��2��6<   �� 5+   
   $��1��6   $��3��6!   #��[ 6.   ._�5,      �� #��[ 6   .��6A   
Projects6K   5-      �� 5.   
   -   5        $��projectsComboBox��5.      $��1��6+   $��4��6;   �� 50   
   -   5        $��2��50      $��2��6!     addDeleteButtonStyle#��[ 6P   .��51      �� $��Images/add_button.png��6    � ToolTip 52      _� 53      .��54      �� .+�55      �� $
��Bold"�6$   Add new employee6H   56      57      59      �� 5:   
   -   5        $��2��5:      $��4��6!   #��[ 6O   .��5;      �� $��Images/add_button.png��6    5<      _� 5=      .��5>      �� .+�5?      �� $
��Bold"�6$   Add new project6G   5@      5A      5C      �� 5D   
   -   5        $��3��5D      $��2��6!   #��[ 6S   .��5E      �� $��Images/delete_button.png��6    5F      _� 5G      .��5H      �� .+�5I      �� $
��Bold"�6$   " Delete current selected employee6X   5J      5K      5M      �� 5N   
   -   5        $��3��5N      $��4��6!   #��[ 6R   .��5O      �� $��Images/delete_button.png��6    5P      _� 5Q      .��5R      �� .+�5S      �� $
��Bold"�6$   !Delete current selected project6W   5T      5U      5W      �� 5X   
   -   5        $��1��5X      $��5��6"     buttonStyle#��[ 6P    5Y      _� 5Z      .��5[      �� .+�5\      �� $
��Bold"�6$   
Add time6@   �� 5]      DBAdd time to current selected employee in current selected project.6h   5^      5_      .��5`      
Add time5b      �� 5c   
   -   5        $��1��5c      $��7��6"   $	��180��6O   #��[ 6[    5d      _� 5e      .��5f      �� .+�5g      �� $
��Bold"�6$   
Get report6B   �� 5h      PNGet report about time and amout of involved employees in all present projects.6t   5i      5j      .��5k      
Get report5m      �� 5n   
   $��1��6   $��8��6    $��10(�6-   .��6B   '%Created special for Alex Mavrishchev.5p      5q      5r      