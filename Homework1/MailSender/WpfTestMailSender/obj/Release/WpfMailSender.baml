   M S B A M L   `   `   `  ���� L  HWpfTestMailSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfTestMailSenderWpfTestMailSender  %    WpfTestMailSender.WpfMailSender   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:WpfTestMailSender       � Title$  Рассылятор��$	��481��$	��541��.��� .+��� -   $��BtnSendMail��$!��Отправка почты��$
��Left=�$��403,229,0,0q�$	��Top=�$	��109��G� -   $��PasswordBox��$
��Left=�$��
393,23,0,0q�$	��Top=�$	��119���� -   $��
MsgTextBox��$
��Left=�$	��109��$��143,105,0,0q�$	��Top=�$	��369��. �/� .T�J� .*�.*��� $2�,Укажите текст сообщения���� -   $��SubjectTextBox��$
��Left=�$��23��$��
143,63,0,0q� �� TextWrapping$
 Wrap=�$0��*Укажите тему сообщения��$	��Top=�$	��369���� -   $��UserMail��$
��Left=�$��23��$��
143,22,0,0q�$
 Wrap=�$$��user@mail.ru                  ��$	��Top=�$	��120���� $)��#Логин пользователя��$
��Left=�$��	20,24,0,0q�$	��Top=�$	��160��
���   ��� $��Пароль��$
��Left=�$	��Top=�$��
340,24,0,0q�
���   �$��65���� $!��Тема сообщения��$
��Left=�$��	20,64,0,0q�$	��Top=�$	��107��
���   ��� $#��Текст сообщения��$
��Left=�$��
20,107,0,0q�$	��Top=�$	��107��
���   ��� -   $��
LogTextBox��$
��Left=�$	��170��$��
20,261,0,0q�$
 Wrap=�$��TextBox��$	��Top=�$	��492��