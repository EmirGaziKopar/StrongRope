using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(KgTopla.isGameOver == true)
        {
            this.gameObject.GetComponent<Rigidbody2D>().simulated = false;
        }
    }
}
