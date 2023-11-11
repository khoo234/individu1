using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class myVariable : MonoBehaviour
{

    private int health = 100;
    private int Health = 100;
    private int myhealth = 100;
    private string messageForTheTextView = "New Text";
    private const int PlayerScore = 100;
    //private const int PLAYER_SCORE = 100;

    
    
    public string firstname;
    
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Ohayou {firstname}!";
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {

        }
    }
}
