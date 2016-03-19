using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ThatsRealyBigSenpai
{
    public class dildo : MonoBehaviour{
        public static GameObject dd;
        
        public static void meme(){
            if (dd == null){
                dd = new GameObject();
                dd.AddComponent<Oniichan>();
                UnityEngine.Object.DontDestroyOnLoad(dd);
            }
        }
    }
}
