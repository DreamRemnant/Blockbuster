﻿namespace Blockbuster.API.Models.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
