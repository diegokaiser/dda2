﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_Chambix.ServicioPost {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PostBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Chambix")]
    [System.SerializableAttribute()]
    public partial class PostBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreDistritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreSubCategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime create_atField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string create_byField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionPostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short estadoPostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short idDistritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short idPostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short idSubcategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short idUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imagenPostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal precioPostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tituloPostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime update_atField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string update_byField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short valoracionPostField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoUsuario {
            get {
                return this.ApellidoUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoUsuarioField, value) != true)) {
                    this.ApellidoUsuarioField = value;
                    this.RaisePropertyChanged("ApellidoUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCategoria {
            get {
                return this.NombreCategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreCategoriaField, value) != true)) {
                    this.NombreCategoriaField = value;
                    this.RaisePropertyChanged("NombreCategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreDistrito {
            get {
                return this.NombreDistritoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreDistritoField, value) != true)) {
                    this.NombreDistritoField = value;
                    this.RaisePropertyChanged("NombreDistrito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreSubCategoria {
            get {
                return this.NombreSubCategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreSubCategoriaField, value) != true)) {
                    this.NombreSubCategoriaField = value;
                    this.RaisePropertyChanged("NombreSubCategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreUsuario {
            get {
                return this.NombreUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreUsuarioField, value) != true)) {
                    this.NombreUsuarioField = value;
                    this.RaisePropertyChanged("NombreUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime create_at {
            get {
                return this.create_atField;
            }
            set {
                if ((this.create_atField.Equals(value) != true)) {
                    this.create_atField = value;
                    this.RaisePropertyChanged("create_at");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string create_by {
            get {
                return this.create_byField;
            }
            set {
                if ((object.ReferenceEquals(this.create_byField, value) != true)) {
                    this.create_byField = value;
                    this.RaisePropertyChanged("create_by");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descripcionPost {
            get {
                return this.descripcionPostField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionPostField, value) != true)) {
                    this.descripcionPostField = value;
                    this.RaisePropertyChanged("descripcionPost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short estadoPost {
            get {
                return this.estadoPostField;
            }
            set {
                if ((this.estadoPostField.Equals(value) != true)) {
                    this.estadoPostField = value;
                    this.RaisePropertyChanged("estadoPost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short idDistrito {
            get {
                return this.idDistritoField;
            }
            set {
                if ((this.idDistritoField.Equals(value) != true)) {
                    this.idDistritoField = value;
                    this.RaisePropertyChanged("idDistrito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short idPost {
            get {
                return this.idPostField;
            }
            set {
                if ((this.idPostField.Equals(value) != true)) {
                    this.idPostField = value;
                    this.RaisePropertyChanged("idPost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short idSubcategoria {
            get {
                return this.idSubcategoriaField;
            }
            set {
                if ((this.idSubcategoriaField.Equals(value) != true)) {
                    this.idSubcategoriaField = value;
                    this.RaisePropertyChanged("idSubcategoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short idUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                if ((this.idUsuarioField.Equals(value) != true)) {
                    this.idUsuarioField = value;
                    this.RaisePropertyChanged("idUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imagenPost {
            get {
                return this.imagenPostField;
            }
            set {
                if ((object.ReferenceEquals(this.imagenPostField, value) != true)) {
                    this.imagenPostField = value;
                    this.RaisePropertyChanged("imagenPost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal precioPost {
            get {
                return this.precioPostField;
            }
            set {
                if ((this.precioPostField.Equals(value) != true)) {
                    this.precioPostField = value;
                    this.RaisePropertyChanged("precioPost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tituloPost {
            get {
                return this.tituloPostField;
            }
            set {
                if ((object.ReferenceEquals(this.tituloPostField, value) != true)) {
                    this.tituloPostField = value;
                    this.RaisePropertyChanged("tituloPost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime update_at {
            get {
                return this.update_atField;
            }
            set {
                if ((this.update_atField.Equals(value) != true)) {
                    this.update_atField = value;
                    this.RaisePropertyChanged("update_at");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string update_by {
            get {
                return this.update_byField;
            }
            set {
                if ((object.ReferenceEquals(this.update_byField, value) != true)) {
                    this.update_byField = value;
                    this.RaisePropertyChanged("update_by");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short valoracionPost {
            get {
                return this.valoracionPostField;
            }
            set {
                if ((this.valoracionPostField.Equals(value) != true)) {
                    this.valoracionPostField = value;
                    this.RaisePropertyChanged("valoracionPost");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioPost.IServicioPost")]
    public interface IServicioPost {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/InsertPost", ReplyAction="http://tempuri.org/IServicioPost/InsertPostResponse")]
        bool InsertPost(short idUsuario, short idSubcategoria, short idDistrito, string tituloPost, string descripcionPost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/InsertPost", ReplyAction="http://tempuri.org/IServicioPost/InsertPostResponse")]
        System.Threading.Tasks.Task<bool> InsertPostAsync(short idUsuario, short idSubcategoria, short idDistrito, string tituloPost, string descripcionPost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/UpdatePost", ReplyAction="http://tempuri.org/IServicioPost/UpdatePostResponse")]
        bool UpdatePost(WEB_Chambix.ServicioPost.PostBE objPostBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/UpdatePost", ReplyAction="http://tempuri.org/IServicioPost/UpdatePostResponse")]
        System.Threading.Tasks.Task<bool> UpdatePostAsync(WEB_Chambix.ServicioPost.PostBE objPostBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/LogicDeletePost", ReplyAction="http://tempuri.org/IServicioPost/LogicDeletePostResponse")]
        bool LogicDeletePost(short idPost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/LogicDeletePost", ReplyAction="http://tempuri.org/IServicioPost/LogicDeletePostResponse")]
        System.Threading.Tasks.Task<bool> LogicDeletePostAsync(short idPost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetPost", ReplyAction="http://tempuri.org/IServicioPost/GetPostResponse")]
        WEB_Chambix.ServicioPost.PostBE GetPost(short idPost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetPost", ReplyAction="http://tempuri.org/IServicioPost/GetPostResponse")]
        System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE> GetPostAsync(short idPost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetAllPosts", ReplyAction="http://tempuri.org/IServicioPost/GetAllPostsResponse")]
        WEB_Chambix.ServicioPost.PostBE[] GetAllPosts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetAllPosts", ReplyAction="http://tempuri.org/IServicioPost/GetAllPostsResponse")]
        System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetAllPostsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetAllPostsPorCategoria", ReplyAction="http://tempuri.org/IServicioPost/GetAllPostsPorCategoriaResponse")]
        WEB_Chambix.ServicioPost.PostBE[] GetAllPostsPorCategoria(short idSubCategoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetAllPostsPorCategoria", ReplyAction="http://tempuri.org/IServicioPost/GetAllPostsPorCategoriaResponse")]
        System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetAllPostsPorCategoriaAsync(short idSubCategoria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetContarPostPorCategoria", ReplyAction="http://tempuri.org/IServicioPost/GetContarPostPorCategoriaResponse")]
        short GetContarPostPorCategoria(short idPost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetContarPostPorCategoria", ReplyAction="http://tempuri.org/IServicioPost/GetContarPostPorCategoriaResponse")]
        System.Threading.Tasks.Task<short> GetContarPostPorCategoriaAsync(short idPost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetPostLike", ReplyAction="http://tempuri.org/IServicioPost/GetPostLikeResponse")]
        WEB_Chambix.ServicioPost.PostBE[] GetPostLike(string palabraClave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetPostLike", ReplyAction="http://tempuri.org/IServicioPost/GetPostLikeResponse")]
        System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetPostLikeAsync(string palabraClave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetAllPostsPorIdUsuario", ReplyAction="http://tempuri.org/IServicioPost/GetAllPostsPorIdUsuarioResponse")]
        WEB_Chambix.ServicioPost.PostBE[] GetAllPostsPorIdUsuario(short idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetAllPostsPorIdUsuario", ReplyAction="http://tempuri.org/IServicioPost/GetAllPostsPorIdUsuarioResponse")]
        System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetAllPostsPorIdUsuarioAsync(short idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetAllPostsServiciosPorIdUsuario", ReplyAction="http://tempuri.org/IServicioPost/GetAllPostsServiciosPorIdUsuarioResponse")]
        WEB_Chambix.ServicioPost.PostBE[] GetAllPostsServiciosPorIdUsuario(short idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetAllPostsServiciosPorIdUsuario", ReplyAction="http://tempuri.org/IServicioPost/GetAllPostsServiciosPorIdUsuarioResponse")]
        System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetAllPostsServiciosPorIdUsuarioAsync(short idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetContarPost", ReplyAction="http://tempuri.org/IServicioPost/GetContarPostResponse")]
        short GetContarPost();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetContarPost", ReplyAction="http://tempuri.org/IServicioPost/GetContarPostResponse")]
        System.Threading.Tasks.Task<short> GetContarPostAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetContarPostPorIdUsuario", ReplyAction="http://tempuri.org/IServicioPost/GetContarPostPorIdUsuarioResponse")]
        short GetContarPostPorIdUsuario(short idUsuarios);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPost/GetContarPostPorIdUsuario", ReplyAction="http://tempuri.org/IServicioPost/GetContarPostPorIdUsuarioResponse")]
        System.Threading.Tasks.Task<short> GetContarPostPorIdUsuarioAsync(short idUsuarios);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPostChannel : WEB_Chambix.ServicioPost.IServicioPost, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPostClient : System.ServiceModel.ClientBase<WEB_Chambix.ServicioPost.IServicioPost>, WEB_Chambix.ServicioPost.IServicioPost {
        
        public ServicioPostClient() {
        }
        
        public ServicioPostClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioPostClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPostClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPostClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool InsertPost(short idUsuario, short idSubcategoria, short idDistrito, string tituloPost, string descripcionPost) {
            return base.Channel.InsertPost(idUsuario, idSubcategoria, idDistrito, tituloPost, descripcionPost);
        }
        
        public System.Threading.Tasks.Task<bool> InsertPostAsync(short idUsuario, short idSubcategoria, short idDistrito, string tituloPost, string descripcionPost) {
            return base.Channel.InsertPostAsync(idUsuario, idSubcategoria, idDistrito, tituloPost, descripcionPost);
        }
        
        public bool UpdatePost(WEB_Chambix.ServicioPost.PostBE objPostBE) {
            return base.Channel.UpdatePost(objPostBE);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePostAsync(WEB_Chambix.ServicioPost.PostBE objPostBE) {
            return base.Channel.UpdatePostAsync(objPostBE);
        }
        
        public bool LogicDeletePost(short idPost) {
            return base.Channel.LogicDeletePost(idPost);
        }
        
        public System.Threading.Tasks.Task<bool> LogicDeletePostAsync(short idPost) {
            return base.Channel.LogicDeletePostAsync(idPost);
        }
        
        public WEB_Chambix.ServicioPost.PostBE GetPost(short idPost) {
            return base.Channel.GetPost(idPost);
        }
        
        public System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE> GetPostAsync(short idPost) {
            return base.Channel.GetPostAsync(idPost);
        }
        
        public WEB_Chambix.ServicioPost.PostBE[] GetAllPosts() {
            return base.Channel.GetAllPosts();
        }
        
        public System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetAllPostsAsync() {
            return base.Channel.GetAllPostsAsync();
        }
        
        public WEB_Chambix.ServicioPost.PostBE[] GetAllPostsPorCategoria(short idSubCategoria) {
            return base.Channel.GetAllPostsPorCategoria(idSubCategoria);
        }
        
        public System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetAllPostsPorCategoriaAsync(short idSubCategoria) {
            return base.Channel.GetAllPostsPorCategoriaAsync(idSubCategoria);
        }
        
        public short GetContarPostPorCategoria(short idPost) {
            return base.Channel.GetContarPostPorCategoria(idPost);
        }
        
        public System.Threading.Tasks.Task<short> GetContarPostPorCategoriaAsync(short idPost) {
            return base.Channel.GetContarPostPorCategoriaAsync(idPost);
        }
        
        public WEB_Chambix.ServicioPost.PostBE[] GetPostLike(string palabraClave) {
            return base.Channel.GetPostLike(palabraClave);
        }
        
        public System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetPostLikeAsync(string palabraClave) {
            return base.Channel.GetPostLikeAsync(palabraClave);
        }
        
        public WEB_Chambix.ServicioPost.PostBE[] GetAllPostsPorIdUsuario(short idUsuario) {
            return base.Channel.GetAllPostsPorIdUsuario(idUsuario);
        }
        
        public System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetAllPostsPorIdUsuarioAsync(short idUsuario) {
            return base.Channel.GetAllPostsPorIdUsuarioAsync(idUsuario);
        }
        
        public WEB_Chambix.ServicioPost.PostBE[] GetAllPostsServiciosPorIdUsuario(short idUsuario) {
            return base.Channel.GetAllPostsServiciosPorIdUsuario(idUsuario);
        }
        
        public System.Threading.Tasks.Task<WEB_Chambix.ServicioPost.PostBE[]> GetAllPostsServiciosPorIdUsuarioAsync(short idUsuario) {
            return base.Channel.GetAllPostsServiciosPorIdUsuarioAsync(idUsuario);
        }
        
        public short GetContarPost() {
            return base.Channel.GetContarPost();
        }
        
        public System.Threading.Tasks.Task<short> GetContarPostAsync() {
            return base.Channel.GetContarPostAsync();
        }
        
        public short GetContarPostPorIdUsuario(short idUsuarios) {
            return base.Channel.GetContarPostPorIdUsuario(idUsuarios);
        }
        
        public System.Threading.Tasks.Task<short> GetContarPostPorIdUsuarioAsync(short idUsuarios) {
            return base.Channel.GetContarPostPorIdUsuarioAsync(idUsuarios);
        }
    }
}
