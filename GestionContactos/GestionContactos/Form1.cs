using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int TAM = 10;
        string[] nombre = new string[TAM];
        string[] telef = new string[TAM];

        bool LeerContacto(string[] nom, string[] tlf)
        {
            string nombre, telefono;
            nombre = telefono = string.Empty;
            bool repe;
            bool result = true;

            nombre = Interaction.InputBox("Introduce el nombre del contacto que desea añadir:");
            repe = ComproNom(nombre, nom);

            if (!repe)
            {
                telefono = Interaction.InputBox("Introduce el número de teléfono del contacto que desea añadir:");
                result = AñadirContacto(nombre, telefono, nom, tlf);
            }
            else
            {
                result = false;
            }

            return result;
        }
        bool AñadirContacto(string nombre, string telefono, string[] nom, string[] tlf)
        {
            int i = 0;
            bool vacia = false;
            while (i < nom.Length && !vacia)
            {
                if (nom[i] == null)
                {
                    nom[i] = nombre;
                    tlf[i] = telefono;
                    vacia = true;
                }
                i++;
            }
            return vacia;
        }
        bool ComproNom(string nom, string[] nombre)
        {
            bool repet = false;

            int i = 0;
            while (!repet && i < nombre.Length)
            {
                if (nom == nombre[i])
                {
                    repet = true;
                }
                i++;
            }
            return repet;
        }
        private void btnAñadirContacto_Click(object sender, EventArgs e)
        {
            bool result;

            result = LeerContacto(nombre, telef);

            if (result)
            {
                MessageBox.Show("Se ha añadido el contacto.");
            }
            else
            {
                MessageBox.Show("No se ha podido añadir el contacto porque el contacto ya existe o no hay más huecos en los contactos.");
            }
        }

        void ElimContacto(string[] telef, string[] vecNombre, string nom)
        {
            int cont = 0;
            bool encontrado = false;

            while (cont < vecNombre.Length && !encontrado)
            {
                if (nom == vecNombre[cont])
                {
                    vecNombre[cont] = null;
                    telef[cont] = null;
                    encontrado = true;

                    MessageBox.Show("El contacto ha sido eliminado con éxito.");
                }

                cont++;
            }

            if (!encontrado)
            {
                MessageBox.Show("El contacto no se encuentra en la agenda.");
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            string nom = Interaction.InputBox("Introduce el nombre del contacto que desea eliminar:");

            ElimContacto(telef, nombre, nom);
        }

        void modificarContacto(string[] vecNombre, string[] telefono, string nom)
        {
            int cont = 0;
            bool encontrado = false;

            while (cont < vecNombre.Length && !encontrado)
            {
                if (nom == vecNombre[cont])
                {
                    telef[cont] = Interaction.InputBox("Introduce un nuevo teléfono para el contacto:");                    
                    encontrado = true;
                    MessageBox.Show("El contacto ha sido modificado con éxito.");
                }
                cont++;
            }
            if (!encontrado)
            {
                MessageBox.Show("El contacto no se encuentra en la agenda.");
            }
        }
        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            string nom = Interaction.InputBox("Introduce el nombre del contacto del cual desea modificar el teléfono:");
            modificarContacto(nombre, telef, nom);
        }
    }
}
