using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.ColliderEvent;

public class PressButton : MonoBehaviour ,
    IColliderEventPressUpHandler,
    IColliderEventPressEnterHandler,
    IColliderEventPressExitHandler,

    IColliderEventHoverEnterHandler,
    IColliderEventHoverExitHandler
{
    public GameObject pressButton;
    public GameObject explosionEffect;
    public GameObject explosionPosition;
    private Transform pressButtonTransform;
    private float pressButtonOriginalYPos;

    void Start()
    {
        pressButtonTransform = pressButton.GetComponent<Transform>();
        pressButtonOriginalYPos = pressButtonTransform.position.y;
    }

    public void OnColliderEventPressEnter(ColliderButtonEventData eventData)
    {
        pressButtonTransform.position = new Vector3(pressButtonTransform.position.x,
            pressButtonOriginalYPos - 0.15f,
            pressButtonTransform.position.z);
    }

    public void OnColliderEventPressExit(ColliderButtonEventData eventData)
    {
        pressButtonTransform.position = new Vector3(pressButtonTransform.position.x,
            pressButtonOriginalYPos,
            pressButtonTransform.position.z);
    }

    public void OnColliderEventPressUp(ColliderButtonEventData eventData)
    {
        
    }

    public void OnColliderEventHoverEnter(ColliderHoverEventData eventData)
    {
        pressButton.GetComponent<Renderer>().material.color = Color.white;
    }

    public void OnColliderEventHoverExit(ColliderHoverEventData eventData)
    {
        pressButton.GetComponent<Renderer>().material.color = Color.red;
    }
}
