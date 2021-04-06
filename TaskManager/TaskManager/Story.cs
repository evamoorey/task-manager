using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TaskManager
{
    /// <summary>
    /// Класс задач типа История.
    /// </summary>
    [DataContract]
    public class Story : Problem, IAssignable
    {
        /// <summary>
        /// Список исполнителей задачи типа История.
        /// </summary>
        [DataMember]
        public List<User> Users { get; set; }

        /// <summary>
        /// Максимальное количество пользователей.
        /// </summary>
        [DataMember]
        public int MaxCount { get; set; }

        /// <summary>
        /// Пустой конструктор для задач типа История.
        /// </summary>
        public Story()
        {
            Status = "open";
            Users = new List<User>();
        }

        /// <summary>
        /// Конструктор с параметрами для задач типа История.
        /// </summary>
        /// <param name="name"> Имя задачи. </param>
        /// <param name="date"> Дата создания задачи. </param>
        public Story(string name, DateTime date)
        {
            Status = "open";
            this.Date = date;
            this.Name = name;
            Users = new List<User>();
            MaxCount = 7;
        }
    }
}