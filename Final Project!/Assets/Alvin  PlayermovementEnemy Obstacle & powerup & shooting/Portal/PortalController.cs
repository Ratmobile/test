using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public Transform destination;
    GameObject Player;



    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTiggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if (Vector2.Distance(Player.transform.position, transform.position) > 0.3f) 
            {
                Player.transform.position = destination.transform.position;
            }
        }




    }    
    }

