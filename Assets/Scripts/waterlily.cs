using UnityEngine;

public class waterlily : MonoBehaviour
{
    public float moveAmount = 0.01f;
    public float moveSpeed = 1f;
    public float rotateAmount = 3f;
    public float rotateSpeed = 0.8f;

    private Vector3 startPos;
    private Quaternion startRot;
    private float randomOffset;

    void Start()
    {
        startPos = transform.localPosition;
        startRot = transform.localRotation;
        randomOffset = Random.Range(0f, 10f);
    }

    void Update()
    {
        float yMove = Mathf.Sin((Time.time + randomOffset) * moveSpeed) * moveAmount;
        float zRot = Mathf.Sin((Time.time + randomOffset) * rotateSpeed) * rotateAmount;

        transform.localPosition = startPos + new Vector3(0f, yMove, 0f);
        transform.localRotation = startRot * Quaternion.Euler(0f, 0f, zRot);
    }
}
