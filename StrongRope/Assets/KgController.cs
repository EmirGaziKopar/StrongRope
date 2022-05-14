using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KgController : MonoBehaviour
{
    GameObject[] Agirliklar;

    int kg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("5kg") != null)
        {
            kg = GameObject.FindGameObjectsWithTag("5kg").Length * 5;
            Debug.Log(kg);
        }
        
    }
}
