using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public PowerupEffect powerupEffect;

    public void OnTiggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        powerupEffect.Apply(collision.gameObject);

    }







}


   
