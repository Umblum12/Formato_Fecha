Console.WriteLine("Introduzca la fecha con el Formato dd/mm/aaaa: ");
string fecha = Console.ReadLine();

string[] fechapartida = fecha.Split('/');

int dia = Convert.ToInt32(fechapartida[0]);
int mes = Convert.ToInt32(fechapartida[1]);
int año = Convert.ToInt32(fechapartida[2]);

string mestexto = "";
switch (mes)
{
    case 1:
        mestexto = "Enero";
        break;
    case 2:
        mestexto = "Febrero";
        break;
    case 3:
        mestexto = "Marzo";
        break;
    case 4:
        mestexto = "Abril";
        break;
    case 5:
        mestexto = "Mayo";
        break;
    case 6:
        mestexto = "Junio";
        break;
    case 7:
        mestexto = "Julio";
        break;
    case 8:
        mestexto = "Agosto";
        break;
    case 9:
        mestexto = "Septiembre";
        break;
    case 10:
        mestexto = "Octubre";
        break;
    case 11:
        mestexto = "Noviembre";
        break;
    case 12:
        mestexto = "Diciembre";
        break;
    default:
        break;
}
Console.WriteLine($"{dia} de {mestexto} de {año}");
Console.ReadKey();