   M S B A M L   `   `   `  ���� B  >MLStudy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MLStudyMLStudy      MLStudy.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:MLStudy     -     � Title$  
MainWindow��$	��400��$	��723�� � 
ResizeMode$ NoResize=�.��� $��	0,0,10,-5q�.+��� -    ��Name$ c1��$��平均损失:��$
��Left=�$��151,263,0,0q�$	��Top=��� -   $ t1��$��计算用时:��$
��Left=�$��151,293,0,0q�$	��Top=��� -    ��Name$ Canva1��$
��Left=�$	��257��$��
437,93,0,0q�$	��Top=�$	��256���� -   $ Canva2��$
��Left=�$	��257��$��
437,93,0,0q�$	��Top=�$	��256���� -    ��Name$	 lb1��$
��Left=�$	��257��$��
278,93,0,0q�$	��Top=�$	��143���� -    ��Name$ reset��$��初始化神经网络��$
��Left=�$��31��$��
451,21,0,0q�$	��Top=�$	��232���� $��进行��$
��Left=�$��
459,57,0,0q�$	��Top=��� -    ��Name$ 	traintime��$
��Left=�$��20��$��
498,60,0,0q�$
��1000�� �� TextWrapping$
 Wrap=�$	��Top=�$��57�� J� 	AllowDrop$ False���� $	��次��$
��Left=�$��
567,57,0,0q�$	��Top=��� -	   $��训练��$
��Left=�$��24��$��
594,58,0,0q�$	��Top=�$��89���� $
��Left=�$	��257��$��
437,93,0,0q�
���   �$	��Top=�$	��257���� $��图像分辨率:��$
��Left=�$��
276,60,0,0q�$	��Top=��� -
   $	 res��$
��Left=�$��20��$��
356,62,0,0q�$��30��$
 Wrap=�$	��Top=�$��58��$ False���� $
��Left=�$��78��$��
437,10,0,0q����	#FFD1D1D1$	��Top=�$��1���� -   $ t2��$��绘画用时:��$
��Left=�$��151,325,0,0q�$	��Top=��� -   $
 xval��$
��Left=�$��25��$��
181,93,0,0q�$
 Wrap=�$	��Top=�$��86���� -   $
 yval��$
��Left=�$��25                  ��$��181,123,0,0q�$
 Wrap=�$	��Top=�$��86���� $��X:��$
��Left=�$��25��$��
151,93,0,0q�$	��Top=�$��25���� $��Y:��$
��Left=�$��25��$��151,123,0,0q�$	��Top=�$��25���� -   $	 add��$��添加数据��$
��Left=�$��29��$��151,187,0,0q�$	��Top=�$	��116���� -   $ delete��$��去除数据��$
��Left=�$��30��$��151,222,0,0q�$	��Top=�$	��116���� -   $	 val��$
��Left=�$��25                  ��$��191,153,0,0q�$
 Wrap=�$	��Top=�$��76���� $��预期:��$
��Left=�$��25��$��151,153,0,0q�$	��Top=�$��40��