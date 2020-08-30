﻿using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace PL.Authorization.Application.Authentication
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Claim> Claims { get; set; }
        public string Password { get; set; }
    }
}