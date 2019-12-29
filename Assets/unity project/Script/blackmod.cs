using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackmod : MonoBehaviour
{    
    public GameObject A;
    Transform AT;
    void Start ()
    {
        AT=A.transform;
    }
    void LateUpdate () 
    {
        transform.position = new Vector3 (AT.position.x,0,0);
    }
}