using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singletone<InputManager>
{
    // ��������, ������������ ��� ���������� �������
    public VirtualJoystick steering;

    // �������� ����� ���������� � ��������
    public float fireRate = 0.2f;

    // ������� �������� ShipWeapons ���������� ���������
    private ShipWeapons currentWeapons;

    // �������� true ���� � ������ ������ ������ �����
    private bool isFiring = false;

    // ���������� ��������� ShipWeapons ��� ����������
    // ���������� currentWeapons
    public void SetWeapons(ShipWeapons weapons)
    {
        this.currentWeapons = weapons;
    }
    // ���������� ���������� ��� ������
    // ���������� currentWeapons
    public void RemoveWeapons(ShipWeapons weapons)
    {
        // ���� currentWeapons ��������� �� ������ 
        // ������ 'weapons', ��������� �� null
        if(this.currentWeapons == weapons)
        {
            this.currentWeapons = null;
        }
    }
    // ����������, ����� ���������� Fire
    public void startFiring()
    {
        // ��������� ��������� ������� ����
        StartCoroutine(FireWeapons());
    }
    IEnumerator FireWeapons()
    {
        // ���������� ������� ������� ����
        isFiring = true;

        // ���������� ��������, ���� isFiring = true
        while (isFiring)
        {
            // ���� �������� ���������� ������� ���������������,
            // �������� ��� � ������������� ���������� �������
            if (this.currentWeapons != null)
            {
                currentWeapons.Fire();
            }
            // ����� fireRate ������ ����� ��������� ���������
            yield return new WaitForSeconds(fireRate);
        }
    }
    // ����������� ����� ������������ ������� ����� � ������ Fire
    public void StopFiring()
    {
        // ��������� false, ����� ��������� ���� � FireWeapons
        isFiring = false;
    }
}
