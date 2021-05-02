using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class to_menu : MonoBehaviour
{
    public void OnClick () {
        global.lvlNumber=0;
        SceneManager.LoadScene("menu");
        global.partChecker=0;
        global.rowChecker=0;        
    }
}
