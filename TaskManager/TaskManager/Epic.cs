using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TaskManager
{
    /// <summary>
    /// Класс задач типа Эпик.
    /// </summary>
    [DataContract]
    [KnownType(typeof(Story))]
    [KnownType(typeof(Task))]
    [KnownType(typeof(Bug))]
    public class Epic : Problem
    {
        /// <summary>
        /// Список подзадачи задачи Эпик.
        /// </summary>
        [DataMember] public List<Problem> subtask;

        /// <summary>
        /// Пустой конструктор задачи типа Эпик.
        /// </summary>
        public Epic()
        {
            Status = "open";
            subtask = new List<Problem>();
        }

        /// <summary>
        /// Конструктор с параметрами для задачи типа Эпик.
        /// </summary>
        /// <param name="name"> Имя задачи типа Эпик. </param>
        /// <param name="date"> Дата создания задачи типа Эпик. </param>
        public Epic(string name, DateTime date)
        {
            Status = "open";
            this.Name = name;
            this.Date = date;
            subtask = new List<Problem>();
        }
    }
}