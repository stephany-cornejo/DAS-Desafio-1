# Sistema de Gestión de Biblioteca

Esta es una aplicación de escritorio Winforms desarrollada en C# con .NET 8.0 para la administración de datos (libros, usuarios y préstamos) de una biblioteca.

## Requisitos de instalación


- Sistema Operativo Windows 7 
- .NET 8.0 SDK
- Visual Studio Code o Visual Studio Community

## Instalación

### Paso 1: Clonar o Descargar el Repositorio

```bash
git clone https://github.com/stephany-cornejo/DAS-Desafio-1
cd Desafio-Das
```

O descargar el archivo ZIP y extraerlo en su computadora.

### Paso 2: Restaurar Dependencias

Abrir una terminal en la carpeta del proyecto y ejecutar:

```bash
dotnet restore
```

### Paso 3: Compilar y ejecutar

```bash
dotnet build
dotnet run
```

## Despliegue

### Crear una Construcción de Liberación

Para crear una versión optimizada lista para distribución:

```bash
dotnet build -c Release
```

El ejecutable se generará en: `DesafioDas\bin\Release\net8.0-windows\`

### Empaquetar para Distribución

Para crear un archivo ejecutable independiente:

```bash
dotnet publish -c Release -o ./publish
```

Esto creará una carpeta `publish` con todos los archivos necesarios para ejecutar la aplicación en otro equipo.

### Distribuir la Aplicación

1. Copie el contenido de la carpeta `publish` a una unidad USB o servidor de distribución
2. En la máquina destino, ejecute `DesafioDas.exe` directamente
3. **Nota**: La máquina destino debe tener instalado .NET 8.0 Runtime (no es necesario el SDK completo)

Para instalar solo el Runtime en la máquina destino:
```bash
# Descargar el instalador de .NET 8.0 Runtime desde:
https://dotnet.microsoft.com/download/dotnet/8.0
```

## 🔧 Desarrollo

El proyecto utiliza Windows Forms para la interfaz de usuario.

### Estructura del Proyecto

```
DesafioDas/
├── Form1.cs                 # Lógica principal de la aplicación
├── Form1.Designer.cs        # Definición del diseño de la interfaz
├── Program.cs               # Punto de entrada
├── DesafioDas.csproj        # Archivo de configuración del proyecto
└── Models/
    ├── clsUsuarios.cs       # Modelo de Usuario
    ├── clsLibros.cs         # Modelo de Libro
    └── clsPrestamos.cs      # Modelo de Préstamo
```

### Editar la Interfaz de Usuario

1. Abra `Form1.cs` en Visual Studio o VS Code
2. Modifique los controles en `Form1.Designer.cs` o use el diseñador visual
3. Compile el proyecto con `dotnet build`

## 🐛 Depuración

### Depuración en Visual Studio Code

1. Abra el proyecto en VS Code
2. Presione `Ctrl + Shift + D` para abrir la vista de Debug
3. Presione `F5` o seleccione "Run" para iniciar la depuración
4. Use puntos de interrupción (Breakpoints) haciendo clic en el número de línea

### Depuración en Visual Studio

1. Abra el proyecto (archivo `.sln`)
2. Presione `F5` o seleccione `Debug > Start Debugging`
3. Use la ventana de depuración para inspeccionar variables

## 🎯 Características de la Aplicación

- **Gestión de Libros**: Agregar, editar y eliminar libros del catálogo
- **Gestión de Usuarios**: Administrar usuarios y sus datos de contacto
- **Registro de Préstamos**: Registrar y controlar préstamos de libros
- **Filtrado por Usuario**: Ver préstamos específicos de cada usuario
- **Estadísticas**: Visualizar gráficos de usuarios más activos y libros más prestados

## 📝 Licencia

Este proyecto es desarrollado con fines educativos.

## 💬 Soporte

Para reportar problemas o sugerencias, contacte al equipo de desarrollo.
