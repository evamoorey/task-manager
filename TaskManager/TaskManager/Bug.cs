using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TaskManager
{
    /// <summary>
    /// Класс задач типа Баг.
    /// </summary>
    [DataContract]
    public class Bug : Problem, IAssignable
    {
        /// <summary>
        /// Список исполнителей задачи типа Баг.
        /// </summary>
        [DataMember]
        public List<User> Users { get; set; }

        /// <summary>
        /// Максимальное количество пользователей.
        /// </summary>
        [DataMember]
        public int MaxCount { get; set; }

        /// <summary>
        /// Конструктор без параметров для задачи типа Баг.
        /// </summary>
        public Bug()
        {
            Status = "open";
            Users = new List<User>();
        }

        /// <summary>
        /// Конструктор с параметрами задачи типа Баг.
        /// </summary>
        /// <param name="name"> Имя задачи типа Баг. </param>
        /// <param name="date"> Время создания задачи типа Баг. </param>
        public Bug(string name, DateTime date)
        {
            Status = "open";
            this.Name = name;
            this.Date = date;
            Users = new List<User>();
            MaxCount = 1;
        }
    }
}