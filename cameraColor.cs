using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraColor : MonoBehaviour {
        private Camera camera;

        public float duration = 3.0F;

        public Color color1, color2;

        private void OnEnable()
        {
            camera = GetComponent<Camera>();
            camera.clearFlags = CameraClearFlags.SolidColor;
        }

        private void Update()
        {
            var t = Mathf.PingPong(Time.time, duration) / duration;
            camera.backgroundColor = Color.Lerp(color1, color2, t);
        }
    } 
