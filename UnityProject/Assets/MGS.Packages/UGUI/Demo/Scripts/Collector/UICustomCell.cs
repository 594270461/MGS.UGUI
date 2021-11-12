/*************************************************************************
 *  Copyright (c) 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  UICustomCell.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  10/23/2021
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;
using UnityEngine.UI;

namespace MGS.UGUI.Demo
{
    public class UICustomCell : UIRefreshable<UICustomCellOptions>
    {
        public Image Image;
        public Text text;

        protected override void OnRefresh(UICustomCellOptions options)
        {
            Image.color = options.color;
            text.text = options.message;
        }
    }

    [Serializable]
    public struct UICustomCellOptions
    {
        public Color color;
        public string message;
    }
}