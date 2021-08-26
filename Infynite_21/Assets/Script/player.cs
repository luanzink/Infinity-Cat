using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    Rigidbody2D p1;
    public float jumpForce;
    public static bool subiu;

    [SerializeField]
    float boost;
    bool perBoost;
    //float c = 0f;
    [SerializeField]
    GameObject destObj;
   
    
    void Start()
    {

        
        p1 = GetComponent<Rigidbody2D>();
        subiu = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            destObj.SetActive(false);
            Time.timeScale = 1;
            subiu = true;
            p1.velocity = new Vector2(p1.velocity.x, jumpForce);            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            destObj.SetActive(true);
            perBoost = true;
            Impulso();


        }
        else
        {
            perBoost = false;
            
        }
            

    }
   
    void Impulso()
    {
        if (perBoost) 
        {
            for (float i = 0f; i <= boost; i++)
            {
                p1.AddForce(Vector2.up * i);

                
            }
        }
        
        

        

    }
}
