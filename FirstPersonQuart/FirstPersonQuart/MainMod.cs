using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;

namespace FirstPersonQuart
{
    public class MainMod : MelonMod
    {
        /**
         * Apparently 0.3.0A doesn't support UnityEngine.Input?
         * if anyone can figure it out, PR is welcome
         * for now, a boolean object is checked/unchecked on scene load
         * override the update loop, with a boolean check there.
         */

        public bool prep = true;

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            MelonLogger.Msg("Loaded Scene by Name : " + sceneName);
            if (sceneName != "CharacterSelect" && sceneName != "TempMenu")
            {
                prep = false;
            }
        }

        public override void OnUpdate()
        {
            if (prep == false)
            {
                prep = locateCameras();
            }
        }

        public bool locateCameras()
        {
            var cameras = Resources.FindObjectsOfTypeAll<UnityEngine.Camera>();
            if (cameras.Length > 0)
            {
                for (int i = 0; i < cameras.Length; i++)
                {
                    if (cameras[i].gameObject.name.Equals("FPPCamera"))
                    {
                        cameras[i].gameObject.SetActive(true);
                        cameras[i].fieldOfView = 85;

                        GameObject.Find("pSphere1").SetActive(false);
                        GameObject.Find("pSphere2").SetActive(false);
                        GameObject.Find("Group27005").SetActive(false);
                        GameObject.Find("Jaw").SetActive(false);

                        return true;
                    }
                }
            }
            return false;
        }
    }
}
