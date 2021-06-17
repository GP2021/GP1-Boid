using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderMotion : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 p = new Vector3();
        p.x = 5.0f * Mathf.Sin(Time.time * 2.0f);
        p.z = 5.0f * Mathf.Cos(Time.time * 2.0f);
        transform.position = p;
    }
}
