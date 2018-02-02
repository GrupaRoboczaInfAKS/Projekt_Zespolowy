using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoundryDestroyer : MonoBehaviour {

	void OnTrigger(Collider other)
    {
        
        SceneManager.LoadScene("Test05-Opel");
    }

}
