   M S B A M L   `   `   `  ����	  Labs4/    )CustomControlsLibrary.CircularProgressBar   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Aav2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6L   $��50��5      $��50��6     � 	Resources  5         RotationStoryboard g� RepeatBehavior �� 
TargetName �� TargetProperty W� From	 W� To g� Duration �� 
TargetType  ProgressCircleStyle �� Property	 �� Value��%�  &	        &	 E    �� 5   
   $ Forever��60   .��5      W� $ ProgressCircle��5	      $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5
      $ 0X�5      $	 360X�6   $ 0:0:1D�6#   W� 5      $ ProgressCircle1��5      $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5      $	 -45X�5      $	 315X�6   $ 0:0:1D�6%   W� 5      $ ProgressCircle2��5      $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5      $	 -90X�5      $	 270X�6   $ 0:0:1D�6%   W� 5      $ ProgressCircle3��5      $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5      $
 -135X�5      $	 225X�6   $ 0:0:1D�6&   W� 5      $ ProgressCircle4��5      $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5      $
 -180X�5      $	 180X�6   $ 0:0:1D�6&   W� 5      $ ProgressCircle5��5      $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5      $
 -225X�5      $	 135X�6   $ 0:0:1D�6&   W� 5       $ ProgressCircle6��5!      $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5"      $
 -270X�5#      $ 90X�6   $ 0:0:1D�6%   W� 5$      $ ProgressCircle7��5%      $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5&      $
 -315X�5'      $ 45X�6   $ 0:0:1D�6%   5(      �� 5)   
   " A�6   .�5*      ��  � ��$	 15��6&   �� 5+       � ��$	 15��6'   �� 5,       � ��	 �	#FFB4B4B46%   �� 5-       � ��
	 �����6'   �� 5.       � ��$	 0��60   �� 5/       �@J�RenderTransformOrigin$	 0,2.1&�66   �� 50       � z�	 51      �� 52      54      55      57      .��59      � .+�5:   
   A� -   5        
 A�Name$
 ProgressCircle��5:      #��[ 6*   $��24,-8,11,42q�6W    � Triggers 5;      :� 5<       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5=      �� #��[  6&   5>      5@      A� 5A   
   -   5        $
 ProgressCircle1��5A      #��[ 6+   $��24,-8,11,42q�6X    5B      :� 5C      $ FrameworkElement.Loaded��6   .[�5D      �� #��[  6&   5E      5G      A� 5H   
   -   5        $
 ProgressCircle2��5H      #��[ 6+   $��24,-8,11,42q�6X    5I      :� 5J      $ FrameworkElement.Loaded��6   .[�5K      �� #��[  6&   5L      5N      A� 5O   
   -   5        $
 ProgressCircle3��5O      #��[ 6+   $��24,-8,11,42q�6X    5P      :� 5Q      $ FrameworkElement.Loaded��6   .[�5R      �� #��[  6&   5S      5U      A� 5V   
   -   5        $
 ProgressCircle4��5V      #��[ 6+   $��24,-8,11,42q�6X    5W      :� 5X      $ FrameworkElement.Loaded��6   .[�5Y      �� #��[  6&   5Z      5\      A� 5]   
   -   5        $
 ProgressCircle5��5]      #��[ 6+   $��24,-8,11,42q�6X    5^      :� 5_      $ FrameworkElement.Loaded��6   .[�5`      �� #��[  6&   5a      5c      A� 5d   
   -   5        $
 ProgressCircle6��5d      #��[ 6+   $��24,-8,11,42q�6X    5e      :� 5f      $ FrameworkElement.Loaded��6   .[�5g      �� #��[  6&   5h      5j      A� 5k   
   -   5        $
 ProgressCircle7��5k      #��[ 6+   $��24,-8,11,42q�6X    5l      :� 5m      $ FrameworkElement.Loaded��6   .[�5n      �� #��[  6&   5o      5q      5r      5s      