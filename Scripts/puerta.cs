using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puerta : MonoBehaviour {

    public GameObject player;
    // Use this for initialization

    void OnEnable()
    {
        Client.dedos += ded;
    }


    void OnDisable()
    {
        Client.dedos -= ded;
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void ded (int d) {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (d == 2 && dist <= 5)
        {
            SceneManager.LoadScene("Room_teen");
        }

    }
}
