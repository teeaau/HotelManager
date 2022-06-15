# HotelManager
Provide management app for hotels

### Requirement
- Visual Studio
- Microsoft SQL Server

### How to use

#### Create database with EF6 code-first
- Open project with Visual Studio
- View -> Other Windows -> Package Manager Console
- Write line in PM console:
```
update-database
```

#### Login with default account
- Username: admin
- Password: 123456

#### Change permission for Employee
- Open SQL Server Management Studio 
- Edit table 'RolePermission' in schema 'HotelDb'

##### Role 
- roleId for Manager: 1
- roleId for Employee: 2

##### Permission
- permissionId for Booking: 1
- permissionId for Profile: 2
- permissionId for RoomConfig: 3
- permissionId for Payment: 4
- permissionId for Income: 5
- permissionId for Chart: 6
- permissionId for User: 7
- permissionId for Customer: 8
