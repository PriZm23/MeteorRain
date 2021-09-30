using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollide : MonoBehaviour
{
    // Объём повреждений, наносимых объекту
    public int damage = 1;

    // Объём повреждений, наносимых себе при попадании
    // в какой то другой объект
    public int damageToSelf = 5;

    void HitObject(GameObject theObject)
    {
        // Нанести повреждение объекту, в который попал 
        // данный объект, если возможно
        var theirDamage = theObject.GetComponentInParent<DamageTaking>();
        if (theirDamage)
        {
            theirDamage.TakeDamage(damage);
        }
        // Нанести повреждение себе, если возможно
        var ourDamage = this.GetComponentInParent<DamageTaking>();
        if (ourDamage)
        {
            ourDamage.TakeDamage(damageToSelf);
        }
    }
    // Объект вошёл в область действия данного тригера?
    private void OnTriggerEnter(Collider collider)
    {
        HitObject(collider.gameObject);
    }
    // Другой объект столкнулся с текущим объектом?
    private void OnCollisionEnter(Collision collision)
    {
        HitObject(collision.gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
