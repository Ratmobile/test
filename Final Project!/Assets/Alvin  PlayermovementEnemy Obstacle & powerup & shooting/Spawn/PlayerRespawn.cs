using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject player;
    public GameObject respawnPoint;
    //Start is called before the first frame update 
    void Start()
    {

    }
    //Update is called Once per frame 
    void Update ()
    {

    }
    private void OnTiggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }
    }