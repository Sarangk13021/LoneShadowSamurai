using UnityEngine;

public class PlayerFacing : MonoBehaviour
{
    private PlayerController playercontroller;
    private SpriteRenderer Img;
    void Awake()
    {
        playercontroller = GetComponentInParent<PlayerController>();
        Img = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (playercontroller.Horizontal < 0)
            Img.flipX = true;
        else if (playercontroller.Horizontal > 0)
            Img.flipX = false;
    }
}
