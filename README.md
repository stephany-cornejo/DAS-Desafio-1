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

### Crear una construcción de liberación

Para crear una versión optimizada para distribuir:

```bash
dotnet build -c Release
```

El ejecutable se podrá encontrar en: `DesafioDas\bin\Release\net8.0-windows\`

### Empaquetar para distribuir

Para crear un archivo ejecutable:

```bash
dotnet publish -c Release -o ./publish
```

### Distribución

1. Copiar el contenido de la carpeta `publish` a una USB o servidor
2. Ejecutar `DesafioDas.exe` 

## Desarrollo

Desarrollado por Stephany Cornejo 

## Licencia

Este proyecto es licenciado bajo la Licencia MIT.