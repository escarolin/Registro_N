   M S B A M L   `   `   `  ����E  ARegistro_N, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Registro_N
Registro_N  5   	       Registro_N.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Registro_N     5   	     � Title$  Registro��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
      �� $��-120,-110,-1,-1 q�6   $��Center=�6-   $��Center=�6H   .+�5   
   �� $��ID��6   $
��Bold"�6   $
��14px(�61   $��130,-125,1,1q�6A   $��SimSun-ExtB)�6W   $��Normal$�6p   �� 5      -   5         ��Name$ 	IDTextBox��5      $��50��6=   $��25��6H   $��10,-225,0,0q�6T   ��6)   �� *ID+6T   �� 5   
   -   5         ��Name$ BuscarButton��5      $��240,-225,0,0q�6(   $	��100��6>   $��30��6J   $��Buscar��6V   6g   �� 5      $��/Buscar.png��6   $��30��6*   $��30��65   $��160,-225,0,0q�6B   �� 5   
   $��Nombres:��6   $
��Bold"�6$   $
��14px(�67   $��110,-90,1,1q�6G   $��SimSun-ExtB)�6\   $��Normal$�6u   �� 5      -   5        $ NombreTextBox��5      $	��190��6F   $��25��6R   $��150,-140,0,0q�6^   ��6-   �� *	Nombres+6^   �� 5   
   $��Telefono��6   $
��Bold"�6$   $
��14px(�67   $��110,-50,1,1q�6G   $��SimSun-ExtB)�6\   $��Normal$�6u   �� 5      -   5        $ TelefonoTextBox��5      $	��190��6I   $��25��6U   $��150,-60,0,0q�6a   ��6/   �� *
Telefono+6a   �� 5   
   $��Cedula��6   $
��Bold"�6"   $
��14px(�65   $��110,-10,1,1q�6E   $��SimSun-ExtB)�6Z   $��Normal$�6s   �� 5      -   5        $ CedulaTextBox��5      $	��190��6E   $��25��6Q   $��150,-30,0,0q�6]   ��6-   �� *Cedula+6]   �� 5   
   $��	Direccion��6   $
��Bold"�6%   $
��14px(�68   $��
110,10,1,1q�6H   $��SimSun-ExtB)�6\   $��Normal$�6u   �� 5      -   5        $ DireccionTextBox��5      $	��190��6J   $��27��6V   $��150,-40,0,0q�6b   ��60   �� *
Direcion+6b   �� 5   
   $��FechaNacimiento��6   $
��Bold"�6+   $
��13px(�6>   $��
110,10,1,1q�6N   $��SimSun-ExtB)�6b   $��Normal$�6{   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ FechaNacimiento��5         Text$ (Binding FechaNacimiento)��62   $	��190��6S   $��35��6_   $��150,-30,0,0q�6k   �� 5!   
   -   5        $ NuevoButton��5!      $��-120,20,0,0q�6'   $	��100��6<   $��40��6H   $�� Nuevo��6T   6e   �� 5"      $��
/Nuevo.png��6   $��40��6)   $��40��64   $��-187,-40,0,0q�6A   �� 5$      -	   5        $ GuardarButton��5$      $��140,-40,0,0q�6-   $	��100��6B   $��40��6P   $��Guardar��6^   6p   �� 5%      $��/Guardar.png��6   $��35��6,   $��35��67   $��
75,-40,0,0q�6D   �� 5'      -
   5        $ EliminarButton��5'      $��390,-40,0,0q�6.   $	��100��6C   $��40��6Q   $��Eliminar��6_   6r   �� 5(      $��/Borrar.png��6   $��30��6.   $��30��69   $��330,-40,0,0q�6F   5*      5,      5-      