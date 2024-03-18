﻿using Domain.Entities;

namespace Application.DTOs.JanrDtos;

public class JanrDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public static implicit operator JanrDto(Janr janr)
        => new()
        {
            Id = janr.Id,
            Name = janr.Name
        };
}
