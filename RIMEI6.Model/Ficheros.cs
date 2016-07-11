using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIMEI6.Model
{
    public class Ficheros
    {
        public Queue files { get; set; }

        public Ficheros()
        {
            files = new Queue();
        }

        public bool leeFicheros()
        {
            // Esta función se ejecuta después de que el usuario haga click en el botón de sele-
            // ccionar ficheros a leer. La función se encarga de crear la cola de archivos a leer
            // y de preparar el contexto para la ejecución de la lectura en segundo plano.
            var dialogDirectory = new FolderBrowserDialog();
            dialogDirectory.Description = "Selecciona el directorio de análisis";
            dialogDirectory.ShowNewFolderButton = false;
            DialogResult resultDir = dialogDirectory.ShowDialog();
            if (dialogDirectory.SelectedPath != "")
            {
                string pathDir = dialogDirectory.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(pathDir);
                // Se introduce en la pila los nombres de todos los ficheros que cumplan
                // los requisitos aquí mostrados.
                foreach (var fi in di.GetFiles())
                {
                    if ((fi.Extension == ".csv") || (fi.Extension == ".txt"))
                        files.Enqueue(fi.FullName);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Dispose()
        {
            files.Clear();
        } 
    }
}
