using UnityEngine;

public class HintforDoor : MonoBehaviour
{
    public GameObject hint;
    public GameObject cheat;
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
        cheat.SetActive(false);
        hint.SetActive(true);
    }
}
