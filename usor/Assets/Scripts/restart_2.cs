using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart_2 : MonoBehaviour
{
    void OnMouseUp () {
        SceneManager.LoadScene("2lvl");
        global.partChecker=0;
        global.rowChecker=0;
    }
}
