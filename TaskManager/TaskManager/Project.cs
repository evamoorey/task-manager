using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TaskManager
{
    /// <summary>
    /// Класс проект.
    /// </summary>
    [DataContract]
    public class Project
    {
        /// <summary>
        /// Имя проекта.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Список задач в проекте.
        /// </summary>
        [DataMember] public List<Problem> problems;

        /// <summary>
        /// Конструктор проекта.
        /// </summary>
        /// <param name="name"> Имя проекта. </param>
        public Project(string name)
        {
            Name = name;
            problems = new List<Problem>();
        }

        /// <summary>
        ///  Пустой конструктор.
        /// </summary>
        public Project()
        {
        }
    }
}