using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LV2sel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene("select LV");
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("LV3sel");
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("LV2");
        }
    }
}