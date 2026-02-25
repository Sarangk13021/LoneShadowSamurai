using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playermovement;

    void Awake()
    {
        playermovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        PcGetmovement();
    }

    void PcGetmovement()
    {
        float horizontal = 0f;   // IMPORTANT: reset every frame

        if (Input.GetKey(KeyCode.A))
            horizontal = -1f;

        if (Input.GetKey(KeyCode.D))
            horizontal = 1f;

        playermovement.SetMovement(horizontal);
    }

    // mobile buttons
    public void pressedLeft()
    {
        playermovement.SetMovement(-1f);
    }

    public void pressedRight()
    {
        playermovement.SetMovement(1f);
    }

    public void released()
    {
        playermovement.SetMovement(0f);
    }
}