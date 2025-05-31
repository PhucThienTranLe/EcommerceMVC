﻿using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Nhập tên thương hiệu")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Nhập mô tả thương hiệu")]
        public string Description { get; set; }
        public string Slug { get; set; }
        public int Status { get; set; }
    }
}
