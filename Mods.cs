using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Photon.Pun;
using ZenonsModTemplate.Utils;
using UnityEngine.InputSystem;
using System.Drawing;
namespace ZenonsModTemplate
{
    //You can change the class name if you want to
    public class Mod : MonoBehaviour
    {
        public static bool modded;

        //public void OnGUI() 
        //{
        //bool disconnect = GUILayout.Button("Disconnect", Array.Empty<GUILayoutOption>());

        // if (disconnect) 
        //  {
        //    LobbyUtils.Disconnect();
        // }

        //bool joinpub = GUILayout.Button("Join Random Canyon", Array.Empty<GUILayoutOption>());
        //if (joinpub) 
        //{
        //    LobbyUtils.JoinPublicRoom("canyon");
        // }
        // }


        public static List<GameObject> cblos = new List<GameObject> { };

        public void Update() 
        {
            {
                foreach (GameObject l in cblos)
                {
                    l.SetActive(true);
                }
                cblos.Clear();
            }
        }
    }
}
