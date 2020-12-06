using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void Scene_Changer(string name)
    {
        SceneManager.LoadScene(name,LoadSceneMode.Single);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
