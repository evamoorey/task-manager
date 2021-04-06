using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TaskManager
{
    /// <summary>
    /// Класс задач типа Таск.
    /// </summary>
    [DataContract]
    public class Task : Problem, IAssignable
    {
        /// <summary>
        /// Список исполнителей.
        /// </summary>
        [DataMember]
        public List<User> Users { get; set; }

        /// <summary>
        /// Максимальное количество пользователей.
        /// </summary>
        [DataMember]
        public int MaxCount { get; set; }

        /// <summary>
        /// Пустой конструктор задачи типа Таск.
        /// </summary>
        public Task()
        {
            Users = new List<User>();
            Status = "open";
        }

        /// <summary>
        /// Конструктор с параметрами для задачи типа Таск.
        /// </summary>
        /// <param name="name"> Имя задачи типа Таск. </param>
        /// <param name="date"> Дата создания задачи типа Таск. </param>
        public Task(string name, DateTime date)
        {
            Status = "open";
            this.Date = date;
            this.Name = name;
            Users = new List<User>();
            MaxCount = 1;
        }
    }
}