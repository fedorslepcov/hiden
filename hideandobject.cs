using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hideandobject : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI win;
    static int score = 0;

    void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(text);
        score = score + 1;
        if (score == 3){
            win.text = "Ты выиграл!";
        }
    }
   
}
