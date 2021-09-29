using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ����� ��������������� �������� ��������� �� 
// ������������ ����� ������.
// ��� ���������� ������ GameManager � InputManager.

// ����� ��������������� ���� �������, ���������� ���
public class MyManager : Singletone<MyManager>
{

}
// ����� ����� ����� ���������� � ������������� 
// ������ ���������� ������
// MyManager.instance.DoSomething();
public class Singletone<T> : MonoBehaviour where T : MonoBehaviour
{
    // ������������ ��������� ����� ������
    private static T _instance;

    // ����� �������. ��� ������ ������ ����������� _instance.
    // ���� ��������� ������ �� ������,
    // ������� ��������� �� ������ � ������
    public static T instance
    {
        get
        {
            // ���� �������� _ instance ��� �� ���������
            if(_instance == null)
            {
                // ���������� ����� ������
                _instance = FindObjectOfType<T>();

                // �������� ��������� �� ������ � ������ �������
                if(_instance == null)
                {
                    Debug.LogError("Can't find " + typeof(T) + "!");
                }
            }
            // ������� ��������� ��� �������������
            return _instance;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
