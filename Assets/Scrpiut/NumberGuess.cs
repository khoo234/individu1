using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuess : MonoBehaviour
{
    public int guess;
    public int randomnumber;
    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = "Pick number 1-10";
        randomnumber = Random.RandomRange(1, 10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void checkGuesss()
    {
        if (guess > 0 && guess < 11)
        {
            if (guess == randomnumber)
            {
                textMeshPro.text = "Sama";

            }
            else if (guess > randomnumber)
            {
                textMeshPro.text = "Guess > number";
            }
            else
            {
                textMeshPro.text = "number > guess";
            }
        }
        else
        {
            textMeshPro.text = "Please number 1-10";
        }
    }
}
