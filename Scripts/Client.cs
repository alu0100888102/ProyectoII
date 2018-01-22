using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Client : MonoBehaviour {

    const short wMsg = 1005;
    const short aMsg = 1006;
    const short sMsg = 1007;
    const short dMsg = 1008;
    const short eMsg = 1009;
    const short dedosMsg = 1010;
    const short palabrasMsg = 1011;

    public delegate void wAction(bool b);
    public static event wAction wClicked;
    public delegate void aAction(bool b);
    public static event aAction aClicked;
    public delegate void sAction(bool b);
    public static event sAction sClicked;
    public delegate void dAction(bool b);
    public static event dAction dClicked;
    public delegate void eAction(bool b);
    public static event eAction eClicked;
    public delegate void ndedos(int n);
    public static event ndedos dedos;
    public delegate void palabrasreco(string s);
    public static event palabrasreco palabras;


    public Text text;

    NetworkClient myClient;

    void Start () {
        SetupClient();
	}
	

    // Create a client and connect to the server port
    public void SetupClient()
    {
        myClient = new NetworkClient();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);
        myClient.RegisterHandler(wMsg, wtMsg);
        myClient.RegisterHandler(aMsg, atMsg);
        myClient.RegisterHandler(dMsg, dtMsg);
        myClient.RegisterHandler(sMsg, stMsg);
        myClient.RegisterHandler(eMsg, etMsg);
        myClient.RegisterHandler(dedosMsg, dedostMsg);
        myClient.RegisterHandler(palabrasMsg, palabrastMsg);

        myClient.Connect("10.168.2.251", 4444);

        
    }

    public void OnConnected(NetworkMessage netMsg)
    {
        Client.wClicked += pressw;
        Client.aClicked += pressa;
        Client.sClicked += presss;
        Client.dClicked += pressd;
        Client.eClicked += presse;
        Client.dedos += dedostt;
        Client.palabras += palabrastt;
    }

    public void wtMsg(NetworkMessage netMsg)
    {
        MyMessage msg = netMsg.ReadMessage<MyMessage>();
        if (wClicked != null)
            wClicked(msg.pressed);
    }
    public void atMsg(NetworkMessage netMsg)
    {
        MyMessage msg = netMsg.ReadMessage<MyMessage>();
        if (aClicked != null)
            aClicked(msg.pressed);
    }
    public void stMsg(NetworkMessage netMsg)
    {
        MyMessage msg = netMsg.ReadMessage<MyMessage>();
        if (sClicked != null)
            sClicked(msg.pressed);
    }
    public void dtMsg(NetworkMessage netMsg)
    {
        MyMessage msg = netMsg.ReadMessage<MyMessage>();
        if (dClicked != null)
            dClicked(msg.pressed);
    }
    public void etMsg(NetworkMessage netMsg)
    {
        MyMessage msg = netMsg.ReadMessage<MyMessage>();
        if (eClicked != null)
            eClicked(msg.pressed);
    }

    public void dedostMsg(NetworkMessage netMsg)
    {
        DMessage msg = netMsg.ReadMessage<DMessage>();
        if (dedos != null)
            dedos(msg.numero);
    }

    public void palabrastMsg(NetworkMessage netMsg)
    {
        PMessage msg = netMsg.ReadMessage<PMessage>();
        if (palabras != null)
            palabras(msg.palabras);
    }

    bool w = false;
    bool a = false;
    bool s = false;
    bool d = false;
    bool e = false;
    int num = 0;
    string p = "";
    bool test = true;
    void pressw (bool b){
        w = b;
    }
    void pressa(bool b)
    {
        a = b;
    }
    void presss(bool b)
    {
        s = b;
    }
    void pressd(bool b)
    {
        d = b;
    }
    void presse(bool b)
    {
        e = b;
    }
    void dedostt(int n)
    {
        num = n;
    }
    void palabrastt(string s)
    {
        if(s != "")
            p = s;
        if (s == "cero")
            exit();
    }
    void exit()
    {
        test = true;
        Client.wClicked -= pressw;
        Client.aClicked -= pressa;
        Client.sClicked -= presss;
        Client.dClicked -= pressd;
        Client.eClicked -= presse;
        Client.dedos -= dedostt;
        Client.palabras -= palabrastt;

        text.text = "Conected";
        SceneManager.LoadScene("Room_childhood");
    }

    private void Update()
    {
        if (test == true)
        {
            text.text = "";
            if (w)
                text.text += "w";
            if (a)
                text.text += "a";
            if (s)
                text.text += "s";
            if (d)
                text.text += "d";
            if (e)
                text.text += "e";
            text.text += "\n" + num;
            text.text += "\n" + p;
        }

    }

}
