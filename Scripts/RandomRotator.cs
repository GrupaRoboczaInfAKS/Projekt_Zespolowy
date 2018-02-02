using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    public int tumble;
    
    void Update()
    {
        transform.Rotate(Time.deltaTime*tumble, Time.deltaTime * tumble, Time.deltaTime * tumble);

    }
}
