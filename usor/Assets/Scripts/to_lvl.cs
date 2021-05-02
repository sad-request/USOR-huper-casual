using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class to_lvl : MonoBehaviour
{    
     public string lvlButton;
    public void OnClick () {

        lvlButton = gameObject.name;

        if (lvlButton=="1_1") {
            global.lvlNumber=1;
            SceneManager.LoadScene("1lvl");
        }
        if (lvlButton=="1_2") {
            global.lvlNumber=2;
            SceneManager.LoadScene("2lvl");
        }
        if (lvlButton=="1_3") {
            global.lvlNumber=3;
            SceneManager.LoadScene("3lvl");
        }
        if (lvlButton=="1_4") {
            global.lvlNumber=4;
            SceneManager.LoadScene("4lvl");
        }
        if (lvlButton=="2_1") {
            global.lvlNumber=5;
            SceneManager.LoadScene("5lvl");
        }
        if (lvlButton=="2_2") {
            global.lvlNumber=6;
            SceneManager.LoadScene("6lvl");
        }
        if (lvlButton=="2_3") {
            global.lvlNumber=7;
            SceneManager.LoadScene("7lvl");
        }
        if (lvlButton=="2_4") {
            global.lvlNumber=8;
            SceneManager.LoadScene("8lvl");
        } 
    }
}
