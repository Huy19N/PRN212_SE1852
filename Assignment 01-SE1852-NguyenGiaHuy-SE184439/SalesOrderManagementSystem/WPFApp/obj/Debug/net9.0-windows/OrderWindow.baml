   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5   	       WPFApp.OrderWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFApp     5   	     � Title$  OrderWindow��5   	   $	��600��6   $	��800��6*   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� $��	Customer:��6   $��Center=�6)   �� 5      -   5         ��Name$ 
cbCustomer��5      $	��200��6+    �� DisplayMemberPath$ ContactName��67    �� SelectedValuePath$ 
CustomerID��5      $	��5,0q�66   �� 5      $��Order Date:��6   $��Center=�6+   $��20,0,0,0q�6F   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpOrderDate��5      $	��150��6.   $	��5,0q�6:   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgOrderDetails��5      $��1��6+      AutoGenerateColumns$ False��68   	   CanUserAddRows$
	 True��6T   
   Columns
 5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Product��6)      DisplayMemberPath$ ProductName��5   )      SelectedValuePath$ 	ProductID��6I      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   )      SelectedValueBinding 5   :   �� *	ProductID+5   )   0  *System.Windows.Controls.DataGridTextColumn  5      $ 
Unit Price��6%   $	 100 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	UnitPrice+6W     5       $ Quantity��6%   $	 100 6T    67   �� *
Quantity+6T     5!      $ Discount (%)��6%   $	 100 6X    6;   �� *
Discount+6X     5"      $ Total��6%      
IsReadOnly$
 True��6N   $	 100 6`    64   �� *Total+6`   5$      �� 5'   
   $ 
Horizontal=�6   $��2��6.   $��Right=�6;   $��0,10,0,0q�6W   .+�5(      �� -   5        $��
Save Order��5(      $	��100��6*   $��10q�66   6B   �� 5)      -   5        $��Cancel��5)      $	��100��6&   62   5*      5+      5,      