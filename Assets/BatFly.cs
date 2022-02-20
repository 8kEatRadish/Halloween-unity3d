using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatFly : MonoBehaviour
{
    Vector3 origPos;
    float elapse;

    public float Interval = 0.05f;
    public float Range = 0.05f;
    // Start is called before the first frame update
    void Start(){
        origPos = transform.position;
    }

    // Update is called once per frame
    void Update(){
        elapse += Time.deltaTime;

        if(elapse > Interval){
            var pos = transform.position;
            pos.x = origPos.x + Random.Range(-Range,Range);
            pos.y = origPos.y + Random.Range(-Range,Range);
            transform.position = pos;

            elapse = 0.0f;
        }
    }
}
