using UnityEngine;

public class atttack_broom : MonoBehaviour
{
    public Animator broom;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            broom.SetTrigger("attack");
        }
    }
}