using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class to_congrats : MonoBehaviour
{
    void go_to_congrats () {
        if (global.staticChecker == true){
            //Debug.Log("errere");
            SceneManager.LoadScene("congrats");
        }
    }
}
