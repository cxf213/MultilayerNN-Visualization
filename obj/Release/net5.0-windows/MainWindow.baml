   M S B A M L   `   `   `  ���� B  >MLStudy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MLStudyMLStudy      MLStudy.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:MLStudy     -     � Title$  人工智障-分类机��$	��400��$	��723�� � 
ResizeMode$ NoResize=�.��� $��	0,0,10,-5q�.+��� -    ��Name$ c1��$��平均损失:��$
��Left=�$��
91,259,0,0q�$	��Top=��� -   $ t1��$��计算用时:��$
��Left=�$��
91,289,0,0q�$	��Top=��� -    ��Name$ Canva1��$
��Left=�$	��257��$��
377,89,0,0q�$	��Top=�$	��256���� -   $ Canva2��$
��Left=�$	��257��$��
377,89,0,0q�$	��Top=�$	��256���� -    ��Name$	 lb1��$
��Left=�$	��257��$��
218,89,0,0q�$	��Top=�$	��143���� -    ��Name$ reset��$��初始化神经网络��$
��Left=�$��31��$��
391,17,0,0q�$	��Top=�$	��232���� $��进行��$
��Left=�$��
399,53,0,0q�$	��Top=��� -    ��Name$ 	traintime��$
��Left=�$��20��$��
438,56,0,0q�$
��1000�� �� TextWrapping$
 Wrap=�$	��Top=�$��57�� J� 	AllowDrop$ False���� $	��次��$
��Left=�$��
507,53,0,0q�$	��Top=��� -	   $��训练��$
��Left=�$��24��$��
534,54,0,0q�$	��Top=�$��89���� $
��Left=�$	��257��$��
377,89,0,0q�
���   �$	��Top=�$	��257���� $��图像分辨率:��$
��Left=�$��
216,56,0,0q�$	��Top=��� -
   $	 res��$
��Left=�$��20��$��
296,58,0,0q�$��30��$
 Wrap=�$	��Top=�$��58��$ False���� $
��Left=�$��78��$��	377,6,0,0q����	#FFD1D1D1$	��Top=�$��1���� -   $ t2��$��绘画用时:��$
��Left=�$��
91,321,0,0q�$	��Top=��� -   $
 xval��$
��Left=�$��25��$��
121,89,0,0q�$
 Wrap=�$	��Top=�$��86��$��0���� -   $
 yval��$
��Left=�$��25                  ��$��121,119,0,0q�$
 Wrap=�$	��Top=�$��86��$��1���� $��X:��$
��Left=�$��25��$��	91,89,0,0q�$	��Top=�$��25���� $��Y:��$
��Left=�$��25��$��
91,119,0,0q�$	��Top=�$��25���� -   $	 add��$��添加数据��$
��Left=�$��29��$��
91,183,0,0q�$	��Top=�$	��116���� -   $ delete��$��去除数据��$
��Left=�$��30��$��
91,218,0,0q�$	��Top=�$	��116���� -   $	 val��$
��Left=�$��25                  ��$��131,149,0,0q�$
 Wrap=�$	��Top=�$��76��$��1���� $��预期:��$
��Left=�$��25��$��
91,149,0,0q�$	��Top=�$��40���� $��O��$
��Left=�$��30��$��361,329,0,0q�$	��Top=�$��40��$
��Bold"��� $��X��$
��Left=�$��30��$��613,342,0,0q�$	��Top=�$��40��$
��Bold"��� $��Y��$
��Left=�$��30��$��
361,83,0,0q�$	��Top=�$��40��$
��Bold"��� $��	学习率��$
��Left=�$��	91,14,0,0q�$	��Top=��� -   $ 	learnRate��$
��Left=�$��20��$��
142,17,0,0q�$	��1.0��$
 Wrap=�$	��Top=�$��58��$ False���� $��	学习组��$
��Left=�$��	91,41,0,0q�$	��Top=��� -   $ 	res_Copy1��$
��Left=�$��20��$��
142,45,0,0q�$��1��$
 Wrap=�$	��Top=�$��58��$ False��${�False���� -   $ sumTime��$��已进行 0 次训练��$
��Left=�$��24��$��
216,17,0,0q�$	��Top=�$	��145��