using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enuscene_script : MonoBehaviour {

    public void zamiana_sceny(int zamiana_sceny)
    {
        SceneManager.LoadScene(zamiana_sceny);
    }
}
