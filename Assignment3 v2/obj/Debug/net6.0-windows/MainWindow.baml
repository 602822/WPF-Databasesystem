   M S B A M L   `   `   `  ����I  EAssignment3 v2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Assignment3_v2Assignment3_v2  5   	       Assignment3_v2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Assignment3_v2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��0,79,0,0q�6    � ColumnDefinitions 5
   
   �� 5      $
��291* �6   �� 5      $
��509* �6   .+�5   
   �� -   5        $��studentList��5      $��2��6>   ��6&   ��  �� View 5      �� 5      P�5      �� 5       �� Width$	 100��6)   $��Student��65    �� DisplayMemberBinding 5      ��  �� Path$ Studentname��� 5      $ 75��6)   $��ID��64    5      �� $ Id��� 5      $ 75��6)   $	��Age��64    5      �� $ 
Studentage��� 5      $ 75��6)   $��
Coursecode��64    5      �� $ 
Coursecode��� 5      $ 75��6)   $��Grade��64    5      �� $ Grade1�5      5      5!      �� 5"   
   -   5        $��searchField��5"      $
��Left=�6'   $��
21,-65,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��120��6�   6�   �� 5#   
   -   5        $��searchButton��5#      $��Search��6'   $��18,-35,221,0q�68   $	��Top=�6N    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5$      V� 5%      .~�5&      �� �� 5'      �� 5(       �� Angle$ 0.128Q�6&   T� 5)      5*      5,      �� 5-   
   -   5        $��selectCource��5-      $
��Left=�6(   $��
29,-43,0,0q�6C   $	��Top=�6W   $��94��6o   $��27��6z   $��1��6�   �� 5.   
   $#��Select Cource                ��6   $
��Left=�5/      $��
29,-65,0,0q�6-   $	��Top=�6A   $��1��6Y   �� 50   
   -   5        $��selectGrade��50      $
��Left=�6(   $��128,-43,0,0q�6C   $	��Top=�6X   $��97��6p   $��27��6{   $��1��6�   �� 51   
   $"��Select Grade                ��6   $
��Left=�52      $��128,-66,0,0q�6-   $	��Top=�6B   $��1��6Z   �� 53   
   -   5        $��failedStudentsCheckBox��53      $��1��63   $��Only show Failed students��6C   $
��Left=�6g   $��230,-40,0,0q�6�   $	��Top=�6�   $	��165��6�   6�   �� 54   
   -   5        $��
editButton��54      $��1��6#   $
��Edit��63   $
��Left=�6B   $��400,-43,0,0q�6]   $	��Top=�6r   $��78��6�   6�   55      56      