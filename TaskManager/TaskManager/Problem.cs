using System;
using System.Runtime.Serialization;

namespace TaskManager
{
    /// <summary>
    /// Родительский класс для всех задач.
    /// </summary>
    [DataContract]
    [KnownType(typeof(Epic))]
    [KnownType(typeof(Story))]
    [KnownType(typeof(Task))]
    [KnownType(typeof(Bug))]
    public class Problem
    {
        /// <summary>
        /// Свойство имени задачи.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Свойство даты создания задачи.
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        /// Свойство статуса задачи.
        /// </summary>
        [DataMember]
        public string Status { get; set; }
    }
}