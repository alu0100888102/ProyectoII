using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using System.Threading;
using UnityEngine.Networking;
using UnityEngine.UI;
//using UnityEngine.Windows.Speech;

public class MyMessage : MessageBase
{
    public bool pressed;
}

public class DMessage : MessageBase
{
    public int numero;
}

public class PMessage : MessageBase
{
    public string palabras;
}
/*public class Server : MonoBehaviour
{

    const short wMsg = 1005;
    const short aMsg = 1006;
    const short sMsg = 1007;
    const short dMsg = 1008;
    const short eMsg = 1009;
    const short dedosMsg = 1010;
    const short palabrasMsg = 1011;

    public Text text;

    Thread receiveThread;
    UdpClient client;
    public int port;
    public int aux;

    private string m;

    private string[] m_Keywords = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "reset", "Libro azul uno", "Libro azul dos", "Libro azul tres", "Libro azul cuatro", "Libro rojo uno", "Libro rojo dos", "Libro rojo tres", "Libro rojo cuatro", "Libro verde uno", "Libro verde dos", "Libro verde tres", "Libro verde cuatro", "Libro amarillo uno", "Libro amarillo dos", "Libro amarillo tres", "Libro amarillo cuatro" };

    private static KeywordRecognizer m_Recognizer;

    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        SetupServer();
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        m_Recognizer.Start();
        m = "";
    }

    private float timer = 0;
    void Update()
    {
        text.text = "";
        var msg = new MyMessage();
        msg.pressed = Input.GetKey(KeyCode.S);
        NetworkServer.SendToAll(sMsg, msg);
        msg.pressed = Input.GetKey(KeyCode.W);
        NetworkServer.SendToAll(wMsg, msg);
        msg.pressed = Input.GetKey(KeyCode.A);
        NetworkServer.SendToAll(aMsg, msg);
        msg.pressed = Input.GetKey(KeyCode.D);
        NetworkServer.SendToAll(dMsg, msg);
        msg.pressed = Input.GetKey(KeyCode.E);
        NetworkServer.SendToAll(eMsg, msg);
        if (Input.GetKey(KeyCode.W))
            text.text += "w";
        if (Input.GetKey(KeyCode.A))
            text.text += "a";
        if (Input.GetKey(KeyCode.S))
            text.text += "s";
        if (Input.GetKey(KeyCode.D))
             text.text += "d";
        if (Input.GetKey(KeyCode.E))
            text.text += "e";

        var dmsg = new DMessage();
        dmsg.numero = aux;
         NetworkServer.SendToAll(dedosMsg, dmsg);

         text.text += "\n " + aux;
        text.text += "\n" + m;
    }

    // Create a server and listen on a port
    public void SetupServer()
    {
        NetworkServer.Listen(4444);
        init();
    }

    private void init()
    {
        Debug.Log("UPDSend.init()");
        port = 5065;
        Debug.Log("Sending to 127.0.0.1 : " + port);
        receiveThread = new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
    }

    private void ReceiveData()
    {
        client = new UdpClient(port);
        while (true)
        {
            try
            {
                IPEndPoint anyIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                byte[] data = client.Receive(ref anyIP);
                string text = Encoding.UTF8.GetString(data);
                int position = Int32.Parse(text);
                position--;
                Debug.Log("Los dedos mostrados son : " + position);
                aux = position;
            }
            catch (Exception e)
            {
                Debug.Log("ERROR : " + e.ToString());
            }
        }
    }
    void OnApplicationQuit()
    {
        if (receiveThread != null)
        {
            receiveThread.Abort();
            client.Close();
            Debug.Log(receiveThread.IsAlive); //must be false
        }
    }

    public void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
        Debug.Log(args.text);
        m = args.text;
        var msg = new PMessage();
        msg.palabras = args.text;
        NetworkServer.SendToAll(palabrasMsg, msg);
    }
}*/



/*using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using UnityEngine.SceneManagement;

public class Server : MonoBehaviour
{
    Thread receiveThread;
    UdpClient client;
    public int port;
    public int aux;
    Scene currentScene;
    string sceneName;
    // Use this for initialization
    void Start()
    {
        init();
        currentScene = SceneManager.GetActiveScene();
    }

    private void init()
    {
        Debug.Log("UPDSend.init()");
        port = 5065;
        Debug.Log("Sending to 127.0.0.1 : " + port);
        receiveThread = new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
    }

    private void ReceiveData()
    {
        client = new UdpClient(port);
        while (true)
        {
            try
            {
                IPEndPoint anyIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                byte[] data = client.Receive(ref anyIP);
                string text = Encoding.UTF8.GetString(data);
                int position = Int32.Parse(text);
                position--;
                Debug.Log("Los dedos mostrados son : " + position);
                aux = position;
            }
            catch (Exception e)
            {
                Debug.Log("ERROR : " + e.ToString());
            }
        }
    }

    void OnApplicationQuit()
    {
        if (receiveThread != null)
        {
            receiveThread.Abort();
            client.Close();
            Debug.Log(receiveThread.IsAlive); //must be false
        }
    }
    public void Update()
    {
        sceneName = currentScene.name;
        if (sceneName == "Room_childhood")
        {
            ServerController.get_position(aux);
        }
        else if (sceneName == "Room_teen")
        {
            ServerController2.get_position(aux);
        }
    }
}
*/

