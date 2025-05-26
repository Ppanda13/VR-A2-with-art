using UnityEngine;

public class PuzzleKey : MonoBehaviour
{
    public PuzzleGameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkans()
    {
        gameManager.strings[1] = gameObject.tag;
    }
}
