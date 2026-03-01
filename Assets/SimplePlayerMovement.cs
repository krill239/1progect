using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Скорость перемещения

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D или стрелки влево/вправо
        float moveVertical = Input.GetAxis("Vertical");     // W/S или стрелки вверх/вниз

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Перемещаем объект
        transform.Translate(movement * speed * Time.deltaTime);
    }
}