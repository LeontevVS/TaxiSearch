   M S B A M L   `   `   `  ����E  ATaxiSearch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TaxiSearch
TaxiSearch  5   	       TaxiSearch.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TaxiSearch     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��31 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   $��Center=�6;   .+�5      �� -   5         ��Name$ 
Btn_Create��5      $��Создать��6)   $��	15,3,15,3q�6;   6N   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridOrders��5      $��0��6(      AutoGenerateColumns .     
IsReadOnly . ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Дата��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      `� 5       �� StringFormat$ {0}.{1}.{2}��6'   .1�5      ��  �� Path$ Date.Day�6&   �� 5      $ 
Date.Month�6&   �� 5      $ 	Date.Year�6&   5      5         5!      $	 Гос. номер��6%   $
 * 6c    69   �� *Taxi.Car.LicensePlate+6c     5"      $	 Водитель��6%   $
 * 6\    67   �� *Taxi.Driver.Name+6\     5#      $	 Марка авто��6%   $
 * 6\    69   �� *Taxi.Car.Brand+6\     5$      $	 Модель авто��6%   $
 * 6]    6:   �� *Taxi.Car.Model+6]     5%      $	 Отправление��6%   $
 * 6Z    6:   �� *AddressFrom+6Z     5&      $	 Назначение��6%   $
 * 6W    69   �� *	AddressTo+6W   5(      5)      5*      