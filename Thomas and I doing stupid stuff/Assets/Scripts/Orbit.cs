using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform target;
    public float radius = 1;
    public float orbitTime = 1;
    public float day = 0.0f;
    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(Mathf.Sin((day / orbitTime) * 2 * Mathf.PI) * radius, 0, Mathf.Cos((day / orbitTime) * 2 * Mathf.PI) * radius) ;
        //transform.position = new Vector3(transform.position.x / transform.localScale.x, transform.position.y / transform.localScale.y, transform.position.z / transform.localScale.z);
        day += Time.deltaTime;
    }
}
