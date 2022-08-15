using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvester : MonoBehaviour {

    public Transform ResourseBase;
    public Transform HomeBase;

    private float _movementSpeed;
    private int _capacity;
    private float _hurvestingTime;
    private float _unloadingResoursesTime;
    private Vector3 _basePosition;
    private Vector3 _resourseBasePosotion;
    private bool _onSearchingResourses = true;
    private bool _onReturningToBase = false;
    private bool _onHurvestingResourses = false;
    private bool _onUnLoadingResourses = false;
    private ResourseManager _resourseManager;

    private float _lerpValue = 0;
    private float _timer = 0;

    private void Start() {
        _movementSpeed = 0.1f;
        _capacity = 10;
        _hurvestingTime = 5f;
        _unloadingResoursesTime = 3f;
        _basePosition = HomeBase.position;
        _resourseBasePosotion = ResourseBase.position;

        _resourseManager = GameObject.FindObjectOfType<ResourseManager>().GetComponent<ResourseManager>();
    }

    private void Update() {
        if (_onSearchingResourses) {
            MoveToResoursBase();
        }

        else if (_onReturningToBase) {
            ReturnToMainBase();
        }

        else if (_onHurvestingResourses) {
            StartHurvestingTimer();
        }

        else if (_onUnLoadingResourses) {
            StartUnloadingResoursesTimer();
        }
    }

    private void MoveToResoursBase() {
        _lerpValue += Time.deltaTime * _movementSpeed;
        Mathf.Clamp01(_lerpValue);
        transform.position = Vector3.Lerp(_basePosition, _resourseBasePosotion, _lerpValue);

        if (_lerpValue >= 1) {
            _onSearchingResourses = false;
            _onHurvestingResourses = true;
            _lerpValue = 0;
        }
    }

    private void ReturnToMainBase() {
        _lerpValue += Time.deltaTime * _movementSpeed;
        Mathf.Clamp01(_lerpValue);
        transform.position = Vector3.Lerp(_resourseBasePosotion, _basePosition, _lerpValue);

        if (_lerpValue >= 1) {
            _onReturningToBase = false;
            _onUnLoadingResourses = true;
            _lerpValue = 0;
        }
    }

    private void StartHurvestingTimer() {
        _timer += Time.deltaTime;
        Mathf.Clamp(_timer, 0, _hurvestingTime);

        if (_timer >= _hurvestingTime) {
            _onHurvestingResourses = false;
            _onReturningToBase = true;
            _timer = 0;
        }
    }

    private void StartUnloadingResoursesTimer() {
        _timer += Time.deltaTime;
        Mathf.Clamp(_timer, 0, _unloadingResoursesTime);

        if (_timer >= _unloadingResoursesTime) {
            _onUnLoadingResourses = false;
            _onSearchingResourses = true;
            _timer = 0;
            _resourseManager.AddResourses(_capacity);
        }
    }
}
