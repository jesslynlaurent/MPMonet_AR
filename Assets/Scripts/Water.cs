using UnityEngine;

public class WaterScroll : MonoBehaviour
{
    public Renderer rend;
    public float speedX = 0.03f;
    public float speedY = 0.01f;

    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speedX, Time.time * speedY);

        if (rend.material.HasProperty("_BaseMap"))
            rend.material.SetTextureOffset("_BaseMap", offset);
        else
            rend.material.mainTextureOffset = offset;
    }
}
