using UnityEngine;

public class tree : MonoBehaviour
{
    public float swayAmountX = 1f;
    public float swayAmountZ = 1.5f;
    public float swaySpeed = 0.5f;

    private Quaternion startRot;
    private float randomOffset;

    void Start()
    {
        startRot = transform.localRotation;
        randomOffset = Random.Range(0f, 10f);
    }

    void Update()
    {
        float swayX = Mathf.Sin((Time.time + randomOffset) * swaySpeed) * swayAmountX;
        float swayZ = Mathf.Sin((Time.time + randomOffset) * swaySpeed) * swayAmountZ;

        transform.localRotation = startRot * Quaternion.Euler(swayX, 0f, swayZ);
    }
}
