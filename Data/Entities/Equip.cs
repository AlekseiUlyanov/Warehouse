﻿namespace Data.Entities
{
    /// <summary>
    /// Оборудование
    /// </summary>
    public class Equip
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        //public int Id { get; set; }
        public Guid Id { get; set; }

        /// <summary>
        /// Серийный номер
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Модель 
        /// </summary>
        public string Model { get; set; }
    }

}
