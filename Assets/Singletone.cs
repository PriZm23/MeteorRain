using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Этот класс позволяетдругим объектам ссылаться на 
// единственный общий объект.
// Его используют классы GameManager и InputManager.

// Чтобы воспользоваться этим классом, унаследуем его
public class MyManager : Singletone<MyManager>
{

}
// После этого можно обращаться к единственному 
// общему экземпляру класса
// MyManager.instance.DoSomething();
public class Singletone<T> : MonoBehaviour where T : MonoBehaviour
{
    // Единственный экземпляр этого класса
    private static T _instance;

    // Метод доступа. При первом вызове настраивает _instance.
    // Если требуемый объект не найден,
    // выводит сообщение об ошибке в журнал
    public static T instance
    {
        get
        {
            // Если свойство _ instance ещё не настроено
            if(_instance == null)
            {
                // попытаться найти объект
                _instance = FindObjectOfType<T>();

                // Записать сообщение об ошибке в случае неудачи
                if(_instance == null)
                {
                    Debug.LogError("Can't find " + typeof(T) + "!");
                }
            }
            // Вернуть экземпляр для использования
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
