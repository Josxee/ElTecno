# ElTecno

Integrantes:
José David Alvarado Ramírez,
José Guillermo Sibaja Murillo,
Jose Luis Guerrero Vargas,
Landon Patterson Foster,
Christopher Ariel Carballo Vallejos

Repositorio:
https://github.com/Josxee/ElTecno.git

Especificaciones Técnicas:
El proyecto Media Dashboard fue desarrollado para la empresa El Tecno, con el objetivo de mostrar información dinámica relacionada con tecnología, clima local, tipo de cambio, noticias globales y anuncios. Esta plataforma busca ser visualmente atractiva, intuitiva y útil para mantener informados tanto a empleados como visitantes.

El sistema está construido bajo la arquitectura ASP.NET Core Web API, utilizando una estructura por capas que incluye controladores, servicios, modelos y utilidades auxiliares. Los controladores reciben las solicitudes HTTP, los servicios se encargan del consumo de APIs externas, los modelos representan los datos obtenidos y los helpers manejan transformaciones o construcción de URLs.

Se han integrado varias APIs externas que brindan datos actualizados: Open-Meteo para el clima, ExchangeRate.Host para el tipo de cambio, GNews para las noticias y Adzuna para los anuncios. Cada API fue seleccionada según las necesidades funcionales definidas por la empresa.

En cuanto a las tecnologías utilizadas, se emplearon paquetes como Microsoft.AspNetCore.Mvc, Microsoft.Extensions.Http y Newtonsoft.Json. Opcionalmente se puede incluir Swashbuckle.AspNetCore para la documentación Swagger.

Durante el desarrollo se aplicaron principios SOLID, asegurando que cada clase tenga una única responsabilidad y que el código sea extensible, intercambiable y mantenible. Además, se aplicaron patrones de diseño como Service Pattern para centralizar la lógica, DTO Pattern para mapear los datos externos, e incluso el Factory Pattern si se desean múltiples formatos de respuesta.

El sistema también contempla funcionalidades de autenticación como registro e inicio de sesión, asegurando la protección de la información mediante buenas prácticas de seguridad. Se incluyen también prototipos básicos del dashboard, panel de usuario y login, como guía visual del producto final.
