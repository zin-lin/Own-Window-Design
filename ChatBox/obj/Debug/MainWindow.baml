   M S B A M L   `   `   `  ����B  >ChatBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ChatBoxChatBox  5   	       ChatBox.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ChatBox     5   	   -   5          �Name$  	AppWindow��5	   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � Title$ Welcome Mates��5   	   $	��500��6   $	��800��6,    � 	Resources 5         ChatBox.MainWindow �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Padding �� FallbackValue ��Name   BackgroundLightBrush �� CornerRadius  ForegroundLightBrush J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   Opacity J� OpacityMask !� Visual �� ElementName � RowDefinitions K� ZIndex'  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome � ColumnDefinitions  SystemIconButton (� Stretch  Reg  FSLarge  ThemedColorBrush  MicrosoftBlue  MarvelMagento  LukeLightSaberDegobah 	 Leavy Brush 

 Red045  XoxBrush �� TextAlignment �� Orientation  WindowControlButton  WindowCloseButton��%'  '        7   7  7  7  7  7  7  7  7  7 	 7 
 7  7  7  7  �� 5   
   "  6   .�5      ��  � �� 5      �� 5      "	 �6&   .R�5      �� 
 6"   �� *OuterMarginSizeThinkness+$ 10��._�5      � .+�5   "   �� $ 
Conatainer��6)   8��   6p   �� *WindowRadiusSizeRadius+$ 10���� 5"   "   8��  6)   �� *WindowRadiusSizeRadius+$ 12�� 5$   &     5&   *   $ 0Q�6;   $	 0.3Q�6K   6[   5(   #   � 5,   &    5/   *   !� 51   .    6:   �� $ 
Conatainer�� 54   *   �� 56   .   ��6<   �� *
TitlePro+$ 42���� 5:   .   $��* �6<   .+�5B   *   � $��0��6/   $ 1��6?    .  5D   .   �� 5F   .   $
��Auto �6?   �� 5H   .   $��* �6?   �� 5J   .   $
��Auto �6?   6N   .+�5O   .   �� 8��  . ��5P   -   �� *MenuCommand+.��5R   2   �� $��images/logo/mml.png��68   5S   /   (� 5W   .   $��0��66   $��3��6F   $��4q�6Z   $ Uniform=�6e   .��5X   .   �� .+�5Z   2   �� 8�� 8�� �� 5\   4   $�M��68   8�� 6A   �� 6s   $�Y��6w   8�� 6�   �� 6�   $�M��6�   8�� 6�   �� 6�   $�A��6�   8�� 6�   �� 6/  $�T��63  8��	 6<  �� 6i  $�E��6m  8��
 6v  5_   3   �� 5a   2   $��@Companionship��6<   8�� $ Center=�6y   $��Center=�5b   <   6\   5d   /   5j   /   �� 5k   .   $��2��69   $ 
Horizontal=�6I   .+�5l   2   �� $��-��69   8�� $
��12 0q�6r   ��5m   8   �� *MinimizeCommand+�� 5o   .   $
��🗖��65   8�� $
��12 0q�6q   ��5p   8   �� *MaximizeCommand+�� 5s   2   $��X��69   8�� $
��12 0q�6r   ��5t   8   �� *CloseCommand+5x   /   5y   +   �� 5�   &   $��1��6-   
 6:   �� *InnerContentPadding+._�5�   *   �� #��z��6;   5�   '   5�   #   5�      5�      5�      5�      5�      5�         WindowChrome 5�        5�   
      CornerRadius$ 0��5�         GlassFrameThickness$ 0q�5�         ResizeBorderThickness 5�      �� *ResizeBorderThickness+   CaptionHeight 5�      �� *TitleHeight+5�      .��5�      � 
�������.+�5�   
    � -   5           �Name$  	MainFrame��5�      ��6#   �� *CurrentPage+! �� 	Converter! +   %ChatBox.ApplicationPageValueConvertor  5�      5�      