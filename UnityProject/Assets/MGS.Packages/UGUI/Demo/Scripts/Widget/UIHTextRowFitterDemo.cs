/*************************************************************************
 *  Copyright (c) 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  UIHTextRowFitterDemo.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  8/29/2021
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.UGUI.Demo
{
    public class UIHTextRowFitterDemo : MonoBehaviour
    {
        public UIHTextRowFitter textRowFitter;

        private void Start()
        {
            var datas = new HTextRowData[]
            {
                new HTextRowData("Test tittle:", "Test content"),
                new HTextRowData("Test a long lengh tittle:", "Test content"),
                new HTextRowData("Test tittle:", "Test a long lengh content")
            };
            textRowFitter.Refresh(datas);
        }
    }
}