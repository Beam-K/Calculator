using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{

    public TextMeshProUGUI Textt;


    public void ButtonClick(int number)
    {
        Textt.text += number.ToString();
    }

    public void RemoveAllText()
    {
        if (Textt != null)
        {
            Textt.text = string.Empty;
        }
    }

    public void RemoveLastNumber(int number)
    {
        if (Textt != null && Textt.text.Length > 0)
        {
            Textt.text = Textt.text.Substring(0, Textt.text.Length - 1);
        }
    }
}