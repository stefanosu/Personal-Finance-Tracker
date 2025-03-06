# Personal Finance Tracker

## Overview
The **Personal Finance Tracker** is a full-stack application designed to help users manage their finances. The backend is built with **C# (ASP.NET Core)** and the frontend is developed using **Next.js (TypeScript)**.

## Project structure

```
personal-finance-tracker/
│── backend/                      # C# ASP.NET Core backend
│   ├── Controllers/               # API controllers (Transactions, Auth, etc.)
│   ├── Models/                    # Data models (User, Transaction, etc.)
│   ├── Services/                  # Business logic services
│   ├── Data/                      # Database context and migrations
│   ├── Middleware/                 # Authentication, logging, etc.
│   ├── appsettings.json            # Config file (DB connection, secrets)
│   ├── Program.cs                  # Main entry point
│   ├── Startup.cs                  # Configure services & middleware
│   ├── README.md                    # Backend documentation
│
│── frontend/                      # Next.js frontend
│   ├── public/                     # Static assets (icons, images)
│   ├── src/
│   │   ├── components/             # Reusable UI components
│   │   ├── contexts/               # React Context API state management
│   │   ├── hooks/                  # Custom hooks
│   │   ├── layouts/                # Layout components
│   │   ├── pages/                  # Next.js pages (dashboard, transactions, etc.)
│   │   ├── services/               # API calls to backend
│   │   ├── styles/                 # CSS/SCSS files
│   │   ├── types/                  # TypeScript interfaces
│   │   ├── utils/                  # Helper functions
│   │   ├── config.ts               # Environment variables & API URLs
│   │   ├── theme.ts                # Theme settings
│   ├── .env.local                  # Environment variables
│   ├── next.config.js              # Next.js config
│   ├── tsconfig.json               # TypeScript config
│   ├── README.md                    # Frontend documentation
│
│── docker-compose.yml              # Docker for backend & frontend
│── README.md                       # Main documentation
```

---

## Backend (ASP.NET Core)

### Features
- User authentication (JWT-based)
- Transaction tracking (income, expenses)
- Category-based expense management
- REST API for frontend communication

### Setup Instructions
1. **Clone the repository**
   ```sh
   git clone https://github.com/stefanosu/personal-finance-tracker.git
   cd personal-finance-tracker/backend
   ```

2. **Configure the database** (PostgreSQL or SQL Server)
   - Update `appsettings.json` with your database connection string.

3. **Run Migrations**
   ```sh
   dotnet ef database update
   ```

4. **Start the API Server**
   ```sh
   dotnet run
   ```

5. **API Endpoints**
   - `POST /api/auth/login` - User login
   - `POST /api/auth/register` - User registration
   - `GET /api/transactions` - Fetch transactions
   - `POST /api/transactions` - Add new transaction
   
---

## Frontend (Next.js)

### Features
- User authentication (JWT stored in cookies/local storage)
- Dashboard for financial insights
- Transaction history with filtering
- Responsive UI using Tailwind CSS

### Setup Instructions
1. **Navigate to the frontend directory**
   ```sh
   cd ../frontend
   ```
2. **Install dependencies**
   ```sh
   npm install
   ```
3. **Set environment variables** (Create `.env.local`)
   ```sh
   NEXT_PUBLIC_API_URL=http://localhost:5000/api
   ```
4. **Run the development server**
   ```sh
   npm run dev
   ```

5. **Access the app** at `http://localhost:3000`

---

## Deployment
### Backend (Docker & Hosting)
- Create a Docker image:
  ```sh
  docker build -t personal-finance-backend .
  ```
- Run the container:
  ```sh
  docker run -p 5000:5000 personal-finance-backend
  ```

### Frontend (Vercel/Netlify)
- Deploy with Vercel:
  ```sh
  vercel --prod
  ```

---

## Contributing
1. Fork the repository
2. Create a new branch (`feature-xyz`)
3. Commit your changes
4. Open a Pull Request

---

## License
MIT License

