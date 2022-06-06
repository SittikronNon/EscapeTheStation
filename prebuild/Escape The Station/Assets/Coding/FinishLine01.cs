using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine01 : MonoBehaviour
{

    public GameObject nextlevelButton, backgroundNext, NextlevelText, backtomenu;

    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();

        if (player != null)
        {
            backgroundNext.SetActive(true);
            nextlevelButton.SetActive(true);
            NextlevelText.SetActive(true);
            backtomenu.SetActive(true);

            Destroy(player.gameObject);

        }
        

    }

}
