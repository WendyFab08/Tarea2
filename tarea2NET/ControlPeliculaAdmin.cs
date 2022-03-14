using tarea2NET;
namespace tarea2NET
{
    class ControlPeliculaAdmin
    {
        private List<Pelicula> _peliculas;

        public ControlPeliculaAdmin()
        {
            _peliculas = new List<Pelicula>();
        }

        public void showMenuPrincipal()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al Sistema de Control de Peliculas");
                Console.WriteLine("Recuerda que la clasificacion esta por interes");
                Console.WriteLine("poco, medio, alto");
                Console.WriteLine("1.- Poco");
                Console.WriteLine("2.- Medio");
                Console.WriteLine("3.- Alto");
                Console.WriteLine("4.- Salir");
            } while (!validaMenu(4, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {

                case 1:
                    showMenuPoco();
                    break;
                case 2:
                    showMenuMedio();
                    break;
                case 3:
                    showMenuAlto();
                    break;
                case 4: break;
            }
        }

        //POCO
        private void showMenuPoco()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Administración de Peliculas por Poco Interes");
                Console.WriteLine("1.- Listar");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar...");
            } while (!validaMenu(5, ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada)
            {

                case 1:
                    listarPpoco();
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuPoco();
                    break;
                case 2:
                    crearPpelicula();
                    break;
                case 3:
                    editarPpelicula();
                    break;
                case 4:
                    eliminarPpelicula();
                    break;
                case 5:
                    showMenuPrincipal();
                    break;
            }
        }
        private void listarPpoco()
        {
            Console.WriteLine("Lista de Peliculas de Poco Interes");
            foreach (Pelicula item in _peliculas)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private void eliminarPpelicula()
        {
            string? titulo;
            listarPpoco();
            titulo = pedirValorString("Escribe el Titulo de la Pelicula a Eliminar");
            Pelicula? pelicula = _peliculas.FirstOrDefault(e => e.titulo == titulo);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                _peliculas.Remove(pelicula);
                Console.WriteLine($"La Pelicula de Titulo: {pelicula.titulo} se eliminó correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            showMenuPoco();
        }
        private void editarPpelicula()
        {
            string? titulo;
            string? genero;
            string? nacionalidad;
            string? aEstreno;
            Console.WriteLine("Editar de Pelicula");
            listarPpoco();
            matricula = pedirValorString("Titulo de la Pelicula a Editar");
            Pelicula? pelicula = _peliculas.FirstOrDefault(e => e.titulo == titulo);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                genero = pedirValorString("Genero");
                nacionalidad = pedirValorString("Nacionalidad");
                aEstreno = pedirValorString("Año de Estreno");
                pelicula.genero = genero;
                pelicula.nacionalidad = nacionalidad;
                pelicula.aEstreno = aEstreno;
                Console.WriteLine($"La pelicula de Titulo: {pelicula.titulo} se editó correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            showMenuPoco();
        }
        private void crearPpelicula()
        {
            string? titulo;
            string? genero;
            string? nacionalidad;
            string? aEstreno;
            Console.WriteLine("Alta de Pelicula");
            titulo = pedirValorString("Titulo");
            genero = pedirValorString("Genero");
            nacionalidad = pedirValorString("Nacionalidad");
            aEstreno = pedirValorString("Año de estreno");
            Console.Clear();
            listarPpoco();
            matricula = pedirValorString("Titulo de la Pelicula a Editar");
            Pelicula? pelicula = _peliculas.FirstOrDefault(e => e.titulo == titulo);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                Pelicula nuevaPelicula = new Pelicula(Pelicula.Pelicula(titulo, genero, nacionalidad, aEstreno));
                _estudiantes.Add(nuevoEstudiante);
                Console.WriteLine($"Pelicula registrada correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            showMenuPoco();
        }

        //MEDIO
        private void showMenuMedio()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Administración de Peliculas por Medio Interes");
                Console.WriteLine("1.- Listar");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar...");
            } while (!validaMenu(5, ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada)
            {

                case 1:
                    listarPmedio();
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuMedio();
                    break;
                case 2:
                    crearMpelicula();
                    break;
                case 3:
                    editarMpelicula();
                    break;
                case 4:
                    eliminarMpelicula();
                    break;
                case 5:
                    showMenuPrincipal();
                    break;
            }
        }
        private void listarPmedio()
        {
            Console.WriteLine("Lista de Peliculas de Medio Interes");
            foreach (Pelicula item in _peliculas)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private void eliminarMpelicula()
        {
            string? titulo;
            listarPmedio();
            titulo = pedirValorString("Escribe el Titulo de la Pelicula a Eliminar");
            Pelicula? pelicula = _peliculas.FirstOrDefault(e => e.titulo == titulo);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                _peliculas.Remove(pelicula);
                Console.WriteLine($"La Pelicula de Titulo: {pelicula.titulo} se eliminó correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            showMenuMedio();
        }
        private void editarMpelicula()
        {
            string? titulo;
            string? genero;
            string? nacionalidad;
            string? aEstreno;
            Console.WriteLine("Editar de Pelicula");
            listarPmedio();
            matricula = pedirValorString("Titulo de la Pelicula a Editar");
            Pelicula? pelicula = _peliculas.FirstOrDefault(e => e.titulo == titulo);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró el Pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                genero = pedirValorString("Genero");
                nacionalidad = pedirValorString("Nacionalidad");
                aEstreno = pedirValorString("Año de Estreno");
                pelicula.genero = genero;
                pelicula.nacionalidad = nacionalidad;
                pelicula.aEstreno = aEstreno;
                Console.WriteLine($"La pelicula de Titulo: {pelicula.titulo} se editó correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            showMenuMedio();
        }
        private void crearMpelicula()
        {
            string? titulo;
            string? genero;
            string? nacionalidad;
            string? aEstreno;
            Console.WriteLine("Alta de Pelicula");
            titulo = pedirValorString("Titulo");
            genero = pedirValorString("Genero");
            nacionalidad = pedirValorString("Nacionalidad");
            aEstreno = pedirValorString("Año de estreno");
            Console.Clear();
            listarPmedio();
            matricula = pedirValorString("Titulo de la Pelicula a Editar");
            Pelicula? pelicula = _peliculas.FirstOrDefault(e => e.titulo == titulo);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                Pelicula nuevaPelicula = new Pelicula(Pelicula.Pelicula(titulo, genero, nacionalidad, aEstreno));
                _estudiantes.Add(nuevoEstudiante);
                Console.WriteLine($"Pelicula registrada correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            showMenuMedio();
        }
        //ALTO
        private void showMenuAlto()
        {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Administración de Peliculas por Alto Interes");
                Console.WriteLine("1.- Listar");
                Console.WriteLine("2.- Crear");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar...");
            } while (!validaMenu(5, ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada)
            {

                case 1:
                    listarPalto();
                    Console.WriteLine("Presiona 'Enter' para continuar...");
                    Console.ReadLine();
                    showMenuAlto();
                    break;
                case 2:
                    crearApelicula();
                    break;
                case 3:
                    editarApelicula();
                    break;
                case 4:
                    eliminarApelicula();
                    break;
                case 5:
                    showMenuPrincipal();
                    break;
            }
        }
        private void listarPalto()
        {
            Console.WriteLine("Lista de Peliculas de Alto Interes");
            foreach (Pelicula item in _peliculas)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private void eliminarApelicula()
        {
            string? titulo;
            listarPalto();
            titulo = pedirValorString("Escribe el Titulo de la Pelicula a Eliminar");
            Pelicula? pelicula = _peliculas.FirstOrDefault(e => e.titulo == titulo);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                _peliculas.Remove(pelicula);
                Console.WriteLine($"La Pelicula de Titulo: {pelicula.titulo} se eliminó correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            showMenuAlto();
        }
        private void editarMpelicula()
        {
            string? titulo;
            string? genero;
            string? nacionalidad;
            string? aEstreno;
            Console.WriteLine("Editar de Pelicula");
            listarPalto();
            matricula = pedirValorString("Titulo de la Pelicula a Editar");
            Pelicula? pelicula = _peliculas.FirstOrDefault(e => e.titulo == titulo);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                genero = pedirValorString("Genero");
                nacionalidad = pedirValorString("Nacionalidad");
                aEstreno = pedirValorString("Año de Estreno");
                pelicula.genero = genero;
                pelicula.nacionalidad = nacionalidad;
                pelicula.aEstreno = aEstreno;
                Console.WriteLine($"La pelicula de Titulo: {pelicula.titulo} se editó correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            showMenuAlto();
        }
        private void crearMpelicula()
        {
            string? titulo;
            string? genero;
            string? nacionalidad;
            string? aEstreno;
            Console.WriteLine("Alta de Pelicula");
            titulo = pedirValorString("Titulo");
            genero = pedirValorString("Genero");
            nacionalidad = pedirValorString("Nacionalidad");
            aEstreno = pedirValorString("Año de estreno");
            Console.Clear();
            listarPalto();
            matricula = pedirValorString("Titulo de la Pelicula a Editar");
            Pelicula? pelicula = _peliculas.FirstOrDefault(e => e.titulo == titulo);
            if (pelicula == null)
            {
                Console.WriteLine("No se encontró la Pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                Pelicula nuevaPelicula = new Pelicula(Pelicula.Pelicula(titulo, genero, nacionalidad, aEstreno));
                _estudiantes.Add(nuevoEstudiante);
                Console.WriteLine($"Pelicula registrada correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            showMenuAlto();
        }



        // FINAL
        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción Invalida.");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es válido, debes ingresar un número.");
                return false;
            }
        }
        private string pedirValorString(string texto)
        {
            string? valor;
            do
            {
                Console.Write($"{texto}: ");
                valor = Console.ReadLine();
                if (valor == null || valor == "")
                {
                    Console.WriteLine("Valor inválido.");
                }
            } while (valor == null || valor == "");
            return valor;
        }


        //Inicializar 
        public void inicializarDatos()
        {
            Pelicula pelicula1 = new Pelicula("Alicia en el Pais de las Maravillas", "Ficcion", "Estadounidense", "2008");
            Pelicula pelicula2 = new Pelicula("Macario", "Regional Mexicano", "Mexicana", "1945");
        }

    }
}