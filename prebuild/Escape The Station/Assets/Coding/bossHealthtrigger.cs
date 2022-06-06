using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealthtrigger : MonoBehaviour
{

    public GameObject bossHealthbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();

        if (player != null)
        {
            bossHealthbar.SetActive(true);

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
