using UnityEngine;

public class MoveKOUKOKU : MonoBehaviour
{

    float rotSpeed = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        this.rotSpeed = 5.5f;

        transform.Rotate(0, 0, rotSpeed);

    }
}
