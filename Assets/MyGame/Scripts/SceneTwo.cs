using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneTwo : MonoBehaviour
{

    public float zahl;
    public Text zahlText;
    
    void Update()
    {
        zahlText.text = zahl.ToString();
    }

    public void Plus()
    {
        zahl++;
    }

    public void Minus()
    {
        zahl--;
    }

    public void Mult()
    {
        zahl = zahl * 2;
    }

    public void Mivid()
    {
        zahl = zahl / 2;
    }

    public void Back()
    {
        SceneManager.LoadScene("Scene01");
    }
}
