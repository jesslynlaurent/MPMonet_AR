using UnityEngine;

public class Water : MonoBehaviour
{
    public Renderer rend;
    public float speedX = 0.01f;
    public float speedY = 0.005f;

    private Vector2 offset;

    void Start()
    {
        if (rend == null)
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (rend == null) return;
        offset += new Vector2(speedX, speedY) * Time.deltaTime;
        
        if (rend.material.HasProperty("_BaseMap"))
        rend.material.SetTextureOffset("_BaseMap",offset);
        else
        rend.material.mainTextureOffset =  offset;
    }
}
