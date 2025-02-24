using BepInEx;
using UnityEngine;

namespace UI
{
    [BepInPlugin("azure.mod.template", "azure.mod.template", "1.0.0")]
    public class GUI : BaseUnityPlugin
    {
        void OnGUI()
        {
            UnityEngine.GUI.color = Color.black;

            if (UnityEngine.GUI.Button(new Rect(0f, 0f, 280f, 35f), Buttons.button1_name))
            {
                Buttons.Button1();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 40f, 280f, 35f), Buttons.button2_name))
            {
                Buttons.Button2();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 80f, 280f, 35f), Buttons.button3_name))
            {
                Buttons.Button3();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 120f, 280f, 35f), Buttons.button4_name))
            {
                Buttons.Button4();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 160f, 280f, 35f), Buttons.button5_name))
            {
                Buttons.Button5();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 200f, 280f, 35f), Buttons.button6_name))
            {
                Buttons.Button6();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 240f, 280f, 35f), Buttons.button7_name))
            {
                Buttons.Button7();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 280f, 280f, 35f), Buttons.button8_name))
            {
                Buttons.Button8();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 320f, 280f, 35f), Buttons.button9_name))
            {
                Buttons.Button9();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 360f, 280f, 35f), Buttons.button10_name))
            {
                Buttons.Button10();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 400f, 280f, 35f), Buttons.button11_name))
            {
                Buttons.Button11();
            }

            if (UnityEngine.GUI.Button(new Rect(0f, 440f, 280f, 35f), Buttons.button12_name))
            {
                Buttons.Button12();
            }
        }
    }
}
