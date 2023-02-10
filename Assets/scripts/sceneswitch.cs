using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class sceneswitch : MonoBehaviour
{
    GameObject player; 
    public string change;
    public void StartPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void end()
    {
        Application.Quit();
    }
    public void changeColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
