using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public static Text showText;

    public string[] textDescription = new string[]
                            {"Yo", "Hi", "Boo"};
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void textDesc()
    {
        showText.text = "HIII";
    }
}
