using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieza : MonoBehaviour {

    public GameObject player;
    public ParticleSystem part;

	// Use this for initialization
	void Start () {
		
	}

    void OnEnable()
    {
        Client.eClicked += presse;
    }


    void OnDisable()
    {
        Client.eClicked -= presse;
    }

    private void presse(bool t)
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (t && dist <= 3)
        {
                Destroy(this.gameObject);
                player.GetComponent<player>().cogePieza();
                part.Play();
        }
    }
}
