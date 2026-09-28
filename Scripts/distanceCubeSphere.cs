using UnityEngine;

public class distanceCubeSphere : MonoBehaviour
{
    GameObject theSphere;

    void Start()
    {
        theSphere = GameObject.FindWithTag("sphere");

        float distance = Vector3.Distance(
            transform.position, 
            theSphere.transform.position
        );
        Debug.Log("Distancia del cubo a la esfera: " + distance);
    }
}
