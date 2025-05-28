using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            changeScene();
        }
    }

    public void changeScene()
    {
        if (PlayerPrefs.GetString("Rand_Rooms") == "false")
            SceneManager.LoadScene(sceneName);
        else
        {
            RandomSceneSelection(PlayerPrefs.GetInt("FM"), PlayerPrefs.GetInt("RS"), PlayerPrefs.GetInt("DS"));
        }
    }

    public void RandomSceneSelection(int FM, int RS, int DS)
    {
        int total = (3 - (FM + RS + DS));
        if (total == 0)
        {
            SceneManager.LoadScene("VictoryScene");
        }
        else
        {
            string[] scenes = new string[total];
            int x = 0;
            int y = Random.Range(0, total);
            if (FM == 0)
            {
                scenes[x] = "FloorMaze";
                x++;
            }
            if (RS == 0)
            {
                scenes[x] = "RiddleScene";
                x++;
            }
            if (DS == 0)
            {
                scenes[x] = "DoorsScene";
                x++;
            }
            RemoveSceneFromRandom(scenes[y]);
            SceneManager.LoadScene(scenes[y]);
        }
    }
    public void RemoveSceneFromRandom(string sceneName)
    {
        switch (sceneName)
        {
            case "FloorMaze":
                PlayerPrefs.SetInt("FM", 1);
                break;
            case "RiddleScene":
                PlayerPrefs.SetInt("RS", 1);
                break;
            case "DoorsScene":
                PlayerPrefs.SetInt("DS", 1);
                break;
        }
    }
}
