using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject TheCar;
    public float CarX;
    public float CarY;
    public float CarZ;
	
	// Update is called once per frame
	void Update () {
        CarX = TheCar.transform.position.x;
        CarY = TheCar.transform.position.y;
        CarZ = TheCar.transform.position.z;

        transform.position = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
    }
}