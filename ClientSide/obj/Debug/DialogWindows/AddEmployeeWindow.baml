   M S B A M L   `   `   `  ����E  AClientSide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ClientSide
ClientSide  5   	   0    *ClientSide.DialogWindows.AddEmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ClientSide     5   	   -   5          � Title$  AddEmployee��5   	    � SizeToContent$ WidthAndHeight=�5	   	    � WindowStartupLocation$ CenterScreen=�6(   .��5      � $��15q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��/Images/add_button.png��6   $��32��60   $��32��6;   $��2��6G   $
��20,0q�6X   �� 5   
   $��1��6   $��0��6    .��6-   First name of new employee:6J   �� 5   
   -   5        $��Employee_Name��5      $��1��6'   $��1��67   $	��250��6D   .��6�   Ivan6�   �� 5   
   $��1��6   $��2��6    .��6-   
Last name:69   �� 5   
   -   5        $��Employee_Last_Name��5      $��1��6,   $��3��6<   $	��250��6I   .��6�   Ivanov6�   � 5   
   $��4��6   $��2��6!   $��Right=�65   $��0,15,0,0q�6Q   .+�5       �� -   5        $��btnDialogOk��5    &    �� 	IsDefault . $��60��6S   $��0,0,10,0q�6a   .��6s   _Ok6x   �� 5!       �� IsCancel . $��60��6%   .��63   	_Cancel6<   5"      5#      5$      