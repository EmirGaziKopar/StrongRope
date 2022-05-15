using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KgTopla : MonoBehaviour
{
    public GameObject panel;

    public static bool isGameOver;
    
    List<GameObject> Balls = new List<GameObject>();

    public GameObject bar;

    float toplamKg = 1;

    // Start is called before the first frame update
    void Start()
    {
        bar.GetComponent<Image>().fillAmount = 1f;
        isGameOver = false;
        Time.timeScale = 1f;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bar.GetComponent<Image>().fillAmount = 1-(toplamKg/200); //200 bitis noktasý

        Debug.Log("Toplam : "+toplamKg);

        if(1 - (toplamKg / 200) <= 0.01)
        {
            isGameOver = true;
            Time.timeScale = 0.7f;
            panel.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        Balls.Add(collision.gameObject);
        Debug.Log(Balls.Count);
        */
        if(collision.gameObject.tag == "5kg")
        {
            toplamKg += 5;
        }
        if (collision.gameObject.tag == "10kg")
        {
            toplamKg += 10;
        }
        if (collision.gameObject.tag == "20kg")
        {
            toplamKg += 20;
        }
        if(collision.gameObject.tag == "elmas")
        {
            if (toplamKg >= 5)
            {
                toplamKg -= 5;
            }
            
        }


    }

    

}
