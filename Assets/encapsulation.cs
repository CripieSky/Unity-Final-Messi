using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class encapsulation : MonoBehaviour
{
    // ENCAPSILATION
    public string text { get; set; }
    public TextMeshProUGUI titleText;

    private void Start()
    {
        SetText(); // POLYMORPHISM
    }

    void SetText()
    {
        text = Text = "Title";
        titleText.text = text;
    }

    public string Text
    {
        get { return text; }
        set { text = value; }
    }

}
