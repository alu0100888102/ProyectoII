using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exit_room2 : MonoBehaviour
{

    public GameObject llave;
    public TextMesh num;
    public GameObject ayuda_panel;
    public Text ayuda;
    public static bool posible = false;
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!posible)
            {
                ayuda_panel.SetActive(true);

                ayuda.text = "Aún no puedes salir de la habitación.";
            }
            else
            {
                ayuda_panel.SetActive(true);
                ayuda.text = "Siguiente escena...";
                SceneManager.LoadScene("highway");
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!posible)
            {
                ayuda_panel.SetActive(true);

                ayuda.text = "Aún no puedes salir de la habitación.";
            }
            else
            {
                ayuda_panel.SetActive(true);
                ayuda.text = "Siguiente escena...";
                SceneManager.LoadScene("highway");
            }
        }
    }
}
