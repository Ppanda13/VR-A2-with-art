using UnityEngine;

public class cheatForDoor : MonoBehaviour
{
    public GameObject cheat;
    public GameObject hint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        hint.SetActive(false);
        cheat.SetActive(true);
    }
}
