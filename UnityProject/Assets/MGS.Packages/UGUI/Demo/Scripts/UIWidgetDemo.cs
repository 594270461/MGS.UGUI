/*************************************************************************
 *  Copyright (c) 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  UIWidgetDemo.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  8/6/2021
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.UGUI.Demo
{
    public class UIWidgetDemo : MonoBehaviour
    {
        [SerializeField]
        private SearchSelector searchSelector;

        private void Awake()
        {
            searchSelector.OnSelectEvent += SearchSelector_OnSelectEvent;
        }

        private void Start()
        {
            var items = new string[]
            {
                "0","01","012", "0123","01234"
            };

            var caption = "Enter keywords...";
            searchSelector.Refresh(items, -1, caption);
        }

        private void SearchSelector_OnSelectEvent(int index, string value)
        {
            Debug.LogFormat("SearchSelector_OnSelectEvent index is {0}, value is {1}", index, value);
        }
    }
}