   M S B A M L   `   `   `  ����>  :TP2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TP2TP2  5          TP2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      #localclr-namespace:TP2     5        � Title$  
MainWindow��5      $	��450��6   $	��800��6%   $
��auto��64   .��5      � $��0q�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $	 Red��6    � Offset$ 1Q�6+   5      .+�5   
   �� $��REGISTRO��6   $��Center=�6#   $��0,25,0,0q�6@   $	��Top=�6R   
�������$��24(�6}   $
��Bold"�6�   �� 5#   
   -   5        $��Alta de Trabajador��5#      $	��160��5$      $��50��5%      $
��Left=�5&      $	��Top=�5'      ���#4CAF50
�������$��16(�5+       � Cursor$
 Hand��5,      $��110,110,0,0q�6   $
��Bold"�60   �� 5:   
   -   5        $��Cargar horas��5:      $	��160��5;      $��50��5<      $	��Top=�5=      ���#4CAF50
�������$��16(�5@      $
 Hand��5A      $��540,110,110,0q�6   $
��Bold"�6H   &   System.Windows.Controls.DataGrid  5Y   
   -   5          Name$ trabajadoresDataGrid��5Y         AutoGenerateColumns .     CanUserAddRows .  	   CanUserDeleteRows	 . $��10,200,10,10q�5]      
   Columns
 5^      0  *System.Windows.Controls.DataGridTextColumn  5_      ,  &System.Windows.Controls.DataGridColumn   Header$ Apellido��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Apellido+  5`      $ Nombre��6%    65   �� *Nombre+  5a      $ 	Domicilio��6%    68   �� *	Domicilio+  5b      $ 	Localidad��6%    68   �� *	Localidad+  5c      $ 	Provincia��6%    68   �� *	Provincia+  5d      $ Celular��6%    66   �� *
NroCelular+  5e      $ 
Categoría��6%    68   �� *Categoria.Nombre+  5f      $ Rango��6%    64   �� *Rango.Nombre+  5g      $ Área Trabajo��6%    6;   �� *AreaTrabajo+  5h      $ Horas��6%    64   �� *CantidadHoras+  5i      $ 
Valor Hora��6%    69   �� *	ValorHora+  5j      $ Sueldo��6%    65   �� *Sueldo+  5k      $ Fecha Ingreso��6%    6<   �� *FechaIngreso+5m      5o      5p      