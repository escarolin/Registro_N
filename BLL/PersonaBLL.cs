using System;
using System.Linq;
using System.Linq.Expressions;
using Registro_N.DAL;
using System.Collections.Generic;
using Registro_N.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Registro_N.BLL{
    public class PersonaBLL
    {
       public static bool Guardar (Persona persona)
       {
           if(!Existe(persona.ID))
           return Insetar(persona);
           else{
           return Modificar(persona);
           } 
        
       }

         private static bool Insetar(Persona persona)
         {
             bool paso=false;
             Contexto contexto=new Contexto();
             try
             {
                 //agregar la entidad que decea insertar en el contexto
                 contexto.Persona.Add(persona);
                 paso=contexto.SaveChanges() >0;

             }
             catch (Exception)
             {
                 throw;

             }
             finally
             {
                 contexto.Dispose();
             }
             return paso;
             
         }
         private static bool Modificar(Persona persona)
         {
             bool paso = false; 
             Contexto contexto = new Contexto();
             try 
             {
                 //marcar la intidad como modificada para que el contexto sepa proceder
                 contexto.Persona.Add(persona);
                 paso=contexto.SaveChanges()>0;

             }
             catch (Exception)
             {
                 throw;
             }
             finally
             {
                 contexto.Dispose();
             }
             return paso;
         }
         public static bool Eliminar(int id)
         {
        bool paso= false;
        Contexto contexto = new Contexto();
        try{
             //buscar la entidad que se desea eliminar
             var persona=contexto.Persona.Find(id);
             if(persona!=null)
             {
                 contexto.Persona.Remove(persona); //remover la entidad
                 paso=contexto.SaveChanges()>0;

             }
             
             }
             catch (Exception)
             {
                 throw;
             }
             finally
             {
                 contexto.Dispose();
             }
             return paso;
         }
         public static Persona Buscar(int id)
         {
           Contexto contexto= new Contexto();
           Persona persona;
           try
           {
               persona=contexto.Persona.Find(id);

           }
           catch (Exception)
             {
                 throw;
             }
             finally
             {
                 contexto.Dispose();
             }
             return persona;

         }


    public static bool Existe (int id ){
   Contexto contexto =new Contexto();
   bool encontrado= false;
   try {
       encontrado=contexto.Persona.Any(e=> e.ID==id);
   }
   catch(Exception)
   {
       throw;
   }
    finally
    {
        contexto.Dispose();

    }
 return encontrado;

    }

   
      


    }

  
}
