using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Horizontal;
    private const string HORIZONTAL = "Horizontal";
    private PlayerMovement playermovement;
    void Awake()
    {
        playermovement = GetComponent<PlayerMovement>();
    }
    void Update()
    {
        Horizontal = Input.GetAxis(HORIZONTAL);
        playermovement.SetHorizontal(Horizontal);
    }

    public void LeftButton()
    {
        playermovement.SetHorizontal(-1);
    }
    public void RightButton()
    {
        playermovement.SetHorizontal(1);
    }

}
