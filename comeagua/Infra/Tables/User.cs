﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comeagua.Infra.Tables
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }

        public int ReviewID { get; set; }
        public virtual List<Photo> Photos { get; set; }
        public virtual List<Event> Events { get; set; }
    }
}