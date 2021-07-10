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
        public Boolean InsertUser(UserBE objUserBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();


            try
            {
                tb_Usuario objUser = new tb_Usuario();
                objUser.nombreUsuario = objUserBE.nombreUsuario;
                objUser.apellidoUsuario = objUserBE.apellidoUsuario;
                objUser.contrasenaUsuario = objUserBE.contrasenaUsuario;
                objUser.idDistrito = Convert.ToByte(objUserBE.idDistrito);
                objUser.emailUsuario = objUserBE.emailUsuario;
                objUser.cellUsuario = objUserBE.cellUsuario;
                objUser.wspUsuario = objUserBE.wspUsuario;
                objUser.ocupacionUsuario = objUserBE.ocupacionUsuario;
                objUser.create_at = objUserBE.create_at;
                objUser.create_by = objUserBE.create_by;

                Chambix.tb_Usuario.Add(objUser);
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean UpdateUser(UserBE objUserBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Usuario objUser = (from objUsr in Chambix.tb_Usuario
                                      where objUsr.idUsuario == objUserBE.idUsuario
                                      select objUsr).FirstOrDefault();

                objUser.idUsuario = objUserBE.idUsuario;
                objUser.tipoUsuario = Convert.ToByte(objUserBE.tipoUsuario);
                objUser.estadoUsuario = Convert.ToBoolean(objUserBE.estadoUsuario);
                objUser.nombreUsuario = objUserBE.nombreUsuario;
                objUser.apellidoUsuario = objUserBE.apellidoUsuario;
                objUser.contrasenaUsuario = objUserBE.contrasenaUsuario;
                objUser.idDistrito = Convert.ToByte(objUserBE.idDistrito);
                objUser.emailUsuario = objUserBE.emailUsuario;
                objUser.cellUsuario = objUserBE.cellUsuario;
                objUser.rankUsuario = objUserBE.rankUsuario;
                objUser.wspUsuario = objUserBE.wspUsuario;
                objUser.ocupacionUsuario = objUserBE.ocupacionUsuario;
                objUser.idTipoCuenta = Convert.ToByte(objUserBE.idTipoCuenta);

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
    }
}
