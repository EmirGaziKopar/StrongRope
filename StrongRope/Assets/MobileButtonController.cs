using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileButtonController : MonoBehaviour
{
    public static bool rightClick;
    public static bool leftClick;

    // Start is called before the first frame update
    void Start()
    {
        rightClick = false;
        leftClick = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void rigtDown()
    {
        rightClick = true;
    }

    public void rigtUp()
    {
        rightClick = false;
    }

    public void leftDown()
    {
        leftClick = true;
    }

    public void leftUp()
    {
        leftClick = false;
    }

}
