   M S B A M L   `   `   `  ����  WpfApplication2"    WpfApplication2.WindowBallon   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  WindowBallon��5   	   $	��215��6   $	��280��6+    � WindowStyle$ SingleBorderWindow=�5   	    � ShowInTaskbar .   � AllowsTransparency .   J� Opacity$ 1Q�5   $   
����  �$��Center=�6B   $��Center=�5   	   $��Center=�6-   $��Center=�6H    � 
ResizeMode$ NoResize=�5	   	   .��5
      �� -   5         ��Name$ 
LayoutRoot��5
      
�������$��Stretch=�68    � 	Resources 5   
      myStoryboard g� AutoReverse	 g� RepeatBehavior
 W� From	 W� To g� Duration �� 
TargetName �� TargetProperty W� EasingFunction-  'System.Windows.Media.Animation.BackEase   	Amplitude7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode	 �� To��%  &	        �� 5       . $	 Forever��6A   .��5      W� $
 1X�6"   $ 3X�6+   $ 00:00:1D�62   $ myScaleTransform��5   "   $ ScaleX�5   "    5        5      $	 0.3Q�6#   $ 	EaseInOut=�63   5      W� 5      $
 1X�6"   $ 3X�6+   $ 0:0:1D�62   $ myScaleTransform��5   "   $ ScaleY�5   "    5        5      $	 0.3Q�6#   $ 	EaseInOut=�63   5      �� 5      $ MyAnimatedBrush��6!   $ Color�5   !   $
 BlueX�5   !   $ 0:0:1D�6+   5      5       5!       � Triggers 5"   
   :� 5#       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5$      �� #��[  6"   5%      .+�5(   
   A� -   5         A�Name$ 	myEllipse��5(      $��60q�6    J� RenderTransformOrigin$ 0.5, 0.5&�61   $��50��6R   $��50��6]   ��5)      �� 5*      -   5        MyAnimatedBrush�� �� Color$ Orange��5*   ;   z�5-      �� 5.      -   5        myScaleTransform��5.   !   50      52      53      