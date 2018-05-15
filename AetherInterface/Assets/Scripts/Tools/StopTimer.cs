using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
public class StopTimer : MonoBehaviour, IPointerClickHandler
{
    public GameObject Timer;
    public void OnPointerClick(PointerEventData eventData)//Disables the timer from counting down
    {
        Timer.GetComponent<Timer>().CancelInvoke();
    }
}
