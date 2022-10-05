using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelloWorldTwo : MonoBehaviour
{
    public Button Next;

    public void press()
    {
        SceneManager.LoadScene("Scene02");
        
    }
}
