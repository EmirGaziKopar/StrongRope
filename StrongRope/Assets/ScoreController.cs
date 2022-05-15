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
        time += Time.deltaTime;
        score.text = time.ToString();
    }
}
