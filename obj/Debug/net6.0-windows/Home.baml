   M S B A M L   `   `   `  ����I  ECRUDInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CRUDInterfacesCRUDInterfaces  5   	       CRUDInterfaces.Home   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   (localclr-namespace:CRUDInterfaces  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�5   	    � Title$
 Home��5   	   $	��600��6   $	��850��6#      MaterialDesignBody#���   6/    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   	Direction   Opacity   Color �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� 5   
   " ��6   .�5      ��  � �� �#2596be6+   �� 5       � ��
 �����6+   �� 5       � ��$ 10q�6(   �� 5       � ��$ 0,25,0,5q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ buttonBorder��5      #��z��5   !   $	��180��5      $��40��5      $	 5��5      $��1q�5      
�������
 5        5   "   $ 3Q�63   $	 270Q�6C   $	 0.5Q�6S   $ Black��6a   ._�5       �� $��Center=�6/   $��Center=�6L   5!       5"      P� 5#       �@J�IsMouseOver$
 True��6=   . �5$   "   �� $ buttonBorder��6)    � �� �#307bae6Y   5%      5'      5)      5*      5+      .��5,      � ���#383434 � ColumnDefinitions 5-   
   �� 5.      $
��Auto �6   �� 5/      $��* �6   .+�53   
   '  !MaterialDesignThemes.Wpf.PopupBox  $	��Top=�6"   $
��Left=�6:   $��0,0,20,0q�6U      PlacementMode$ BottomAndAlignLeftEdges=�6g      	StaysOpen$ False��6�   $��25��6�      PopupContent. 54      �� $��Right=�6   .+�55      �� $��	16 10 0 6q�6    �� Orientation$ 
Horizontal=�60   57      �� 58      -   5         ��Name$ btnCerrarSesion��58       � ToolTip$ Cerrar Sesion��62   $��0 8 0 0q�6J   $��Cerrar Sesion��6[   6s   �� 59      -   5        $ btn_exit��59      $ Cerrar Aplicacion��6+   $��Cerrar Aplicacion��6G   6c   5:      5;      ]� 5>   
   -   5         ]�Name$ menuDockPanel��5>      $��0��6+   $	��228��6;   .+�5?      �� $��5q�6   .+�5@      �� -   5        $	��Top=�5@      #��[B��6G   .��5A      ]� $��Center=�6    .+�5B      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6'   $��15��63   $��32��6?      
Foreground
 �����6J   �� 5C      $
��Home��6$   $	��Top=�60   $��Center=�6E   $
��Left=�6`   $
��Bold"�6{   5D      5E      �� 5G      -   5        $	��Top=�5G      #��[B��6M   .��5H      ]� $��Center=�6    .+�5I        $
 List=�6'   $��15��63   $��32��6?   
 �����6J   �� 5J      $��	Productos��6$   $	��Top=�65   $��Center=�6J   $
��Left=�6e   $
��Bold"�6�   5K      5L      �� 5M      -   5        $	��Top=�5M      #��[B��6R   .��5N      ]� $��Center=�6    .+�5O        $	 Add=�6'   $��15��62   $��32��6>   
 �����6I   �� 5P      $��Insertar Productos��6$   $	��Top=�6>   $��Center=�6S   $
��Left=�6n   $
��Bold"�6�   5Q      5R      �� 5T      -   5        $	��Top=�5T      #��[B��6R   .��5U      ]� $��Center=�6    .+�5V        $ Eraser=�6'   $��15��65   $��32��6A   
 �����6L   �� 5W      $��Borrar Productos��6$   $	��Top=�6<   $��Center=�6Q   $
��Left=�6l   $
��Bold"�6�   5X      5Y      �� 5[      -   5        $	��Top=�5[      #��[B��6R   .��5\      ]� $��Center=�6    .+�5]        $ Refresh=�6'   $��15��66   $��32��6B   
 �����6M   �� 5^      $��Actualizar Productos��6$   $	��Top=�6@   $��Center=�6U   $
��Left=�6p   $
��Bold"�6�   5_      5`      �� 5b      -	   5        $	��Top=�5b      #��[B��6S   .��5c      ]� $��Center=�6    .+�5d        $
 Star=�6'   $��15��63   $��32��6?   
 �����6J   �� 5e      $��Top + Vendidos��6$   $	��Top=�6:   $��Center=�6O   $
��Left=�6j   $
��Bold"�6�   5f      5g      �� 5i      -
   5        $	��Top=�5i      #��[B��6X   .��5j      ]� $��Center=�6    .+�5k        $ Dollar=�6'   $��15��65   $��32��6A   
 �����6L   �� 5l      $��Top + Caros��6$   $	��Top=�67   $��Center=�6L   $
��Left=�6g   $
��Bold"�6�   5m      5n      �� 5p      -   5        $	��Top=�5p      #��[B��6T   .��5q      ]� $��Center=�6    .+�5r        $ Cancel=�6'   $��15��65   $��32��6A   
 �����6L   �� 5s      $��Productos sin Stock��6$   $	��Top=�6?   $��Center=�6T   $
��Left=�6o   $
��Bold"�6�   5t      5u      5w      5x       � 5|   
   -   5          �Name$ contentFrame��5|      $��1��6&     � NavigationUIVisibility$ Hidden=�66   5~      5      