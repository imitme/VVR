using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {


    public void AfterGrabbed(Draggable draggableObj)
    {
        Debug.Log("AfterGrabbed()");
    }
    public void BeforeRelease(Draggable draggableObj)
    {
        Debug.Log("BeforeRelease()");

    }
    public void OnDrop(Draggable draggableObj)
    {
        Debug.Log("OnDrop()");
    }
}
