using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MetalMovement : MonoBehaviour
{

    float hizlandirTime;

    int hizlandirSayac;

    public enum Taraf {
        sol, sag
    };

     public Taraf taraf;

    float tmpSpeed;

    float tmpSpeed2;

    public bool sagBasladi;

    public bool solBasladi;

    public float speed;

    public float speed_2;


    public float solSpeed;

    public float sagSpeed;


    public Rigidbody2D rigidbody2D;

    int sayac,sayac_2;

    float time;

    float time2;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        tmpSpeed = speed;

        tmpSpeed2 = speed_2;

    }

    // Update is called once per frame
    void Update()
    {


        if(hizlandirTime < 3)
        {
            hizlandirTime += Time.deltaTime;
        }
        else
        {
            hizlandirTime = 0;

            hizlandirSayac++;

            if (hizlandirSayac < 3)
            {
                solSpeed += 0.25f;
                sagSpeed += 0.25f;

            }
            if(hizlandirSayac == 2)
            {
                
                solSpeed += 0.20f;   
                sagSpeed += 0.20f;
            }
            
        }

        //transform.position += new Vector3(1*Time.deltaTime * speed, 0, 0);

        /*
        time2 += Time.deltaTime;
        if (time2 < 0.5f)
        {
            time2 += Time.deltaTime;
        }
        else
        {
            Debug.Log(time);
            time2 += Time.deltaTime;
            rigidbody2D.velocity = new Vector3(-50 * Time.deltaTime, 0, 0);
        }
        *
        *
        */





        if (taraf == Taraf.sol && Vector3.Distance(GameObject.FindGameObjectWithTag("Orta").transform.position, transform.GetChild(1).position) > 0.5f && Vector3.Distance(GameObject.FindGameObjectWithTag("mesafe").transform.position, GameObject.FindGameObjectWithTag("mesafeSol").transform.position) > 0.5f)
        {
            transform.position += new Vector3(-solSpeed * Time.deltaTime, 0, 0);

            if (sagBasladi && speed > 0)
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

                speed -= 0.1f;


            }


            if (Input.GetKeyDown(KeyCode.A) || Input.GetMouseButtonDown(0))
            {
                sagBasladi = true;


                speed = tmpSpeed;

                /*if (sayac < 3)
                {
                    sayac++;


                    Vector3 a = new Vector3(0.01f, 0, 0);
                    rigidbody2D.velocity = a * speed;


                }
                */

            }
            if (Input.GetKeyUp(KeyCode.A) || Input.GetMouseButtonUp(0))
            {
                sayac = 0;

            }
        }
        else
        {
            //olurda sýnýr dýþýna çýkarsa oyun bugda kalmasýn diye kýsýtýn dýþýna itme iþlemi yapýyoruz.
            if(taraf == Taraf.sol && Vector3.Distance(GameObject.FindGameObjectWithTag("Orta").transform.position, transform.GetChild(1).position) <= 0.5f)
            {
                Debug.Log("Girdikkkk");
                transform.position -= new Vector3(1 * Time.deltaTime, 0, 0);
            }
            

            if(taraf == Taraf.sol && Vector3.Distance( GameObject.FindGameObjectWithTag("mesafe").transform.position, GameObject.FindGameObjectWithTag("mesafeSol").transform.position) <= 0.5f)
            {
                transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
            }
            
        }
        if (taraf == Taraf.sag && Vector3.Distance(GameObject.FindGameObjectWithTag("Orta").transform.position, transform.GetChild(1).position) > 0.5f && Vector3.Distance(GameObject.FindGameObjectWithTag("mesafee").transform.position, GameObject.FindGameObjectWithTag("mesafeSag").transform.position) > 0.5f)
        {
            transform.position += new Vector3(sagSpeed * Time.deltaTime, 0, 0);

            if (solBasladi && speed_2 > 0)
            {
                transform.position += new Vector3(-speed_2 * Time.deltaTime, 0, 0);
                speed_2 -= 0.1f;
            }

            if (Input.GetKeyDown(KeyCode.D) || Input.GetMouseButtonDown(1))
            {
                solBasladi = true;
                speed_2 = tmpSpeed2;
            }

            if (Input.GetKeyUp(KeyCode.D)  || Input.GetMouseButtonUp(1))
            {
                sayac_2 = 0;

            }
        }

        else
        {
            if (taraf == Taraf.sag && Vector3.Distance(GameObject.FindGameObjectWithTag("Orta").transform.position, transform.GetChild(1).position) < 0.5f)
            {
                transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
            }

            if (taraf == Taraf.sag && Vector3.Distance(GameObject.FindGameObjectWithTag("mesafee").transform.position, GameObject.FindGameObjectWithTag("mesafeSag").transform.position) < 0.5f)
            {
                transform.position -= new Vector3(1 * Time.deltaTime, 0, 0);
            }
        }




            /*transform.position += new Vector3(-solSpeed * Time.deltaTime, 0, 0);

            if (sagBasladi &&  speed>0)
            {
                transform.position += new Vector3(speed* Time.deltaTime, 0, 0);

                speed -= 0.1f;


            }       


            if (Input.GetKeyDown(KeyCode.A))
            {
                sagBasladi = true;


                speed = tmpSpeed;

                /*if (sayac < 3)
                {
                    sayac++;


                    Vector3 a = new Vector3(0.01f, 0, 0);
                    rigidbody2D.velocity = a * speed;


                }


            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                sayac = 0;

            }*/






        }
}
