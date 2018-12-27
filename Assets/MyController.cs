using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MyController : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;
    private EVRButtonId triggerButton = EVRButtonId.k_EButton_SteamVR_Trigger;
    private EVRButtonId gripButton = EVRButtonId.k_EButton_Grip;
    private EVRButtonId touchpadButton = EVRButtonId.k_EButton_SteamVR_Touchpad;

	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	void Update () {
        device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetPress(triggerButton))
        {
            //Debug.Log("트리거 버튼 선택");
        }


        //Trigger
        if (device.GetPressDown(triggerButton))
        {
            Debug.Log("GetPressDown()");    //눌렀을때 최초 한번만
        }
        if (device.GetPressUp(triggerButton))
        {
            Debug.Log("GetPressUp()");      //땠을때 최초 한번만
        }

        //Grip
        if (device.GetPress(gripButton))
        {
            Debug.Log("GetPress()");
        }
        if (device.GetPressDown(gripButton))
        {
            Debug.Log("GetPressDown()");
        }
        if (device.GetPressUp(gripButton))
        {
            Debug.Log("GetPressUp()");
        }

        //Touchpad
        if (device.GetPress(touchpadButton))
        {
            Debug.Log("GetPress()");
        }
        if (device.GetPressDown(touchpadButton))
        {
            Debug.Log("GetPressDown()");
        }
        if (device.GetPressUp(touchpadButton))
        {
            Debug.Log("GetPressUp()");
        }

        //Touchpad 좌표
        float touchpadX = device.GetAxis(touchpadButton).x;
        float touchpadY = device.GetAxis(touchpadButton).y;
        Debug.Log(string.Format("[x; {0}, y;{1}", touchpadX, touchpadY));

    }
}
