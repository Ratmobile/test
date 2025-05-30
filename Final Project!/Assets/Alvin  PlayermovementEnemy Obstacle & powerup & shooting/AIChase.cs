using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{
    public GameObject player;
    public float speed;
 

    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.forward;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.x, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this .transform.position, player.transform.position, speed * Time.deltaTime);

        }
    }

