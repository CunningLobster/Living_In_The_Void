using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategicCamera : MonoBehaviour
{
    public RaycastHit hit;

    private Vector3 selectedBuildingPos;
    public Vector3 SelectedBuildingPos { get => selectedBuildingPos; }

    void Start()
    {
        
    }

    void Update()
    {
        if (!CameraRaycast(out hit)) return;
        CameraRaycast(out hit);
        if (hit.collider.gameObject.TryGetComponent<IRaycastTarget>(out IRaycastTarget raycastTarget))
            raycastTarget.Respond(hit.point);

        selectedBuildingPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
    }

    bool CameraRaycast(out RaycastHit hit)
    {
        Vector3 origin = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height / 2));
        Vector3 direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500));

        Ray ray = new Ray(origin, direction);
        //RaycastHit hit;
        Debug.DrawRay(origin, direction, Color.blue);
        return Physics.Raycast(ray, out hit)/* && hit.collider.gameObject.GetComponent<Station>() != null*/;
    }

}
