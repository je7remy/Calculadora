# 🎤🔢 Calculadora con Síntesis de Voz en C#

🚀 **Bienvenido a mi proyecto!** Esta es una calculadora desarrollada en **C# con Windows Forms**, que incorpora **síntesis de voz** utilizando `System.Speech`. ¡Cada número y operación se pronuncian en voz alta! 🗣️

## 📌 Características
✅ Calculadora funcional con operaciones básicas (`+`, `-`, `×`, `÷`)  
✅ Interfaz gráfica moderna con **Windows Forms**  
✅ Síntesis de voz con `SpeechSynthesizer`  
✅ Botón de borrar para limpiar la pantalla  
✅ Compatible con **Visual Studio** y **.NET Framework**  

## 🖥️ Captura de Pantalla   
![Pasted image 20250202162407](https://github.com/user-attachments/assets/fc7ba250-4a14-4af6-95bf-4aa4d1c8cd7b)

## 🚀 Instalación y Uso  
Sigue estos pasos para ejecutar el proyecto en tu máquina:  

1️⃣ **Clona el repositorio:**  
```sh
git clone https://github.com/tu-usuario/calculadora-voz.git
```
2️⃣ **Abre el proyecto en Visual Studio**  
3️⃣ **Ejecuta el proyecto** (`F5`) y disfruta de la calculadora con síntesis de voz! 🎧  

## 🛠️ Requisitos  
🔹 **Windows 10/11**  
🔹 **Visual Studio** (Cualquier versión compatible con WinForms)  
🔹 **.NET Framework 4.7 o superior**  

## 📜 Código Principal  
Aquí tienes un fragmento del código que permite la síntesis de voz:  

```csharp
using System.Speech.Synthesis;

SpeechSynthesizer voz = new SpeechSynthesizer();
voz.SpeakAsync("Bienvenido a la calculadora con voz");
```

## 🎯 Mejoras Futuras  
🔹 Implementar **tema oscuro** y personalización UI  
🔹 Añadir historial de cálculos  

## 🤝 Contribuciones  
¡Las contribuciones son bienvenidas! Puedes hacer un **fork** del proyecto y enviarme un **pull request** con mejoras. 💡  

## 📄 Licencia  
Este proyecto está bajo la licencia **[MIT](LICENSE)**. ¡Úsalo libremente!  

📢 *Si te gusta este proyecto, no olvides darle una ⭐ en GitHub!*  
---
💻 Hecho con ❤️ por **[Jeremy]**  
