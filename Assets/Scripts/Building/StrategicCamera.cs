using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Стратегическая камера. Отвечает за движение камеры и рэйкастинг объектов в точке указателя мыши
/// </summary>
public class StrategicCamera : MonoBehaviour
{
    private RaycastHit hit;

    /// <summary>
    /// Данные точки пересечения луча и объекта
    /// </summary>
    public RaycastHit Hit => hit;

    void Update()
    {
        if (!CameraRaycast(out hit)) return;
        CameraRaycast(out hit);
    }

    /// <summary>
    /// Рэйкаст с помощью луча, выходящего из камеры и направленного на курсор мыши
    /// </summary>
    /// <param name="hit">Данные точки пересечения луча и объекта</param>
    /// <returns>true, если в точке пересечения есть объект с коллайдером</returns>
    bool CameraRaycast(out RaycastHit hit)
    {
        Vector3 origin = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height / 2));
        Vector3 direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500));

        Ray ray = new Ray(origin, direction);
        Debug.DrawRay(origin, direction, Color.blue);
        return Physics.Raycast(ray, out hit);
    }

}
