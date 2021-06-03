using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioTestimonio" en el código y en el archivo de configuración a la vez.
    public class ServicioTestimonio : IServicioTestimonio
    {

        public bool InsertTestimonio(TestimonioBE objTestimonioBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Testimonio objTestimonio = new tb_Testimonio();

                objTestimonio.idUsuario = objTestimonioBE.idUsuario;
                objTestimonio.idPost = objTestimonioBE.idPost;
                objTestimonio.tituloTestimonio = objTestimonioBE.tituloTestimonio;
                objTestimonio.descripcionTestimonio = objTestimonioBE.descripcionTestimonio;

                Chambix.tb_Testimonio.Add(objTestimonio);
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateTestimonio(TestimonioBE objTestimonioBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Testimonio objTestimonio = (from objTest in Chambix.tb_Testimonio
                                           where objTest.idTestimonio == objTestimonioBE.idTestimonio
                                               select objTest).FirstOrDefault();

                objTestimonio.idTestimonio = objTestimonioBE.idTestimonio;
                objTestimonio.idUsuario = objTestimonioBE.idUsuario;
                objTestimonio.idPost = objTestimonioBE.idPost;
                objTestimonio.tituloTestimonio = objTestimonioBE.tituloTestimonio;
                objTestimonio.descripcionTestimonio = objTestimonioBE.descripcionTestimonio;
                objTestimonio.estadoTestimonio = objTestimonioBE.estadoTestimonio;
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteTestimonio(Int32 idTestimonio)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Testimonio objTestimonio = (from objTest in Chambix.tb_Testimonio
                                               where objTest.idTestimonio == idTestimonio
                                               select objTest).FirstOrDefault();

                Chambix.tb_Testimonio.Remove(objTestimonio);
                Chambix.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TestimonioBE> GetAllTestimonio()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<TestimonioBE> objTestimonioList = new List<TestimonioBE>();

                var query = (from objTest in Chambix.tb_Testimonio
                             select objTest);
                foreach (var objTestimonio in query)
                {
                    TestimonioBE objTestimonioBE = new TestimonioBE();

                    objTestimonioBE.idTestimonio = Convert.ToInt32(objTestimonio.idPost);
                    objTestimonioBE.idUsuario = Convert.ToInt32(objTestimonio.idUsuario);
                    objTestimonioBE.idPost = Convert.ToByte(objTestimonio.idPost);
                    objTestimonioBE.tituloTestimonio = objTestimonio.tituloTestimonio;
                    objTestimonioBE.descripcionTestimonio = objTestimonio.descripcionTestimonio;
                    objTestimonioBE.estadoTestimonio = (bool)objTestimonio.estadoTestimonio;
                    objTestimonioBE.create_at = (DateTime)objTestimonio.create_at;
                    if (objTestimonio.update_at != null)
                    {
                        objTestimonioBE.update_at = (DateTime)objTestimonio.update_at;
                    }

                    objTestimonioList.Add(objTestimonioBE);
                }
                return objTestimonioList;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TestimonioBE GetTestimonio(Int32 idTestimonio)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Testimonio objTestimonio = (from objTest in Chambix.tb_Testimonio
                                               where objTest.idTestimonio == idTestimonio
                                               select objTest).FirstOrDefault();

                TestimonioBE objTestimonioBE = new TestimonioBE();

                objTestimonioBE.idTestimonio = Convert.ToInt32(objTestimonio.idPost);
                objTestimonioBE.idUsuario = Convert.ToInt32(objTestimonio.idUsuario);
                objTestimonioBE.idPost = Convert.ToByte(objTestimonio.idPost);
                objTestimonioBE.tituloTestimonio = objTestimonio.tituloTestimonio;
                objTestimonioBE.descripcionTestimonio = objTestimonio.descripcionTestimonio;
                objTestimonioBE.estadoTestimonio = (bool)objTestimonio.estadoTestimonio;
                objTestimonioBE.create_at = (DateTime)objTestimonio.create_at;
                if (objTestimonio.update_at != null)
                {
                    objTestimonioBE.update_at = (DateTime)objTestimonio.update_at;
                }


                return objTestimonioBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
