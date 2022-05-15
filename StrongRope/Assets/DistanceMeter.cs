using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceMeter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position , GameObject.FindGameObjectWithTag("mesafe").transform.position) > 0.5f);
    }
}
