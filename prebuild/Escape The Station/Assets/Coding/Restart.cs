using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartScene01()
    {
        SceneManager.LoadScene("Level1");
    }

    public void restartScene02()
    {
        SceneManager.LoadScene("Level2");
    }

    public void restartScene03()
    {
        SceneManager.LoadScene("Level3");
    }

    public void restartFinalScene()
    {
        SceneManager.LoadScene("FinalLevel");
    }
}
