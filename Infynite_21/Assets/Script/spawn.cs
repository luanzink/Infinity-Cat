using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float rateSpawn;
    float currentRateSpawn;
    public GameObject prefab1, prefab2, prefab3,prefab4;
    Transform localSpawn;
    int escolha;
    public static int qtSpawn;
    public int limitedSpawn;
    public List<GameObject> obj = new List<GameObject>();
    Vector3 offSet;



    // Start is called before the first frame update
    void Start()
    {
        localSpawn = GetComponent<Transform>();
        //GetComponent<Collider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(qtSpawn);
        
        currentRateSpawn += Time.deltaTime;
        if (currentRateSpawn > rateSpawn && qtSpawn <= limitedSpawn) {
            currentRateSpawn = 0;
            Spawn();
           
            
        }
        
    }

    void Spawn()
    {
        escolha = Random.Range(1, 5);

        switch (escolha)
        {
            case 1:
                prefab1.transform.position = new Vector3(0, localSpawn.position.y + (offSet.y * 0.7f), 0);
                offSet = prefab1.transform.position;
                Instantiate(prefab1);
                //obj.Add(prefab1);
                qtSpawn = qtSpawn + 1;
                break;
            case 2:
                prefab2.transform.position = new Vector3(0, localSpawn.position.y + (offSet.y * 0.7f), 0);
                offSet = prefab2.transform.position;
                Instantiate(prefab2);
                // obj.Add(prefab2);
                qtSpawn = qtSpawn + 1;
                break;
            case 3:
                prefab3.transform.position = new Vector3(0, localSpawn.position.y + (offSet.y * 0.7f), 0);
                offSet = prefab3.transform.position;
                Instantiate(prefab3);
                // obj.Add(prefab3);
                qtSpawn = qtSpawn + 1;
                break;
            case 4:
                prefab4.transform.position = new Vector3(0, localSpawn.position.y + (offSet.y * 0.7f), 0);
                offSet = prefab4.transform.position;
                Instantiate(prefab4);
                // obj.Add(prefab4);
                qtSpawn = qtSpawn + 1;
                break;
        }

        



    }
   
}
