   M S B A M L   `   `   `  ����I  EImplementation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ImplementationImplementation  5   	   !    Implementation.WorkOfSystem   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Implementation     5   	   -   5          � Title$  WorkOfSystem��5   	    � Icon$ Icon.png��6    � 
ResizeMode$ NoResize=�6.   $	��570��6D   $	��792��6Q   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��257* �6   �� 5      $��5* �6   .+�5   
   �� -   5         ��Name$ Background1��5      $��BookStore.png��6%   $��Center=�6<   $	��571��6Y   $	��Top=�6f   $	��817��6~   $��-15,0,-16,-29q�6�   $��2��6�   6�   �� 5   
   -   5         ��Name$ label��5      $'��!day of work of the bookstore from��6   $
��Left=�6K   $	��Top=�6f   $��	57,47,0,0q�6~   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   -   5         ��Name$ 
currentDay��5       �� 
IsReadOnly . $
��Left=�68   $��22��6S    �� TextWrapping$
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $��52��6�   $��5,53,0,0q�6�   	 J� RenderTransformOrigin$	 0.704,4.076&�6�   �� 5   
   -   5        $ numberOfDays��5       . $
��Left=�6:   $��23��6U   $
 Wrap=�6a   $��TextBox��6u   $	��Top=�6�   $��54��6�   $��
328,53,0,0q�6�   �� 5   
   -   5        $ label1��5      $��days.��6    $
��Left=�60   $	��Top=�6K   $��
387,47,0,0q�6c   $
��Bold"�6w   $��Italic$�6�   $��16(�6�   �� 5   
   -   5        $ label2��5      $6��0The system of control of the range of bookstore.��6    $
��Left=�6[   $	��Top=�6v   $��	162,0,0,0q�6�   $
��Bold"�6�   $��Italic$�6�   $��20(�6�   
���  ��6�   �� 5   
   $
��Left=�6   $	��164��6/   $	��Top=�6<   $	��199��6T   $��510,200,0,0q�6`   �� 5   
   -   5        $ label3��5      $��Placing customer's order��6    $
��Left=�6C   $	��Top=�6^   $��510,205,0,0q�6v   $	��220��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   �� 5   
   -	   5        $ label4��5      $��The order made:��6    $
��Left=�6:   $	��Top=�6U   $��Italic$�6m   $��14(�6�   $��550,225,0,0q�6�   $
��Bold"�6�   �� 5   
   -
   5        
 ��Name$
 orderInStore��5      $��in store��6B   $
��Left=�6U   $	��Top=�6p   $��76��6�   $��570,260,0,0q�6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   $	 
1.04,0.491&�6�   �� 5   
   -   5        $
 orderByPhone��5      $��by phone��6B   $
��Left=�6U   $	��Top=�6p   $��75��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   $��570,290,0,0q�6�   $	 0.123,0.422&�6�   �� 5   
   -   5        $
 orderByEmail��5      $��by email��6'   $
��Left=�6U   $	��Top=�6p   $��75��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   $��570,319,0,0q�6�   $	 0.557,-1.759&�6�   �� 5   
   -   5        $ rangeOfBookstore��5       . $
��Left=�6>   $	��365��6Y   $	��Top=�6f   $	��425��6~   $��	5,125,0,0q�6�   #��� /�6�   " �� VerticalScrollBarVisibility$ Visible=�6�   �� 5   
   -   5        $ label5��5      $��Range of bookstore:��6    $
��Left=�6?   $	��Top=�6Z   $	 2.224,4.615&�6r   $��	22,96,0,0q�6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   �� 5   
   -   5        $
 nextDay��5      $��Next day of work��6"   $
��Left=�6Y   $	��Top=�6t   $	��200��6�   $��500,400,0,0q�6�   $��37��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   �� 5   
   -   5        $
 	backToTop��5      $��Back to top��6$   $
��Left=�6:   $	��Top=�6U   $	��199��6m   $��506,458,0,0q�6y   $��37��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   6�   �� 5   
   -   5        $
 requestsToPublishers��5      $-��'view outstanding requests to publishers��6/   $
��Left=�6a   $	��Top=�6|   $	��305��6�   $��
445,69,0,0q�6�   $��40��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6  �� 5    
   -   5        $
 
viewOrders��5       $��view outstanding orders��6>   $
��Left=�6`   $	��Top=�6{   $	��275��6�   $��460,131,0,0q�6�   $��34��6�   $
��Bold"�6�   $��Italic$�6�   $��16(�6�   �� 5!   
   -   5        $ label6��5!      $<��6Requests to publishers are sent at the end of the day.��6    $
��Left=�6a   $	��Top=�6|   $
��Bold"�6�   $��Italic$�6�   $��
449,45,0,0q�6�   �� 5"   
   -   5        $
 resultOfTheWork��5"      $y�Hidden=�6H   $��Result of the work��6\   $
��Left=�6y   $	��Top=�6�   $	��200��6�   $	 1.467,2.604&�6�   $��505,401,0,0q�6�   $��39��6�   $
��Bold"�6�   $��Italic$�6  $��16(�6"  5$      5%      