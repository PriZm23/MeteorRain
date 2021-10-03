using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    // Показывает предупреждающую рамку, если угрок
    // улетает далеко от центра
    public float warningRadius = 400.0f;

    // Расстояние от центра, удаление от которого
    // завершает игру
    public float destroyRadius = 450.0f;

    public void OnDrawGizmosSelected()
    {
        // Жёлтым цветом показать сферу предупреждения
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, warningRadius);

        // А красным сферу уничтожения
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, destroyRadius);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
