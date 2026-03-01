using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //============ Giving Values ============//
    public float Horizontal;
    private const string HORIZONTAL = "Horizontal";
    //========== Reference Scripts ==========//
    private PlayerMovement playermovement;
    private PlayerAnimation playeranimation;
    private PlayerJump playerjump;
    private PlayerAttack playerattack;
    void Awake()
    {
        playermovement = GetComponent<PlayerMovement>();
        playeranimation = GetComponentInChildren<PlayerAnimation>();
        playerjump = GetComponent<PlayerJump>();
        playerattack = GetComponent<PlayerAttack>();
    }
    void Update()
    {
        Horizontal = Input.GetAxis(HORIZONTAL);
        playermovement.SetHorizontal(Horizontal);
        if (Input.GetMouseButtonDown(0))
        {
            playerattack.Attack();
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
        playerattack.Attack();
    }
    public void DodgeButton()
    {
        playeranimation.PlayeDodge();
    }

}
