int menu;
int[] preciosEntradas = {0,15000,30000 ,10000, 40000};
do{
Console.WriteLine("i. Nueva Inscripción");
Console.WriteLine("ii. Obtener Estadísticas del Evento");
Console.WriteLine("iii. Buscar cliente");
Console.WriteLine("iv. Cambiar entrada de un Cliente");
Console.WriteLine("v. Salir");
menu = Funciones.IngresarEnteroEnRango("Ingresa una opcion entre 1 y 5 ",1,5 );
switch(menu)
{
case 1:
{
    Clientes unCliente = cargarPersona();
    
    Ticketera.AgregarCliente(unCliente);

    break;
}
case 2:
{
ObtenerEstadisticas();
    break;
}
case 3:
{
    int id = Funciones.IngresarEntero("Ingrese el id que quiera buscar ");
    Ticketera.buscarCliente(id);
    break;
}
case 4:
{
    int idCambiarEntrada = Funciones.IngresarEntero("Ingrese su id ");
 int N_E = Funciones.IngresarEntero("ingrese nuevo tipo de entrada ");
 Ticketera.CambiarEntrada(idCambiarEntrada,N_E,0);
    break;
}
}
}while(menu!= 5);
Clientes cargarPersona(){
string nom = Funciones.IngresarTexto("Ingrese Nombre ");
int dni = Funciones.IngresarEntero("Ingrese su dni ");
string apell= Funciones.IngresarTexto("Ingrese apellido ");
DateTime F_I = DateTime.Now;
int T_E = Funciones.IngresarEntero("ingrese tipo de entrada ");
int T_A = preciosEntradas[T_E];

Clientes UnaPersona = new Clientes(nom,dni,apell,F_I,T_E,T_A);
return UnaPersona;
}
void ObtenerEstadisticas()
{
    foreach (string item in Ticketera.EstadisticasTicketera())
    {
        Console.WriteLine(item);
    }
}
