using UnityEngine;

public class vector3 : MonoBehaviour
{
    public Vector3 firstVector;
    public Vector3 secondVector;
    public float magnitude1;
    public float magnitude2;
    public float angle;
    public float distance;
    public string highestVector;

    void Start()
    {
        magnitude1 = firstVector.magnitude;
        magnitude2 = secondVector.magnitude;
        Debug.Log("Magnitud del primer vector: " + magnitude1);
        Debug.Log("Magnitud del segundo vector: " + magnitude2);

        angle = Vector3.Angle(firstVector, secondVector);
        Debug.Log("Ángulo que forman: " + angle);

        distance = Vector3.Distance(firstVector, secondVector);
        Debug.Log("Distancia entre ambos vectores: " + distance);

        FindHighestVector();
    }

    void FindHighestVector() {
        if (firstVector.y > secondVector.y) {
            highestVector = "El primer vector está a mayor altura";
        }
        else if (firstVector.y < secondVector.y) {
            highestVector = "El segundo vector está a mayor altura";
        } else {
            highestVector = "Ambos vectores tienen la misma altura";
        }
        Debug.Log(highestVector);
    }
}
