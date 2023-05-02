using System.Collections.Generic;
class Ticketera{

static private Dictionary<int,Clientes> DicClientes = new Dictionary<int,Clientes>();
static private int UltimoIDEntrada = 1;
const int VALORENTRADA1 = 15000;
const int VALORENTRADA2 = 30000;
const int VALORENTRADA3 = 10000;
const int VALORENTRADA4 = 40000;

static public int DevolverUltimoID()
{

UltimoIDEntrada = UltimoIDEntrada + 1;
return UltimoIDEntrada;
}

static public int AgregarCliente(Clientes Uncliente)
{
DicClientes.Add(UltimoIDEntrada,Uncliente);
return UltimoIDEntrada;
}
static public Clientes buscarCliente(int idPedido){
bool existe = DicClientes.ContainsKey(idPedido);
if(existe)
{
    Console.WriteLine("Nombre: "+DicClientes[idPedido].Nombre);
    Console.WriteLine("dni: " + DicClientes[idPedido].DNI);
    Console.WriteLine("Apellido: " + DicClientes[idPedido].Apellido);
    Console.WriteLine("Fecha Inscripcion: " + DicClientes[idPedido].FechaInscripcion);
    Console.WriteLine("Tipo entrada: " + DicClientes[idPedido].TipoEntrada);
    Console.WriteLine("Total abonado " + DicClientes[idPedido].TotalAbonado);
return DicClientes[idPedido];
}
return null;
}
static public bool CambiarEntrada(int idPedido,int nuevaEntrada,int total)
{
    int precioNuevaEntrada = 0;
    switch (nuevaEntrada)
    {
      case 1: 
    {
        precioNuevaEntrada = VALORENTRADA1;
      break;
    }
      case 2: 
        precioNuevaEntrada = VALORENTRADA2;
    {
      break;
    }
      case 3: 
      precioNuevaEntrada = VALORENTRADA3;
    {
      break;
    }
      case 4: 
      precioNuevaEntrada = VALORENTRADA4;
    {  
      break;
    }
    }
if (DicClientes[idPedido].TotalAbonado < precioNuevaEntrada)
{
DicClientes[idPedido].TipoEntrada = nuevaEntrada;
DicClientes[idPedido].TotalAbonado = precioNuevaEntrada;
DicClientes[idPedido].FechaInscripcion = DateTime.Now;
return true;
} else
{ 
  Console.WriteLine("No se pudo realizar el cambio.");
return false;
}
}
static public List<string> EstadisticasTicketera()
{
List<string> listaString = new List<string>();
listaString.Add(DicClientes.Count.ToString());
int total1 = 0;
int total2 = 0;
int total3 = 0;
int total4 = 0;
foreach (Clientes Dic in DicClientes.Values)
{ 
  switch(Dic.TipoEntrada){
    case 1:{
        total1++;
        break;
    }
    case 2:
    {
        total2++;
        break;
    }
    case 3:{
        total3++;
        break;
    }
    case 4:{
        total4++;
        break;
    }
}
    
}
double porcentaje1 = 0;
double porcentaje2 = 0;
double porcentaje3 = 0;
double porcentaje4 = 0;
double recaudacionTotal =0;
int totalEntradas = DicClientes.Count;
Console.WriteLine(total1);
if(total1 != 0)
{
porcentaje1 = total1 * 100 / totalEntradas;
}
if(total1 != 0)
{
porcentaje2 = total2 * 100 / totalEntradas;
}
if(total3 != 0)
{
porcentaje3 = total3 * 100 / totalEntradas;
}
if(total4 != 0)
{
porcentaje4 = total4 * 100 / totalEntradas;
}

listaString.Add(porcentaje1.ToString() + "% es el porcentaje del tipo de entrada 1");
listaString.Add(porcentaje2.ToString() + "% es el porcentaje del tipo de entrada 2");
listaString.Add(porcentaje3.ToString() + "% es el porcentaje del tipo de entrada 3");
listaString.Add(porcentaje4.ToString() + "% es el porcentaje del tipo de entrada 4");

int recaudacion1 = total1 * VALORENTRADA1;
int recaudacion2 = total2 * VALORENTRADA2;
int recaudacion3 = total3 * VALORENTRADA3;
int recaudacion4 = total4 * VALORENTRADA4;
listaString.Add(recaudacion1.ToString() + " Es recaudacion del tipo 1");
listaString.Add(recaudacion2.ToString() + " Es recaudacion del tipo 2");
listaString.Add(recaudacion3.ToString() + " Es recaudacion del tipo 3");
listaString.Add(recaudacion4.ToString() + " Es recaudacion del tipo 4");
recaudacionTotal = recaudacion1 +  recaudacion2+ recaudacion3+ recaudacion4;
listaString.Add(recaudacionTotal.ToString() + " Es la recaudacion total");
return listaString;
}
}





