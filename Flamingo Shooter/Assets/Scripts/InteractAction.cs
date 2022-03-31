using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractAction : MonoBehaviour
{
    public int wheatherTime=0;

    public Camera myCam;

    public GameObject rain;

    GameObject piano;

    public Material sunsetRed;
    public Material night;
    public Material afternoonSky;

    public Light DirectionLight;

    public GameObject fireLight1;
    public GameObject fireLight2;
    public GameObject fireSound;
    public GameObject fireSmoke;

    public List<Light> floor1Light;
    void Start()
    {
        rain.SetActive(false);

        RenderSettings.skybox = afternoonSky;
        RenderSettings.fogColor = new Color32(255, 255, 190, 255);
        RenderSettings.ambientIntensity = 2f;

        DirectionLight.color = new Color32(255, 255, 200, 255);

        fireLight1.SetActive(false);
        fireLight2.SetActive(false);
        fireSound.SetActive(false);
        fireSmoke.SetActive(false);

        for (int i = 0; i < 70; i++)
        {
            floor1Light[i].color = new Color32(0, 0, 0, 0);        // Á¶¸í OFF
        }
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

        if (Input.GetMouseButtonDown(0))        // ¸¶¿ì½º Å¬¸¯½Ã
        {
            print(hit.transform.gameObject.name);       // ÀÌ¸§À» È£Ãâ

            if(hit.transform.gameObject.name == "Piano_low" )       // ÇÇ¾Æ³ë Å¬¸¯½Ã
            {
                wheatherTime++;
                print(wheatherTime % 4);

                if (wheatherTime % 4==1)        // ³ëÀ» ÇØÁú³è
                {
                    rain.SetActive(false);

                    RenderSettings.skybox = sunsetRed;
                    RenderSettings.fogColor = new Color32(229, 90, 1, 255);
                    RenderSettings.ambientIntensity = 0.05f;

                    DirectionLight.color = new Color32(106, 58, 27, 255);
                    fireLight1.SetActive(true);
                    fireLight2.SetActive(true);
                    fireSound.SetActive(true);
                    fireSmoke.SetActive(true);

                    for (int i = 0; i < 70; i++)
                    {
                        floor1Light[i].color = new Color32(229, 90, 1, 255);        
                    }
                }

                else if(wheatherTime % 4 == 2)      // ¹ãÇÏ´Ã ´Þºû
                {
                    rain.SetActive(false);

                    RenderSettings.skybox = night;
                    RenderSettings.fogColor = new Color32(166, 166, 166, 150);
                    RenderSettings.ambientIntensity = 0.02f;

                    DirectionLight.color = new Color32(80, 80, 80, 255);
                    fireLight1.SetActive(true);
                    fireLight2.SetActive(true);
                    fireSound.SetActive(true);
                    fireSmoke.SetActive(true);

                    for (int i = 0; i < 70; i++)
                    {
                        floor1Light[i].color = new Color32(180, 180, 180, 150);     
                    }
                }

                else if (wheatherTime % 4 == 3)     // ºñ¿À´Â ¹ãÇÏ´Ã ´Þºû
                {
                    rain.SetActive(true);

                    RenderSettings.skybox = night;
                    RenderSettings.fogColor = new Color32(166, 166, 166, 150);
                    RenderSettings.ambientIntensity = 0.02f;

                    DirectionLight.color = new Color32(80, 80, 80, 255);

                    fireLight1.SetActive(false);
                    fireLight2.SetActive(false);
                    fireSound.SetActive(false);
                    fireSmoke.SetActive(true);
                }

                else if (wheatherTime % 4 == 0)     // ¸¼Àº ÇÏ´Ã ¶ß°Å¿î ÅÂ¾ç
                {
                    rain.SetActive(false);

                    RenderSettings.skybox = afternoonSky;
                    RenderSettings.fogColor = new Color32(255, 255, 190, 200);
                    RenderSettings.ambientIntensity = 2f;

                    DirectionLight.color = new Color32(255, 255, 200, 200);

                    fireLight1.SetActive(false);
                    fireLight2.SetActive(false);
                    fireSound.SetActive(false);
                    fireSmoke.SetActive(false);

                    for (int i = 0; i < 70; i++)
                    {
                        floor1Light[i].color = new Color32(0, 0, 0, 0);        // Á¶¸í OFF
                    }
                }
            }
            
        }
        
    }
}
