﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - ItemEditTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/08/11
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemEditTagHelper : ItemLinkTagHelperBase
{
    public ItemEditTagHelper(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory)
        : base(contextAccessor, urlHelperFactory)
    {
        ActionName = "Edit";
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        BuildContent(output,"text-warning","Edit","edit");
    }
}