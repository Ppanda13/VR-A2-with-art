using UnityEngine;

public class PuzzleSocket : MonoBehaviour
{
    public string correcttag;
    public PuzzleGameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckAns()
    {
        gameManager.strings[0] = correcttag;
    }
}
