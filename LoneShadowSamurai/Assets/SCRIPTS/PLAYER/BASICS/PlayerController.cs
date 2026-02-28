using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Horizontal;
    private const string HORIZONTAL = "Horizontal";
    private PlayerMovement playermovement;
    private PlayerAnimation playeranimation;
    void Awake()
    {
        playermovement = GetComponent<PlayerMovement>();
        playeranimation = GetComponentInChildren<PlayerAnimation>();
    }
    void Update()
    {
        Horizontal = Input.GetAxis(HORIZONTAL);
        playermovement.SetHorizontal(Horizontal);
        if (Input.GetMouseButtonDown(0))
        {
            playeranimation.PlayAttack();
        }
        if (Input.GetKey(KeyCode.P))
        {
            playeranimation.PlayDeath();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playeranimation.PlayeDodge();
        }
    }

    public void LeftButton()
    {
        playermovement.SetHorizontal(-1);
    }
    public void RightButton()
    {
        playermovement.SetHorizontal(1);
    }
    public void AttackButton()
    {
        playeranimation.PlayAttack();
    }
    public void DodgeButton()
    {
        playeranimation.PlayeDodge();
    }

}
