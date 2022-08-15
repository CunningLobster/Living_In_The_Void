using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastStation();


        if (!gameObject.activeInHierarchy) return;
        //gameObject.transform.position = Input.mousePosition;

    }

    void RaycastStation()
    {
        Ray ray = new Ray(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width/2, Screen.height/2)), Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500)));
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        Debug.DrawRay(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height / 2)), Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500)), Color.blue);

        Debug.Log(hit.point);
        gameObject.transform.position = hit.point;
    }

}
