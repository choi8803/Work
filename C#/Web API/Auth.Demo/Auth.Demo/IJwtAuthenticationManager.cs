﻿namespace Auth.Demo
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
