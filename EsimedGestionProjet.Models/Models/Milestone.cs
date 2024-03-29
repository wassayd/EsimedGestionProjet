﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EsimedGestionProjet.Models
{
    public record Milestone 
    {
        public Guid Id { get; init; }

        public List<Task> Tasks { get; set; }

        [Required]
        public string Label { get; set; }

        public DateTime DeleveryDateEstimated { get; set; }

        public DateTime RealDateEstimated { get; set; }

        [Required]
        public User User { get; set; }

        public DateTime TheoricCalculatedEndDate { get; set; }

        [Required]
        public Project Project { get; set; }

        public Progression Progression { get; set; } = Progression.Created;

        public bool IsFinished()
        {
            return false;
        }
    }
}
