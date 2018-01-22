using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botella : MonoBehaviour {

    public GameObject player;
    private bool looked = false;
    private float time = 0;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!looked)
            gameObject.transform.RotateAround(Vector3.up, 8 * Time.deltaTime);

        float dist = Vector3.Distance(player.transform.position, transform.position);
        RaycastHit hit;
        var cameraCenter = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 2f, Camera.main.nearClipPlane));
        if (Physics.Raycast(cameraCenter, Camera.main.transform.forward, out hit, 1000))
        {
            if (hit.transform.gameObject == this.gameObject)
            {
                time += Time.deltaTime;
                print(time);
                if (time >= 1.5)
                    looked = true;
            }
        }

    }
}
