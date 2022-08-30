using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Данные здания
/// </summary>
[CreateAssetMenu(fileName = "Create Building Data", menuName = "ScriptableObjects/Building", order = 1)]
public class BuildingData : ScriptableObject
{
    /// <summary>
    /// Иконка здания
    /// </summary>
    [SerializeField] Sprite image;
    //Далее будут требования для пострройки здания (напр. Кол-во необходимых ресурсов)
}
