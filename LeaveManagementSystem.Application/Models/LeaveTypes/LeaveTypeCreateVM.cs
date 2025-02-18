﻿namespace LeaveManagementSystem.Application.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(4, 150, ErrorMessage = "You have violated length requirements")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1, 90)]
        [Display(Name = "Number of Days")]
        public int NumberOfDays { get; set; }
    }
}
