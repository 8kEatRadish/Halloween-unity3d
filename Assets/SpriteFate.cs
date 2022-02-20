using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFate : MonoBehaviour
{
    public float Duration = 2.0f;
    
    float elapse;

    // Start is called before the first frame update
    void Start()
    {
        SetAlpha(0);
    }

    void SetAlpha(float a){
        var sp = GetComponent<SpriteRenderer>();
        var c = sp.color;
        c.a = a;
        sp.color = c;
    }

    // Update is called once per frame
    void Update()
    {
        if (elapse < Duration)
        {
            elapse += Time.deltaTime;
            SetAlpha(elapse / Duration);
        }
    }
}
