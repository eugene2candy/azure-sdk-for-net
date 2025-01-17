// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster. </summary>
    public partial class ContainerServiceMaintenanceWindow
    {
        /// <summary> Initializes a new instance of ContainerServiceMaintenanceWindow. </summary>
        /// <param name="schedule"> Recurrence schedule for the maintenance window. </param>
        /// <param name="durationHours"> Length of maintenance window range from 4 to 24 hours. </param>
        /// <param name="startTime"> The start time of the maintenance window. Accepted values are from &apos;00:00&apos; to &apos;23:59&apos;. &apos;utcOffset&apos; applies to this field. For example: &apos;02:00&apos; with &apos;utcOffset: +02:00&apos; means UTC time &apos;00:00&apos;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> or <paramref name="startTime"/> is null. </exception>
        public ContainerServiceMaintenanceWindow(ContainerServiceMaintenanceSchedule schedule, int durationHours, string startTime)
        {
            Argument.AssertNotNull(schedule, nameof(schedule));
            Argument.AssertNotNull(startTime, nameof(startTime));

            Schedule = schedule;
            DurationHours = durationHours;
            StartTime = startTime;
            NotAllowedDates = new ChangeTrackingList<ContainerServiceDateSpan>();
        }

        /// <summary> Initializes a new instance of ContainerServiceMaintenanceWindow. </summary>
        /// <param name="schedule"> Recurrence schedule for the maintenance window. </param>
        /// <param name="durationHours"> Length of maintenance window range from 4 to 24 hours. </param>
        /// <param name="utcOffset"> The UTC offset in format +/-HH:mm. For example, &apos;+05:30&apos; for IST and &apos;-07:00&apos; for PST. If not specified, the default is &apos;+00:00&apos;. </param>
        /// <param name="startDate"> The date the maintenance window activates. If the current date is before this date, the maintenance window is inactive and will not be used for upgrades. If not specified, the maintenance window will be active right away. </param>
        /// <param name="startTime"> The start time of the maintenance window. Accepted values are from &apos;00:00&apos; to &apos;23:59&apos;. &apos;utcOffset&apos; applies to this field. For example: &apos;02:00&apos; with &apos;utcOffset: +02:00&apos; means UTC time &apos;00:00&apos;. </param>
        /// <param name="notAllowedDates"> Date ranges on which upgrade is not allowed. &apos;utcOffset&apos; applies to this field. For example, with &apos;utcOffset: +02:00&apos; and &apos;dateSpan&apos; being &apos;2022-12-23&apos; to &apos;2023-01-03&apos;, maintenance will be blocked from &apos;2022-12-22 22:00&apos; to &apos;2023-01-03 22:00&apos; in UTC time. </param>
        internal ContainerServiceMaintenanceWindow(ContainerServiceMaintenanceSchedule schedule, int durationHours, string utcOffset, string startDate, string startTime, IList<ContainerServiceDateSpan> notAllowedDates)
        {
            Schedule = schedule;
            DurationHours = durationHours;
            UtcOffset = utcOffset;
            StartDate = startDate;
            StartTime = startTime;
            NotAllowedDates = notAllowedDates;
        }

        /// <summary> Recurrence schedule for the maintenance window. </summary>
        public ContainerServiceMaintenanceSchedule Schedule { get; set; }
        /// <summary> Length of maintenance window range from 4 to 24 hours. </summary>
        public int DurationHours { get; set; }
        /// <summary> The UTC offset in format +/-HH:mm. For example, &apos;+05:30&apos; for IST and &apos;-07:00&apos; for PST. If not specified, the default is &apos;+00:00&apos;. </summary>
        public string UtcOffset { get; set; }
        /// <summary> The start time of the maintenance window. Accepted values are from &apos;00:00&apos; to &apos;23:59&apos;. &apos;utcOffset&apos; applies to this field. For example: &apos;02:00&apos; with &apos;utcOffset: +02:00&apos; means UTC time &apos;00:00&apos;. </summary>
        public string StartTime { get; set; }
        /// <summary> Date ranges on which upgrade is not allowed. &apos;utcOffset&apos; applies to this field. For example, with &apos;utcOffset: +02:00&apos; and &apos;dateSpan&apos; being &apos;2022-12-23&apos; to &apos;2023-01-03&apos;, maintenance will be blocked from &apos;2022-12-22 22:00&apos; to &apos;2023-01-03 22:00&apos; in UTC time. </summary>
        public IList<ContainerServiceDateSpan> NotAllowedDates { get; }
    }
}
