   M S B A M L   `   `   `  ����E  ATaxiSearch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TaxiSearch
TaxiSearch  5   	   !    TaxiSearch.TaxiChoiceWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TaxiSearch     5   	     � Title$  TaxiChoiceWindow��5   	   $	��450��6"   $	��600��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��31 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   $��Center=�6;   .+�5      �� -   5         ��Name$ btnClose��5      $��Закрыть��6'   $��0,3,15,3q�69   6K   �� 5      -   5        $ 	btnChoice��5      $��Выбрать��6(   $��	15,3,15,3q�6:   6M   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DGridTaxis��5      $��0��6'      AutoGenerateColumns .     
IsReadOnly . ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Гос. номер��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Car.LicensePlate+6^     5      $	 
Марка��6%   $
 * 6R    64   �� *	Car.Brand+6R     5      $	 Модель��6%   $
 * 6S    65   �� *	Car.Model+6S     5      $	 Водитель��6%   $
 * 6W    67   �� *Driver.Name+6W   5      5      5       