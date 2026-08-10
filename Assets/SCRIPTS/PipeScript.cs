using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float lifelimit = 0f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < lifelimit)
        {
            Destroy(gameObject);
        }   
    }
        
    
}
