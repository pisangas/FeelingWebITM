![.NET](https://img.shields.io/badge/.NET-6.0-blueviolet?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Backend%20Logic-green?logo=csharp&logoColor=white)
![Web](https://img.shields.io/badge/Frontend-Web%20UI-lightgrey)
![Status](https://img.shields.io/badge/Status-Acad%C3%A9mico-orange)

# FeelingWebITM

> Plataforma académica de visualización y análisis de sentimientos en Tweets

---

##  Descripción

FeelingWebITM es una aplicación web construida sobre **.NET**, diseñada para explorar, visualizar y analizar sentimientos en datos de Twitter. Combina un backend enfocado en análisis, una capa compartida de lógica y modelos, y una interfaz web contemporánea. Ideal para prácticas de procesamiento de texto, visualización y aprendizaje de arquitectura full-stack. :contentReference[oaicite:0]{index=0}

---

##  Estructura del proyecto

FeelingWebITM/

├── FeelingWeb.API ← Backend RESTful en C# (.NET)

├── FeelingWeb.Shared ← Modelos y lógica común entre backend y frontend

├── FeelingWeb.WEB ← Interfaz web (HTML, CSS, Razor/MVC)

├── Tweets.csv ← Dataset de tweets de prueba

└── FeelingWeb.sln ← Solución para Visual Studio / VS Code

:contentReference[oaicite:1]{index=1}

---

##  Funcionalidades (sugeridas)

- Consumo de datos — lectura de tweets desde `Tweets.csv`.
- Categorización de sentimientos (positivos, negativos, neutros).
- Visualización de patrones en la UI: gráficas, nubes de palabras, etc.
- Separación clara de responsabilidades: API, lógica compartida, frontend.

---

Ideas para expandir

Implementar análisis de sentimiento real usando librerías como ML.NET o APIs externas.

Incorporar gráficos dinámicos con librerías JavaScript (Chart.js, D3.js, etc.).

Añadir autenticación básica para acceder a la visualización.

Permitir carga de archivos CSV personalizados desde la UI.

Crear dashboards con filtros por fecha, autor o palabra clave.

---

📬 Contacto

👨‍💻 Autor: Eduardo (pisangas)

🔗 GitHub: @pisangas
