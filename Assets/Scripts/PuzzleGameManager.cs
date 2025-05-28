using System.Net.Sockets;
using UnityEngine;


public class PuzzleGameManager : MonoBehaviour
{
    public PuzzleSocket[] sockets;
    public string strings;
    public AudioSource correct;
    public AudioSource wrong;
    public DoorScript door;
    [SerializeField]
    private bool Blue;
    [SerializeField]
    private bool Rred;
    [SerializeField]
    private bool Ggreen;
    [SerializeField]
    private bool Orange;
    [SerializeField]
    private bool Purple;
    [SerializeField]
    private bool Yellow;
    [SerializeField]
    private bool White;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        strings = "";
        Blue = false;
        Rred = false;
        Ggreen = false;
        Orange = false;
        Purple = false;
        Yellow = false;
        White = false;
    }

    // Update is called once per frame
    void Update() 
    {
        if (Blue == true && Rred == true && Purple == true && Ggreen == true && Yellow == true && Orange == true && White == true)
        {
            door.forceOpenDoor();
        }
    }

    public void checkans(string socket)
    {
        if (strings == socket)
        {
            //yay
            switch (strings)
            {
                case "blue":
                    Debug.Log("Matched " + strings);
                    Blue = !Blue;
                    if (Blue == true)
                    {
                        Debug.Log("1");
                        DisplayAnswerForSocket(socket, true);
                        correct.Play();
                    }
                    else
                    {
                        Debug.Log("2");
                    }
                        break;
                case "rred":
                    Debug.Log("Matched " + strings);
                    Rred = !Rred;
                    if (Rred == true)
                    {
                        Debug.Log("1");
                        DisplayAnswerForSocket(socket, true);
                        correct.Play();
                    }
                    else
                    {
                        Debug.Log("2");
                    }
                    break;
                case "purple":
                    Debug.Log("Matched " + strings);
                    Purple = !Purple;
                    if (Purple == true)
                    {
                        Debug.Log("1");
                        DisplayAnswerForSocket(socket, true);
                        correct.Play();
                    }
                    else
                    {
                        Debug.Log("2");
                    }
                    break;
                case "ggreen":
                    Debug.Log("Matched " + strings);
                    Ggreen = !Ggreen;
                    if (Ggreen == true)
                    {
                        Debug.Log("1");
                        DisplayAnswerForSocket(socket, true);
                        correct.Play();
                    }
                    else
                    {
                        Debug.Log("2");
                    }
                    break;
                case "orange":
                    Debug.Log("Matched " + strings);
                    Orange = !Orange;
                    if (Orange == true)
                    {
                        Debug.Log("1");
                        DisplayAnswerForSocket(socket, true);
                        correct.Play();
                    }
                    else
                    {
                        Debug.Log("2");
                    }
                    break;
                case "yellow":
                    Debug.Log("Matched " + strings);
                    Yellow = !Yellow;
                    if (Yellow == true)
                    {
                        Debug.Log("1");
                        DisplayAnswerForSocket(socket, true);
                        correct.Play();
                    }
                    else
                    {
                        Debug.Log("2");
                    }
                    break;
                case "white":
                    Debug.Log("Matched " + strings);
                    White = !White;
                    if (White == true)
                    {
                        Debug.Log("1");
                        DisplayAnswerForSocket(socket, true);
                        correct.Play();
                    }
                    else
                    {
                        Debug.Log("2");
                    }
                    break;
            }
        }
        else
        {
            Debug.Log("Wrong Answer");
            DisplayAnswerForSocket(socket, false);
            wrong.Play();
        }
        strings = "";
    }

    public void DisplayAnswerForSocket(string socketid, bool ans_statsus)
    {
        foreach (PuzzleSocket socket in sockets)
        {
            if (socket.correcttag == socketid)
            {
                socket.DisplayAnswerHandler(ans_statsus);
                break;
            }
        }
    }
}
