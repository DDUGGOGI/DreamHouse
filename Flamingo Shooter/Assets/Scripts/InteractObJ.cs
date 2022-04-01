using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObJ : MonoBehaviour
{

    public bool isOpen = false;
    public bool isConnect = false;

    public Vector3 defaultPosition;
    public Vector3 targetPosition;
    public Animation ani;

    public string openMove;
    public string closeMmove;


    void Start()
    {
        ani = GetComponent<Animation>();

    }


    void Update()
    {
        
    }

    public void ChangePosition()
    {
        if (isOpen==false)
        {
            ani.Play(openMove);
            Invoke("OnBool", 1f);
            /*
            print("¹® ¿­¸²");
            Vector3 vel = Vector3.zero;
            transform.position = Vector3.Lerp(this.transform.position, targetPosition, 0.1f);
            Invoke("offConnect", 1.1f);
            Invoke("OnBool", 1.2f);
            */
        }
        else if(isOpen ==true)
        {
            ani.Play(closeMmove);
            Invoke("OffBool", 1f);
            /*
            Vector3 vel = Vector3.zero;
            print("¹® ´ÝÈû");
            transform.position = Vector3.Lerp(this.transform.position, defaultPosition, 0.1f);
            Invoke("offConnect", 1.1f);
            Invoke("OffBool", 1.2f);
            */

        }
    }

    public void OnBool()
    {
        isOpen = true;
    }

    public void OffBool()
    {
        isOpen = false;
    }

    public void OnConnect()
    {
        isConnect = true;
    }

    void offConnect()
    {
        isConnect = false;
    }
}
