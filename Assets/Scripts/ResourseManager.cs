using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourseManager : MonoBehaviour {

    public Text ResourceText;

    private int _resourse = 0;

    private void Start() {
        ResourceText.text = _resourse.ToString();
    }

    public void AddResourses(int amount) {
        _resourse += amount;
        UpdateResourseCountOnHud();
    }

    public void SpendResourses(int amount) {
        _resourse -= amount;
        Mathf.Clamp(_resourse, 0, _resourse);
        UpdateResourseCountOnHud();
    }

    private void UpdateResourseCountOnHud() {
        ResourceText.text = _resourse.ToString();
    }
}
