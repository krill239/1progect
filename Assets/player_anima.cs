using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class player_anima : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animator player_Anima;
    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.W))
    {
            player_Anima.SetBool("Walk", true);
    }else if (Input.GetKeyDown(KeyCode.E))
    {
            player_Anima.SetTrigger("Open");
    }
    else
    {
            player_Anima.SetBool("Walk", false);
    }
    }
}
