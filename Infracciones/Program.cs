using System;
using System.IO;

namespace Infracciones
{
    class Program
    {
       
        static void Main(string[] args)
        {
        voy:
            Console.Clear();

            Console.WriteLine("Bienvenido al programa de registro de infracciones");
            Console.WriteLine("1-Agregar una infraccion");
            Console.WriteLine("2-Pgar una infraccion");
            Console.WriteLine("3-Exportar Caso");
            Console.WriteLine("4-Salir");

            Console.WriteLine("Elija la Opcion deseada:  ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                
                
                case "1":

                    try
                    {
                        Console.Clear();
                        error infra = new error();
                        Console.WriteLine("Vamos a agregar");
                        Console.WriteLine("..........................................");


                        Console.WriteLine("Digite el id");
                        infra.Id = Convert.ToInt32(Console.ReadLine());

                        //Primer parametro
                        Console.WriteLine(" Digite la cedula del imprudente ");
                        infra.Cedula = Console.ReadLine();


                        //segundo  parametro
                        Console.WriteLine(" Digite el Nombre del imprudente ");
                        infra.Nombre = Console.ReadLine();



                        //tercer parametro
                        Console.WriteLine(" Digite el Apellido del imprudente ");
                        infra.Apellido = Console.ReadLine();



                        //cuarto parametro
                        Console.WriteLine(" Digite la Placa del imprudente ");
                        infra.Placa = Console.ReadLine();



                    //quinto  parametro
                    Console.WriteLine(" Digite la Marca del imprudente ");
                    infra.Marca = Console.ReadLine();



                    //sexto parametro
                    Console.WriteLine(" Digite la laptitud del imprudente ");
                    infra.Latitud = Console.ReadLine();


                    //octavo parametro
                    Console.WriteLine(" Digite la longitud del imprudente ");
                    infra.Longitud = Console.ReadLine();

                    //noveno parametro
                    Console.WriteLine(" Digite la Descripcion del imprudente ");
                        infra.Descripcion = Console.ReadLine();

                        infra.pagado = false;

                        using (MultaContex mul = new MultaContex())
                        {
                            mul.Add(infra);
                            mul.SaveChanges();
                        Console.WriteLine("Guardado correctamente");
                        Console.ReadKey();
                    }
                       

                   }
                    catch (Exception x)
                    {

                       Console.WriteLine(x.Message);
                        Console.ReadKey();
                    }

                    
                    
                    goto voy;
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Vamos a pagar ladronaso");
                    Console.WriteLine("..........................................");

                    try
                    {
                        using (MultaContex mul = new MultaContex())
                        {
                            var multa = mul.datos;
                            foreach (error lista in multa)
                            {
                                Console.WriteLine("Id: " + lista.Id);
                                Console.WriteLine("Nombre: " + lista.Nombre + " " + lista.Apellido);
                                Console.WriteLine("Cedula: " + lista.Cedula);
                                Console.WriteLine("Marca: " + lista.Marca);
                                Console.WriteLine("Placa: " + lista.Placa);
                                Console.WriteLine("Descripcion: " + lista.Descripcion);
                                Console.WriteLine("Pagado: " + lista.pagado);
                                Console.WriteLine("..................................");

                            }
                        }
                    }
                    catch (Exception x)
                    {

                        Console.WriteLine(x.Message);
                    }

                    try
                    {
                        error m = new error();
                        Console.WriteLine("Digite el id que quiere editar");
                         m.Id = Convert.ToInt32(Console.ReadLine());

                        using (MultaContex mul = new MultaContex())
                        {
                            var multas = mul.datos.Find(m.Id);
                            multas.pagado = true;

                            mul.SaveChanges();
                            Console.WriteLine("Cambio realizado");
                            Console.ReadKey();


                            string ruta = "C:\\Personas";
                            if (Directory.Exists(ruta) == false)
                            {
                                Directory.CreateDirectory(ruta);

                            }

                            string contenido = "<html>" +
                                "<body>" +
                                "" +
                                "<h1> Factura </h1>" +
                                "<p> Id: </p>" + multas.Id +
                                "<p>Nombre:  </p>" + multas.Nombre + m.Apellido +
                                "<p>Marca:  </p>" + multas.Marca +
                                "<p> Cedula: </p>" + multas.Cedula +
                                "<p>  Paga:  </p>" + multas.pagado +
                                "<p> Placa:   </p>" + multas.Placa +
                                "" +
                                "</body>" +
                                "</html>";
                            File.WriteAllText("C:\\Personas\\" + multas.Nombre + ".html", contenido);
                            Console.WriteLine("Exportando........... Enter para continuar");
                            Console.ReadKey();
                            Console.WriteLine("Exportado :)");
                            Console.ReadKey();





                            goto voy;
                        }



                    }
                    catch (Exception x )
                    {

                        Console.WriteLine(x.Message);
                    }
                    


                 
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Vamos a exportar el caso");



                    try
                    {
                        using (MultaContex mul = new MultaContex())
                        {
                            var multa = mul.datos;
                            foreach (error lista in multa)
                            {
                                Console.WriteLine("Id: " + lista.Id);
                                Console.WriteLine("Nombre: " + lista.Nombre + " " + lista.Apellido);
                                Console.WriteLine("Cedula: " + lista.Cedula);
                                Console.WriteLine("Marca: " + lista.Marca);
                                Console.WriteLine("Placa: " + lista.Placa);
                                Console.WriteLine("Descripcion: " + lista.Descripcion);
                                Console.WriteLine("Pagado: " + lista.pagado);
                                Console.WriteLine("..................................");

                            }
                        }
                    }
                    catch (Exception x)
                    {

                        Console.WriteLine(x.Message);
                    }

                    try
                    {
                        error m = new error();
                        Console.WriteLine("Digite el id que quiere Exportar");
                        m.Id = Convert.ToInt32(Console.ReadLine());

                        using (MultaContex mul = new MultaContex())
                        {
                            var multas = mul.datos.Find(m.Id);
                            string ruta = "C:\\Personas";
                            if (Directory.Exists(ruta)==false)
                            {
                                Directory.CreateDirectory(ruta);

                            }

                            string contenido = "<html>" +
                                "<body>" +
                                "" +
                                "<h1> Factura </h1>" +
                                "<p> Id: </p>" +multas.Id+
                                "<p>Nombre:  </p>"+multas.Nombre+m.Apellido+
                                "<p>Marca:  </p>" +multas.Marca +
                                "<p> Cedula: </p>" +multas.Cedula +
                                "<p>  Paga:  </p>" +multas.pagado+
                                "<p> Placa:   </p>" +multas.Placa+
                                "" +
                                "</body>"+
                                "</html>";
                            File.WriteAllText("C:\\Personas\\" + multas.Nombre + ".html", contenido);
                            Console.WriteLine("Exportando........... Enter para continuar");
                            Console.ReadKey();
                            Console.WriteLine("Exportado :)");
                            Console.ReadKey();
                            goto voy;

                        }

                       
                    }
                    catch (Exception x)
                    {

                        Console.WriteLine(x.Message);
                    }


                    Console.ReadKey();
                    goto voy;
                    break;

                case "4": Console.ReadKey();
                    Console.Clear();
                  
                    break;
                default: goto voy; break;
            }

        }


     
    }
}
