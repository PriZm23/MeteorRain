using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 10.0f;
    void Start()
    {
        // Установить скорость перемещения твёрдого тела
        GetComponent<Rigidbody>().velocity = transform.forward * speed;

        // Создать красный индикатор для данного астероида
        var indicator = IndicatorManager.instance.AddIndicator(gameObject, Color.red);
    }

    void Update()
    {
        
    }
}
