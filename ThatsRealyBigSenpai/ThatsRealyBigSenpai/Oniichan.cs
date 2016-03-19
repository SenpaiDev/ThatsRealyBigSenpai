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
        private static int screenH = Screen.height / 2 - memeH / 2;
        private static int screenW = Screen.width / 2 - memeW / 2;
        private bool Menutog = false;
        public GUIStyle CatBG = new GUIStyle();
        public Texture2D CatBGColor = new Texture2D(1, 1, TextureFormat.ARGB32, false);
        public GUIStyle SelBG = new GUIStyle();
        public Texture2D SelBGColor = new Texture2D(1, 1, TextureFormat.ARGB32, false);
        void Start() {
            CatBGColor.SetPixels(new Color[] { new Color(12, 12, 12, 200) });
            SelBGColor.SetPixels(new Color[] { new Color(200, 52, 52, 52) });
        }



        void OnGUI() {
            if (Menutog) {


                CatBG = new GUIStyle("button");
                CatBG.normal.background = CatBGColor;
                CatBG.hover.background = CatBGColor;
                CatBG.active.background = SelBGColor;

                GUILayout.BeginArea(new Rect(screenW, screenH, 100, memeH));
                if (GUILayout.Button("Player", CatBG, GUILayout.Height(60))) { }
                GUILayout.Space(-3);
                if (GUILayout.Button("Items", CatBG, GUILayout.Height(60))) { }
                GUILayout.Space(-3);

                if (GUILayout.Button("Misc", CatBG, GUILayout.Height(60))) { }
                GUILayout.Space(-3);

                if (GUILayout.Button("Online", CatBG, GUILayout.Height(60))) { }
                GUILayout.Space(-3);
                if (GUILayout.Button("Options", CatBG, GUILayout.Height(60))) { }
                GUILayout.EndArea();


            }


        }
        void Update(){
            if (UnityEngine.Input.GetKeyDown(KeyCode.G)){
                Menutog = !Menutog;
                if (Menutog)
                {
                    LocalPlayer.FpCharacter.LockView(true);
                } else { 
                    LocalPlayer.FpCharacter.UnLockView();
              }
            }
        }
    }
}
