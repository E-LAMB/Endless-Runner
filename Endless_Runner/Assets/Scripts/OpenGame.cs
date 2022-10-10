using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGame : MonoBehaviour
{

    public int loadtarget = 0;

    public void loadGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(loadtarget);
    }
}
