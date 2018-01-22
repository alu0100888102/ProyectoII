using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class KeywordRoom2 : MonoBehaviour
{

    //private string[] m_Keywords = {"cero","uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve","reset"};

    //public static KeywordRecognizer m_Recognizer;

    public TextMesh num;

    static bool reset;

    static string sig;

    static int count;

    public Text ayuda;

    public GameObject ayuda_panel;

    public GameObject llave;


    private void OnEnable()
    {
        Client.palabras += cambiarCombinacion;
        Client.dedos += ded;
    }

    private void OnDisable()
    {
        Client.palabras -= cambiarCombinacion;
        Client.dedos -= ded;
    }

    void Start()
    {
        /*m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        m_Recognizer.Start();
        reset = true;*/
        count = 0;
       
    }
    void Update()
    {
    }

    public void ded(int n)
    {
        if (n == 5)
        {
            comprobar_combinacion();
            if ((llave.activeSelf) && (num.text == "2000"))
            {
                ayuda_panel.SetActive(true);
                ayuda.text = "LLave Conseguida, ya puedes salir";
                llave.SetActive(false);
                exit_room2.posible = true;

            }
            else
            {
                ayuda_panel.SetActive(true);
                ayuda.text = "Aún no puedo ver a Leslie, necesito el código para coger la llave de la puerta.";
            }
        }
    }

    /*public static void Empezar()
    {

        m_Recognizer.Start();

    }
    public void Empezar_boton()
    {

        m_Recognizer.Start();

    }
    public void Parar()
    {

        m_Recognizer.Stop();
        PhraseRecognitionSystem.Shutdown();

    }
    public void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
        Debug.Log(args.text);
        
    }*/

    public void cambiarCombinacion(string s)
    {
        if (s == "reset")
        {
            reset = true;
            count = 0;
            sig = "";
            ayuda_panel.SetActive(true);
            ayuda.text = "RESET";
        }
        else
        {
            if (count != 4)
            {
                if (reset)
                {
                    change_number_uno(s);
                    reset = false;
                    count = 1;
                }
                else
                {
                    change_number_otros(s);
                    count++;
                    Debug.Log(sig);
                    Debug.Log(count);
                }
            }
            else
            {
                count = 1;
                change_number_uno(s);
            }
        }
    }
    public void comprobar_combinacion()
    {
        if (num.text != "2000")
        {
            ayuda_panel.SetActive(true);
            ayuda.text = "Mmmmm, no recuerdo la combinación, quizás podría probar con el año en el que empecé a salir con Leslie...\nLa echo tanto de menos...";
        }
        else
        {
            ayuda_panel.SetActive(true);
            ayuda.text = "2000...el año que empezamos a salir...Necesito ver a Leslie, voy a salir de aquí...\nPulsa e o enseña 2 dedos para coger la llave.";
            llave.SetActive(true);
        }
    }
    public void change_number_uno(string word)
    {
        if (word == "cero")
        {
            num.text = "0";
            sig = "0";
        }
        else if (word == "uno")
        {
            num.text = "1";
            sig = "1";
        }
        else if (word == "dos")
        {
            num.text = "2";
            sig = "2";
        }
        else if (word == "tres")
        {
            num.text = "3";
            sig = "3";
        }
        else if (word == "cuatro")
        {
            num.text = "4";
            sig = "4";
        }
        else if (word == "cinco")
        {
            num.text = "5";
            sig = "5";
        }
        else if (word == "seis")
        {
            num.text = "6";
            sig = "6";
        }
        else if (word == "siete")
        {
            num.text = "7";
            sig = "7";
        }
        else if (word == "ocho")
        {
            num.text = "8";
            sig = "8";
        }
        else if (word == "nueve")
        {
            num.text = "9";
            sig = "9";
        }
    }
    public void change_number_otros(string word)
    {
        if (word == "cero")
        {
            num.text = sig + "0";
            sig = sig + "0";
        }
        if (word == "uno")
        {
            num.text = sig +"1";
            sig = sig + "1";
        }
        else if (word == "dos")
        {
            num.text = sig + "2";
            sig = sig + "2";
        }
        else if (word == "tres")
        {
            num.text = sig + "3";
            sig = sig + "3";
        }
        else if (word == "cuatro")
        {
            num.text = sig + "4";
            sig = sig + "4";
        }
        else if (word == "cinco")
        {
            num.text = sig + "5";
            sig = sig + "5";
        }
        else if (word == "seis")
        {
            num.text = sig + "6";
            sig = sig + "6";
        }
        else if (word == "siete")
        {
            num.text = sig + "7";
            sig = sig + "7";
        }
        else if (word == "ocho")
        {
            num.text = sig + "8";
            sig = sig + "8";
        }
        else if (word == "nueve")
        {
            num.text = sig + "9";
            sig = sig + "9";
        }
    }
}