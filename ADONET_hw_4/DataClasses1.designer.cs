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

namespace ADONET_hw_4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="music2")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertartist(artist instance);
    partial void Updateartist(artist instance);
    partial void Deleteartist(artist instance);
    partial void Insertsong_artist(song_artist instance);
    partial void Updatesong_artist(song_artist instance);
    partial void Deletesong_artist(song_artist instance);
    partial void Insertsong(song instance);
    partial void Updatesong(song instance);
    partial void Deletesong(song instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ADONET_hw_4.Properties.Settings.Default.music2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
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
		
		public System.Data.Linq.Table<artist> artists
		{
			get
			{
				return this.GetTable<artist>();
			}
		}
		
		public System.Data.Linq.Table<song_artist> song_artists
		{
			get
			{
				return this.GetTable<song_artist>();
			}
		}
		
		public System.Data.Linq.Table<song> songs
		{
			get
			{
				return this.GetTable<song>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.artists")]
	public partial class artist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<song_artist> _song_artists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public artist()
		{
			this._song_artists = new EntitySet<song_artist>(new Action<song_artist>(this.attach_song_artists), new Action<song_artist>(this.detach_song_artists));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="artist_song_artist", Storage="_song_artists", ThisKey="Id", OtherKey="ArtistId")]
		public EntitySet<song_artist> song_artists
		{
			get
			{
				return this._song_artists;
			}
			set
			{
				this._song_artists.Assign(value);
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
		
		private void attach_song_artists(song_artist entity)
		{
			this.SendPropertyChanging();
			entity.artist = this;
		}
		
		private void detach_song_artists(song_artist entity)
		{
			this.SendPropertyChanging();
			entity.artist = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.song_artists")]
	public partial class song_artist : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _SongId;
		
		private int _ArtistId;
		
		private EntityRef<artist> _artist;
		
		private EntityRef<song> _song;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSongIdChanging(int value);
    partial void OnSongIdChanged();
    partial void OnArtistIdChanging(int value);
    partial void OnArtistIdChanged();
    #endregion
		
		public song_artist()
		{
			this._artist = default(EntityRef<artist>);
			this._song = default(EntityRef<song>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SongId", DbType="Int NOT NULL")]
		public int SongId
		{
			get
			{
				return this._SongId;
			}
			set
			{
				if ((this._SongId != value))
				{
					if (this._song.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSongIdChanging(value);
					this.SendPropertyChanging();
					this._SongId = value;
					this.SendPropertyChanged("SongId");
					this.OnSongIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ArtistId", DbType="Int NOT NULL")]
		public int ArtistId
		{
			get
			{
				return this._ArtistId;
			}
			set
			{
				if ((this._ArtistId != value))
				{
					if (this._artist.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnArtistIdChanging(value);
					this.SendPropertyChanging();
					this._ArtistId = value;
					this.SendPropertyChanged("ArtistId");
					this.OnArtistIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="artist_song_artist", Storage="_artist", ThisKey="ArtistId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public artist artist
		{
			get
			{
				return this._artist.Entity;
			}
			set
			{
				artist previousValue = this._artist.Entity;
				if (((previousValue != value) 
							|| (this._artist.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._artist.Entity = null;
						previousValue.song_artists.Remove(this);
					}
					this._artist.Entity = value;
					if ((value != null))
					{
						value.song_artists.Add(this);
						this._ArtistId = value.Id;
					}
					else
					{
						this._ArtistId = default(int);
					}
					this.SendPropertyChanged("artist");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="song_song_artist", Storage="_song", ThisKey="SongId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public song song
		{
			get
			{
				return this._song.Entity;
			}
			set
			{
				song previousValue = this._song.Entity;
				if (((previousValue != value) 
							|| (this._song.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._song.Entity = null;
						previousValue.song_artists.Remove(this);
					}
					this._song.Entity = value;
					if ((value != null))
					{
						value.song_artists.Add(this);
						this._SongId = value.Id;
					}
					else
					{
						this._SongId = default(int);
					}
					this.SendPropertyChanged("song");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.songs")]
	public partial class song : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _title;
		
		private System.Nullable<int> _rating;
		
		private int _weight;
		
		private int _duration;
		
		private System.DateTime _date;
		
		private EntitySet<song_artist> _song_artists;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnratingChanging(System.Nullable<int> value);
    partial void OnratingChanged();
    partial void OnweightChanging(int value);
    partial void OnweightChanged();
    partial void OndurationChanging(int value);
    partial void OndurationChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    #endregion
		
		public song()
		{
			this._song_artists = new EntitySet<song_artist>(new Action<song_artist>(this.attach_song_artists), new Action<song_artist>(this.detach_song_artists));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rating", DbType="Int")]
		public System.Nullable<int> rating
		{
			get
			{
				return this._rating;
			}
			set
			{
				if ((this._rating != value))
				{
					this.OnratingChanging(value);
					this.SendPropertyChanging();
					this._rating = value;
					this.SendPropertyChanged("rating");
					this.OnratingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_weight", DbType="Int NOT NULL")]
		public int weight
		{
			get
			{
				return this._weight;
			}
			set
			{
				if ((this._weight != value))
				{
					this.OnweightChanging(value);
					this.SendPropertyChanging();
					this._weight = value;
					this.SendPropertyChanged("weight");
					this.OnweightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_duration", DbType="Int NOT NULL")]
		public int duration
		{
			get
			{
				return this._duration;
			}
			set
			{
				if ((this._duration != value))
				{
					this.OndurationChanging(value);
					this.SendPropertyChanging();
					this._duration = value;
					this.SendPropertyChanged("duration");
					this.OndurationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="song_song_artist", Storage="_song_artists", ThisKey="Id", OtherKey="SongId")]
		public EntitySet<song_artist> song_artists
		{
			get
			{
				return this._song_artists;
			}
			set
			{
				this._song_artists.Assign(value);
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
		
		private void attach_song_artists(song_artist entity)
		{
			this.SendPropertyChanging();
			entity.song = this;
		}
		
		private void detach_song_artists(song_artist entity)
		{
			this.SendPropertyChanging();
			entity.song = null;
		}
	}
}
#pragma warning restore 1591
