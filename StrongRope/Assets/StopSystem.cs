using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "platform")
        {
            Debug.Log("geldi");
            collision.gameObject.transform.GetComponent<MetalMovement>().speed = 0;
            collision.gameObject.transform.GetComponent<MetalMovement>().speed_2 = 0;

            collision.gameObject.transform.GetComponent<MetalMovement>().solSpeed = 0;
            collision.gameObject.transform.GetComponent<MetalMovement>().sagSpeed = 0;

            
        }
    }
}
