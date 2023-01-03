using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    [SerializeField] LayerMask raycastLayerHit;
    Vector3 crosshairPosition;

    [SerializeField] GameObject bullet;
    [SerializeField] GameObject shotParticle;

    void Update()
    {
        //ray = new Ray(Camera.main.transform.position, Camera.main.transform.position - Input.mousePosition);
        if (!Pause.IsPaused && !Timer.IsTimeOut)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, float.MaxValue, raycastLayerHit))
            {
                crosshairPosition = hit.point;
                transform.LookAt(crosshairPosition);
            }
            if (Input.GetKeyDown(KeyCode.Mouse0)) Shot();
        }
    }
    void Shot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        Instantiate(shotParticle, transform.position, transform.rotation);
    }
}
