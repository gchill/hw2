using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class speedValue : MonoBehaviour
{
    public Slider Slider; 
    public TextMeshProUGUI speedTxt;
    public static float speed;

    void Update()
    {
       speed = Slider.value;
       speedTxt.text = speed.ToString();
    }
}
