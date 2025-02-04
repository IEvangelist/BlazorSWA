using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorApp.Shared
{
    public class Link
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [RegularExpression(@"^(https?://)?([\w-]+\.)+[\w-]+(/[\w- ./:?%&=#]*)?$", ErrorMessage = "That doesn't look like a valid URL"), Required]
        public string Url { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}