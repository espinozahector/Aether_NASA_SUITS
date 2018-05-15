using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class AdjustSeconds : MonoBehaviour, IPointerClickHandler
{
    public GameObject AdjustHours;
    public GameObject AdjustMin;
    public Text SecondsText;
    public Text SecondsText2;
    public Text MinutesText;
    public Text MinutesText2;
    public Text HoursText;
    public Text HoursText2;
    public bool SecCheck;

    public void OnPointerClick(PointerEventData eventData)
    {
        SecCheck = true;
        AdjustMin.GetComponent<AdjustMin>().MinCheck = false;
        AdjustHours.GetComponent<AdjustHours>().HourCheck = false;
        //Highlight the Seconds
        SecondsText.color = Color.green;
        SecondsText2.color = Color.green;
        //Unhighlight other sections
        MinutesText.color = Color.white;
        MinutesText2.color = Color.white;
        HoursText.color = Color.white;
        HoursText2.color = Color.white;
    }
}
