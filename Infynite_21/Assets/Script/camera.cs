using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public player player;
    private Vector3 lastPlayerPos;
    private float distanceToMove;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<player>();
        lastPlayerPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.subiu == true)
        {
            distanceToMove = player.transform.position.y - lastPlayerPos.y;

            transform.position = new Vector3(transform.position.x, transform.position.y + distanceToMove, transform.position.z);

            lastPlayerPos = player.transform.position;

            player.subiu = false;

        }
    }
}
