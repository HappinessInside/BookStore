   M S B A M L   `   `   `  ����I  EImplementation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ImplementationImplementation  5   	       Implementation.Order   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Implementation     5   	     � Title$  Order��5   	    � Icon$ Icon.png��6    � 
ResizeMode$ NoResize=�6'   $	��570��6=   $	��792��6J   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ BackgroundWithBook��5      $��Book.jpg��6,   $��Center=�6>   $	��560��6[   $	��Top=�6h   $	��817��6�   $��1,0,-32,-18q�6�   $��2��6�   6�   �� 5   
   -   5         ��Name$ label��5      $��Order��6   $��Center=�6/   $	��Top=�6L   $
��Bold"�6d   $��Italic$�6v   $��20(�6�   
���  ��$��348,-2,362,0q�6�   $��34��6�   $��76��6�   �� 5   
   -   5         ��Name$ rangeOfBookstore��5      $ �� HorizontalScrollBarVisibility$ Visible=�6,    �� 
IsReadOnly . $
��Left=�6f   $	��147��6�   $	��Top=�6�   $	��402��6�   $��
374,56,0,0q�6�   #��� /�6�   "	 �� VerticalScrollBarVisibility$	 Visible=�6   �� 5   
   -   5        $ label1��5      $#��Range of books for reference:��6    $
��Left=�6H   $	��Top=�6c   $��
488,25,0,0q�6{   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   $��31��6�   $	��229��6�   �� 5   
   -   5        $ surnameOfTheCuctomer��5      $
��Left=�60   $��30��6K   
 �� TextWrapping$

 Wrap=�6W   $	��Top=�6l   $	��337��6�   $��	23,51,0,0q�6�   �� 5   
   -   5        $ label2��5      $��Surname of the customer:��6    $
��Left=�6C   $	��Top=�6^   $��	23,25,0,0q�6v   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   $��31��6�   $	��202��6�   �� 5   
   -   5        $ phoneNumber��5      $
��Left=�6'   $��33��6B   $

 Wrap=�6N   $	��Top=�6b   $	��337��6z   $��
23,106,0,0q�6�   �� 5   
   -   5        $ label3��5      $��Customer's phone number:��6    $
��Left=�6C   $	��Top=�6^    J� RenderTransformOrigin$ 1.247,4.154&�6v   $��	23,81,0,0q�6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   $��31��6�   $	��210��6�   �� 5   
   -	   5        $ label4��5      $��Customer's email adress:��6    $
��Left=�6C   $	��Top=�6^   $
��Bold"�6v   $��Italic$�6�   $��
23,139,0,0q�6�   $��16(�6�   $��31��6�   $	��196��6�   �� 5   
   -
   5        $ emailAdress��5      $
��Left=�6'   $��33��6B   $

 Wrap=�6N   $	��Top=�6b   $	��337��6z   $��
23,170,0,0q�6�   �� 5   
   -   5        $ label5��5      $��Ordered books:��6    $
��Left=�69   $	��Top=�6T   $
��Bold"�6l   $��Italic$�6~   $��348,208,0,0q�6�   $��18(�6�   $��31��6�   $	��143��6�   �� 5   
   -   5        $ author0��5      $
��Left=�6#   $��25��6>   $

 Wrap=�6J   $	��Top=�6_   $	��210��6w   $��	9,261,0,0q�6�   �� 5   
   -   5        $ label6��5      $��Author��6    $
��Left=�61   $	��Top=�6L   $��
10,233,0,0q�6d   $
��Bold"�6x   $��Italic$�6�   $ 0.388,0.423&�6�   $��16(�6�   $��31��6�   $��62��6�   �� 5   
   -   5        $ label7��5      $*��$Name of the book or the word ''new''��6    $
��Left=�6O   $	��Top=�6j   $��288,233,0,0q�6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   $��31��6�   $	��289��6�   �� 5   
   -   5        $ name0��5      $
��Left=�6!   $��25��6<   $

 Wrap=�6H   $	��Top=�6]   $	��376��6u   $��242,261,0,0q�6�   �� 5   
   -   5        $ label8��5      $��Number of copies��6    $
��Left=�6;   $	��Top=�6V   $��623,233,0,0q�6n   $ 6.848,10.154&�6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   �� 5   
   -   5         ��Name$ numberOfCopies0��5      $
��Left=�6,   $	��Top=�6G   $	��120��6_   $��634,261,0,0q�6k   $��25��6�   .@�5      �� 16   �� 5       26   �� 5!      36   �� 5"      46   �� 5#      56   �� 5$      66   �� 5%      76   �� 5&      86   �� 5'      96   �� 5(      106   5)      �� 5*   
   -   5         ��Name$ addTheBookButton��5*      $��Add the book��6+   $
��Left=�6B   $	��Top=�6]   $	��154��6u   $��611,452,0,0q�6�   $��31��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   6�   �� 5+   
   -   5        $ placeTheOrder��5+      $��Place the order��6D   $
��Left=�6^   $	��Top=�6y   $	��154��6�   $��611,488,0,0q�6�   $��31��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   �� 5,   
   -   5        $ author1��5,      $y�Hidden=�6#   $
��Left=�67   $��25��6R   $

 Wrap=�6^   $	��Top=�6s   $	��210��6�   $��	9,300,0,0q�6�   �� 5-   
   -   5        $ author2��5-      $y�Hidden=�6#   $
��Left=�67   $��25��6R   $

 Wrap=�6^   $	��Top=�6s   $	��210��6�   $��
10,343,0,0q�6�   �� 5.   
   -   5        $ author3��5.      $y�Hidden=�6#   $
��Left=�67   $��25��6R   $

 Wrap=�6^   $	��Top=�6s   $	��210��6�   $��	9,383,0,0q�6�   �� 5/   
   -   5        $ author4��5/      $y�Hidden=�6#   $
��Left=�67   $��25��6R   $

 Wrap=�6^   $	��Top=�6s   $	��210��6�   $��
10,422,0,0q�6�   �� 50   
   -   5        $ name1��50      $y�Hidden=�6!   $
��Left=�65   $��25��6P   $

 Wrap=�6\   $	��Top=�6q   $	��376��6�   $��242,300,0,0q�6�   �� 51   
   -   5        $ name2��51      $y�Hidden=�6!   $
��Left=�65   $��25��6P   $

 Wrap=�6\   $	��Top=�6q   $	��376��6�   $��242,343,0,0q�6�   �� 52   
   -   5        $ name3��52      $y�Hidden=�6!   $
��Left=�65   $��25��6P   $

 Wrap=�6\   $	��Top=�6q   $	��376��6�   $��242,383,0,0q�6�   �� 53   
   -   5        $ name4��53      $y�Hidden=�6!   $
��Left=�65   $��25��6P   $

 Wrap=�6\   $	��Top=�6q   $	��376��6�   $��242,422,0,0q�6�   �� 54   
   -   5        $ numberOfCopies1��54      $y�Hidden=�6,   $
��Left=�6@   $	��Top=�6[   $	��120��6s   $��634,300,0,0q�6   $��25��6�   .@�55      �� �� 6   $�1��6   6)   �� 56      �� 6   $�2��6   6)   �� 57      �� 6   $�3��6   6)   �� 58      �� 6   $�4��6   6)   �� 59      �� 6   $�5��6   6)   �� 5:      �� 6   $�6��6   6)   �� 5;      �� 6   $�7��6   6)   �� 5<      �� 6   $�8��6   6)   �� 5=      �� 6   $�9��6   6)   �� 5>      �� 6   $�10��6   6*   5?      �� 5@   
   -   5        $ numberOfCopies2��5@      $y�Hidden=�6,   $
��Left=�6@   $	��Top=�6[   $	��120��6s   $��634,343,0,0q�6   $��25��6�   .@�5A      �� �� 6   $�1��6   6)   �� 5B      �� 6   $�2��6   6)   �� 5C      �� 6   $�3��6   6)   �� 5D      �� 6   $�4��6   6)   �� 5E      �� 6   $�5��6   6)   �� 5F      �� 6   $�6��6   6)   �� 5G      �� 6   $�7��6   6)   �� 5H      �� 6   $�8��6   6)   �� 5I      �� 6   $�9��6   6)   �� 5J      �� 6   $�10��6   6*   5K      �� 5L   
   -   5        $ numberOfCopies3��5L      $y�Hidden=�6,   $
��Left=�6@   $	��Top=�6[   $	��120��6s   $��634,383,0,0q�6   $��25��6�   .@�5M      �� �� 6   $�1��6   6)   �� 5N      �� 6   $�2��6   6)   �� 5O      �� 6   $�3��6   6)   �� 5P      �� 6   $�4��6   6)   �� 5Q      �� 6   $�5��6   6)   �� 5R      �� 6   $�6��6   6)   �� 5S      �� 6   $�7��6   6)   �� 5T      �� 6   $�8��6   6)   �� 5U      �� 6   $�9��6   6)   �� 5V      �� 6   $�10��6   6*   5W      �� 5X   
   -   5        $ numberOfCopies4��5X      $y�Hidden=�6,   $
��Left=�6@   $	��Top=�6[   $	��120��6s   $��634,422,0,0q�6   $��25��6�   .@�5Y      �� �� 6   $�1��6   6)   �� 5Z      �� 6   $�2��6   6)   �� 5[      �� 6   $�3��6   6)   �� 5\      �� 6   $�4��6   6)   �� 5]      �� 6   $�5��6   6)   �� 5^      �� 6   $�6��6   6)   �� 5_      �� 6   $�7��6   6)   �� 5`      �� 6   $�8��6   6)   �� 5a      �� 6   $�9��6   6)   �� 5b      �� 6   $�10��6   6*   5c      5f      5g      