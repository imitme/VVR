using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//각각 이벤트 할당
    public void OnVirtualPress()
    {
        Debug.Log("OnVirtualPress()");
    }
    public void OnVirtualClick()
    {
        Debug.Log("OnVirtualClick()");
    }
    public void OnVirualPressDown()
    {
        Debug.Log("OnVirualPressDown()");
    }
    public void OnVirualPressUp()
    {
        Debug.Log("OnVirualPressUp()");
    }

}
