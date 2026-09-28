using UnityEngine;

public class distance : MonoBehaviour
{
    void Start()
    {
        Vector3 positionCylinder = GameObject.FindWithTag("cylinder").transform.position;
        Vector3 positionCube = GameObject.FindWithTag("cube").transform.position;
        float distanceCylinder = Vector3.Distance(
            transform.position, 
            positionCylinder
        );
        float distanceCube = Vector3.Distance(
            transform.position, 
            positionCube
        );
        Debug.Log("Distancia de la esfera al cilindro: " + distanceCylinder);
        Debug.Log("Distancia de la esfera al cubo: " + distanceCube);
    }
}
