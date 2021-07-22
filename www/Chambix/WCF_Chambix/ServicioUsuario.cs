using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuario : IServicioUsuario
    {
        public Boolean InsertUser(String nombreUsuario, String apellidoUsuario, String contrasenaUsuario,Int16 idDistrito,String emailUsuario, String cellUsuario, String wspUsuario ,String ocupacionUsuario)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();


            try
            {
                tb_Usuario objUser = new tb_Usuario();
                objUser.nombreUsuario = nombreUsuario;
                objUser.apellidoUsuario = apellidoUsuario;
                objUser.contrasenaUsuario = contrasenaUsuario;
                objUser.idDistrito = Convert.ToByte(idDistrito);
                objUser.emailUsuario = emailUsuario;
                objUser.cellUsuario = cellUsuario;
                objUser.wspUsuario = wspUsuario;
                objUser.ocupacionUsuario = ocupacionUsuario;

                Chambix.tb_Usuario.Add(objUser);
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean UpdateUser(Int16 idUsuario,String nombreUsuario,String apellidoUsuario,String contrasenaUsuario,Int16 idDistrito,String emailUsuario,String cellUsuario,String wspUsuario,String ocupacionUsuario)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Usuario objUser = (from objUsr in Chambix.tb_Usuario
                                      where objUsr.idUsuario == idUsuario
                                      select objUsr).FirstOrDefault();

                objUser.idUsuario = idUsuario;
                objUser.nombreUsuario = nombreUsuario;
                objUser.apellidoUsuario = apellidoUsuario;
                objUser.contrasenaUsuario = contrasenaUsuario;
                objUser.idDistrito = Convert.ToByte(idDistrito);
                objUser.emailUsuario = emailUsuario;
                objUser.cellUsuario = cellUsuario;
                objUser.wspUsuario = wspUsuario;
                objUser.ocupacionUsuario = ocupacionUsuario;

                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Boolean LogicDeleteUser(UserBE objUserBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Usuario objUser = (from objUsr in Chambix.tb_Usuario
                                      where objUsr.idUsuario == objUserBE.idUsuario
                                      select objUsr).FirstOrDefault();
                objUser.estadoUsuario = false;
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UserBE GetUser(Int16 idUser)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Usuario objUser = (from objUsr in Chambix.tb_Usuario
                                      where objUsr.idUsuario == idUser
                                      && objUsr.estadoUsuario == true
                                      select objUsr).FirstOrDefault();
                UserBE objUserBE = new UserBE();
                objUserBE.idUsuario = Convert.ToInt16(objUser.idUsuario);
                objUserBE.tipoUsuario = Convert.ToInt16(objUser.tipoUsuario);
                objUserBE.estadoUsuario = Convert.ToInt16(objUser.estadoUsuario);
                objUserBE.nombreUsuario = objUser.nombreUsuario;
                objUserBE.apellidoUsuario = objUser.apellidoUsuario;
                objUserBE.contrasenaUsuario = objUser.contrasenaUsuario;
                objUserBE.idDistrito = Convert.ToInt16(objUser.idDistrito);
                objUserBE.emailUsuario = objUser.emailUsuario;
                objUserBE.cellUsuario = objUser.cellUsuario;
                objUserBE.rankUsuario = Convert.ToInt16(objUser.rankUsuario);
                objUserBE.wspUsuario = objUser.wspUsuario;
                objUserBE.ocupacionUsuario = objUser.ocupacionUsuario;
                objUserBE.idTipoCuenta = objUser.idTipoCuenta;
                objUserBE.tiempoCuenta = Convert.ToDateTime(objUser.tiempoCuenta);
                objUserBE.create_at = (DateTime)objUser.create_at;
                return objUserBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<UserBE> GetAllUsers()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<UserBE> objUserLists = new List<UserBE>();
                var query = (from objUsr in Chambix.tb_Usuario
                             where objUsr.estadoUsuario == true
                             select objUsr);
                foreach (var objUser in query)
                {
                    UserBE objUserBE = new UserBE();
                    objUserBE.idUsuario = Convert.ToInt16(objUser.idUsuario);
                    objUserBE.tipoUsuario = Convert.ToInt16(objUser.tipoUsuario);
                    objUserBE.estadoUsuario = Convert.ToInt16(objUser.estadoUsuario);
                    objUserBE.nombreUsuario = objUser.nombreUsuario;
                    objUserBE.apellidoUsuario = objUser.apellidoUsuario;
                    objUserBE.contrasenaUsuario = objUser.contrasenaUsuario;
                    objUserBE.idDistrito = Convert.ToInt16(objUser.idDistrito);
                    objUserBE.emailUsuario = objUser.emailUsuario;
                    objUserBE.cellUsuario = objUser.cellUsuario;
                    objUserBE.rankUsuario = Convert.ToInt16(objUser.rankUsuario);
                    objUserBE.wspUsuario = objUser.wspUsuario;
                    objUserBE.ocupacionUsuario = objUser.ocupacionUsuario;
                    objUserBE.idTipoCuenta = objUser.idTipoCuenta;
                    objUserBE.tiempoCuenta = Convert.ToDateTime(objUser.tiempoCuenta);
                    objUserBE.create_at = (DateTime)objUser.create_at;
                    objUserLists.Add(objUserBE);
                }
                return objUserLists;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UserBE> GetAllUsersPostulantes(Int16 idPost)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<UserBE> objUserLists = new List<UserBE>();
                var query = (from objSer in Chambix.tb_Servicio
                             where objSer.tb_Usuario.estadoUsuario == true
                             && objSer.idPost==idPost
                             select objSer);
                foreach (var objServicio in query)
                {
                    UserBE objUserBE = new UserBE();
                    objUserBE.idUsuario = Convert.ToInt16(objServicio.tb_Usuario.idUsuario);
                    objUserBE.tipoUsuario = Convert.ToInt16(objServicio.tb_Usuario.tipoUsuario);
                    objUserBE.estadoUsuario = Convert.ToInt16(objServicio.tb_Usuario.estadoUsuario);
                    objUserBE.nombreUsuario = objServicio.tb_Usuario.nombreUsuario;
                    objUserBE.apellidoUsuario = objServicio.tb_Usuario.apellidoUsuario;
                    objUserBE.contrasenaUsuario = objServicio.tb_Usuario.contrasenaUsuario;
                    objUserBE.idDistrito = Convert.ToInt16(objServicio.tb_Usuario.idDistrito);
                    objUserBE.emailUsuario = objServicio.tb_Usuario.emailUsuario;
                    objUserBE.cellUsuario = objServicio.tb_Usuario.cellUsuario;
                    objUserBE.rankUsuario = Convert.ToInt16(objServicio.tb_Usuario.rankUsuario);
                    objUserBE.wspUsuario = objServicio.tb_Usuario.wspUsuario;
                    objUserBE.ocupacionUsuario = objServicio.tb_Usuario.ocupacionUsuario;
                    objUserBE.idTipoCuenta = objServicio.tb_Usuario.idTipoCuenta;
                    objUserBE.tiempoCuenta = Convert.ToDateTime(objServicio.tb_Usuario.tiempoCuenta);
                    objUserBE.create_at = (DateTime)objServicio.create_at;
                    objUserLists.Add(objUserBE);
                }
                return objUserLists;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UserBE> GetAllUsersClients()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<UserBE> objUserLists = new List<UserBE>();
                var query = (from objUsr in Chambix.tb_Usuario
                             where objUsr.estadoUsuario == true
                            && objUsr.tipoUsuario == 1
                             select objUsr);
                foreach (var objUser in query)
                {
                    UserBE objUserBE = new UserBE();
                    objUserBE.idUsuario = Convert.ToInt16(objUser.idUsuario);
                    objUserBE.tipoUsuario = Convert.ToInt16(objUser.tipoUsuario);
                    objUserBE.estadoUsuario = Convert.ToInt16(objUser.estadoUsuario);
                    objUserBE.nombreUsuario = objUser.nombreUsuario;
                    objUserBE.apellidoUsuario = objUser.apellidoUsuario;
                    objUserBE.contrasenaUsuario = objUser.contrasenaUsuario;
                    objUserBE.idDistrito = Convert.ToInt16(objUser.idDistrito);
                    objUserBE.emailUsuario = objUser.emailUsuario;
                    objUserBE.cellUsuario = objUser.cellUsuario;
                    objUserBE.rankUsuario = Convert.ToInt16(objUser.rankUsuario);
                    objUserBE.wspUsuario = objUser.wspUsuario;
                    objUserBE.ocupacionUsuario = objUser.ocupacionUsuario;
                    objUserBE.idTipoCuenta = objUser.idTipoCuenta;
                    objUserBE.tiempoCuenta = Convert.ToDateTime(objUser.tiempoCuenta);
                    objUserBE.create_at = (DateTime)objUser.create_at;
                    objUserLists.Add(objUserBE);

                }
                return objUserLists;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UserBE> GetAllUsersProfesionals()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<UserBE> objUserLists = new List<UserBE>();
                var query = (from objUsr in Chambix.tb_Usuario
                             where objUsr.estadoUsuario == true
                             && objUsr.tipoUsuario == 2
                             select objUsr);
                foreach (var objUser in query)
                {
                    UserBE objUserBE = new UserBE();
                    objUserBE.nombreUsuario = objUser.nombreUsuario;
                    objUserBE.apellidoUsuario = objUser.apellidoUsuario;
                    objUserBE.contrasenaUsuario = objUser.contrasenaUsuario;
                    objUserBE.idDistrito = Convert.ToInt16(objUser.idDistrito);
                    objUserBE.emailUsuario = objUser.emailUsuario;
                    objUserBE.cellUsuario = objUser.cellUsuario;
                    objUserBE.wspUsuario = objUser.wspUsuario;
                    objUserBE.ocupacionUsuario = objUser.ocupacionUsuario;
                    objUserLists.Add(objUserBE);

                }
                return objUserLists;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UserBE> GetAllUsersAdmins()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<UserBE> objUserLists = new List<UserBE>();
                var query = (from objUsr in Chambix.tb_Usuario
                             where objUsr.estadoUsuario == true
                             && objUsr.tipoUsuario == 3
                             select objUsr);
                foreach (var objUser in query)
                {
                    UserBE objUserBE = new UserBE();
                    objUserBE.idUsuario = Convert.ToInt16(objUser.idUsuario);
                    objUserBE.tipoUsuario = Convert.ToInt16(objUser.tipoUsuario);
                    objUserBE.estadoUsuario = Convert.ToInt16(objUser.estadoUsuario);
                    objUserBE.nombreUsuario = objUser.nombreUsuario;
                    objUserBE.apellidoUsuario = objUser.apellidoUsuario;
                    objUserBE.contrasenaUsuario = objUser.contrasenaUsuario;
                    objUserBE.idDistrito = Convert.ToInt16(objUser.idDistrito);
                    objUserBE.emailUsuario = objUser.emailUsuario;
                    objUserBE.cellUsuario = objUser.cellUsuario;
                    objUserBE.rankUsuario = Convert.ToInt16(objUser.rankUsuario);
                    objUserBE.wspUsuario = objUser.wspUsuario;
                    objUserBE.ocupacionUsuario = objUser.ocupacionUsuario;
                    objUserBE.idTipoCuenta = objUser.idTipoCuenta;
                    objUserBE.tiempoCuenta = Convert.ToDateTime(objUser.tiempoCuenta);
                    objUserBE.create_at = (DateTime)objUser.create_at;
                    objUserLists.Add(objUserBE);

                }
                return objUserLists;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Int16 GetContarUsuarios()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                Int16 cantUsuarios = Convert.ToInt16(
                    (from objUser in Chambix.tb_Usuario
                     where objUser.estadoUsuario == true
                     select objUser).Count()
                    );
                return cantUsuarios;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
