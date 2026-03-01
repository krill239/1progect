using UnityEngine;

public class newcube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int age = 14;
    public float speed = 0.1f;
    public float speedJump = 0.1f;
    void Start()
    {
        // Debug.Log(age);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 1, 0) * speedJump * Time.deltaTime);
        }
    }
}
