﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SharedKernelData.Entity
{
    public abstract class EntityBase
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedUtc { get; set; }
        public bool Deleted { get; set; }
        

        //[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime Created { get; set; }
    }
}