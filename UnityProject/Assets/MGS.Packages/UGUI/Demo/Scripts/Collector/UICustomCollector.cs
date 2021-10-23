﻿/*************************************************************************
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

namespace MGS.UGUI.Demo
{
    public class UICustomCollector : UICollector<UICustomItem, UICustomItemOptions>
    {
        protected override void RefreshItem(UICustomItem item, UICustomItemOptions info)
        {
            item.Refresh(info);
        }
    }
}