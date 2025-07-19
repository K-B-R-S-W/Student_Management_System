# 🎓 Student Management System 🎓

A comprehensive **Windows Forms application** built with modern **C#** and **.NET 8.0**, designed for efficient and secure student data management. This robust desktop solution offers intuitive user interfaces, secure authentication, and reliable local database integration.

---

## ✨ Features

### 🔐 Authentication & Security
- **Secure User Registration** – Register new users with encrypted password storage  
- **User Login System** – Validates credentials using secure authentication methods  
- **Password Hashing** – Industry-standard encryption using cryptographic libraries

### 📊 Student Data Management
- **Full CRUD Operations** – Add, view, update, and delete student records  
- **Input Validation** – Thorough error handling and validation for all inputs  
- **Advanced Search & Filter** – Quickly find records with precision  
- **Data Export Options** – Export student data to various file formats

### 🎨 User Experience
- **Modern UI Design** – Clean and intuitive Windows Forms interface  
- **Custom Message Dialogs** – User-friendly alerts and confirmations  
- **Responsive Layout** – Adapts well to different resolutions  
- **Error Handling** – Graceful fallback with informative messages

### 🗄️ Database Support
- **SQLite Integration** – Lightweight, embedded database (default)  
- **MySQL Compatibility** – Optional MySQL support for networked environments  
- **Transaction Support** – Ensures data integrity and reliability

---

## 🚀 Getting Started

### 🧰 System Requirements
- **OS:** Windows 10 or later  
- **Framework:** .NET 8.0 SDK or newer  
- **IDE:** Visual Studio 2022 (recommended) or Visual Studio Code with C# extension  
- **Memory:** Minimum 4 GB RAM  
- **Storage:** At least 100 MB of free space

### 📥 Installation Steps

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/K-B-R-S-W/Student_Management_System.git
   cd Student_Management_System
   ```

2. **Restore Dependencies:**
   ```bash
   dotnet restore
   ```

3. **Build the Application:**
   ```bash
   dotnet build --configuration Release
   ```

4. **Run the Application:**
   ```bash
   dotnet run
   ```
   _Or open `Student_man.sln` in Visual Studio and press **F5**._

---

## 🔧 Configuration

### 📁 SQLite (Default)
- No setup required – `userdata.db` is auto-generated on first run  
- Database is stored in the application’s data directory

### ⚙️ App Settings
1. Copy `appsettings.example.json` → `appsettings.json`  
2. Update values (e.g., database path, connection strings) as needed  
3. Ensure correct file permissions

---

## 🏗️ Project Structure

```
Student_Management_System/
├── Forms/
│   ├── Createacc.cs       
│   ├── Login.cs        
│   └── Reg.cs          
├── Data/
│   └── DatabaseHelper.cs    
├── Components/
│   └── CustomMessageBox.cs
├── Resources/
│   ├── Images/        
│   └── Assets/           
├── bin/Debug/
│   └── Dependencies/       
└── Student_man.sln         
```

---

## 📦 Dependencies & Libraries

### Framework
- **.NET 8.0** – Modern, cross-platform development platform  
- **Windows Forms** – Rich desktop UI framework

### Database & ORM
- `System.Data.SQLite` ^1.0.118 – SQLite integration  
- `MySql.Data` ^8.0.33 – MySQL support (optional)  
- `EntityFramework` ^6.4.4 – ORM for data manipulation

### Security
- `BouncyCastle` ^2.2.1 – Advanced cryptographic functions  
- `System.Security.Cryptography` – Password encryption/hashing

### UI & Utilities
- `System.Windows.Forms` – UI components  
- `System.Drawing` – Image and graphics handling

---

## 🔄 Usage Guide

### 🧑‍💻 First-Time Setup
1. Launch the application  
2. Click **Create Account** to register  
3. Enter credentials and submit  
4. Login using your new account

### 🧾 Managing Students
- Use **Add Student** to insert new entries  
- View/edit/delete records in the data grid  
- Utilize the search bar for filtering student data

### 🗃️ Backups
- **SQLite:** Backup `userdata.db` file  
- **MySQL:** Use standard MySQL dump/backup procedures

---

## 🤝 Contributing

We welcome contributions from developers!

### How to Contribute
1. Fork this repo  
2. Create your branch:  
3. Open a Pull Request

### Guidelines
- Follow standard C# coding practices  
- Include unit tests for new features  
- Update documentation as needed  
- Make sure all tests pass before submitting

### Reporting Bugs
- Use the **GitHub Issues** tab  
- Include:
  - Steps to reproduce
  - Environment details
  - Error messages (if any)

---

## 📞 Support

- **📧 Email:** [k.b.ravindusankalpaac@gmail.com](mailto:k.b.ravindusankalpaac@gmail.com)  
- **🐛 Bug Reports:** [GitHub Issues](https://github.com/K-B-R-S-W/Student_Management_System/issues)  
- **📖 Documentation:** See the project [Wiki](https://github.com/K-B-R-S-W/Student_Management_System/wiki)  
- **💬 Discussions:** Join the [GitHub Discussions](https://github.com/K-B-R-S-W/Student_Management_System/discussions)

---

## ⭐ Support This Project

If you find this project helpful, please consider giving it a **⭐ star** on GitHub!
