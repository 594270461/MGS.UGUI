/*************************************************************************
 *  Copyright (c) 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  UIPanelDemo.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  8/8/2021
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.UGUI.Demo
{
    public class UIPanelDemo : MonoBehaviour
    {
        [SerializeField]
        private TextInputText inputText;

        private void Awake()
        {
            inputText.InitForInteger(0, 1000);
            inputText.OnValueChangedEvent += InputText_OnValueChangedEvent;
        }

        private void Start()
        {
            inputText.Refresh("Weight:", "56", "Enter number...", "KG");
        }

        private void InputText_OnValueChangedEvent(string value)
        {
            Debug.LogFormat("InputText_OnValueChangedEvent value is {0}", value);
        }
    }
}