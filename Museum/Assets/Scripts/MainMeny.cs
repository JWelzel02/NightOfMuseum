using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeny : MonoBehaviour
{
    public void Playgame ()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Quit ()
    {
        Application.Quit();
    }
}
