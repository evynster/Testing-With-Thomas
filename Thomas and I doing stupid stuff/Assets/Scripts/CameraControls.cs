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

        //Mouse looking code.  gets the x and y mouse movement and applies it to the rotational vector of the camera.
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity *10 *Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity *10 *Time.deltaTime;
        

        transform.Rotate(Vector3.up * mouseX);
        transform.Rotate(Vector3.left * mouseY);
        //any Z rotation from the mouse is then clamped out here.
        Vector3 mouseLook = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 0);
        //transform.leulerAngles = mouseLook;
        //mouseLook.x = Mathf.Clamp(mouseLook.x, 0f,89.5f );

        mouseLook.x = Mathf.Clamp(mouseLook.x, 0, 150);
       /* if(mouseLook.x >85f && mouseLook.x < 90f)
        {
            mouseLook.x = 84.9999999999999999f;
        }
        else if (mouseLook.x < 270f && mouseLook.x > 275f)
        {
            mouseLook.x = 275.00000000000000001f;
        }
         */
        transform.localRotation = Quaternion.Euler(mouseLook.x, mouseLook.y, 0f);
        Debug.Log("mouse raw input "+ mouseX + mouseY + "mouseLook v3 x,y: " + mouseLook.x +" , "+ mouseLook.y);
        cameraTranslationSpeed();
        cameraKeyMovement();
        
    }
    void cameraTranslationSpeed() {
        if (Input.mouseScrollDelta.y > 0)
        {
            speed++;
        }
        else if (Input.mouseScrollDelta.y < 0 && speed > 0)
        {
            speed--;
        }

    }
    void cameraKeyMovement() {
        //keyboard rotation 
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward * 0.05f);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.back * 0.05f);
        }
        //keyboard translation 
        if (Input.GetKey(KeyCode.D))
        {
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
