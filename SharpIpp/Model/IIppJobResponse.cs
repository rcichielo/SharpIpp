﻿namespace SharpIpp.Model
{
    public interface IIppJobResponse : IIppResponseMessage
    {
        /// <summary>
        ///     job-uri
        /// </summary>
        public string JobUri { get; set; }

        /// <summary>
        ///     job-id
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        ///     job-state
        /// </summary>
        public JobState JobState { get; set; }

        /// <summary>
        ///     job-state-reasons
        /// </summary>
        public string[] JobStateReasons { get; set; }

        /// <summary>
        ///     job-state-message
        /// </summary>
        public string? JobStateMessage { get; set; }

        /// <summary>
        ///     number-of-intervening-jobs
        /// </summary>
        public int? NumberOfInterveningJobs { get; set; }
    }
}