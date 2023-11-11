using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    public string firstname;
    public string lastname;
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Ohayou {firstname} {lastname}!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
