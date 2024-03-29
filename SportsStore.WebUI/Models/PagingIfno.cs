﻿using System;

namespace SportsStore.WebUI.Models {
    public class PagingIfno {
        public int TotalItems { get; set; }
        public int ItemPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemPerPage); }
        }
    }

}