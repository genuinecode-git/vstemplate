﻿namespace ApplicationTemplate.API.Application.Models
{
    public class ErrorResponse
    {
        public string Title { get; set; }
        public int Status { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; } = new();
    }
}
