using UnityEngine;

public class PuzzleSocket : MonoBehaviour
{
    public string correcttag;
    public PuzzleGameManager gameManager;
    public Light red;
    public Light green;
    bool lightbool;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (lightbool)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                green.gameObject.SetActive(false);
                red.gameObject.SetActive(false);
                lightbool = false;
                timer = 0;
            }
        }

    }

    public void CheckAns()
    {
        Debug.Log("Socket " + correcttag);
        gameManager.checkans(correcttag);
    }

    public void DisplayCorrect()
    {
        green.gameObject.SetActive(true);
    }

    public void DisplayWrong()
    {
        red.gameObject.SetActive(true);
    }

    public void DisplayAnswerHandler(bool ansstatus)
    {
        if (ansstatus)
            DisplayCorrect();
        else
            DisplayWrong();
        lightbool = true;
    }
}
