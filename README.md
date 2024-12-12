# REST-UNED-Cliente

## Descripción
Proyecto del curso Programación Avanzada de la universidad para la empresa ficticia REST-UNED. Este proyecto implementa un sistema cliente/servidor para la gestión de pedidos de platos en restaurantes, desarrollado en .NET 7. La solución incluye una aplicación cliente, se comunica con el servidor a través del protocolo TCP. La aplicación cliente permite a los usuarios realizar pedidos y conectarse al servidor para verificar su identidad y registrar pedidos.

## Características del Proyecto
- **Desarrollo Orientado a Objetos**: Uso de POO para estructurar las clases de objetos.
- **Manejo de Excepciones**: Implementación de manejo de excepciones para evitar cierres inesperados y mostrar mensajes apropiados al usuario.
- **Interfaz de Usuario**: Desarrollada con formularios GUI utilizando Windows Forms.
- Utilizado por los clientes para conectarse con el servidor central y realizar reservas.
- Opción para conectarse y desconectarse del servidor.
- Validación de la existencia del cliente en la base de datos al iniciar sesión.
- Muestra el nombre del cliente con los dos apellidos una vez validado.
- Desbloqueo de funcionalidades tras la validación del cliente.

## Tecnologías Utilizadas
- **Lenguaje de Programación**: C#
- **Framework**: .NET 7
- **Patrón de Diseño**: Modelo-Vista-Presentador (MVP)
- **Inyección de Dependencias**
- **ORM**: Entity Framework Core
- **Interfaz de Usuario**: Windows Forms
