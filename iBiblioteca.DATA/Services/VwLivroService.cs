﻿using iBiblioteca.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBiblioteca.DATA.Services
{
    public class VwLivroService 
    {
        public RepositoryVwLivro oRepositoryVwLivro { get; set; }
        public VwLivroService()
        {
            oRepositoryVwLivro = new RepositoryVwLivro();
        }
    }
}
