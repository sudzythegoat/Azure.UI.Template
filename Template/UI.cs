using BepInEx;
using UnityEngine;

namespace OptimizeX
{
    [BepInPlugin("azure.mod.template", "azure.mod.template", "1.0.0")]
    public class GUI : BaseUnityPlugin
    {
        void OnGUI()
        {
            UnityEngine.GUI.color = Color.black;

            if (UnityEngine.GUI.Button(new Rect(0f, 0f, 280f, 35f), Mods.button1_name))
            {
                Mods.Button1();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 40f, 280f, 35f), Mods.button2_name))
            {
                Mods.Button2();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 80f, 280f, 35f), Mods.button3_name))
            {
                Mods.Button3();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 120f, 280f, 35f), Mods.button4_name))
            {
                Mods.Button4();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 160f, 280f, 35f), Mods.button5_name))
            {
                Mods.Button5();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 200f, 280f, 35f), Mods.button6_name))
            {
                Mods.Button6();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 240f, 280f, 35f), Mods.button7_name))
            {
                Mods.Button7();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 280f, 280f, 35f), Mods.button8_name))
            {
                Mods.Button8();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 320f, 280f, 35f), Mods.button9_name))
            {
                Mods.Button9();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 360f, 280f, 35f), Mods.button10_name))
            {
                Mods.Button10();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 400f, 280f, 35f), Mods.button11_name))
            {
                Mods.Button11();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 440f, 280f, 35f), Mods.button12_name))
            {
                Mods.Button12();
            }
        }
    }
}
