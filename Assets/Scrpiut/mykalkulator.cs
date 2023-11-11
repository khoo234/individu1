using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mykalkulator : MonoBehaviour
{
    public int amount = 1000;
    public float percentage = 0.2f;
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

    public void display()
    {
        float tipamount = (float)amount * percentage;
        textMeshPro.text = $"hasil {tipamount}";
    }
}
