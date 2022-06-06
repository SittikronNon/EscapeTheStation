using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    public GameObject  backgroundEnd, EndGameButton, backtomenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();

        if (player != null)
        {
            backgroundEnd.SetActive(true);
            
            EndGameButton.SetActive(true);
            backtomenu.SetActive(true);

            

        }


    }
}
