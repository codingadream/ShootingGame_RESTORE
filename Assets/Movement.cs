using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float speed;
    public float rotationSpeed;
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed, 0);

        if (Input.GetKey(KeyCode.W)) { transform.Translate(0, 0, speed); }
        if (Input.GetKey(KeyCode.S)) { transform.Translate(0, 0, -speed); }
        if (Input.GetKey(KeyCode.A)) { transform.Translate(-speed, 0, 0); }
        if (Input.GetKey(KeyCode.D)) { transform.Translate(speed, 0, 0); }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) { transform.Translate(0, 0, speed); }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { transform.Translate(0, 0, -speed); }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(-speed, 0, 0); }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { transform.Translate(speed, 0, 0); }

    }
}
