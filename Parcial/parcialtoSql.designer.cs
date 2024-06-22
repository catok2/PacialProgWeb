﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parcial
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="parcial")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertalumnos(alumnos instance);
    partial void Updatealumnos(alumnos instance);
    partial void Deletealumnos(alumnos instance);
    partial void Insertcomentarios(comentarios instance);
    partial void Updatecomentarios(comentarios instance);
    partial void Deletecomentarios(comentarios instance);
    #endregion
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<alumnos> alumnos
		{
			get
			{
				return this.GetTable<alumnos>();
			}
		}
		
		public System.Data.Linq.Table<comentarios> comentarios
		{
			get
			{
				return this.GetTable<comentarios>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.alumnos")]
	public partial class alumnos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Apellido;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Email;
		
		private string _Turno;
		
		private EntitySet<comentarios> _comentarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnTurnoChanging(string value);
    partial void OnTurnoChanged();
    #endregion
		
		public alumnos()
		{
			this._comentarios = new EntitySet<comentarios>(new Action<comentarios>(this.attach_comentarios), new Action<comentarios>(this.detach_comentarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="NVarChar(2)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this.OnTurnoChanging(value);
					this.SendPropertyChanging();
					this._Turno = value;
					this.SendPropertyChanged("Turno");
					this.OnTurnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="alumnos_comentarios", Storage="_comentarios", ThisKey="Id", OtherKey="AlumnoId")]
		public EntitySet<comentarios> comentarios
		{
			get
			{
				return this._comentarios;
			}
			set
			{
				this._comentarios.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_comentarios(comentarios entity)
		{
			this.SendPropertyChanging();
			entity.alumnos = this;
		}
		
		private void detach_comentarios(comentarios entity)
		{
			this.SendPropertyChanging();
			entity.alumnos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.comentarios")]
	public partial class comentarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _DNI;
		
		private string _Apellido;
		
		private string _Comentario;
		
		private int _AlumnoId;
		
		private EntityRef<alumnos> _alumnos;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnComentarioChanging(string value);
    partial void OnComentarioChanged();
    partial void OnAlumnoIdChanging(int value);
    partial void OnAlumnoIdChanged();
    #endregion
		
		public comentarios()
		{
			this._alumnos = default(EntityRef<alumnos>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(20)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="NVarChar(100)")]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comentario", DbType="NVarChar(MAX)")]
		public string Comentario
		{
			get
			{
				return this._Comentario;
			}
			set
			{
				if ((this._Comentario != value))
				{
					this.OnComentarioChanging(value);
					this.SendPropertyChanging();
					this._Comentario = value;
					this.SendPropertyChanged("Comentario");
					this.OnComentarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlumnoId", DbType="Int NOT NULL")]
		public int AlumnoId
		{
			get
			{
				return this._AlumnoId;
			}
			set
			{
				if ((this._AlumnoId != value))
				{
					if (this._alumnos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAlumnoIdChanging(value);
					this.SendPropertyChanging();
					this._AlumnoId = value;
					this.SendPropertyChanged("AlumnoId");
					this.OnAlumnoIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="alumnos_comentarios", Storage="_alumnos", ThisKey="AlumnoId", OtherKey="Id", IsForeignKey=true)]
		public alumnos alumnos
		{
			get
			{
				return this._alumnos.Entity;
			}
			set
			{
				alumnos previousValue = this._alumnos.Entity;
				if (((previousValue != value) 
							|| (this._alumnos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._alumnos.Entity = null;
						previousValue.comentarios.Remove(this);
					}
					this._alumnos.Entity = value;
					if ((value != null))
					{
						value.comentarios.Add(this);
						this._AlumnoId = value.Id;
					}
					else
					{
						this._AlumnoId = default(int);
					}
					this.SendPropertyChanged("alumnos");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591