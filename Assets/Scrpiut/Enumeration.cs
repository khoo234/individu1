using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum MovementAxis
{
    Down,
    Up
}

public class Enumeration : MonoBehaviour
{
    public MovementAxis playerdirection;
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

    public void showmessage()
    {
        if (playerdirection == MovementAxis.Up)
        {
            textMeshPro.text = $"Player Moving 1";
        }
        else
        {
            textMeshPro.text = $"Player moving -1";
        }
    }
        
}
