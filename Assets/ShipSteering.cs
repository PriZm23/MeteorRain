using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSteering : MonoBehaviour
{
    // �������� �������� �������
    public float turnRate = 6.0f;

    // ���� ������������ �������
    public float levelDumping = 1.0f;
    
    void Update()
    {
        // ������� ����� �������, ������� ������ �����������
        // ��������� �� turnRate, � ���������� ���������
        // 90% �� �������� �����

        // ������� �������� ���� ������������
        var steeringInput = InputManager.instance.steering.delta;

        // ������ ������� ������ ��� ���������� ��������
        var rotation = new Vector2();

        rotation.y = steeringInput.x;
        rotation.x = steeringInput.y;

        // �������� �� turnRate, ����� ��������
        // �������� ��������
        rotation *= turnRate;

        // ������������� � �������, ������� �� 90%
        // �������� �����
        rotation.x = Mathf.Clamp(rotation.x, -Mathf.PI * 0.9f, Mathf.PI * 0.9f);

        // � ������������� ������� � ���������� ��������
        var newOrientation = Quaternion.Euler(rotation);

        // ���������� ������� � ������� ����������� 
        transform.rotation *= newOrientation;

        // ����� ���������� �������������� �������

        // ������� ����������, ����� ���� �� ����������
        // � ���������� �������� ������������ ��� Z
        var levelAngles = transform.eulerAngles;
        levelAngles.z = 0.0f;
        var levelOrientation = Quaternion.Euler(levelAngles);

        // ���������� ������� ���������� � ��������� ���������
        // ���� ���������� "��� ��������"; ����� ��� ����������
        // �� ���������� ���������� ������, ������ ��������
        // ������������� ��� ������������
        transform.rotation = Quaternion.Slerp(transform.rotation,
            levelOrientation, levelDumping * Time.deltaTime);
    }
}
