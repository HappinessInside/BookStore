   M S B A M L   `   `   `  ����I  EImplementation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ImplementationImplementation  5   	       Implementation.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Implementation     5   	     � Title$  
MainWindow��5   	    � Icon$ Icon.png��6    � 
ResizeMode$ NoResize=�6,   $	��570��6B   $	��792��6O   .��5	      � $��0,0,2,0q�6   .+�5
   
   �� -   5         ��Name$ 
Background��5
      $��Background.jpg��6$   $��Center=�6<   $	��606��6Y   $	��Top=�6f   $	��784��6~   $��	0,0,0,-72q�6�   $��2��6�   �� 5   
   -   5         ��Name$ label��5      $:��4Enter the parameters that the system will work with.��6   $
��Left=�6^   $	��Top=�6y   $��172,114,0,0q�6�   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   
���  ��$	��504��6�   $��2��6�   �� 5   
   -   5        $ label1��5      $/��)The number of days the bookstore is work:��6    $
��Left=�6T   $	��Top=�6o   $��
19,147,0,0q�6�   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   
�������6�   �� 5   
   -   5         ��Name$ numberOfDays��5      $
��Left=�6)   $	��Top=�6D   $��97��6\   $��431,151,0,0q�6g   $��31��6|   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   .@�5      �� 106   �� 5      156   �� 5      206   �� 5      256   �� 5      306   5      �� 5   
   -   5         ��Name$ Furtherbutton��5      $��Further��6(   $
��Left=�6:   $	��Top=�6U   $	��123��6m   $��337,484,0,0q�6y   $��33��6�   $��18(�6�   $
��Bold"�6�   $��Italic$�6�   
���  ��6�   �� 5   
   -   5        $ label2��5      $B��<Make a request to the publisher when the store has less than��6    $
��Left=�6g   $	��Top=�6�   $��41��6�   $	��584��6�   $��
10,187,0,0q�6�   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   
�������6�   �� 5   
   -   5        $ numberOfBooks��5      $
��Left=�6*   $	��Top=�6E   $��97��6]   $��594,187,0,0q�6h   $��31��6}    J� RenderTransformOrigin$ 0.041,0.774&�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   .@�5      �� 36   �� 5      46   �� 5      56   5      �� 5   
   -   5        $ label3��5      $��copies of the book��6    $
��Left=�6=   $	��Top=�6X   $��577,218,0,0q�6p   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   
�������6�   �� 5   
   -	   5        $ label4��5      $?��9Publishing houses with which the bookstore has partnered:��6    $
��Left=�6d   $	��Top=�6   $��
70,338,0,0q�6�   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   
�������6�   �� 5   
   -
   5         ��Name$ sciencePublisher��5      $��Science Publisher��6-   $
��Left=�6I   $	��Top=�6d   $
��Bold"�6|   $��Italic$�6�   
��� � �$��301,452,0,0q�6�   $��20(�6�   �� 5   
   -   5        $ publishingHouseDrofa��5      $��Publishing house Drofa��61   $
��Left=�6R   $	��Top=�6m   $
��Bold"�6�   $��Italic$�6�   $��20(�6�   
��� � �$��300,389,0,0q�6�   �� 5    
   -   5        $ labirintPressPublisher��5       $��Labirint press publisher��63   $
��Left=�6V   $	��Top=�6q   
��� � �$
��Bold"�6�   $��Italic$�6�   $��301,425,0,0q�6�   $��20(�6�   �� 5!   
   -   5        $ label5��5!      $ ��The usual retail margin is��6    $
��Left=�6E   $	��Top=�6`   $
��Bold"�6x   $��Italic$�6�   $��20(�6�   
�������$��
33,239,0,0q�6�   �� 5"   
   -   5        $ label6��5"      $��percent��6    $
��Left=�62   $	��Top=�6M   $
��Bold"�6e   $��Italic$�6w   $��20(�6�   
�������$��391,239,0,0q�6�   �� 5#   
   -   5        $ usualRetailMargin��5#      $
��Left=�6.   $	��Top=�6I   $��97��6a   $��289,243,0,0q�6l   $��33��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   .@�5$      �� 56   �� 5%      106   5&      �� 5'   
   -   5        $ label7��5'      $%��Retail mark-up for new books is��6    $
��Left=�6J   $	��Top=�6e   $
��Bold"�6}   $��Italic$�6�   $��20(�6�   
�������$��
33,292,0,0q�6�   �� 5(   
   -   5        $ label8��5(      $��percent��6    $
��Left=�62   $	��Top=�6M   $
��Bold"�6e   $��Italic$�6w   
�������$ 4.346,1.038&�6�   $��426,292,0,0q�6�   $��20(�6�   �� 5)   
   -   5        $ retailMarginForNewBooks��5)      $
��Left=�64   $	��Top=�6O   $��97��6g   $��324,296,0,0q�6r   $��33��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   .@�5*      �� 156   �� 5+      206   5,      �� 5-   
   -   5        $ label9��5-      $��Publishing house Drofa��6    $
��Left=�6A   $	��Top=�6\   $
��Bold"�6t   $��Italic$�6�   $��20(�6�   $��311,383,0,0q�6�   �� 5.   
   -   5        $ label10��5.      $��Labirint press publisher��6!   $
��Left=�6D   $	��Top=�6_   $
��Bold"�6w   $��Italic$�6�   $��320,419,0,0q�6�   $��20(�6�   �� 5/   
   -   5        $ label11��5/      $��Science Publisher��6!   $
��Left=�6=   $	��Top=�6X   $
��Bold"�6p   $��Italic$�6�   $��20(�6�   $��320,448,0,0q�6�   51      52      