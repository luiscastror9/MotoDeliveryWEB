using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Migrations;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication8.Models
{
    public class RegistrarUsuarioViewModels
    {
        
        public int usuario_id { get; set; }
        public string tipo_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string pais { get; set; }
        public string doc_tipo { get; set; }
        public string num_doc { get; set; }
        public System.DateTime f_nac { get; set; }
        public string calle { get; set; }
        public string altura { get; set; }
        public string dep { get; set; }
        public string email { get; set; }
        public string cp { get; set; }
        public string contrasena { get; set; }
        
    

        

    
    }
}