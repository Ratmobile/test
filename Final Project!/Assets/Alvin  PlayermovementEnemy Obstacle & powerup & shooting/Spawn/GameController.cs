

using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector2 checkpointpos;
    
    Rigidbody2D playerRb;

    private void Awake()
    {
     
    }
    private void Start()
    {
        checkpointpos = transform.position;
        playerRb = GetComponent<Rigidbody2D>();
    }
    private void OnTiggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();

        }
    }
    public void UpdateCheckpoint(Vector2 pos)
    {
        checkpointpos = pos;
    }
    void Die()
    {
      StartCoroutine(Respawn(0.5f));
    }
   System.Collections.IEnumerator Respawn(float duration)
    {
        playerRb.simulated = false;
        playerRb.velocity = new Vector2(0, 0);
        transform.localScale = new Vector3(0, 0, 0);
       yield return new WaitForSeconds(duration);
        transform.position = checkpointpos;
        transform.localScale = new Vector3 (1,1,1);
        playerRb.simulated = true;

    }
}