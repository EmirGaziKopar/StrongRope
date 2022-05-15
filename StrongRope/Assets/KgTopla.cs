using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KgTopla : MonoBehaviour
{

    
    List<GameObject> Balls = new List<GameObject>();


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
        Balls.Add(collision.gameObject);
        Debug.Log(Balls.Count);
    }

    

}
