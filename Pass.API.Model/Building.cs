﻿using System;
using Pass.API.Interfaces.Entities;

namespace Pass.API.Model
{
	public class BuildingDTO : IBuilding
	{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
