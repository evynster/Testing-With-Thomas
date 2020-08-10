using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerTrackPlanet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform planetPosition;
    // Update is called once per frame
    void Update()
    {
        transform.position=planetPosition.position;
        transform.position = transform.position + new Vector3(0,10,0);
    }
}
