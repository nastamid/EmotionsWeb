﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmotionsWeb.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmotionsDB")]
	public partial class EmotionsDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertIcon(Icon instance);
    partial void UpdateIcon(Icon instance);
    partial void DeleteIcon(Icon instance);
    partial void InsertPost(Post instance);
    partial void UpdatePost(Post instance);
    partial void DeletePost(Post instance);
    #endregion
		
		public EmotionsDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["EmotionsDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EmotionsDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmotionsDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmotionsDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmotionsDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Icon> Icons
		{
			get
			{
				return this.GetTable<Icon>();
			}
		}
		
		public System.Data.Linq.Table<Post> Posts
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _FacebookId;
		
		private int _PostId;
		
		private string _ProfileImage;
		
		private System.DateTime _CreateDate;
		
		private EntitySet<Post> _Posts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFacebookIdChanging(int value);
    partial void OnFacebookIdChanged();
    partial void OnPostIdChanging(int value);
    partial void OnPostIdChanged();
    partial void OnProfileImageChanging(string value);
    partial void OnProfileImageChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    #endregion
		
		public User()
		{
			this._Posts = new EntitySet<Post>(new Action<Post>(this.attach_Posts), new Action<Post>(this.detach_Posts));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FacebookId", DbType="Int NOT NULL")]
		public int FacebookId
		{
			get
			{
				return this._FacebookId;
			}
			set
			{
				if ((this._FacebookId != value))
				{
					this.OnFacebookIdChanging(value);
					this.SendPropertyChanging();
					this._FacebookId = value;
					this.SendPropertyChanged("FacebookId");
					this.OnFacebookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostId", DbType="Int NOT NULL")]
		public int PostId
		{
			get
			{
				return this._PostId;
			}
			set
			{
				if ((this._PostId != value))
				{
					this.OnPostIdChanging(value);
					this.SendPropertyChanging();
					this._PostId = value;
					this.SendPropertyChanged("PostId");
					this.OnPostIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProfileImage", DbType="NVarChar(MAX)")]
		public string ProfileImage
		{
			get
			{
				return this._ProfileImage;
			}
			set
			{
				if ((this._ProfileImage != value))
				{
					this.OnProfileImageChanging(value);
					this.SendPropertyChanging();
					this._ProfileImage = value;
					this.SendPropertyChanged("ProfileImage");
					this.OnProfileImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Post", Storage="_Posts", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<Post> Posts
		{
			get
			{
				return this._Posts;
			}
			set
			{
				this._Posts.Assign(value);
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
		
		private void attach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Icons")]
	public partial class Icon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Path;
		
		private EntitySet<Post> _Posts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPathChanging(string value);
    partial void OnPathChanged();
    #endregion
		
		public Icon()
		{
			this._Posts = new EntitySet<Post>(new Action<Post>(this.attach_Posts), new Action<Post>(this.detach_Posts));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Path", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Path
		{
			get
			{
				return this._Path;
			}
			set
			{
				if ((this._Path != value))
				{
					this.OnPathChanging(value);
					this.SendPropertyChanging();
					this._Path = value;
					this.SendPropertyChanged("Path");
					this.OnPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Icon_Post", Storage="_Posts", ThisKey="Id", OtherKey="IconId")]
		public EntitySet<Post> Posts
		{
			get
			{
				return this._Posts;
			}
			set
			{
				this._Posts.Assign(value);
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
		
		private void attach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Icon = this;
		}
		
		private void detach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Icon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Posts")]
	public partial class Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _UserId;
		
		private string _Title;
		
		private string _Description;
		
		private int _IconId;
		
		private System.Nullable<double> _Longitude;
		
		private System.Nullable<double> _Latitude;
		
		private EntityRef<Icon> _Icon;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnIconIdChanging(int value);
    partial void OnIconIdChanged();
    partial void OnLongitudeChanging(System.Nullable<double> value);
    partial void OnLongitudeChanged();
    partial void OnLatitudeChanging(System.Nullable<double> value);
    partial void OnLatitudeChanged();
    #endregion
		
		public Post()
		{
			this._Icon = default(EntityRef<Icon>);
			this._User = default(EntityRef<User>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IconId", DbType="Int NOT NULL")]
		public int IconId
		{
			get
			{
				return this._IconId;
			}
			set
			{
				if ((this._IconId != value))
				{
					if (this._Icon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIconIdChanging(value);
					this.SendPropertyChanging();
					this._IconId = value;
					this.SendPropertyChanged("IconId");
					this.OnIconIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="Float")]
		public System.Nullable<double> Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Float")]
		public System.Nullable<double> Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Icon_Post", Storage="_Icon", ThisKey="IconId", OtherKey="Id", IsForeignKey=true)]
		public Icon Icon
		{
			get
			{
				return this._Icon.Entity;
			}
			set
			{
				Icon previousValue = this._Icon.Entity;
				if (((previousValue != value) 
							|| (this._Icon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Icon.Entity = null;
						previousValue.Posts.Remove(this);
					}
					this._Icon.Entity = value;
					if ((value != null))
					{
						value.Posts.Add(this);
						this._IconId = value.Id;
					}
					else
					{
						this._IconId = default(int);
					}
					this.SendPropertyChanged("Icon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Post", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Posts.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Posts.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
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