﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "EditorialBlock", GUID = "66b7d8c8-598f-47ea-936c-4b8d0eec351b", Description = "")]
    public class EditorialBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}