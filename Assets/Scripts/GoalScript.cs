using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Debug.Log("debugging");

	}

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("player_ball"))
        {

            SceneManager.LoadScene("wingame");

        }

    }

}
