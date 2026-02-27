using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float MoveSpeed = 5f;
    void Start()
    {
        
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 dir = new Vector3(horizontal, 0, 0).normalized;
        transform.position += dir * MoveSpeed * Time.deltaTime;
        Debug.Log(horizontal);
    }
}
