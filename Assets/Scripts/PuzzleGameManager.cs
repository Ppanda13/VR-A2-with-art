using UnityEngine;

public class PuzzleGameManager : MonoBehaviour
{

    public string[] strings;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        strings = new string[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkans()
    {
        if (strings[0] == strings[1])
        {
            //yay
            switch (strings[0]) {
                case "obj1":

                    break;
            }
        }
    }
}
