using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class video : MonoBehaviour {
    GameObject plane;
    public GameObject letras;
    public GameObject luz;

    // Use this for initialization
    void Start () {
        plane = GameObject.FindGameObjectWithTag("plane");
        letras.SetActive(false);
        luz.SetActive(true);
    }

    // Update is called once per frame
    private float t = 0;
	public void Update () {
        t += Time.deltaTime;
        var videoPlayer = plane.GetComponent<UnityEngine.Video.VideoPlayer>();
        if (!videoPlayer.isPlaying && t >= 3)
        {
            letras.SetActive(true);
            luz.SetActive(false);
        }

    }
}
