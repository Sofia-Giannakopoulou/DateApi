﻿using System.ComponentModel.DataAnnotations;

namespace DateApi.Entities;
public class Connection
{
    public required string ConnectionId { get; set; }
    public required string Username { get; set; }
}
