using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    Rigidbody rb;
    float speed = 8.0F;
    float rotationSpeed = 8.0F;
    


    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        rb.AddForce(this.transform.forward * translation * 40);
        rb.AddTorque(this.transform.up * rotation * 15);

        AnalogueSpeedConverter.ShowSpeed(rb.velocity.magnitude, 0, 80);
        
            AnalogueSpeedConverter2.ShowSpeed(rb.velocity.magnitude, 0, 25);

        
    }


    private void OnTriggerEnter(Collider col)
    {
        switch(col.tag)
        {
            case "Curb":
                ScoreTarget.UpdateScore(-1);
                ScoreTarget.UpdateRank(0, -1, 0, 0);
                ScoreTarget.UpdateMessege("Trzymaj się drogi!");
                break;
            case "Pedestrian":
                ScoreTarget.UpdateScore(-10);
                ScoreTarget.UpdateRank(-10, 0, 0, 0);
                ScoreTarget.UpdateMessege("Uważaj na pieszych !!!");
                
                break;
           
            case "Target":
                ScoreTarget.UpdateScore(10);
                ScoreTarget.UpdateRank(0,0,10,0);
                ScoreTarget.UpdateMessege("Punkt kontrolny ");
                
                break;
            case "Sign":
                ScoreTarget.UpdateScore(-1);
                ScoreTarget.UpdateRank(0, 0, 0, -1);
                ScoreTarget.UpdateMessege("Słup ;)");
                break;
            case "Car":
                ScoreTarget.UpdateScore(-5);
                ScoreTarget.UpdateRank(0, 0, 0, -1);
                ScoreTarget.UpdateMessege("Kolizja ");

                break;

            case "Boundry":
                
                SceneManager.LoadScene(2);
                ScoreTarget.ShowRank();
                break;

                

        }
    }

   
}
