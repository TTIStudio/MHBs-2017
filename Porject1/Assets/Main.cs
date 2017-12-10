using UnityEngine;
using System.Collections;

using System;
using System.IO;
// Open File with Windows UI  -- Method 2   -   END
public class Main : MonoBehaviour {


    System.Random rand = new System.Random();

    void Start()
    {
        Create_Plane(10, -20);
        MainCamera_Init(9, 0, 0, 0, 6, (float)-25);

        Creat_MHBs_Circle_area((float)0.1,(float)2,0,0,10,10);
        print("Hello MHB!");

    }
    // Update is called once per frame
    void Update () {
        
    }

    //-----------------------------------------------------------------------------------------------------------   Sence Intilization


    void Create_Plane(int size, float Hight)
    {
        GameObject Plane_1 = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Plane_1.transform.localScale = new Vector3(size, 5, size);
        Plane_1.transform.position = new Vector3(0, (float)Hight, 0);
    }
    void MainCamera_Init(float R_X, float R_Y, float R_Z, float P_X, float P_Y, float P_Z)
    {
        Camera.main.transform.position = new Vector3((float)P_X, (float)P_Y, (float)P_Z);
        Camera.main.transform.Rotate((float)R_X, (float)R_Y, (float)R_Z);
    }


    //-----------------------------------------------------------------------------------------------------------   


    void Create_MHB(float D, float Long, float R_X, float R_Y, float R_Z, float P_X, float P_Y, float P_Z)
    {
        GameObject MHB = new GameObject();
        MHB.name = "MHB";

        GameObject cylinder_1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder_1.transform.localScale = new Vector3((float)D, Long, (float)D);
        cylinder_1.transform.Rotate((float)54.74, (float)45, 0);
        cylinder_1.transform.parent = MHB.transform;

        GameObject cylinder_2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder_2.transform.localScale = new Vector3((float)D, Long, (float)D);
        cylinder_2.transform.Rotate((float)54.74, (float)-45, (float)0);
        cylinder_2.transform.parent = MHB.transform;

        GameObject cylinder_3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder_3.transform.localScale = new Vector3((float)D, Long, (float)D);
        cylinder_3.transform.Rotate((float)-54.74, (float)45, (float)0);
        cylinder_3.transform.parent = MHB.transform;

        GameObject cylinder_4 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder_4.transform.localScale = new Vector3((float)D, Long, (float)D);
        cylinder_4.transform.Rotate((float)-54.74, (float)-45, (float)0);
        cylinder_4.transform.parent = MHB.transform;

        MHB.AddComponent<Rigidbody>();

        MHB.transform.position = new Vector3(P_X, P_Y, P_Z);
        MHB.transform.Rotate(R_X, R_Y, R_Z);
    }



    //-----------------------------------------------------------------------------------------------------------   
    //example:
    //Creat_MHBs_Circle_area((float)0.1,(float)2,0,0,10,10);
    void Creat_MHBs_Circle(float MHB_D, float MHB_LONG, float CIRCLE_CENTER_X, float CIRCLE_CENTER_Z, float CIRCLE_RADIUS, int MHB_NUMBER)
    {
        for (int i=0; i < MHB_NUMBER; i++)
        {
            double a = rand.NextDouble() * 360;
            Create_MHB(MHB_D, MHB_LONG, 0, 0, 0, (float)(Math.Sin(a)+ CIRCLE_CENTER_X)* CIRCLE_RADIUS, 10, (float)(Math.Cos(a)+ CIRCLE_CENTER_Z)* CIRCLE_RADIUS);
        }
    }

    //example:
    //Creat_MHBs_Circle_area((float)0.1,(float)2,0,0,10,10);
    void Creat_MHBs_Circle_area(float MHB_D, float MHB_LONG, float CIRCLE_CENTER_X, float CIRCLE_CENTER_Z, float CIRCLE_RADIUS, int MHB_NUMBER)
    {
        for (int i = 0; i < MHB_NUMBER; i++)
        {
            double a = rand.NextDouble() * 360;
           double  CIRCLE_RADIUS_2 = rand.NextDouble()* CIRCLE_RADIUS;
            Create_MHB(MHB_D, MHB_LONG, 0, 0, 0, (float)(Math.Sin(a) + CIRCLE_CENTER_X) * (float)CIRCLE_RADIUS_2, 10, (float)(Math.Cos(a) + CIRCLE_CENTER_Z) * (float)CIRCLE_RADIUS_2);
        }
    }







}

