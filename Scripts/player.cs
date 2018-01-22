using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    private bool hasPieza = false;
    public Image img;
    private Vector2 pos;
    public AudioSource source;
	void Start () {
        img.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void cogePieza() {
        hasPieza = true;
        img.enabled = true;
        source.Play();
    }

    public bool tienepieza() {
        return hasPieza;
    }
}
