using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LV1sel : MonoBehaviour
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
            SceneManager.LoadScene("LV4sel");
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("LV2sel");
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("LV1");
        }
    }
}