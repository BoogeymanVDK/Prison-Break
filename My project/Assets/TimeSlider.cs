using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSlider : MonoBehaviour
{
    
    public float gametime;
    public Slider timerSlider;
    public bool stopTimer;
    float timee;
    // Start is called before the first frame update
   void Start()
   {
    timee=0;
    stopTimer = false;
    timerSlider.maxValue = gametime;
    timerSlider.value = gametime;
   }
    // Update is called once per frame
    void Update()
    {
        timee+=Time.deltaTime;
        float time = gametime - timee;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        if(time <= 0)
        {
            stopTimer = true;
            PlayerManager.isGameOver = true;
            
        }

        if(stopTimer == false)
        {
            timerSlider.value = time;
        }
        Debug.Log(Time.time);
    }

}
