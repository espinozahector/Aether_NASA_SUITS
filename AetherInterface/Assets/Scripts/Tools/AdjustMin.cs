using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class AdjustMin : MonoBehaviour, IPointerClickHandler
{
    public GameObject AdjustSeconds;
    public GameObject AdjustHours;
    public Text SecondsText;
    public Text SecondsText2;
    public Text MinutesText;
    public Text MinutesText2;
    public Text HoursText;
    public Text HoursText2;
    public bool MinCheck;

    public void OnPointerClick(PointerEventData eventData)
    {
        MinCheck = true;
        AdjustSeconds.GetComponent<AdjustSeconds>().SecCheck = false;
        AdjustHours.GetComponent<AdjustHours>().HourCheck = false;
        //Highlight the Minutes
        MinutesText.color = Color.green;
        MinutesText2.color = Color.green;
        //Unhighlight other sections
        SecondsText.color = Color.white;
        SecondsText2.color = Color.white;
        HoursText.color = Color.white;
        HoursText2.color = Color.white;
    }
}
