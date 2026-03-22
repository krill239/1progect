using UnityEngine;

public class newcube : MonoBehaviour
{
    private int age = 14;
    public float speed = 5f;
    public float jumpForce = 5f;
    public int heal = 100;
    public float maxDamage = 8f;
    public float minDamage = 3f;
    public float Damage;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        // Debug.Log(age);
        rb = GetComponent<Rigidbody>();

        // Если Rigidbody не найден, добавляем его
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
    }

    void Update()
    {
        // Движение
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        // Прыжок с проверкой на земле
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Рандомный урон
        if (Input.GetKey(KeyCode.R))
        {
            Damage = Random.Range(minDamage, maxDamage);
            Debug.Log(Damage);
        }
    }

    // Проверка касания земли
    void OnCollisionStay(Collision collision)
    {
        // Проверяем, что объект касается земли по нормали
        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.normal.y > 0.5f) // Если нормаль направлена вверх (земля)
            {
                isGrounded = true;
                return;
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}