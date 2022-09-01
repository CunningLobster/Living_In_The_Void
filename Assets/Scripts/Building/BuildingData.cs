using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Данные Постройки
/// </summary>
[CreateAssetMenu(fileName = "Create Building Data", menuName = "ScriptableObjects/Building", order = 1)]
public class BuildingData : ScriptableObject
{
    [SerializeField] private Sprite image;
    [SerializeField] private float hp;

    [SerializeField] private float buyingPrice;
}
