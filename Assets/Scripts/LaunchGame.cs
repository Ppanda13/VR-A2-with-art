using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LaunchGame : MonoBehaviour
{
    public UnityEngine.UI.Toggle toggle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.SetString("Rand_Rooms", "false");
        PlayerPrefs.SetInt("FM", 0);
        PlayerPrefs.SetInt("RS", 0);
        PlayerPrefs.SetInt("DS", 0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ToggleRandomRooms()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetString("Rand_Rooms", "true");
        }
        else
        {
            PlayerPrefs.SetString("Rand_Rooms", "false");
        }
    }
}
