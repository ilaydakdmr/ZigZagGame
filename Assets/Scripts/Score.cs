using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text scoretext;
    void Start()
    {
        score = 0;
    }

    
    void Update()
    {
        scoretext.text = score.ToString();
    }
}
