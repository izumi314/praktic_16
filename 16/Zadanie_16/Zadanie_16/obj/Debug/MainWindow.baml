   M S B A M L   `   `   `  ����E  AZadanie_16, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Zadanie_16
Zadanie_16  5   	       Zadanie_16.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Zadanie_16     5   	     � Title$1  +Практическая работа №16��5   	   $	��600��6)   $	��800��66   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��выберите:��6   $��Center=�6)   $��0,0,10,0q�6D   �� 5      -   5         ��Name$ TaskComboBox��5      $	��200��6-   69   �� 5      -   5         ��Name$ 	RunButton��5      $��начать��6(   $��10,0,0,0q�69   $
��10,5q�6K   6Z   5      �� 5   
   $��1��6   $��10q�6"   .@�5      �� $��вход��6   .��5      �� -   5         ��Name$ InputTextBox��5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6E   " �� VerticalScrollBarVisibility$
 Auto=�6Y   5      �� 5      $��
выход��6   .��5      �� -   5        $ OutputTextBox��5       . $
 Wrap=�6F   	 �� 
IsReadOnly	 . $
 Auto=�5      ���	#FFF0F0F06>   5      �� 5      $��описание��6   .��5      �� -   5        $ DescriptionTextBox��5       . $
 Wrap=�6K   	 . $
 Auto=�5       ���	#FFF0F0F06=   5!      5"      �� 5$   
   $��2��6   .@�5%      �� .��5&      �� -   5        
 ��Name$
 StatusTextBlock��5&      $��Ready��65   5'      5(      5)      5*      