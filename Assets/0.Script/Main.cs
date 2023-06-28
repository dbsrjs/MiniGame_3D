using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void OnGame0()
    {
        SceneManager.LoadScene("Game0");
    }
    public void OnGame1()
    {
        SceneManager.LoadScene("Game1");
    }

    public void OnGame2()
    {
        SceneManager.LoadScene("Game2");
    }
}
