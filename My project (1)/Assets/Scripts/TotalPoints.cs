using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalPoints : MonoBehaviour
{
    public static int score;
    public TMPro.TMP_Text text2;


    void Start()
    {
        text2.text = $" Your total score: {score}" ;
    }
    

}
