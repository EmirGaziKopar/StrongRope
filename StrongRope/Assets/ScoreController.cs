using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;




public class ScoreController : MonoBehaviour
{
    
    TextMeshProUGUI score;

    float time;

    


    // Start is called before the first frame update
    void Start()
    {
        score = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        float time2 = time;
        Mathf.Floor(time2);
        time += Time.deltaTime*10;
        score.text = "Score : " + System.Convert.ToInt32(time2).ToString();
    }
}
