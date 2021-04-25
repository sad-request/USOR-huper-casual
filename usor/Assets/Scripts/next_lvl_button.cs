using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class next_lvl_button : MonoBehaviour
{
    void OnMouseUp () {
        SceneManager.LoadScene("2lvl");
        global.partChecker=0;
        global.rowChecker=0;
    }
}
