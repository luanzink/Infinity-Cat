using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    GameObject player;
    public spawn spawn;

   
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D objObstaculo)
    {
       
        if (objObstaculo.gameObject.CompareTag("Player")) {

            Time.timeScale = 0;
        
        }
        

        if (objObstaculo.gameObject.CompareTag("Obs"))
        {
            spawn.qtSpawn = spawn.qtSpawn - 1;
            Destroy(gameObject);
            

        }
       
    }
}
