   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:School.PagesSchool.Pages  5          School.Pages.PageMain   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:School.Pages     5        N� FontSize$  14(�5       N� Title$ PageMain��5	       N� 
FontFamily$) #/School;component/Resources/#Roboto)�6   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Сортировка��6    
  TbMain#��[  6*   �� 5      -   5        $��CmdClass��5   8     CmbMain#��[ 6   $��70��6H   5      5      �� 5   
   -   5        $��BtnBack��5      $��Все��5        BtnBack#��[ 6   $��50��6@   5       &   System.Windows.Controls.DataGrid  5   
   -   5        $��DG��5      $��1��6    
 DGMain#��[ 6*      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Класс��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Class.Number+  5      $ Фамилия��6%   $ * 66    6@   �� *
MiddleName+  5      $ Имя��6%   $ * 62    6<   �� *	FirstName+	 � 	Resources	 5      )  #System.Windows.Controls.DataGridRow
 �� 
TargetType��%E   '        �� 5      "
  6   .�5       -   5        5!      5"      5#      �� 5%   
   $ 
Horizontal=�6   $��2��6.   $��Center=�5&      .+�5'      �� -   5        $��BtnAdd��5'        BtnMain#��[ 6#   $��Добавить��5(      ���#9f95)      �� 5*      -   5        $��	BtnDelete��5*      ���#c66$��Удалить��68   #��[ 5+      5,      5-      5.      