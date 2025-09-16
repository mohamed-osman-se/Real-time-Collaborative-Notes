# 📝 Real-time Collaborative Notes

A small-scale example project showcasing a **Microservices Architecture** with modern backend technologies. This application demonstrates how to design and build distributed systems using **gRPC**, **GraphQL**, **MongoDB**, and **WebSockets** — all packaged in a one-click Docker Compose setup.

---

## ✨ Features

-   **Real-time Collaboration**: Notes update instantly across multiple clients using GraphQL Subscriptions over WebSockets.
-   **Microservices Architecture**:
    -   **gRPC Service**: Handles core CRUD (Create, Read, Update, Delete) operations on notes.
    -   **GraphQL Gateway**: Provides a unified API layer with Queries, Mutations, and Subscriptions.
-   **Strongly-Typed Contracts**: Service definitions are defined using **Protocol Buffers (protobuf)** for efficient and type-safe communication.
-   **Flexible Data Storage**: Uses **MongoDB** (NoSQL) for schema-less data persistence.
-   **Containerized Deployment**: Run the entire system with a single command: `docker-compose up --build`.

---

## 🛠️ Tech Stack

| Category        | Technology                                     |
| --------------- | ---------------------------------------------- |
| **Backend** | `ASP.NET Core (.NET 9)`, `gRPC`, `GraphQL`       |
| **Database** | `MongoDB`                                      |
| **Real-time** | `WebSockets`                                   |
| **DevOps** | `Docker`, `Docker Compose`                     |

---

## 🎬 Video Demo

👉 [**Watch the full demo on YouTube**](https://your-youtube-link-here)

---

## 🚀 Getting Started

### Prerequisites

-   [Docker & Docker Compose](https://www.docker.com/products/docker-desktop/)
-   [.NET 9 SDK](https://dotnet.microsoft.com/) (Optional, for local development)

### Run the Application

1.  Clone the repository:
    ```bash
    git clone [https://github.com/your-username/realtime-collaborative-notes.git](https://github.com/your-username/realtime-collaborative-notes.git)
    ```

2.  Navigate to the project directory:
    ```bash
    cd realtime-collaborative-notes
    ```

3.  Build and run the containers:
    ```bash
    docker-compose up --build
    ```

---

## 🌐 Access Points

-   **GraphQL Playground**: `http://localhost:5236/graphql`

---

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
  addNote(note: {
    title: "First Note"
    content: "This is my first note stored via GraphQL mutation."
  }) {
    calculateSize
  }
}


mutation {
  addNote(note: {
    title: "Reminder"
    content: "Don’t forget to finish the SyncNotes project today!"
  }) {
    calculateSize
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


