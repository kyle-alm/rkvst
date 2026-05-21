# RKVST

*Relational Knowledge Versioned Semantic Tapestry*

RKVST (Archivist) is a lightweight, AI-native knowledge system built around semantic retrieval rather than folders, hierarchies, or chat history.

Everything is stored as versioned **entries** connected through **concepts**. Concepts form a navigable semantic graph. Retrieval is graph traversal; Not keyword search, not folder browsing.

- Write something → it's stored.
- Ask for something → relevant information is retrieved.

---

## Architecture

- **Language:** C# / .NET 9
- **Database:** SQLite
- **Architecture:** Clean Architecture + CQRS
- **Interface:** CLI (MVP)
- **AI:** BYOM (Bring Your Own Model)

## Projects

| Project | Type | Role |
|---|---|---|
| `Archivist.Domain` | Class Library | Entities, value objects |
| `Archivist.Application` | Class Library | Commands, queries, interfaces |
| `Archivist.Infrastructure` | Class Library | SQLite, repositories, AI services |
| `Archivist.Cli` | Console App | Composition root, CLI |

---

## Status

Early MVP. Not ready for use.
