using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractAction : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera myCam;

    public GameObject rain;

    GameObject piano;

    public Material sunsetRed;
    public Material night;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraCenterRay();
    }

    void CameraCenterRay()
    {
        var ray = myCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);

        if (Input.GetMouseButtonDown(0))
        {
            print(hit.transform.gameObject.name);

            if(hit.transform.gameObject.name == "Piano_low" )
            {
                rain.SetActive(!rain.activeSelf);
                RenderSettings.skybox = night;
            }
            
        }
        
    }
}
