using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneTwo : MonoBehaviour
{

    public float Zahl;
    public Text ZahlText;
    
    void Update()
    {
        ZahlText.text = Zahl.ToString();
    }

    public void plus()
    {
        Zahl++;
    }

    public void minus()
    {
        Zahl--;
    }

    public void mult()
    {
        Zahl = Zahl * 2;
    }

    public void divid()
    {
        Zahl = Zahl / 2;
    }

    public void back()
    {
        SceneManager.LoadScene("Scene01");
    }
}
