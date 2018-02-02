using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogueSpeedConverter2 : MonoBehaviour
{

     static float minAngle = -3.5f;
     static float maxAngle = -130.0f;
     
     static AnalogueSpeedConverter2 thisSpeedo;
     static float GearLimit = 7.0f;
     static float m_GearBox = 1;
    static float DownGearLimit = 7.0f;



    // Use this for initialization
    void Start()
    {
        thisSpeedo = this;
        
    }

    // Update is called once per frame
    public static void ShowSpeed(float speed, float min, float max)
    {

        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed * m_GearBox));

        

        if (speed >= GearLimit || speed >= 25 || speed >= 30)
        {
            m_GearBox++;
            GearLimit += GearLimit;
           




        }

        if (speed > DownGearLimit && speed < GearLimit && m_GearBox > 2)
        {

            m_GearBox--;
            DownGearLimit -= DownGearLimit;
        }
        

        ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max * m_GearBox, speed * m_GearBox));
        thisSpeedo.transform.eulerAngles = new Vector3(0, 0, ang);



    }
}
