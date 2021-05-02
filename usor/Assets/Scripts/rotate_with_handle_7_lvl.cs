using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rotate_with_handle_7_lvl : MonoBehaviour
{
   void check_rot0 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation.eulerAngles == vector0) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }

    void check_rot90 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation.eulerAngles == vector90) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }
    void check_rot180 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation.eulerAngles == vector180) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }
    void check_rot270 (GameObject objName, string findName){
        objName = GameObject.Find(findName);
        if (objName.transform.rotation.eulerAngles == vector270) {
        global.partChecker += 1;
        }
        else {global.partChecker = 0;}
    }

    void all_rot_check () {
        global.partChecker = 0;
      //  Debug.Log (global.partChecker);
        check_rot180(obj1, "1_1");
      //  Debug.Log (global.partChecker);
        check_rot270(obj2, "1_2");
      //  Debug.Log (global.partChecker);
        check_rot270(obj3, "1_3");
      //  Debug.Log (global.partChecker);
        check_rot270(obj4, "1_4");
       // Debug.Log (global.partChecker);

        check_rot90(obj5, "1_5");
       // Debug.Log (global.partChecker);
        check_rot0(obj6, "1_6");
      //  Debug.Log (global.partChecker);
        check_rot0(obj7, "1_7");
      //  Debug.Log (global.partChecker);
        check_rot0(obj8, "1_8");
     //   Debug.Log (global.partChecker);

        check_rot180(obj9, "1_9");
      //  Debug.Log (global.partChecker);
        check_rot180(obj10, "1_10");
      //  Debug.Log (global.partChecker);
        check_rot180(obj11, "1_11");
      //  Debug.Log (global.partChecker);
        check_rot270(obj12, "1_12");
      //  Debug.Log (global.partChecker);
        
        check_rot90(obj13, "1_13");
       // Debug.Log (global.partChecker);
        check_rot90(obj14, "1_14");
       // Debug.Log (global.partChecker);
        check_rot90(obj15, "1_15");
       // Debug.Log (global.partChecker);
        check_rot0(obj16, "1_16");
       // Debug.Log (global.partChecker);
    }


    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16;

    Vector3 vector0= new Vector3(0, 0, 0);
    Vector3 vector90= new Vector3(0, 0, 270);
    Vector3 vector180= new Vector3(0, 0, 180);
    Vector3 vector270= new Vector3(0, 0, 90);
    public GameObject part;

    public void OnMouseUp() { 
        this.transform.Rotate(0, 0, -90);     
        all_rot_check ();
        if (global.rowChecker==1 & global.partChecker==16){
            SceneManager.LoadScene("congrats");
        }              
    }
}
