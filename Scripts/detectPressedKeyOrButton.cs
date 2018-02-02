
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class detectPressedKeyOrButton : MonoBehaviour
{



    public void ABC()
    {
        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
                Debug.Log("KeyCode down: " + kcode);
        }
    }
}
