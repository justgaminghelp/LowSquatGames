using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Button_start()
    {
        SceneManager.LoadScene("FirstDisplay",LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
