using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class AdjustHours : MonoBehaviour, IPointerClickHandler
{

    public GameObject AdjustSeconds;
    public GameObject AdjustMin;
    public Text SecondsText;
    public Text SecondsText2;
    public Text MinutesText;
    public Text MinutesText2;
    public Text HoursText;
    public Text HoursText2;
    public bool HourCheck;
    public void OnPointerClick(PointerEventData eventData)
    {
        HourCheck = true;
        AdjustSeconds.GetComponent<AdjustSeconds>().SecCheck = false;
        AdjustMin.GetComponent<AdjustMin>().MinCheck = false;
        //Highlight the Minutes
        HoursText.color = Color.green;
        HoursText2.color = Color.green;
        //Unhighlight other sections
        SecondsText.color = Color.white;
        SecondsText2.color = Color.white;
        MinutesText.color = Color.white;
        MinutesText2.color = Color.white;
    }
}
