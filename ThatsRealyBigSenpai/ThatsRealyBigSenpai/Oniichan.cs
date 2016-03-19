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
        public Texture2D texturetest = new Texture2D(128, 128);
        public GUIStyle currentStyle = null;
        void Start() {
            CatBGColor.SetPixels(new Color[] { new Color(32, 32, 32, 200) });
            SelBGColor.SetPixels(new Color[] { new Color(1, 1, 1, 255) });

            GetComponent<Renderer>().material.mainTexture = texturetest;

            for (int y = 0; y < texturetest.height; y++) {
                for (int x = 0; x < texturetest.width; x++) {
                    Color color = ((x & y) != 0 ? Color.blue : Color.gray);
                    texturetest.SetPixel(x, y, color);
                }
            }
            texturetest.Apply();




        }


        void OnGUI() {
            if (Menutog) {


                CatBG = new GUIStyle("button");
                CatBG.normal.background = CatBGColor;
                CatBG.hover.background = CatBGColor;
                //CatBG.active.background = CatBGColor;
               
                SelBG = new GUIStyle("box");

                SelBG.normal.background = SelBGColor;
                SelBG.hover.background = SelBGColor;
                SelBG.active.background = SelBGColor;
                

                GUILayout.BeginArea(new Rect(screenW, screenH, 100, memeH));
                if (GUILayout.Button("Player", CatBG, GUILayout.Height(60))) {
                }
                GUILayout.Space(-4);
                if (GUILayout.Button("Items", CatBG, GUILayout.Height(60))) { }
                GUILayout.Space(-4);
                if (GUILayout.Button("Misc", CatBG, GUILayout.Height(60))) { }
                GUILayout.Space(-4);
                if (GUILayout.Button("Online", CatBG, GUILayout.Height(60))) { }
                GUILayout.Space(-4);
                if (GUILayout.Button("Options", CatBG, GUILayout.Height(60))) { }
                GUILayout.EndArea();
                //GUI.backgroundColor = new Color(32,32,32,255);
                //GUI.Box(new Rect(screenW + 100, screenH, 400, memeH), "", texturetest);

                //GUILayout.BeginArea(new Rect(screenW + 100, screenH, 400, memeH), SelBG);
                // GUILayout.Box();
                //GUILayout.EndArea();

                InitStyles();
                GUI.Box(new Rect(0, 0, 100, 100), "test", currentStyle);

            }


        }
        private void InitStyles() {
            if (currentStyle == null) {
                currentStyle = new GUIStyle(GUI.skin.box);
                currentStyle.normal.background = MakeTex(2, 2, new Color(0.32f, 0.32f, 0.32f, 0.5f));
            }
        }
        private Texture2D MakeTex(int width, int height, Color col) {
            Color[] pix = new Color[width * height];
            for (int i = 0; i < pix.Length; ++i) {
                pix[i] = col;
            }
            Texture2D result = new Texture2D(width, height);
            result.SetPixels(pix);
            result.Apply();
            return result;
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
