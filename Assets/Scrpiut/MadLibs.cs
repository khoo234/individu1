using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MadLibs : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    public bool statement = false;
    public string verb = "eat";
    public string noun = "mustache";
    public string adjective = "smelly";

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"The statement is {statement}. i did not {verb} the {noun} i am a {adjective} person.";
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
