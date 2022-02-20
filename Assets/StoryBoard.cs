using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryBoard : MonoBehaviour
{
    float[] timeArray = new float[]{4,6,8,10,12};
    int index;

    public GameObject particle;
    public GameObject bat;
    public GameObject face;
    public GameObject word;

    bool canClick = false;

    // Start is called before the first frame update
    void Start()
    {
        particle.SetActive(false);
        bat.SetActive(false);
        face.SetActive(false);
        word.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (index < timeArray.Length && Time.realtimeSinceStartup >= timeArray[index])
        {
            OnTime(index);
            index++;
        }

        // 可点击并且点击鼠标左键
        if(canClick && Input.GetMouseButtonUp(0)){
            word.SetActive(true);
        }
    }

    void OnTime(int index){
        Debug.Log(index);
        switch (index)
        {
            case 0:{
                    particle.SetActive(true);
                }
                break;
            case 1:{
                bat.SetActive(true);
                }
                break;
            case 2:{
                face.SetActive(true);
                }
                break;
            case 3:{
                face.GetComponent<AudioSource>().Play();
                }
                break;
            case 4:{
                canClick = true;
                }
                break;
        }
    }
}
