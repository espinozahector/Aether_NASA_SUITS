using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour
{
    public Button ResetButton;
    public Button StartButton;
    public Text Milliseconds;
    public Text Seconds;
    public Text Seconds2;
    public Text Minutes;
    public Text Minutes2;
    public Text Hours;
    public Text Hours2;
    float millise = 0;
    void Start()
    {
        Button ResButton = ResetButton.GetComponent<Button>();
        Button Startbtn = StartButton.GetComponent<Button>();
        Startbtn.onClick.AddListener(StartTimer);
        ResButton.onClick.AddListener(ResetTimer);
    }
    void ResetTimer()
    {
        float sec = float.Parse(Seconds.text);
        int min = int.Parse(Minutes.text);
        int hrs = int.Parse(Hours.text);
        millise = 0;
        sec = 0;
        min = 0;
        hrs = 0;
        CancelInvoke();
        Milliseconds.text = "" + millise.ToString("00");
        Seconds.text = "" + sec.ToString("0");
        Seconds2.text = "" + sec.ToString("0");
        Minutes.text = "" + min.ToString("0");
        Minutes2.text = "" + min.ToString("0");
        Hours.text = "" + hrs.ToString("0");
        Hours2.text = "" + hrs.ToString("0");
    }
    void StartTimer()
    {
        //Unhighlight Seconds
        Minutes2.color = Color.white;
        Minutes.color = Color.white;
        Seconds.color = Color.white;
        Seconds2.color = Color.white;
        Hours.color = Color.white;
        Hours2.color = Color.white;
        float sec = float.Parse(Seconds.text);
        float sec2 = float.Parse(Seconds2.text);
        int min = int.Parse(Minutes.text);
        int min2 = int.Parse(Minutes2.text);
        int hrs = int.Parse(Hours.text);
        int hrs2 = int.Parse(Hours2.text);
        if (hrs == 0 && min == 0 && sec==0&&hrs2==0&&min2==0&&sec2==0)
        {
            CancelInvoke();
            Milliseconds.text = "" + millise.ToString("00");
            Seconds.text = "" + sec.ToString("0");
            Seconds2.text = "" + sec.ToString("0");
            Minutes.text = "" + min.ToString("0");
            Minutes2.text = "" + min.ToString("0");
            Hours.text = "" + hrs.ToString("0");
            Hours2.text = "" + hrs.ToString("0");
        }
        else
        {
            InvokeRepeating("CountDown", .01f, .01f);
        }
    }
    public void CountDown()
    {
        float sec = float.Parse(Seconds.text);
        float sec2 = float.Parse(Seconds2.text);
        int min = int.Parse(Minutes.text);
        int min2 = int.Parse(Minutes2.text);
        int hrs = int.Parse(Hours.text);
        int hrs2 = int.Parse(Hours2.text);
        millise--;
        //Decrements minute/hours/seconds
        if (millise <= 0)
        {
            millise = 100;
            sec--;
        }
        if (sec <= -.9)                           //Decrements minute
        {
            sec = 9;
            sec2--;
        }
        if(sec2<=-.9)
        {
            sec2 = 5;
            min--;
        }
        if (min <=-.9)                              //Decrements Hours
        {
            min = 9;
            min2--;
        }
        if(min2<=-.9)
        {
            min2 = 5;
            hrs--;
        }
        if(hrs<0)
        {
            hrs = 9;
            hrs2--;
        }
        //Outputs the time to the user
        Milliseconds.text = "" + millise.ToString("00");
        Seconds.text = "" + sec.ToString("0");
        Seconds2.text = "" + sec2.ToString("0");
        Minutes.text = "" + min.ToString("0");
        Minutes2.text = "" + min2.ToString("0");
        Hours.text = "" + hrs.ToString("0");
        Hours2.text = "" + hrs2.ToString("0");
        //if (min < 10)
        //{
        //    Minutes.text = "" + min.ToString("D2");
        //}
        //else
        //{
        //    Minutes.text = "" + min.ToString();
        //}
        //if (hrs < 10)
        //{
        //    Hours.text = "" + hrs.ToString("D2");
        //}
        //else
        //{
        //    Hours.text = "" + hrs.ToString();
        //}
        if (hrs == 0 && min == 0 && sec == 0 && hrs2 == 0 && min2 == 0 && sec2 == 0&& millise <= 1)
        {
            millise = 0;
            sec = 0;
            sec2 = 0;
            min = 0;
            min2 = 0;
            hrs = 0;
            hrs2 = 0;
            Milliseconds.text = "" + millise.ToString("00");
            Seconds.text = "" + sec.ToString("0");
            Seconds2.text = "" + sec2.ToString("0");
            Minutes.text = "" + min.ToString("0");
            Minutes2.text = "" + min2.ToString("0");
            Hours.text = "" + hrs.ToString("0");
            Hours2.text = "" + hrs2.ToString("0");
            CancelInvoke();
        }

    }
}
