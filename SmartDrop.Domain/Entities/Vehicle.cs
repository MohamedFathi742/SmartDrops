using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Domain.Entities;

public class Vehicle
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = string.Empty;

    public double CurrentLatitude { get; set; }

    public double CurrentLongitude { get; set; }


    public List<Drop> AssignedDrops { get; set; } = new();
}