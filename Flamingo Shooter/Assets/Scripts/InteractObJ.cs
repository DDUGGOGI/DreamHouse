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

    public float smoothTime;


    void Start()
    {
        ani = GetComponent<Animation>();

    }


    void Update()
    {
        // ChangePositionCode();
        ChangePositionLocal();
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

    public void ChangePositionCode()
    {
        if (isOpen == false && isConnect==true)
        {
            print("¹® ¿­¸²");
            Vector3 vel = Vector3.zero;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition,ref vel, smoothTime);
            Invoke("offConnect", 1.1f);
            Invoke("OnBool", 1.2f);
            
        }
        else if (isOpen == true && isConnect==true)
        {
            Vector3 vel = Vector3.zero;
            print("¹® ´ÝÈû");
            transform.position = Vector3.SmoothDamp(transform.position, defaultPosition, ref vel, smoothTime);
            Invoke("offConnect", 1.1f);
            Invoke("OffBool", 1.2f);
        }
    }

    public void ChangePositionLocal()
    {
        if (isOpen == false && isConnect == true)
        {
            print("¹® ¿­¸²");
            Vector3 vel = Vector3.zero;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, smoothTime);
            Invoke("offConnect", 1.1f);
            Invoke("OnBool", 1.2f);

        }
        else if (isOpen == true && isConnect == true)
        {
            Vector3 vel = Vector3.zero;
            print("¹® ´ÝÈû");
            transform.position = Vector3.SmoothDamp(transform.position, defaultPosition, ref vel, smoothTime);
            Invoke("offConnect", 1.1f);
            Invoke("OffBool", 1.2f);
        }
    }
}
