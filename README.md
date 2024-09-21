# Sentirse Bien WebApp

### Cómo Colaborar en el Proyecto

#### 1. Clonar el Proyecto desde GitHub utilizando Visual Studio

1. **Instalar Visual Studio** (si no lo tienes instalado).
   - Asegúrate de seleccionar el paquete de desarrollo web .NET al instalar Visual Studio.

2. **Clonar el Repositorio:**
   1. Abre Visual Studio.
   2. En la pantalla de inicio, selecciona **"Clonar un repositorio"**.
   3. En el campo **"Repositorio URL"**, introduce la URL de este repositorio:
      ```
      https://github.com/federicobejarano/sentirsebien-webapp.git
      ```
   4. Elige una carpeta local donde se guardará el proyecto y haz clic en **"Clonar"**.
   
   Esto descargará todos los archivos del proyecto en tu computadora y te permitirá trabajar en ellos desde Visual Studio.

#### 2. Crear una Nueva Rama para Realizar Modificaciones

Es importante que no trabajes directamente en la rama `main` para evitar conflictos y mantener el código limpio. Sigue estos pasos para crear una nueva rama antes de hacer cualquier cambio.

1. **Crear una nueva rama en Visual Studio:**
   1. Ve al **Explorador de Git** en Visual Studio.
   2. En la esquina inferior derecha, verás la rama actual, que debería ser `main`. Haz clic en ella.
   3. Selecciona **"Nueva Rama"** o **"New Branch"**.
   4. Asigna un nombre a tu rama que refleje la tarea que estás realizando (por ejemplo, `feature/nueva-funcionalidad`, `bugfix/arreglar-boton`, etc.).
   5. Asegúrate de que la opción **"Basada en: main"** esté seleccionada.
   6. Haz clic en **"Crear rama"**.

2. **Cambiar a tu nueva rama:**
   - Visual Studio debería cambiar automáticamente a la nueva rama, pero si no es así, haz clic en la barra inferior donde aparece el nombre de la rama y selecciona tu nueva rama.

#### 3. Realizar Cambios y Confirmar los Commits

1. **Haz las modificaciones que necesites en el proyecto.**
   
2. **Guardar y confirmar tus cambios:**
   - Después de realizar cambios, ve al **Explorador de Git** y selecciona los archivos que modificaste.
   - Escribe un mensaje descriptivo en el campo de commit para explicar qué cambios hiciste.
   - Haz clic en **"Confirmar todo"** o **"Commit all"**.

3. **Enviar los cambios al repositorio remoto:**
   - Para enviar tus cambios al repositorio remoto, haz clic en el botón **"Sincronizar"** o **"Push"** en el explorador de Git.

#### 4. Crear un Pull Request

Una vez que hayas terminado de trabajar en tu rama, es momento de solicitar que tus cambios sean revisados e integrados en la rama `main`. Para ello, debes crear un Pull Request (PR).

1. **Crear un Pull Request desde GitHub:**
   1. Ve a la página del repositorio en GitHub.
   2. Verás una notificación que indica que has realizado cambios recientes en una rama y te dará la opción de crear un **Pull Request**.
   3. Haz clic en **"Comparar & Pull Request"**.
   4. Agrega un título y una descripción clara de los cambios que realizaste.
   5. Asegúrate de que la rama base sea `main` y que la rama de comparación sea la que creaste.
   6. Haz clic en **"Crear Pull Request"**.

2. **Revisión y Aprobación:**
   - Un miembro del equipo revisará el Pull Request, y si todo está correcto, se fusionará con la rama `main`.

---

### Buenas Prácticas

- **Siempre trabaja en tu propia rama**. No realices cambios directamente en `main`.
- **Crea un Pull Request** para que tus compañeros puedan revisar los cambios antes de fusionarlos.
- **Escribe mensajes de commit claros y descriptivos**. Esto ayuda a mantener un historial comprensible del proyecto.

---

Puedes añadir esta documentación como un archivo `README.md` o `CONTRIBUTING.md` en el repositorio para que tus compañeros puedan consultarlo en cualquier momento. ¡Esto les ayudará a entender el flujo de trabajo adecuado y a colaborar eficazmente!
