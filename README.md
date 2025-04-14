# 💻 mf-dev-backend-2025

Projeto ASP.NET Core MVC para gerenciamento de veículos, usuários e consumos de combustível.

> 📚 Este projeto foi desenvolvido como parte do microfundamento **Desenvolvimento Web Back-End**, do **2º semestre** do curso de **Análise e Desenvolvimento de Sistemas** da **PUC Minas**.

---

## 🧩 Funcionalidades

- ✅ CRUD de veículos  
- ✅ CRUD de usuários  
- ✅ CRUD de consumos  
- 🔐 Autenticação de usuários  
- 🔒 Controle de acesso por perfil (Admin)  
- 🧭 Exibição condicional no menu (Login/Logout)  
- 📱 Interface responsiva com Bootstrap  

---

## 🔐 Autenticação

O sistema implementa autenticação baseada em cookies, com restrição de acesso às rotas administrativas.

- 🔐 Somente usuários com perfil `Admin` acessam o gerenciamento de usuários.
- 🔑 Rota de login: `/Usuarios/Login`
- 🚫 Página de acesso negado: `/Usuarios/AccessDenied`

### Menu dinâmico:
Usuários autenticados visualizam um menu com saudação e botão de logout. Usuários anônimos veem o botão de login.

---

## 🧪 Tecnologias Utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server LocalDB
- Razor Pages
- Bootstrap
- BCrypt para hashing de senhas

---

## 📸 Prints da Aplicação

![image](https://github.com/user-attachments/assets/6c92abeb-bb6f-4c0a-b420-f99c9dda6e51)
![image](https://github.com/user-attachments/assets/4c25e710-f49e-4a87-a0ab-ebea08f10b45)
![image](https://github.com/user-attachments/assets/2f75f2f3-568a-4853-9e3e-8b9c6b148faa)
![image](https://github.com/user-attachments/assets/f838b0ba-ca9a-4329-8916-68ffe4e98c99)
![image](https://github.com/user-attachments/assets/9b94b19d-1d3d-43f5-9e18-d06fb55ad9b3)

---

## 🚀 Como Executar Localmente

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/mf-dev-backend-2025.git
2. Restaure os pacotes:
   ```bash
   dotnet restore
3. Crie o banco de dados local: 
   ```bash
   dotnet ef database update
4. Execute o projeto:
   ```bash
   dotnet run
