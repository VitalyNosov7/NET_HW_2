## �������� ������� � ����� 2. �������������: ���������������, �������� � ���������� �������:

�������� ����������� ������ ����� Exit � ���� �������, ����� ����� ���� ��������� ��� ������. 
� ���� ������� �������� �������� ������� �������, ����� ����� ���������� ��� ������.

---
## �������:

��� ������� ������ ��� ����������� ��������� ��������:
1. ��� ������ �� ���� �������, � ������ UdpClientApp  ��� �������� ��������� ��� (���. 36-46):
```

            if (UserMessage == "Exit")
            {
                UserMessage = $"The user {Name} has left the application.!";

                Name = "";

                SendMessage();

                client.Close();
                Environment.Exit(0);
            }

```
������������ ���������� ����� ����������, ����� � ������� ����� Exit, ��������� ������ �����������  ����������.

2. ��� ������ �� ���������� �������, � ������ UdpServer ��� �������� ��������� ��� (���. 21 - 30 ):
```
            if (Console.KeyAvailable == true)
            {
                server.Close();
                var key = Console.ReadKey(true).Key;

                Console.WriteLine(key);

                Console.WriteLine("Server stoped!");
                Environment.Exit(0);
            }

```

������������ ��������� ����� ����������, ����� ������ Enter �� ���������� ��������� ������ ���������� ����������. ������������� ������ ����� ����������(������ ��������� ����� ����������� ��������������). 