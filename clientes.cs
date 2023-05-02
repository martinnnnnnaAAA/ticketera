using System;
public class Clientes
{
    public string Nombre{get;set;}
    public int DNI {get;private set;}
     public string Apellido {get;set;}
    public DateTime FechaInscripcion{get;set;}
    public int TipoEntrada{get;set;}
    public int TotalAbonado{get;set;}


public Clientes(string nom, int dni,string apell, DateTime F_I,int T_E,int T_A)
    {
        Nombre = nom;
        DNI = dni;
       Apellido = apell;
       FechaInscripcion=F_I;
       TipoEntrada=T_E;
       TotalAbonado = T_A;
    }
}