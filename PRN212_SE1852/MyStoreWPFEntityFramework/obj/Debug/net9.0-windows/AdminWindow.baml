   M S B A M L   `   `   `  ����T  PMyStoreWPFEntityFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MyStoreWPFEntityFrameworkMyStoreWPFEntityFramework  5   	   +    %MyStoreWPFEntityFramework.AdminWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:MyStoreWPFEntityFramework     5   	     � Title$  AdminWindow��5   	   $	��450��6   $	��800��6*   .��5	      ]� .+�5
   
   � $	��Top=�6   $��50��6)   
����� �.+�5      �� $��Admin System ��6   $��19(�6,   5      �� 5   
   $��Bottom=�6   $��30��6-   
����+��.+�5      �� $��Designed by Huy��6   5      R� 5   
   -   5         R�Name$ 
tvCategory��5   5   $
��Left=�6   $	��250��6)   
����� �$��10,10,611,56q�6[   ]� 5   
   
������.+�5      �� -   5         ��Name$ 	lvProduct��5      $	��Top=�6*   $	��200��6?   
������� �� View 5      �� 5      .P�5      �� $��Code Product��6)    �� DisplayMemberBinding 5      �� *	ProductID+�� 5      $��Name Product��6)    5      �� *ProductName+�� 5      $��Quantity��6)    5      �� *UnitsInStock+�� 5      $��Price��6)    5      �� *	UnitPrice+5      5      � 5       
�������6+   5"      5#      5$      