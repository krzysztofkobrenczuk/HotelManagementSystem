   M S B A M L   `   `   `  ����C  ?HMSWpfUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HMSWpfUIHMSWpfUI  5   	   W SHotelManagementSystem.Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:HotelManagementSystem.Domain;assembly=HotelManagementSystem.DomainHotelManagementSystem.Domain 5   	       HMSWpfUI.Rooms   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:HMSWpfUI     5   	   cDomainPclr-namespace:HotelManagementSystem.Domain;assembly=HotelManagementSystem.Domain     5   	   -   5          � Title$  Rooms��5	   	   $	��409��6   $	��596��6$    � 	Resources 5
         roomViewSource1  roomViewSource��%:   &	        &	      �� 5   
   6   S� 5   
   6   5      .��5      �  � DataContext# [ 6   .+�5   
   �� -   5         ��Name$ RoomListBox��5      $
��Left=�6'   $	��100��6B   $��	10,10,0,0q�6O   $	��Top=�6b   $	��191��6z    �� SelectedValuePath$ Capacity��6�    �� DisplayMemberPath$ Capacity��6�   ��6�   �� 6�   � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $��
10,130,0,0q�69   $	��Top=�6M    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    .+�5      �� $��Description:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��0��6a   $��Center=�6n   �� 5      -   5        	 ��Name$	 descriptionTextBox��5      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��0��6t   $��Center=�6�   $	��120��6   ��6�   �� *Description+
 �� Mode$
 TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6   5      � 5   
   -   5        $ grid2��5      $
��Left=�6   $��	1,162,0,0q�69   $	��Top=�6L    5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5       �� 5!      $
��Auto �6    .+�5#      �� $��Price Per Day:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��0��6c   $��Center=�6p   �� 5$      -   5        $	 pricePerDayTextBox��5$      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��0��6t   $��Center=�6�   $	��120��6   ��6�   �� *PricePerDay+$
 TwoWay=� .  . 6   5%      � 5&   
   -   5        $ grid3��5&      $
��Left=�6   $��
25,194,0,0q�69   $	��Top=�6M    5'      �� 5(      $
��Auto �6#   �� 5)      $
��Auto �6#    5+      �� 5,      $
��Auto �6    .+�5.      �� $��	Capacity:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��0��6^   $��Center=�6k   �� 5/      -   5        $	 capacityTextBox��5/      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��0��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
Capacity+$
 TwoWay=� .  . 6�   50      52      53      