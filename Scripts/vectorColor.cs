using UnityEngine;

public class vectorColor : MonoBehaviour
{
    public int waitingFrames = 120;
    private int framesCounter = 0;
    private Vector3 initialVector;
    private Renderer rd;

    void Start()
    {
        rd = GetComponent<Renderer>();
        
        initialVector = new Vector3(Random.value, Random.value, Random.value);

        Color newColor = new Color(initialVector.x, initialVector.y, initialVector.z);
        rd.material.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {
        framesCounter++;
        if (framesCounter == waitingFrames) {
            ChangeColor();
            framesCounter = 0;
        }  
    }

    void ChangeColor()
    {
        int position = Random.Range(0, 3);
        if (position == 0) {
            initialVector.x = Random.value;
        }
        else if (position == 1) {
            initialVector.y = Random.value;
        }
        else {
            initialVector.z = Random.value;
        }

        Color newColor = new Color(initialVector.x, initialVector.y, initialVector.z);
        rd.material.color = newColor;
    }
}
