using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class circle_selected_color_change : MonoBehaviour
{
    public Sprite circle_handle, selected_circle, shadow, handleSp;
    static int selected1 = 0;

    public GameObject g1, g2, g3, g4;
    public Vector3 vec1;
    public Vector3 vec2 = new Vector3(2F, 2F, 2F);

    static string handleName1, handleName2;
    private string objName1, objName2;

    public GameObject row1, row2, row3, row4;
   // public Sprite item;
    
    void OnMouseUp () {
        if (global.partChecker==16 && global.rowChecker==1){
            //global.staticChecker = true;
           // Debug.Log (global.staticChecker);
            SceneManager.LoadScene("congrats");
           // global.rowChecker = 0;
           // global.partChecker = 0;
        } 
        else {
            if (selected1 == 0){
                objName1 = gameObject.name;
                handleName1 = objName1;
            }
            else if (selected1 == 1) {
                objName2 = gameObject.name;
                handleName2 = objName2;
            }


        if (selected1 == 1){
            g1 = GameObject.Find(handleName1);
            g2 = GameObject.Find(handleName2);
            vec1 = new Vector3(g1.gameObject.transform.position.x, g1.gameObject.transform.position.y, g1.gameObject.transform.position.z);
            vec2 = new Vector3(g2.gameObject.transform.position.x, g2.gameObject.transform.position.y, g2.gameObject.transform.position.z);
            vec1 = g1.gameObject.transform.position;
            vec2 = g2.gameObject.transform.position;
            g1.gameObject.transform.position = vec2;
            g2.gameObject.transform.position = vec1; 
           // g1.GetComponent<SpriteRenderer>().sprite = circle_handle;
           // g2.GetComponent<SpriteRenderer>().sprite = circle_handle;
            selected1 = 2;
        }


        if (selected1 > 1) {
            if (g1.GetComponent <SpriteRenderer> ().sprite == selected_circle
            ){
                g1.GetComponent<SpriteRenderer>().sprite = circle_handle;
               //Debug.Log (this.transform.Find("handle"));
                //this.transform.Find("handle").GetComponent<SpriteRenderer>().sprite = handleSp;
            }
                //Debug.Log ("g1.name");
            if (g2.GetComponent <SpriteRenderer> ().sprite == selected_circle
            ){
                // Debug.Log (this.transform.Find("handle"));
                g2.GetComponent<SpriteRenderer>().sprite = circle_handle;
               // this.transform.Find("handle").GetComponent<SpriteRenderer>().sprite = handleSp;
                }
              //  Debug.Log ("g2.name");
            selected1=0;
        }
        else if (GetComponent <SpriteRenderer> ().sprite == circle_handle
        ) {
            GetComponent <SpriteRenderer> ().sprite = selected_circle;
            //this.transform.Find("handle").GetComponent<SpriteRenderer>().sprite = shadow;
            selected1 += 1;            
        }
        else if (GetComponent <SpriteRenderer> ().sprite == selected_circle 
         ){
            GetComponent <SpriteRenderer> ().sprite = circle_handle;
            //Debug.Log (this.transform.Find("handle"));
           // this.transform.Find("handle").GetComponent<SpriteRenderer>().sprite = handleSp;
            selected1 = 0;
        }



        row1 = GameObject.Find("circle-handle1");
        row2 = GameObject.Find("circle-handle2");
        row3 = GameObject.Find("circle-handle3");
        row4 = GameObject.Find("circle-handle4");


      /*  if (row3.transform.position.y < row4.transform.position.y) {
            if (row3.transform.position.y < row2.transform.position.y){
                if (row1.transform.position.y > row2.transform.position.y) {
                    if (row1.transform.position.y > row2.transform.position.y){
                        if (row4.transform.position.y < row2.transform.position.y){
                            if (row4.transform.position.y < row1.transform.position.y){
                                global.rowChecker = 1;
                            }
                        }
                    }
                    
                    // Debug.Log(row1);
                }
                
            }
           //rowChecker = 1;
        }*/

        if ((row1.transform.position.y > row2.transform.position.y)
        && (row2.transform.position.y > row3.transform.position.y)
        && (row3.transform.position.y > row4.transform.position.y)
        && (row1.transform.position.y > row4.transform.position.y)) {
            global.rowChecker = 1;
        }
        else {global.rowChecker = 0;}
       // Debug.Log(global.rowChecker);
    }
        }

            

}
