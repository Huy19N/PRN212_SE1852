   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5   	       WPFApp.ProductWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFApp     5   	     � Title$  ProductWindow��5   	   $	��450��6   $	��800��6,   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� -   5         ��Name$ 	txtSearch��5      $	��200��6)   $��0,0,10,0q�65   �� 5      -   5        $��Search��5      6&   �� 5      -   5        $	��Add��5      $��10,0,0,0q�6#   65   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgProducts��5      $��1��6'      AutoGenerateColumns$ False��64      
IsReadOnly$
 True��6P      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *	ProductID+6O     5      $
 Name��6%   $	 * 6S   
 63   �� *ProductName+6S     5      $ Category��6%   $		 150 6X   
 67   �� *CategoryName+6X     5      $ 
Unit Price��6%   $		 100 6W   
 69   �� *	UnitPrice+6W     5      $ Stock��6%   $		 100 6U   
 64   �� *UnitsInStock+6U   5      �� 5"   
   $ 
Horizontal=�6   $��Bottom=�6.   $��Right=�6I   $��0,10,0,0q�6e   .+�5#      �� -   5        $
��Edit��5#      $	��100��6$   $��10q�60   6<   �� 5$      -   5        $��Delete��5$      $	��100��6&   $��10q�62   6>   �� 5%      -   5        $��Close��5%      $	��100��6%   $��10q�61   6=   5&      5'      5(      