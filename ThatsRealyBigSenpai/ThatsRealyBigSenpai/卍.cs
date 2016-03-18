using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ThatsRealyBigSenpai
{
    public class 卍{
        public static GameObject ユダヤ人;
        
        public static void Εβραίοι(){
            if(ユダヤ人 == null){
                ユダヤ人 = new GameObject();
                ユダヤ人.AddComponent<Oniichan>();
                UnityEngine.Object.DontDestroyOnLoad(ユダヤ人);
            }
        }
    }
}
