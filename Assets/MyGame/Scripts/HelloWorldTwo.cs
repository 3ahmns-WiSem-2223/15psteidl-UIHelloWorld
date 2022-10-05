using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelloWorldTwo : MonoBehaviour
{
    public Button next;

    public void Press()
    {
        SceneManager.LoadScene("Scene02");       
    }
}
