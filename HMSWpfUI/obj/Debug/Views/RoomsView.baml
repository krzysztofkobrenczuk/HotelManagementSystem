   M S B A M L   `   `   `  ����C  ?HMSWpfUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HMSWpfUI.ViewsHMSWpfUI.Views  5      W SHotelManagementSystem.Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:HotelManagementSystem.Domain;assembly=HotelManagementSystem.DomainHotelManagementSystem.Domain 5          HMSWpfUI.Views.RoomsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:HMSWpfUI.Views     5      cDomainPclr-namespace:HotelManagementSystem.Domain;assembly=HotelManagementSystem.Domain     5      -   5        $	��300��5      $	��503��6H     � 	Resources  5	         roomViewSource1  roomViewSource��%:   &	        &	      �� 5
   
   6   S� 5   
   6   5      .��5      �  � DataContext# [ 6   $��	0,0,-33,0q�69    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ RoomListBox��5      $
��Left=�6'   $	��261��6B   $	��Top=�6O   $	��300��6g    �� SelectedValuePath$ Capacity��6s    �� DisplayMemberPath$ Capacity��6�   ��6�   �� 6�   �� 5   
   -   5         ��Name$ button��5      $	��Add��6!   $
��Left=�6/   $��
10,266,0,0q�6J   $	��Top=�6^   $��50��6v   $��24��6�   �� 5   
   -   5        $ button1��5      $
��Edit��6"   $
��Left=�61   $��
65,266,0,0q�6L   $	��Top=�6`   $��65��6x   $��24��6�   �� 5   
   -   5        $ button2��5      $��Remove��6"   $
��Left=�63   $��135,266,0,0q�6N   $	��Top=�6c   $��66��6{   $��24��6�   � 5   
   -   5         �Name$ grid1��5      # [  6   $
��Left=�6M   $��
332,36,0,0q�6h   $	��Top=�6|    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    .+�5      �� $��	Capacity:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��0��6^   $��Center=�6k   �� 5      -   5        	 ��Name$	 capacityTextBox��5      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��0��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
Capacity+
 �� Mode$
 TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 60  5       � 5!   
   -   5        $ grid2��5!      # [  6   $
��Left=�6M   $��
317,72,0,0q�6h   $	��Top=�6|    5"      �� 5#      $
��Auto �6#   �� 5$      $
��Auto �6#    5&      �� 5'      $
��Auto �6    .+�5)      �� $��Description:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��0��6a   $��Center=�6n   �� 5*      -	   5        $	 descriptionTextBox��5*      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��0��6t   $��Center=�6�   $	��120��6   ��6�   �� *Description+$
 TwoWay=� .  . 6  5+      � 5,   
   -
   5        $ grid3��5,      # [  6   $
��Left=�6M   $��308,110,0,0q�6h   $	��Top=�6}    5-      �� 5.      $
��Auto �6#   �� 5/      $
��Auto �6#    51      �� 52      $
��Auto �6    .+�54      �� $��Price Per Day:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��0��6c   $��Center=�6p   �� 55      -   5        $	 pricePerDayTextBox��55      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��0��6t   $��Center=�6�   $	��120��6   ��6�   �� *PricePerDay+$
 TwoWay=� .  . 6  56      �� 57   
   -   5        $ saveBtn��57      $
��Save��6"   $
��Left=�61   $��206,266,0,0q�6L   $	��Top=�6a   $��65��6y   $��24��6�   6�   59      5:      