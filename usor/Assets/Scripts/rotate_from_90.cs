using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_from_90 : MonoBehaviour
{
    public Transform go;
    public float timer;
    public float speed;

    private float endTime = 0F;
    Quaternion target = Quaternion.Euler(0, 0, -90), target1 = Quaternion.Euler(0, 0, -180);
    
    void Update () {

            if (Input.GetMouseButtonUp(0))
                    endTime = Time.time + timer;
           // else if (transform.rotation == target)
            //        endTime = 0F;


            if (endTime > Time.time && transform.rotation != target1)
                    //go.Rotate(Vector3.back, speed * Time.deltaTime);
                    go.transform.Rotate(0, 0, -10);
    }
}
