   M S B A M L   `   `   `  ����A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:School.PagesSchool.Pages  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          School.Pages.PageMarkStat   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:School.Pages     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        N� FontSize$  14(�5       N� 
FontFamily$) #/School;component/Resources/#Roboto)�5	       N� Title$ 0��5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� $��
Класс��6    
  TbMain#��[  6%   �� 5      -   5        $��CmbClass��5        CmbMain#��[ 6'   5      #  LiveCharts.Wpf.CartesianChart  5   
   $��1��6    � 	Resources 5      #  LiveCharts.Wpf.DefaultTooltip �� 
TargetType �� Property �� Value��%�  '        �� 5      "  6   .�5      ��  � ��
 � ���6H   �� 5       � ��
 �����6C   �� 5       �@ 	ShowTitle .  6B   �� 5       �@ 
ShowSeries .  6C   �� 5       � ��$ 16(�61   6>   �� 5        � ��$
 Bold"�63   6B   �� 5!       �@ CornerRadius$ 20��65   6B   �� 5"       � ��$ 40��6.   6;   �� 5#       � ��$ 40��6/   6<   �� 5$       � ��$ 0q�68   6D   5%      5&      &   LiveCharts.Wpf.Charts.Base.Chart	   Series	 5(        LiveCharts.Wpf.LineSeries    LiveCharts.Wpf.Series
   Values;  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$
 4,2,6,4 6!   64   5*      5+      5,      