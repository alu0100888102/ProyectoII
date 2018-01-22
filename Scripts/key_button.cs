using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class key_button : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject key;
    public GameObject ayuda_panel;
    public Text ayuda;
    public GameObject player;
    public Text btext;

    void OnEnable()
    {
        Client.eClicked += presse;
    }


    void OnDisable()
    {
        Client.eClicked -= presse;
    }


    // Update is called once per frame
    void presse(bool t)
    {
        if (t && animacion_tesoro.abierto)
        {
            press();
        }
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (t && animacion_tesoro.abierto && dist <= 3)
        {
            ayuda_panel.SetActive(true);
            ayuda.text = "Has cogido la llave. Ya puedes salir de la habitación.";
            key.SetActive(false);
        }

    }

    public void press()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.isKinematic = false;
        ayuda_panel.SetActive(true);
        btext.text = "Busca por la habitación.";
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ayuda_panel.SetActive(true);
            ayuda.text = "Has cogido la llave. Ya puedes salir de la habitación.";
            key.SetActive(false);
        }
    }
}