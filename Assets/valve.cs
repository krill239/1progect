using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class valve : MonoBehaviour
{
    public GameObject hinttext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("игрок подошол к вентилю");
            hinttext.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("игрок отошел от вентиля");
            hinttext.SetActive(false);
        }
    }
}
