using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MetalMovement : MonoBehaviour
{

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
        if (taraf==Taraf.sol)
        {
            transform.position += new Vector3(-solSpeed * Time.deltaTime, 0, 0);

            if (sagBasladi && speed > 0)
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

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
                */

            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                sayac = 0;

            }

        }

        if (taraf ==Taraf.sag)
        {
            transform.position += new Vector3(sagSpeed * Time.deltaTime, 0, 0);

            if (solBasladi && speed_2>0)
            {
                transform.position += new Vector3(-speed_2 * Time.deltaTime, 0, 0);
                speed_2 -= 0.1f;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                solBasladi = true;
                speed_2 = tmpSpeed2;
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                sayac_2 = 0;

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
