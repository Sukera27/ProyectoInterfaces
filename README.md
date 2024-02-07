# Aplicación de Escritorio CRUD en WPF con C#

Esta es una aplicación de escritorio desarrollada en WPF utilizando el lenguaje de programación C#. La aplicación realiza operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en una base de datos personalizada de NorthWind, que incluye una tabla de usuarios para el inicio de sesión y registro en la aplicación.

## Interfaz

## Login 

![login](https://github.com/Sukera27/ProyectoInterfaces/assets/122563964/f676d917-a8ea-4de6-b3ca-dcc083717f54) 


Esta ventana, representada por el archivo MainWindow.xaml, es la interfaz de usuario principal de la aplicación. En ella, los usuarios pueden iniciar sesión utilizando sus credenciales. Aquí se emplea el framework MaterialDesign para proporcionar una interfaz moderna y atractiva.

La ventana se compone de varios elementos visuales. En la parte superior, se encuentra un control desplegable para cambiar entre el modo claro y el modo oscuro, lo que permite a los usuarios personalizar su experiencia visual. También hay un botón de ayuda para aquellos que tengan problemas para iniciar sesión y otro para cerrar la aplicación.

En el centro de la ventana, se muestra el logo de la aplicación junto con su nombre, "NorthWindCRUD". Esto proporciona una identidad visual clara y ayuda a los usuarios a reconocer la aplicación.

Justo debajo del logo, se encuentran dos campos de entrada para el nombre de usuario y la contraseña, respectivamente. Estos campos están diseñados para ser intuitivos y están estilizados según las pautas de Material Design.

Además, hay dos botones: uno para iniciar sesión y otro para crear un nuevo usuario. Estos botones permiten a los usuarios realizar acciones importantes dentro de la aplicación de manera rápida y sencilla.

En resumen, la ventana de inicio de sesión es la primera impresión que los usuarios tendrán de la aplicación. Su diseño limpio y moderno, junto con su funcionalidad intuitiva, contribuyen a una experiencia de usuario positiva y satisfactoria.

## Ventana Principal

![VentanaPrincipal](https://github.com/Sukera27/ProyectoInterfaces/assets/122563964/ef7c037a-1be3-48e2-960c-2b601bc36bf1)



Esta ventana, representada por el archivo Home.xaml, es la interfaz principal de la aplicación una vez que el usuario ha iniciado sesión. Proporciona un menú de navegación en la parte izquierda de la pantalla, desde donde los usuarios pueden acceder a diferentes secciones y funcionalidades de la aplicación.

La ventana utiliza el framework MaterialDesign para estilizar los elementos de la interfaz, lo que le brinda una apariencia moderna y atractiva. Además, hace uso de la librería FontAwesome para mostrar iconos junto a los nombres de las diferentes secciones del menú, lo que mejora la usabilidad y la experiencia del usuario.

El menú de navegación incluye varios botones, cada uno representando una sección o funcionalidad de la aplicación. Al hacer clic en uno de estos botones, se carga el contenido correspondiente en el área de contenido cambiante, representada por un elemento Frame en la parte derecha de la pantalla.

En resumen, la ventana Home ofrece una forma intuitiva y eficiente para que los usuarios naveguen por las diferentes partes de la aplicación y accedan a sus funcionalidades principales.


## Estructura del Proyecto

El proyecto está organizado de la siguiente manera:

- **database/**
  - `DataBase.cs`
- **ActualizarProductos/**
  - `ActualizarProductos.xaml.cs`
  - `ActualizarProductos.xaml`
- **App/**
  - `App.xaml.cs`
  - `App.xaml`
- **Properties/**
  - `AssemblyInfo.cs`
- **Images/**
  - `BaseDeDatos-removebg-preview.png`
- **BorrarProductos/**
  - `BorrarProductos.xaml.cs`
  - `BorrarProductos.xaml`
- **Home/**
  - `Home.xaml.cs`
  - `Home.xaml`
- **InsertarProductos/**
  - `InsertarProductos.xaml.cs`
  - `InsertarProductos.xaml`
- **MainWindow (Ventana de Inicio de Sesión)/**
  - `MainWindow.xaml.cs`
  - `MainWindow.xaml`
- **MasCaros/**
  - `MasCaros.xaml.cs`
  - `MasCaros.xaml`
- **MasVendidos/**
  - `MasVendidos.xaml.cs`
  - `MasVendidos.xaml`
- **PaginaProductos/**
  - `PaginaProductos.xaml.cs`
  - `PaginaProductos.xaml`
- **Presentación/**
  - `Presentación.xaml.cs`
  - `Presentación.xaml`
- **SinStock/**
  - `SinStock.xaml.cs`
  - `SinStock.xaml`
- **CRUDInterfaces.csproj**

Cada carpeta contiene archivos relacionados con diferentes aspectos de la aplicación, como la interfaz de usuario, la lógica de negocio y la conexión a la base de datos.

## Diseño

Para el diseño de la interfaz de usuario, se utilizó el framework `MaterialDesign` y los iconos del menú se implementaron utilizando `Font Awesome`.

