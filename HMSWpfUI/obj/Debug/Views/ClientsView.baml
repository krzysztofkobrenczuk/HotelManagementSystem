   M S B A M L   `   `   `  ����C  ?HMSWpfUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HMSWpfUI.ViewsHMSWpfUI.Views  5      W SHotelManagementSystem.Domain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:HotelManagementSystem.Domain;assembly=HotelManagementSystem.DomainHotelManagementSystem.Domain 5           HMSWpfUI.Views.ClientsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:HMSWpfUI.Views     5      cDomainPclr-namespace:HotelManagementSystem.Domain;assembly=HotelManagementSystem.Domain     5      -   5        $��456.14��5	   #     � 	Resources  5
         clientViewSource1  clientViewSource��%:   &	        &	      �� 5   
   6   S� 5   
   6   5      .��5      �  � DataContext# [ 6   $��	0,0,-58,0q�6;   .+�5   
   �� -   5         ��Name$ clientListBox��5      $
��Left=�6)   $	��268��6D   $	��Top=�6Q   $	��274��6i    �� SelectedValuePath$ 	FirstName��6u    �� DisplayMemberPath$ 	FirstName��6�   ��6�   �� 6�   �� 5   
   -   5         ��Name$ saveBtn��5      $
��Save��6"   $
��Left=�61   $��295,270,0,0q�6L   $	��Top=�6a   $��75��6y   6�   � 5   
   -   5         �Name$ grid1��5      # [  6   $
��Left=�6O   $��
302,21,0,0q�6j   $	��Top=�6~    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    .+�5      �� $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��0��6`   $��Center=�6m   �� 5      -   5        	 ��Name$	 firstNameTextBox��5      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��0��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+
 �� Mode$
 TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 63  5      �� 5   
   -   5        $ newBtn��5      $��Add New��6!   $
��Left=�63   $��321,208,0,0q�6N   $	��Top=�6c   $��75��6{   6�   5      5      