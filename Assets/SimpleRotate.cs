using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 45f; // 1秒間に45度回転

    void Update()
    {
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
    }
}
