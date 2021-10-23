/*************************************************************************
 *  Copyright (c) 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  UICustomItem.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  10/23/2021
 *  Description  :  Initial development version.
 *************************************************************************/

using MGS.UGUI.Temp;
using UnityEngine;
using UnityEngine.UI;

namespace MGS.UGUI.Demo
{
    public class UICollectorDemo : MonoBehaviour
    {
        public UITextCollector textCollector;
        public string[] texts;

        [Space(5)]
        public UIImageCollector imageCollector;
        public Sprite[] sprites;

        [Space(5)]
        public Temp.UIButtonCollector buttonCollector;
        public ButtonOptions[] buttonoptions;

        [Space(5)]
        public UICustomCollector customCollector;
        public UICustomItemOptions[] itemOptions;

        [Space(5)]
        public Button btnRefresh;

        private void Awake()
        {
            buttonCollector.OnItemClickEvent += ButtonCollector_OnItemClickEvent;
            btnRefresh.onClick.AddListener(BtnRefresh_OnClick);
        }

        private void ButtonCollector_OnItemClickEvent(int index, string text)
        {
            Debug.LogFormat("ButtonCollector_OnItemClickEvent index: {0} text: {1}", index, text);
        }

        private void BtnRefresh_OnClick()
        {
            RefreshCollectors();
        }

        private void Start()
        {
            RefreshCollectors();
        }

        private void RefreshCollectors()
        {
            textCollector.Refresh(texts);
            imageCollector.Refresh(sprites);
            buttonCollector.Refresh(buttonoptions);
            customCollector.Refresh(itemOptions);
        }
    }
}