using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapons : MonoBehaviour
{
    // Шаблон для создания снарядов
    public GameObject shotPrefab;

    // Список пушек для стрельбы
    public Transform[] firePoints;

    // Индекс в firePoints, указывающий
    // на следующую пушку
    private int firePointIndex;

    // Вызывается диспетчером ввода InputManager
    public void Fire()
    {
        // Если пушки отсутствуют, выйти
        if(firePoints.Length == 0)
        {
            return;
        }
        // Определить следующую пушку для выстрела
        var firePointToUse = firePoints[firePointIndex];

        // Создать новый снаряд с ориентацией,
        // соответствующей пушке
        Instantiate(shotPrefab, firePointToUse.position, firePointToUse.rotation);

        // Перейти е следующей пушке
        firePointIndex++;

        // Если произошёл выход за границы массива,
        // вернуться к его началу
        if(firePointIndex >= firePoints.Length)
        {
            firePointIndex = 0;
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
