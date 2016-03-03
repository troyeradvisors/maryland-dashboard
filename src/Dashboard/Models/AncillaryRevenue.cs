using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dashboard.Models
{
    public partial class AncillaryRevenue
    {
        public int PIN { get; set; }
        public int FiscalYear { get; set; }
        public int AttachmentsRevenue { get; set; }
        [MaxLength(70)]
        public string Custom1Name { get; set; }
        public int Custom1Revenue { get; set; }
        [MaxLength(70)]
        public string Custom2Name { get; set; }
        public int Custom2Revenue { get; set; }
        public int EquipmentRental { get; set; }
        public int Laboratory { get; set; }
        public int MedicalSupplies { get; set; }
        public int OccupationalTherapy { get; set; }
        public int Oxygen { get; set; }
        public int Pharmacy { get; set; }
        public int PhysicalTherapy { get; set; }
        public int PhysicianCare { get; set; }
        public int Radiology { get; set; }
        public int RecreationalActivities { get; set; }
        public int SpeechTherapy { get; set; }
    }
}
