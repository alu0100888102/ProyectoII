using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzzle : MonoBehaviour {

    public GameObject player;
    // Use this for initialization
    public Light l;
    private bool findefiesta = false;
    private float time = 0;

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
        if (t && dist <= 3 && player.GetComponent<player>().tienepieza())
        {
            findefiesta = true;
            l.gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        if (findefiesta)
        {
            time += Time.deltaTime;
            l.intensity = 100 * time;
        }
        if (time >= 5)    
            SceneManager.LoadScene("FiestaMal");
    }
}
