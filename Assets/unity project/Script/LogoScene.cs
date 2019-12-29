using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoScene : MonoBehaviour
{
    // Change scene 3sec later
    void Start()
    {
        Invoke("Scene_Main", 3f);
    }

    // Define Scene_Main
    void Scene_Main()
    {
        SceneManager.LoadScene("Main");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
