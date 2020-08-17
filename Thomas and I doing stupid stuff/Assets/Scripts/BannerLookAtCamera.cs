//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class BannerLookAtCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform targetCamera;
    
    // Update is called once per frame
    void Update()
    {
        float cameraZAxisInverted = targetCamera.transform.eulerAngles.z - (targetCamera.transform.eulerAngles.z * 2);
        Vector3 inheritCameraY = new Vector3(targetCamera.transform.eulerAngles.x, targetCamera.transform.eulerAngles.y, /*cameraZAxisInverted*/0);
        //transform.LookAt(target);
        transform.eulerAngles = inheritCameraY;
       // Debug.Log(inheritCameraY+ " "+ cameraZAxisInverted);
    }
}
