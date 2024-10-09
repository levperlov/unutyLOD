using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LOD : MonoBehaviour
{
    // входные данные(указываются для каждого объекта в карточке объекта)
    public Transform cameraTransform; // Трансформ камеры 
    public Texture texture; // Текстура высокого качества
    public Texture lowtexture; // Текстура низкого качества
    public Material material; // Материал, наложенный на связанный с данным скриптом объект
    public bool isstatic=true; // флаг, отвечающий за то будет ли меняться текстура при попадании объекта в зону видимости любой из камер(true-не меняется, false- меняется)
    public int distanse; // максимальная дистанция, на которой видно объект в хорошем разрешении
    
    private bool isvisible = true; // флаг, отвечающий за видимость объекта
    void Update() // Update is called once per frame
    {
        float dist = Vector3.Distance(cameraTransform.position, transform.position); //получения расстояния между камерой и объектом
        if (dist <= distanse && isvisible) // проверка, что объект виден и расстояние между камерой и объектом<=заданной в свойствах объекта дистанции
        {
            material.mainTexture= texture; //заменяем текстуру на более качественную
        }
        else
        {
            material.mainTexture = lowtexture; //заменяем текстуру на менее качественную
        }
    }
    
    void OnBecameInvisible()// Специальный метод, который unity выполняет, когда ни одна камера ни смотрит на объект
    {
        isvisible=false; //объект вне поля видимости камеры
    }
    void OnBecameVisible() //Специальный метод, который unity выполняет, когда хотя бы одна камера ни смотрит на объект
    {
        if (!isstatic) //если должна меняться текстура при попадании объекта в зону видимости любой из камер
        {
            isvisible=true; //объект в поле видимости камеры
        }
    }
}
