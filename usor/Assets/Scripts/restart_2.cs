using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart_2 : MonoBehaviour
{
    /*public void OnClick () {
        SceneManager.LoadScene("2lvl");
        global.partChecker=0;
        global.rowChecker=0;
    }*/
    public void OnClick () {
        //global.lvlNumber+=1;
     //   string ToString (IFormatProvider? provider);
     //   numInt=global.lvlNumber;
      //  num=numInt.ToString(CultureInfo.InvariantCulture);
        if (global.lvlNumber==1) SceneManager.LoadScene("1lvl");
        if (global.lvlNumber==2) SceneManager.LoadScene("2lvl");
        if (global.lvlNumber==3) SceneManager.LoadScene("3lvl");
        if (global.lvlNumber==4) SceneManager.LoadScene("4lvl");
        if (global.lvlNumber==5) SceneManager.LoadScene("5lvl");
        if (global.lvlNumber==6) SceneManager.LoadScene("6lvl");
        if (global.lvlNumber==7) SceneManager.LoadScene("7lvl");
        if (global.lvlNumber==8) SceneManager.LoadScene("8lvl");
        if (global.lvlNumber==9) SceneManager.LoadScene("9lvl");
        global.partChecker=0;
        global.rowChecker=0; 
    }
}
