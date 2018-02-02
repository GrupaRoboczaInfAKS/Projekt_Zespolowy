using UnityEngine;
using System.Collections;

public class Stering : MonoBehaviour {

	
	
	public Transform frontWheels, frontWheels2;
    private float oldAngle = 0;

	
	void Start () {
		
    }

    

	// Update is called once per frame
	void Update () {
		float steerAngle = Mathf.Clamp(Input.GetAxis ("Horizontal") * 180, -80, 100);
		transform.RotateAround(transform.position, transform.up,  steerAngle - oldAngle);
       
        oldAngle = steerAngle;

		frontWheels.localEulerAngles = new Vector3(0, steerAngle/12, 0);
        frontWheels2.localEulerAngles = new Vector3(0, steerAngle / 12, 0);



    }
}
