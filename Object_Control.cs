using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

//CheckNetIsolation.exe LoopbackExempt -is -n=BluetoothDesktopServer_t05x7yb6e6yp0
namespace Mirror.Examples.RigidbodyPhysics
{
    public class Object_Control : MonoBehaviour
    {
        public GameObject sphere;

        private manager manager;
        float Ypos = 0f;

        List<float> data = new List<float>();
        //int datalength;

        void Awake()
        {
            manager = GetComponent<manager>();
        }

        void Update()
        {
            if (manager.connected)
            {
                Ypos = manager.datum;
                data.Add(Ypos);
                //datalength = data.Count;
                sphere.transform.localPosition = new Vector3(0f, Ypos, 0f);
            }
        }
    }
}


