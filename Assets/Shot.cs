using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Перемещает объект с постоянной скоростью
// и уничтожает его спустя заданное время
public class Shot : MonoBehaviour
{
    // Скорость движения снаряда
    public float speed = 100.0f;

    // Время в секундах, через которое следует
    // уничтожить снаряд
    public float life = 5.0f;
    void Start()
    {
        // Уничтожить через 'life' секунд
        Destroy(gameObject, life);
    }

    void Update()
    {
        // Перемещать вперёд с постоянной скоростью
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
