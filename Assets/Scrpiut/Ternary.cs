using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ternary : MonoBehaviour
{
    public int currentplayer;
    private string message;

    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowMessage()
    {
        //string player = (currentplayer == 1) ? "Player One" : "Player two";
       // textMeshPro.text = $"Ready{player}";

        string status = (currentplayer % 2 == 0) ? "Even" : "odd";
        textMeshPro.text = $"{currentplayer} is {status}"; 
    }
}
