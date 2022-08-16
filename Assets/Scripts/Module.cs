using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour
{
    [SerializeField] float cameraToModuleDistance = 3f;

    [SerializeField] private bool pluggedIn;
    public bool PluggedIn { get => pluggedIn; set { pluggedIn = value; } }

    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (pluggedIn == false)
        {
            if (CameraRaycast(out hit))
                gameObject.transform.position = hit.point;
            else
                gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y + 10, cameraToModuleDistance));
        }
        Debug.Log(CameraRaycast(out hit));
    }

    /// <summary>
    /// Построить луч, исходящий из центра экрана и определяющий точку пересечения со станцией.
    /// </summary>
    bool CameraRaycast(out RaycastHit hit)
    {
        Vector3 origin = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height / 2));
        Vector3 direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500));

        Ray ray = new Ray(origin, direction);
        Debug.DrawRay(origin, direction, Color.blue);
        return Physics.Raycast(ray, out hit)/* && hit.collider.gameObject.GetComponent<Station>() != null*/;
    }

}
