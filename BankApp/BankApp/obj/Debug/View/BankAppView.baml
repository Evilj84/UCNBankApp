   M S B A M L   `   `   `  ����B  >BankApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BankApp.ViewModelBankApp.ViewModel  5      !clr-namespace:BankAppBankApp  5          BankApp.View.BankAppView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .myclr-namespace:BankApp.ViewModel     5      )BankAppclr-namespace:BankApp     5        � Title$  BankAppView��5
       � DataContext 5      (   "BankApp.ViewModel.BankAppViewModel  5   
   .��5      � .+�5   
   �� $��Account No:��6   $
��Left=�6&   $��	16,33,0,0q�6A   $	��Top=�6T   �� 5   
   $��Balance:��6   $
��Left=�6#   $��	16,64,0,0q�6>   $	��Top=�6Q   �� 5   
   $��Interest rate:��6   $
��Left=�6)   $��	16,90,0,0q�6D   $	��Top=�6W   �� 5   
   -   5         ��Name$ 
tbInterest��5      $
��Left=�6(   $��
110,94,0,0q�6C   $
��Wrap=�6W   $	��Top=�5   x   ��6   �� *SelectedItem.Interest+ �� ElementName$ cbAccountNo�� �� FallbackValue$ 0�� �� TargetNullValue$ 0��6x   �� 5   
   -   5        $ 	tbBalance��5      $
��Left=�6'   $��
110,73,0,0q�6B   $
��Wrap=�6V   $	��Top=�5      ��5      �� $ cbAccountNo�� �� Path$ SelectedItem.Amount�$ 0��$ 0��5      �� 5   
   -   5         ��Name$ cbAccountNo��5   f   $
��Left=�6   $��
110,36,0,0q�6.   $	��Top=�6B   $	��120��6Z    �� DisplayMemberPath$ 	AccountID��5   4   ��6   �� *
Accounts+	 �� SelectedValue	 6R   �� $ SelectedAccount�
 �� Mode$
 TwoWay=��� 5   
   $��Withdraw��6   $
��Left=�6#   $��	268,7,0,0q�6>   $	��Top=�6Q   �� 5   
   $��Account information��6   $
��Left=�6.   $��16,7,0,0q�6I   $	��Top=�6[   �� 5   
   $��Amount:��6   $
��Left=�6"   $��
268,33,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Deposit��6   $
��Left=�6"   $��
268,91,0,0q�6=   $	��Top=�6Q   �� 5!   
   -   5         ��Name$ btnWithdraw��5!   ~   $��Withdraw��6�   $
��Left=�6�   $��
342,64,0,0q�6�   $	��Top=�6�   $	��125��6�   ��6   �� $ ClickWithdrawCommand���6?   �� $ 
tbWithdraw��$
 Text�6�   �� 5#   
   -   5         ��Name$ 
tbWithdraw��5#   7   $
��Left=�6K   $��23��6f   $��
342,37,0,0q�6r    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��125��6�   ��6   �� $ WithdrawAmount�6�   �� 5$   
   $��Amount��6   $
��Left=�6!   $��268,122,0,0q�6<   $	��Top=�6Q   �� 5%   
   -   5        $ 	tbDeposit��5%   6   $
��Left=�6I   $��23��6d   $��342,122,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��125��6�   ��6   �� $ DepositAmount�6�   �� 5&   
   $��Interest��6?   $
��Left=�6R   $��110,122,0,0q�6m   $	��Top=�6�   $	��120��6�   ��6   �� $ ClickInterestCommand�6�   �� 5(   
   -   5        $ 
btnDeposit��5(   |   $��Deposit��6�   $
��Left=�6�   $��342,150,0,0q�6�   $	��Top=�6�   $	��125��6�   ��6   �� $ ClickDepositCommand���6>   �� $ 	tbDeposit��$
 Text�6�   5*      5+      