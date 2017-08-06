using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HoleScript : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("player_ball"))
        {

            SceneManager.LoadScene("gameover");

        }

    }

}
