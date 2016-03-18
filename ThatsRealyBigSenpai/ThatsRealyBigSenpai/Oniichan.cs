using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TheForest.Utils;

namespace ThatsRealyBigSenpai
{
    public class Oniichan : MonoBehaviour
    {
        private static int memeW = 500;
        private static int memeH = 300;
        private static float screenH = Screen.height / 2 - memeH / 2;
        private static float screenW = Screen.width / 2 - memeW / 2;
        private bool Menutog = false;
        private GUIStyle CatBG = new GUIStyle();
        private Texture2D CatBGColor = new Texture2D(1, 1, TextureFormat.ARGB32, false);
        void Start(){
            CatBGColor.SetPixels(new Color[] {new Color(32,32,32,250)});
        }

        void OnGUI(){
            if (Menutog){
                CatBG = new GUIStyle("box");
                CatBG.normal.background = CatBGColor;
                GUI.Box(new Rect(screenW, screenH, memeW, memeH), "", CatBG);
                GUILayout.BeginArea(new Rect(screenW, screenH, memeW, memeH));
                GUILayout.EndArea();

            }
        } // >.<

        void Update(){
            if (UnityEngine.Input.GetKeyDown(KeyCode.G)){
                Menutog = !Menutog;
            }
        }
    }
}
