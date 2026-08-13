using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audioSource;
    private LogicScript logic;

    public float flapstrength = 8f;
    public AudioClip flapSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        logic = FindFirstObjectByType<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) ||
            Input.GetMouseButtonDown(0) ||
            (Input.touchCount > 0 &&
             Input.GetTouch(0).phase == TouchPhase.Began))
        {
            rb.linearVelocity = Vector2.up * flapstrength;

            if (flapSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(flapSound);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
    }
}