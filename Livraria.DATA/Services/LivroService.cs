﻿using Livraria.DATA.Repositories;

namespace Livraria.DATA.Services
{
    public class LivroService    
    {        
        public RepositoryLivro oRepositoryLivro { get; set; }

        public LivroService()
        {
            oRepositoryLivro = new RepositoryLivro();
        }
    }
}
