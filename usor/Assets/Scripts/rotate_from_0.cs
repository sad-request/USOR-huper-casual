using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotate_from_0 : MonoBehaviour
{   
    void Start () {

    }
  
    public void rotate0_90 () {
        GetComponent<Animation>().Play("rotate0_90");
    }
}
