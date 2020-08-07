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
        transform.position = target.transform.position + new Vector3((float)Mathf.Sin((day / orbitTime) * 360 * Mathf.PI / 180) * radius, 0, (float)Mathf.Cos((day / orbitTime) * 360 * Mathf.PI / 180) * radius);
        day += Time.deltaTime;
    }
}
