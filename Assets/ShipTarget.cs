using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTarget : MonoBehaviour
{
    // ������ ��� ������������� � �������� ���������� �����
    public Sprite targetImage;

    void Start()
    {
        // ���������������� ����� ���������, ���������������
        // ������� �������, ������������ ����� ����
        // � ������������� ������
        IndicatorManager.instance.AddIndicator(gameObject, Color.yellow, targetImage);
    }

    void Update()
    {
        
    }
}
