﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CockTailAssignment
{
    public class Other : Iingredient
    {

        public string Name { get; set; }
        public IngredientType type { get; set; } 

        public int ID { get; set; }

        public Other()
        {

        }

        // TODO: Make ctor
    }
}
