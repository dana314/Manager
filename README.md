# ���������� �������� Task Manager 
���������� ��� ���������� �������� � ��������� �����, �������������, ��������� � ����������

# ����������
- ���������� ����� � ������� `�������� | ����������� | �������� | �������`
- �������������� �����
- �������� �����
- �������� ������ � SQLite

# ��������� � ������ ����������
1. ���������� ������ � ���������� ������� NuGet (������� "��������"), �������� � ��������� ������
   - `Install-Package System.Data.SQLite`
   - `Install-Package Microsoft.Extensions.DependencyInjection`
2. ��������� ����������

# ��������� ����������
Managerr/
    TaskManagerApp.sln
    README.md 
    CoreManage/
      IManagerRepository.cs
      TaskItem.cs
    DataManage/
      ManagerRepository.cs
    TaskManager/
      Manager.cs
      Program.cs
