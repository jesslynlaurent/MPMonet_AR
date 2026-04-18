using UnityEngine;

public class skyclouds : MonoBehaviour
{
    public Renderer rend;
    public float speedX = 0.002f;
    public float speedY = 0.0005f;

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

        if (rend.material.HasProperty("_BumpMap"))
            rend.material.SetTextureOffset("_BumpMap", offset);
    }
}
