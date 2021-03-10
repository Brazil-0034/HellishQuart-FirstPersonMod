using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MelonLoader;
using UnityEngine;

namespace SaberMod
{
    public class SaberColorChange : MelonMod
    {
        /*
        Mesh swordReplacement;
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            swordReplacement = Resources.Load<Mesh>("LongswordWloszka");
        }
        */

        public override void OnUpdate()
        {
            if (GameObject.Find("LongswordWloszka"))
            {
                GameObject LongswordWloszka = GameObject.Find("LongswordWloszka");
                LongswordWloszka.transform.localScale = new Vector3(s.x, s.y, 0.45f);
                LongswordWloszka.transform.Rotate(0, 90 * Time.deltaTime, 0);

                LongswordWloszka.GetComponent<MeshRenderer>().materials[2].SetColor("_Color", new Color(0, 25, 0, 1));
                LongswordWloszka.GetComponent<MeshRenderer>().materials[2].EnableKeyword("_EMISSION");
                LongswordWloszka.GetComponent<MeshRenderer>().materials[2].SetColor("_EmissionColor", new Color(1, 2, 1, 1));lol
            }


            if (GameObject.Find("blade"))
            {
                GameObject blade = GameObject.Find("blade");
                blade.transform.Rotate(0, 90 * Time.deltaTime, 0);

                blade.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(35 + Time.deltaTime, 0, 0, 1));
                blade.GetComponent<MeshRenderer>().materials[0].EnableKeyword("_EMISSION");
                blade.GetComponent<MeshRenderer>().materials[0].SetColor("_EmissionColor", new Color(5, 1, 1, 1));
            }


            if (GameObject.Find("Dragonka"))
            {
                GameObject Dragonka = GameObject.Find("Dragonka");
                Dragonka.transform.Rotate(0, 90 * Time.deltaTime, 0);
                Vector3 s = Dragonka.transform.localScale;
                Dragonka.transform.localScale = new Vector3(s.x, s.y, 0.45f);

                Dragonka.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", new Color(45 + Time.deltaTime, 0, 0, 1));
                Dragonka.GetComponent<MeshRenderer>().materials[0].EnableKeyword("_EMISSION");
                Dragonka.GetComponent<MeshRenderer>().materials[0].SetColor("_EmissionColor", new Color(1, 2, 1, 1));
            }
        }
    }
}
