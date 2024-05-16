Order Manager to aplikacja napisana w C# z użyciem Windows Forms, która służy do zarządzania zamówieniami oraz płatnościami w firmie. Aplikacja korzysta z pięciu tabel w bazie danych zarządzanej przy użyciu Microsoft SQL Server: Orders, Payments, OrderDetails, Customers i Products. Aplikacja umożliwia zarządzanie danymi w czterech głównych widokach.

W widoku Klienci użytkownicy mogą dodawać, edytować i usuwać informacje o klientach, co pozwala na utrzymanie aktualnych danych kontaktowych i adresowych.

Widok Produkty pozwala na zarządzanie asortymentem poprzez dodawanie nowych produktów, edytowanie informacji o istniejących produktach oraz usuwanie tych, które są już nieaktualne.

Widok Zamówienia umożliwia tworzenie nowych zamówień, dodawanie pozycji do zamówień, usuwanie zamówień oraz ich wysyłanie.

 W widoku Płatności można tworzyć nowe płatności, wycofywać je w razie potrzeby oraz opłacać zrealizowane zamówienia, co ułatwia zarządzanie finansami i monitorowanie stanu płatności.



Wymagania:
1.	VisualStudio 2022
2.	.NET SDK 8.0
3.	SQL Server 2019
4.	SQL Server Management Studio (SSMS)

   
Instalacja: 

1.	Wczytaj skrypt scriptCreatingDB.sql aplikacji z folderu projektu OrderManagerApp\DataAccess\Data do SSMS.
2.	Skonfiguruj połączenie z bazą danych w pliku konfiguracyjnym App.config w projekcie OrderManagerApp (OrderManagerApp\OrderManagerApp\App.config). Należy w <connectionString> podmienić: data source = „nazwaServera” i database = „nazwaBazy’.
3.	Skompiluj projekt i uruchom aplikację.
