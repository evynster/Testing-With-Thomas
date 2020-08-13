using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    //brackeys told me to do this
    public float mouseSensitivity = 100f;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse looking code
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime*10;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime*10;

        transform.Rotate(Vector3.up * mouseX);
        transform.Rotate(Vector3.left * mouseY);
        //keyboard rotation 
        if (Input.GetKey(KeyCode.Q)) {
            transform.Rotate(Vector3.forward*0.05f);
        }else if (Input.GetKey(KeyCode.E)) {
            transform.Rotate(Vector3.back*0.05f);
        }
        //keyboard translation 
        
        if (Input.mouseScrollDelta.y > 0) {
            speed++;
        } else if(Input.mouseScrollDelta.y < 0 && speed > 0) {
            speed--;
        }
       // if (speed == 0)
        if (Input.GetKey(KeyCode.D)) { 
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0f, speed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0f, -speed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
    }
}
