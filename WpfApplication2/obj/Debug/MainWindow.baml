   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	        WpfApplication2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	   -   5          � Title$  
MainWindow��5	   	   $	��508��6   $	��712��6)   .��5
      � $��-37,0,-447,-170q�6    J� RenderTransformOrigin$ 0.563,0.584&�6$    � ColumnDefinitions 5   
   �� 5      $��1187* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      .+�5   
   o� -   5         o�Name$ Threads��5      $
��Left=�6    $��17��6;   $	��Top=�6G   $	��697��6_   $��38,0,0,0q�6k   $ 0.5,0.5&�6}   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.11Q�6&   T� 5      5      .@�5      m� -   5         m�Name$ 	StartMenu��5      $��Threads��6*   $��0q�6;   ���	#FFFBC4C4.@�5      m� -   5        $��Ballon��5      $��center=�6+   $��85��6H   6S   m� 5      -   5        $��Premier��5      $��center=�6,   $��85��6I   6T   5      m� 5       -   5        $ Pause��5       $��Pause/Reload��6&   $��0q�6<   $��80��6G   ���	#FFFBC4C45!      m� 5"      -   5        $ 	CloseMenu��5"      $��Close��6*   $��0q�69   ���	#FFFBC4C4.@�5#      m� -   5        $��Close all Threads��5#      $
��left=�66   $	��160��6Q   6]   m� 5$      -	   5        $��Close last Thread��5$      $
��left=�66   $	��160��6Q   6]   m� 5%      -
   5        $��Close last Ballon Thread��5%      $
��left=�6=   $	��160��6X   6d   m� 5&      -   5        $��Close last Premier Thread��5&      $
��left=�6>   $	��160��6Y   6e   5'      m� 5(      -   5        $
 Quit��5(      $
��Quit��6%   $��0q�63   ���	#FFFBC4C45)      5*      �� 5,   
   ���	#FFF4F4F5$��center=�6%   $	��105��6B   $��70,65,482,0q�6O   
���   �$	��Top=�6s   $	��635��6�   �� 5-   
   -   5         ��Name$ 	textBlock��5-      $��center=�6'   $��239,105,552,0q�6D   $
��Wrap=�6[   $"��No Running 'Ballons' Threads��6o   $	��Top=�6�   $��25��6�   $	��396��6�   ���	#FFFF2828$��16(�6�   �� 5.   
   ���	#FFF4F4F5$��center=�6%   $	��125��6B   $��70,240,482,0q�6O   
���   �$	��Top=�6t   $	��635��6�   �� 5/   
   -   5        $ textBlock_Premier��5/      $��center=�6/   $��239,285,552,0q�6L   $
��Wrap=�6c   $#��No Running 'Premiers' Threads��6w   $	��Top=�6�   $��25��6�   $	��396��6�   ���	#FFFF2828$��16(�6�   51      52      