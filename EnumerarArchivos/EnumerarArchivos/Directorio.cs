﻿// ==++==

using System.Collections.Generic;
using System.IO;

namespace EnumerarArchivos
{
    class Directorio
    {
        public DirectoryInfo EsteDirectorio { get; private set; }

        private IEnumerable<FileInfo> archivos;


        public string Nombre
        {
            get
            {
                return EsteDirectorio.Name;
            }
        }

        public string Ubicacion
        {
            get
            {
                return EsteDirectorio.FullName;
            }
        }

        /// <summary>
        /// Para adherir a las buenas prácticas, el constructor
        /// no inicializa (como es habitual) la propiedad Archivos
        /// ya que ésta operación puede ser costosa en recursos
        /// </summary>
        /// <param name="esteDirectorio"></param>
        public Directorio(DirectoryInfo esteDirectorio)
        {
            EsteDirectorio = esteDirectorio;
        }
        /// <summary>
        /// Esta propiedad es una colección de todos los archivos 
        /// que están contenidos en el directorio
        /// Ojo: No son todos los archivos contenidos en todos
        /// los sub-directorios de este directorio, sino solo 
        /// los que están contenidos directamente en este directorio
        /// Esta propiedad se llena cuando es consultada por primera vez
        /// </summary>
        public IEnumerable<FileInfo> Archivos
        {
            get
            {
                if (archivos == null)
                {
                    archivos = EsteDirectorio.GetFiles("*.*", SearchOption.TopDirectoryOnly);

                }
                return archivos;
            }


        }

    }
}