using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    Module activeModule;
    [SerializeField] StrategicCamera strategicCamera;

    private void Update()
    {
        if (activeModule == null) return;
        activeModule.transform.position = strategicCamera.SelectedBuildingPos;
    }

    public void SetActiveModule(Module module)
    { 
        activeModule = module;
    }

}
