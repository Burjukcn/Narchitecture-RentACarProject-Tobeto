﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Dtos
{
    public class CreatedModelResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public DateTime CreatedDate { get; set; }
    
    }
}
