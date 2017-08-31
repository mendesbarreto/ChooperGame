using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{


    public float input;
    public float sensitility = 50;
    bool pressing;


    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;
    }




    private void FixedUpdate()
    {
        if (pressing)
        {

            input += Time.deltaTime * sensitility;

        }
        else
        {
            input -= Time.deltaTime * sensitility;
        }
        input = Mathf.Clamp(input, 0, 1);
    }
}
