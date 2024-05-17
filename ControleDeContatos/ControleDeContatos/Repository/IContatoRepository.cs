﻿using ControleDeContatos.Models;

namespace ControleDeContatos.Repository
{
    public interface IContatoRepository
    {   
        List<ContatoModel> listAll();
        ContatoModel Adicionar(ContatoModel contato);
    }
}