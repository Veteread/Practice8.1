using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{   
    public void MainScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Scene2()
    {       
        SceneManager.LoadScene(1);
    }
}
