# introduccion-scripts-Unity

## Ejercicio 1

El ejercicio 1 se ha realizado asociando el script *"vectorColor.cs"* a un GameObject cubo. Como un valor del vector debe cambiar cada 120 frames, se utiliza `Update()` para contabilizarlos, ya que este método se ejecuta una vez por frame. Además, se declaran variables públicas para poder modificar su valor desde el inspector.

En el GIF a continuación se muestra la ejecución de dicho ejercicio:

*Con 120 como cantidad de frames de espera:*

<img width="174" height="198" alt="Adobe Express - Grabación de pantalla 2026-09-28 124544" src="https://github.com/user-attachments/assets/01b2c955-0052-48d4-8117-a26ba6c720d0" />

*Con 15 como cantidad de frames de espera:*

<img width="214" height="232" alt="Adobe Express - Grabación de pantalla 2026-09-28 134811" src="https://github.com/user-attachments/assets/2ee65a2b-da5e-4972-aae1-12debf246b16" />

## Ejercicio 2

Para este ejercicio se ha asociado el script *"vector3D.cs"* a una esfera. Dado que se pide dar valor a cada componente de los vectores desde el inspector, estos se han declarado como variables públicas. Del mismo modo, los resultados obtenidos también se han declarado como variables públicas para poder visualizarlos en el inspector.

El script calcula la magnitud de cada vector, el ángulo que forman, la distancia entre ambos y cuál de los dos se encuentra a mayor altura. Estos resultados se muestran tanto en la consola como en el Inspector.
A continuación se muestran ambos tras su ejecución:

<img width="217" height="143" alt="image" src="https://github.com/user-attachments/assets/a127d1d0-2842-48dc-9193-e8b9f1cb77da" />

<img width="366" height="177" alt="Captura de pantalla 2026-09-28 232655" src="https://github.com/user-attachments/assets/7a878c1b-492d-4274-af72-bb1da9111eae" />

## Ejercicio 3

Se ha asociado el script *"positionSphere.cs"* al mismo GameObject esfera que en el ejercicio anterior. Su objetivo es mostrar en la consola la posición de la esfera.

Para obtener dicha posición se puede acceder directamente a la propiedad `position` del componente `Transform` mediante `transform.position`. También sería posible obtener una referencia al componente utilizando `Transform tr = GetComponent<Transform>()` y acceder posteriormente a su propiedad con `tr.position`. En este caso se ha utilizado `transform.position`.

Esto es lo que se muestra en la consola al ejecutar el script:

<img width="257" height="58" alt="image" src="https://github.com/user-attachments/assets/ee4a3911-810f-482a-a234-e6e4c5780e75" />

## Ejercicio 4

En este ejercicio se ha asociado el script *"distance.cs"* a la esfera para calcular la distancia entre esta y los otros dos GameObjects de la escena: el cubo y el cilindro.

Para poder acceder al cubo y al cilindro desde la esfera (donde está asociado el script) se utilizan etiquetas mediante `GameObject.FindWithTag("cube")` y `GameObject.FindWithTag("cylinder")`. Una vez obtenidas las referencias necesarias, se accede a la posición de cada objeto mediante `transform.position` y se utiliza `Vector3.Distance()` para calcular la distancia entre sus posiciones.

De esta forma, el script calcula y muestra en la consola tanto la distancia entre la esfera y el cubo como la distancia entre la esfera y el cilindro. Como se muestra al ejecutarlo:

<img width="468" height="236" alt="Grabación de pantalla 2026-09-28 235835" src="https://github.com/user-attachments/assets/5be96e28-7e92-4a89-96cc-3eeb8c755a3a" />

<img width="308" height="58" alt="image" src="https://github.com/user-attachments/assets/44b4f3d5-0305-4512-8b33-7e969a30a5d5" />

<img width="534" height="194" alt="Grabación de pantalla 2026-09-29 000355" src="https://github.com/user-attachments/assets/2b5defaf-d777-4e39-9fb9-db6c9c3ffa62" />

<img width="271" height="58" alt="image" src="https://github.com/user-attachments/assets/f9a4b1ec-2723-4078-959e-e16d260852e6" />

*Candela García Cruz*
