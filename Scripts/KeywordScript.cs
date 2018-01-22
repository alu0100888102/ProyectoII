using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class KeywordScript : MonoBehaviour
{
   
    /*private string[] m_Keywords = {"Libro azul uno", "Libro azul dos", "Libro azul tres", "Libro azul cuatro", "Libro rojo uno", "Libro rojo dos", "Libro rojo tres","Libro rojo cuatro", "Libro verde uno", "Libro verde dos", "Libro verde tres", "Libro verde cuatro", "Libro amarillo uno", "Libro amarillo dos", "Libro amarillo tres", "Libro amarillo cuatro"};

    private static KeywordRecognizer m_Recognizer;*/

    public TextMesh num1;

    public TextMesh num2;

    public TextMesh num3;

    public TextMesh num4;

    public Text ayuda;

    public GameObject ayuda_panel;

    public TextMesh isntr_panel;

    private void OnEnable()
    {
        Client.palabras += change_number;
    }

    private void OnDisable()
    {
        Client.palabras -= change_number;
    }


    void Start()
    {
        //m_Recognizer = new KeywordRecognizer(m_Keywords);
        //m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        //m_Recognizer.Start();

    }
    /*public static void Empezar()
    {
 
        m_Recognizer.Start();

    }
    public static void Parar()
    {

        m_Recognizer.Stop();
        PhraseRecognitionSystem.Shutdown();

    }
    public void Empezar_boton()
    {

        m_Recognizer.Start();

    }
    public void Parar_boton()
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
            change_number(args.text);
    }*/
    public void get_key()
    {
        if ((num1.text == "4") && (num2.text == "1") && (num3.text == "2") && (num4.text == "3"))
        {
            ayuda_panel.SetActive(true);
            ayuda.text = "Los libros tienen el número correcto, ya puedes abrir el cofre.";

        }
        else
        {
            ayuda_panel.SetActive(true);
            ayuda.text = "Los libros no tienen el número correcto, prueba otra vez.";
        }
    }


    public void change_number(string word)
    {
       isntr_panel.text = word;
        if (word.Contains("Libro"))
        {
            if (word.Contains("azul"))
            {
                if(word.Contains("uno"))
                    num1.text = "1";
                if (word.Contains("dos"))
                    num1.text = "2";
                if (word.Contains("tres"))
                    num1.text = "3";
                if (word.Contains("cuatro"))
                    num1.text = "4";
            }
            if (word.Contains("rojo"))
            {
                if (word.Contains("uno"))
                    num2.text = "1";
                if (word.Contains("dos"))
                    num2.text = "2";
                if (word.Contains("tres"))
                    num2.text = "3";
                if (word.Contains("cuatro"))
                    num2.text = "4";
            }
            if (word.Contains("verde"))
            {
                if (word.Contains("uno"))
                    num3.text = "1";
                if (word.Contains("dos"))
                    num3.text = "2";
                if (word.Contains("tres"))
                    num3.text = "3";
                if (word.Contains("cuatro"))
                    num3.text = "4";
            }
            if (word.Contains("amarillo"))
            {
                if (word.Contains("uno"))
                    num4.text = "1";
                if (word.Contains("dos"))
                    num4.text = "2";
                if (word.Contains("tres"))
                    num4.text = "3";
                if (word.Contains("cuatro"))
                    num4.text = "4";
            }
        }
    }
}
