using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class circle : MonoBehaviour
{
    public Image loading;
    public GameObject go;
    public int minutes;
    public int sec;
    bool tmp;
    int totalSeconds = 0;
    int TOTAL_SECONDS = 0;
    float fillamount;
    // Start is called before the first frame update
    void Start()
    {
        tmp=true;
        if (minutes > 0)
            totalSeconds += minutes * 60;
        if (sec > 0)
            totalSeconds += sec;
        TOTAL_SECONDS = totalSeconds;
        StartCoroutine(second());
        StartCoroutine(shake());
    }

    // Update is called once per frame
    void Update()
    {
        if (sec == 0 && minutes == 0)
        {
            StopCoroutine(second());
            StopCoroutine(shake());
        }
    }
    IEnumerator second()
    {
        yield return new WaitForSeconds(1f);
        if (sec > 0)
            sec--;
        if (sec == 0 && minutes != 0)
        {
            sec = 60;
            minutes--;
        }
        fillLoading();
        StartCoroutine(second());
    }
    IEnumerator shake()
    {
        yield return new WaitForSeconds(0.1f);
        if(sec<15 && minutes==0)
            if(tmp){
                go.transform.position+= new Vector3(1,0,0);
                tmp=false;
            }
            else {
                go.transform.position-= new Vector3(1,0,0);
                tmp=true;
            }
        StartCoroutine(shake());
    }
    void fillLoading()
    {
        totalSeconds--;
        float fill = (float)totalSeconds / TOTAL_SECONDS;
        loading.fillAmount= fill;
    }
}
