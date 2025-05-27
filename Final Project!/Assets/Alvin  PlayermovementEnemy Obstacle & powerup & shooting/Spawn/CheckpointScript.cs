using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    private PlayerRespawn respawn;
    private BoxCollider checkPointCollider;
    void Awake()
    {
        checkPointCollider = GetComponent<BoxCollider>();
        respawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<PlayerRespawn>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTiggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            respawn.respawnPoint = this.gameObject;
            checkPointCollider.enabled = false;
        }
    }

}
