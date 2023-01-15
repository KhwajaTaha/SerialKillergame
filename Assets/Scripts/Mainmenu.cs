using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("DemoScene");
    }

    public void quit()
    {
        Application.Quit();
    }
}
