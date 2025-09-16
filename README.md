# Real-time Collaborative Notes 

A **small-scale example project** showcasing **Microservices Architecture** with modern backend technologies.  
This application demonstrates how to design and build distributed systems using **gRPC with Protobuf**, **GraphQL as a gateway**, **MongoDB for persistence**, and **WebSockets for real-time collaboration** — all packaged in a **Docker Compose one-click setup**.

---

## 🚀 Features

- **Real-time Collaboration** – Notes update instantly across multiple clients using **GraphQL Subscriptions + WebSockets**.  
- **Microservices-based Design** –  
  - **gRPC Service**: Handles CRUD operations on notes.  
  - **GraphQL Gateway**: Standard API layer with Queries, Mutations, and Subscriptions.  
- **Protobuf Contracts** – Service definitions are defined using **Protocol Buffers (protobuf)** for efficient and type-safe communication.  
- **Database** – MongoDB (NoSQL) for flexible, schema-less data storage.  
- **Containerized Deployment** – Run the entire system with a single `docker-compose up --build`.  

---

## 🛠️ Tech Stack

- **Backend Services**:  
  - ASP.NET Core (.NET 9)  
  - gRPC 
  - GraphQL 
- **Database**: MongoDB  
- **Real-time Layer**: WebSockets  
- **Infrastructure**: Docker & Docker Compose  

---

### 🎬 **Video Demo**

👉 [**Watch the full demo on YouTube**](https://your-youtube-link-here)

## ⚡ Getting Started

### 1. Prerequisites
- [Docker](https://www.docker.com/) & Docker Compose  
- [.NET 9 SDK](https://dotnet.microsoft.com/) (optional for local development)  

### 2. Run with Docker
```bash
git clone https://github.com/your-username/realtime-collaborative-notes.git
cd realtime-collaborative-notes
docker-compose up --build
```

## Access Services

-  GraphQL Playground: http://localhost:5236/graphql

##  Example Operations

### Query

```graphql
query {
  notes {
    title
    content
  }
}

```

### mutation

```graphql
mutation {
  addNote(note: { title: "New Note", content: "Hello World!" }) {
    id
    title
    content
  }
}

```

### subscription

```graphql
subscription {
  noteAdded {
    id
    title
    content
  }
}

```

---


