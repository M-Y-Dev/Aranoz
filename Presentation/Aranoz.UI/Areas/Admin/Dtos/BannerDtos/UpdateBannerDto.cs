﻿namespace Aranoz.UI.Areas.Admin.Dtos.BannerDtos
{
    public class UpdateBannerDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
