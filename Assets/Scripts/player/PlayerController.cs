using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public sealed class PlayerController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public float Input
    {
        get { return input; }
        set { input = value; }
    }
    private float input;
    private const float sensitility = 50;
    private bool pressing;

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
        DetectTouch();
    }

    private void DetectTouch()
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
