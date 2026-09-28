using UnityEngine;

public class distanceCylinderSphere : MonoBehaviour
{
    GameObject theSphere;

    void Start()
    {
        theSphere = GameObject.FindWithTag("sphere");

        float distance = Vector3.Distance(
            transform.position, 
            theSphere.transform.position
        );
        Debug.Log("Distancia del cilindro a la esfera: " + distance);
    }
}
