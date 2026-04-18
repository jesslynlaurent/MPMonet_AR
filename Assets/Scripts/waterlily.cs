using UnityEngine;

public class waterlily : MonoBehaviour
{

    public float moveAmount = 0.002f;
    public float moveSpeed = 0.8f;

    private Vector3 startPos;
    private float randomOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.localPosition;
        randomOffset = Random.Range(0f, 10f);
        
    }

    // Update is called once per frame
    void Update()
    {
       float yMove = Mathf.Sin((Time.time + randomOffset) * moveSpeed) * moveAmount;
       float zRot = Mathf.Sin((Time.time + randomOffset) * rotateSpeed) * rotateAmount;

       transform.localPosition = startPos + new Vector3(0f, yMove, 0f);
       transform.localRotation = startRot * Quaternion.Euler(0f, 0f, zRot);
    }
}
