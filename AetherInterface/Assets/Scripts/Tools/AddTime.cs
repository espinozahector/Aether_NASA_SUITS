using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class AddTime : MonoBehaviour, IPointerClickHandler
{
    public Button DeleteButton;
    public GameObject SecCheck;
    public GameObject MinCheck;
    public GameObject HoursCheck;
    public GameObject AdjustSeconds;
    public GameObject AdjustSeconds2;
    public GameObject AdjustHours;
    public GameObject AdjustHours2;
    public GameObject AdjustMin;
    public GameObject AdjustMin2;
    public GameObject TimeChecker;
    float number;
    // Use this for initialization
    void Start()
    {
        Button DelButton = DeleteButton.GetComponent<Button>();
        DelButton.onClick.AddListener(DeleteSection);
        string objectName = gameObject.name;
        number = float.Parse(objectName);
    }
    void DeleteSection()
    {
        float sec = 0;
        int min = 0;
        int hrs = 0;
        if (SecCheck.GetComponent<AdjustSeconds>().SecCheck == true)
        {
            AdjustSeconds.GetComponent<Text>().text = sec.ToString("0");
            AdjustSeconds2.GetComponent<Text>().text = sec.ToString("0");
        }
        else if (MinCheck.GetComponent<AdjustMin>().MinCheck == true)
        {
            AdjustMin.GetComponent<Text>().text = min.ToString("0");
            AdjustMin2.GetComponent<Text>().text = min.ToString("0");
        }
        else if (HoursCheck.GetComponent<AdjustHours>().HourCheck == true)
        {
            AdjustHours.GetComponent<Text>().text = hrs.ToString("0");
            AdjustHours2.GetComponent<Text>().text = hrs.ToString("0");
        }
    }
    public void OnPointerClick(PointerEventData eventData)              //Bug fix for when users add 60 and above
    {
        float hrs = float.Parse(AdjustHours.GetComponent<Text>().text);
        float hrs2 = float.Parse(AdjustHours2.GetComponent<Text>().text);
        float min = float.Parse(AdjustMin.GetComponent<Text>().text);
        float min2 = float.Parse(AdjustMin2.GetComponent<Text>().text);
        float sec = float.Parse(AdjustSeconds.GetComponent<Text>().text);
        float sec2 = float.Parse(AdjustSeconds2.GetComponent<Text>().text);

        //Adding time for the seconds
        if (SecCheck.GetComponent<AdjustSeconds>().SecCheck==true)
        {
            if (TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck == false)
            {
                sec = number;
                AdjustSeconds.GetComponent<Text>().text = sec.ToString("0");
                TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck = true;
            }
            else if (TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck == true)
            {
                if(sec>=6)
                {
                    min += 1;
                    AdjustMin.GetComponent<Text>().text = min.ToString("0");
                    sec -=6;
                    AdjustSeconds2.GetComponent<Text>().text = sec.ToString("0");
                    AdjustSeconds.GetComponent<Text>().text = number.ToString("0");
                }
                else
                {
                    sec2 = number;
                    AdjustSeconds2.GetComponent<Text>().text = sec.ToString("0");
                    AdjustSeconds.GetComponent<Text>().text = sec2.ToString("0");
                }
                TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck = false;
            }
        }
        //Adding time for the minutes
        else if (MinCheck.GetComponent<AdjustMin>().MinCheck == true)
        {
            if (TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck == false)
            {
                min = number;
                AdjustMin.GetComponent<Text>().text = min.ToString("0");
                TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck = true;
            }
            else if (TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck == true)
            {
                if (min >= 6)
                {
                    hrs += 1;
                    AdjustHours.GetComponent<Text>().text = hrs.ToString("0");
                    min -= 6;
                    AdjustMin2.GetComponent<Text>().text = min.ToString("0");
                    AdjustMin.GetComponent<Text>().text = number.ToString("0");
                }
                else
                {
                    min2 = number;
                    AdjustMin2.GetComponent<Text>().text = min.ToString("0");
                    AdjustMin.GetComponent<Text>().text = min2.ToString("0");
                }
                TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck = false;
            }
        }
        //Adding time for hours
        else if (HoursCheck.GetComponent<AdjustHours>().HourCheck == true)
        {
            if (TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck == false)
            {
                hrs = number;
                AdjustHours.GetComponent<Text>().text = hrs.ToString("0");
                TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck = true;
            }
            else if (TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck == true)
            {
                hrs2 = number;
                AdjustHours2.GetComponent<Text>().text = hrs.ToString("0");
                AdjustHours.GetComponent<Text>().text = hrs2.ToString("0");
                TimeChecker.GetComponent<TimeChecker>().DoubleDigitCheck = false;
            }
        }
    }
}