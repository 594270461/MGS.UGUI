/*************************************************************************
 *  Copyright (c) #COPYRIGHTYEAR# Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  UIPositionerDemo.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  #CREATEDATE#
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.UGUI.Demo
{
    public class UIPositionerDemo : MonoBehaviour
    {
        public Transform grid;
        public UIPositioner positioner;
        TextAnchor[] alignments = new TextAnchor[]
        {
            TextAnchor.UpperLeft,
            TextAnchor.UpperCenter,
            TextAnchor.UpperRight,

            TextAnchor.MiddleLeft,
            TextAnchor.MiddleCenter,
            TextAnchor.MiddleRight,

            TextAnchor.LowerLeft,
            TextAnchor.LowerCenter,
            TextAnchor.LowerRight,
        };

        private void Awake()
        {
            var btns = grid.GetComponentsInChildren<Button>();
            var i = 0;
            foreach (var btn in btns)
            {
                var index = i;
                btn.onClick.AddListener(() =>
                {
                    var pos = btn.transform.position;
                    var alignment = alignments[index];
                    var anchor = Vector2.one * 0.5f - Text.GetTextAnchorPivot(alignment);
                    var btnTrans = btn.transform as RectTransform;
                    var offset = new Vector2(btnTrans.rect.width * anchor.x, btnTrans.rect.height * anchor.y);
                    positioner.SetPosition(pos, offset, alignment);
                });
                i++;
            }
        }
    }
}