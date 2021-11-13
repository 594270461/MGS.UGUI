/*************************************************************************
 *  Copyright (c) 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  UIDialogDemo.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  11/13/2021
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;
using UnityEngine.UI;

namespace MGS.UGUI.Demo
{
    public class UIDialogDemo : MonoBehaviour
    {
        public UIDialog dialogBox;

        public Button btnConfirm;
        public Button btnSelectYN;
        public Button btnSelectYNC;

        private void Awake()
        {
            Action<UIDialogResult> call = (result) =>
            {
                Debug.LogFormat("Your select result is {0}", result);
            };

            btnConfirm.onClick.AddListener(() =>
            {
                var option = new UIDialogOption
                {
                    tittle = "Confirm",
                    minimizeButton = true,
                    closeButton = true,
                    content = "This is demo for dialog box test.",
                    yesButton = "Confirm",
                    callback = call
                };
                dialogBox.Refresh(option);
            });

            btnSelectYN.onClick.AddListener(() =>
            {
                var option = new UIDialogOption
                {
                    tittle = "Select",
                    minimizeButton = true,
                    closeButton = true,
                    content = "This is demo for dialog box test\r\nYou can select do or not.",
                    yesButton = "Do It",
                    noButton = "Not Do It",
                    callback = call
                };
                dialogBox.Refresh(option);
            });

            btnSelectYNC.onClick.AddListener(() =>
            {
                var option = new UIDialogOption
                {
                    tittle = "Select",
                    minimizeButton = true,
                    closeButton = true,
                    content = "This is demo for dialog box test\r\nYou can select do or not, or cancel.",
                    yesButton = "Do it",
                    noButton = "Not Do It",
                    cancelButton = "Just Cancel",
                    callback = call
                };
                dialogBox.Refresh(option);
            });
        }
    }
}