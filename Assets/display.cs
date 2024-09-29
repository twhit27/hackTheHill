using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class display: MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void storeName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Today you are working on " + theName;
    }
    
}
