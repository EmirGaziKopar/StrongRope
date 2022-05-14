using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallCreator : MonoBehaviour
{

    int rastgeleSayi;

    int rastgeleSayi2;

    public GameObject kg5;

    public GameObject kg10;

    public GameObject kg20;

    public GameObject elmas;


    public GameObject[] gameObjects = new GameObject[4];


    

    int sayac;

    float time;

    // Start is called before the first frame update
    void Start()
    {
        rastgeleSayi2 = 2;
        gameObjects[0] = kg5;
        gameObjects[1] = kg10;
        gameObjects[2] = kg20;
        gameObjects[3] = elmas;

    }

    // Update is called once per frame
    void Update()
    {

        

        if (time < rastgeleSayi2 )
        {
            time += Time.deltaTime;

            
        }
        else
        {
            rastgeleSayi2 = Random.Range(2, 10);

            rastgeleSayi = Random.Range(0, 4);
            Instantiate(gameObjects[rastgeleSayi], transform.position, Quaternion.identity);

            time = 0;

        }
        
        
    }
}
