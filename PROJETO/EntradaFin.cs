using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PROJETO
{
    internal class EntradaFin 
    { 
        private int _id;
        private string _valor;
        private string _data;
        private string _descricao;
        private string _tipo;    

    public EntradaFin(string valor, string data, string descricao, string tipo)
    {
        _valor = valor;
        _data = data;
        _descricao = descricao;
        _tipo = tipo;
    }

    public EntradaFin(int id, string valor, string data, string descricao, string tipo) : this(valor, data, descricao, tipo)
    {
        _id = id;
    }
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Valor
    {
        get { return _valor; }
        set { _valor = value; }
    }
    public string Data
    {
        get { return _data; }
        set { _data = value; }
    }
    public string Descricao
    {
        get { return _descricao; }
        set { _descricao = value; }
    }
    public string Tipo
    {
        get { return _tipo; }
        set { _tipo = value; }
    }
}
}
