using UnityEngine;

public class BGScript : MonoBehaviour
{
    public float scrollspeed = 0.5f;

    private Renderer backgroundRenderer;
    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();
        
    }

    void Update()
    {
       backgroundRenderer.material.mainTextureOffset += 
         new Vector2(scrollspeed * Time.deltaTime, 0);
    }
}
