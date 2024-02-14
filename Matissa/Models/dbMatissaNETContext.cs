using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Matissa.Models
{
    public partial class dbMatissaNETContext : DbContext
    {
        public dbMatissaNETContext()
        {
        }

        public dbMatissaNETContext(DbContextOptions<dbMatissaNETContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Citum> Cita { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Compra> Compras { get; set; } = null!;
        public virtual DbSet<Detallecitum> Detallecita { get; set; } = null!;
        public virtual DbSet<Detallecompra> Detallecompras { get; set; } = null!;
        public virtual DbSet<Detallepedido> Detallepedidos { get; set; } = null!;
        public virtual DbSet<Detalleventum> Detalleventa { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<Permiso> Permisos { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<Rolxpermiso> Rolxpermisos { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Ventum> Venta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;database=dbMatissaNET;user=root;persist security info=False;connect timeout=300", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Citum>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("PRIMARY");

                entity.ToTable("cita");

                entity.HasIndex(e => e.IdCliente, "idCliente");

                entity.Property(e => e.IdCita)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCita");

                entity.Property(e => e.CostoTotal).HasColumnName("costoTotal");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");

                entity.Property(e => e.IdCliente)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCliente");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cita_ibfk_1");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCliente");

                entity.Property(e => e.ApellidoCliente)
                    .HasMaxLength(50)
                    .HasColumnName("apellidoCliente");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.Nacimiento).HasColumnName("nacimiento");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .HasColumnName("nombreCliente");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra)
                    .HasName("PRIMARY");

                entity.ToTable("compra");

                entity.HasIndex(e => e.IdProveedor, "idProveedor");

                entity.Property(e => e.IdCompra)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCompra");

                entity.Property(e => e.CostoTotalCompra).HasColumnName("costoTotalCompra");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.Factura)
                    .HasMaxLength(50)
                    .HasColumnName("factura");

                entity.Property(e => e.FechaCompra).HasColumnName("fechaCompra");

                entity.Property(e => e.IdProveedor)
                    .HasColumnType("int(11)")
                    .HasColumnName("idProveedor");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("compra_ibfk_1");
            });

            modelBuilder.Entity<Detallecitum>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCita)
                    .HasName("PRIMARY");

                entity.ToTable("detallecita");

                entity.HasIndex(e => e.IdCita, "idCita");

                entity.HasIndex(e => e.IdServicio, "idServicio");

                entity.Property(e => e.IdDetalleCita)
                    .HasColumnType("int(11)")
                    .HasColumnName("idDetalleCita");

                entity.Property(e => e.CostoServicio).HasColumnName("costoServicio");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.DuracionServicio)
                    .HasColumnType("int(11)")
                    .HasColumnName("duracionServicio");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaCita).HasColumnName("fechaCita");

                entity.Property(e => e.HoraFin)
                    .HasColumnType("int(11)")
                    .HasColumnName("horaFin");

                entity.Property(e => e.HoraInicio)
                    .HasColumnType("int(11)")
                    .HasColumnName("horaInicio");

                entity.Property(e => e.IdCita)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCita");

                entity.Property(e => e.IdServicio)
                    .HasColumnType("int(11)")
                    .HasColumnName("idServicio");

                entity.HasOne(d => d.IdCitaNavigation)
                    .WithMany(p => p.Detallecita)
                    .HasForeignKey(d => d.IdCita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detallecita_ibfk_1");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.Detallecita)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detallecita_ibfk_2");
            });

            modelBuilder.Entity<Detallecompra>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCompra)
                    .HasName("PRIMARY");

                entity.ToTable("detallecompra");

                entity.HasIndex(e => e.IdCompra, "idCompra");

                entity.HasIndex(e => e.IdProducto, "idProducto");

                entity.Property(e => e.IdDetalleCompra)
                    .HasColumnType("int(11)")
                    .HasColumnName("idDetalleCompra");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("int(11)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.CostoTotalUnitario).HasColumnName("costoTotalUnitario");

                entity.Property(e => e.IdCompra)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCompra");

                entity.Property(e => e.IdProducto)
                    .HasColumnType("int(11)")
                    .HasColumnName("idProducto");

                entity.Property(e => e.PrecioUnitario).HasColumnName("precioUnitario");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.Detallecompras)
                    .HasForeignKey(d => d.IdCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detallecompra_ibfk_1");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Detallecompras)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detallecompra_ibfk_2");
            });

            modelBuilder.Entity<Detallepedido>(entity =>
            {
                entity.HasKey(e => e.IdDetallePedido)
                    .HasName("PRIMARY");

                entity.ToTable("detallepedido");

                entity.HasIndex(e => e.IdPedido, "idPedido");

                entity.HasIndex(e => e.IdProducto, "idProducto");

                entity.Property(e => e.IdDetallePedido)
                    .HasColumnType("int(11)")
                    .HasColumnName("idDetallePedido");

                entity.Property(e => e.CantidadProducto)
                    .HasColumnType("int(11)")
                    .HasColumnName("cantidadProducto");

                entity.Property(e => e.IdPedido)
                    .HasColumnType("int(11)")
                    .HasColumnName("idPedido");

                entity.Property(e => e.IdProducto)
                    .HasColumnType("int(11)")
                    .HasColumnName("idProducto");

                entity.Property(e => e.PrecioUnitario).HasColumnName("precioUnitario");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Detallepedidos)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detallepedido_ibfk_2");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Detallepedidos)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detallepedido_ibfk_1");
            });

            modelBuilder.Entity<Detalleventum>(entity =>
            {
                entity.HasKey(e => e.IdDetalleVenta)
                    .HasName("PRIMARY");

                entity.ToTable("detalleventa");

                entity.HasIndex(e => e.IdVenta, "idVenta");

                entity.Property(e => e.IdDetalleVenta)
                    .HasColumnType("int(11)")
                    .HasColumnName("idDetalleVenta");

                entity.Property(e => e.IdVenta)
                    .HasColumnType("int(11)")
                    .HasColumnName("idVenta");

                entity.Property(e => e.ReferenciaVenta)
                    .HasColumnType("int(11)")
                    .HasColumnName("referenciaVenta");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.Detalleventa)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detalleventa_ibfk_1");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PRIMARY");

                entity.ToTable("empleado");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnType("int(11)")
                    .HasColumnName("idEmpleado");

                entity.Property(e => e.ApellidoEmpleado)
                    .HasMaxLength(50)
                    .HasColumnName("apellidoEmpleado");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.FechaContrato).HasColumnName("fechaContrato");

                entity.Property(e => e.FechaNacimiento).HasColumnName("fechaNacimiento");

                entity.Property(e => e.Genero)
                    .HasMaxLength(50)
                    .HasColumnName("genero");

                entity.Property(e => e.NombreEmpleado)
                    .HasMaxLength(50)
                    .HasColumnName("nombreEmpleado");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PRIMARY");

                entity.ToTable("pedido");

                entity.HasIndex(e => e.IdCliente, "idCliente");

                entity.Property(e => e.IdPedido)
                    .HasColumnType("int(11)")
                    .HasColumnName("idPedido");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.FechaPedido).HasColumnName("fechaPedido");

                entity.Property(e => e.IdCliente)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCliente");

                entity.Property(e => e.PrecioTotalPedido).HasColumnName("precioTotalPedido");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pedido_ibfk_1");
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.HasKey(e => e.IdPermiso)
                    .HasName("PRIMARY");

                entity.ToTable("permiso");

                entity.Property(e => e.IdPermiso)
                    .HasColumnType("int(11)")
                    .HasColumnName("idPermiso");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Modulo)
                    .HasMaxLength(50)
                    .HasColumnName("modulo");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PRIMARY");

                entity.ToTable("producto");

                entity.Property(e => e.IdProducto)
                    .HasColumnType("int(11)")
                    .HasColumnName("idProducto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.FechaCaducidad).HasColumnName("fechaCaducidad");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(50)
                    .HasColumnName("nombreProducto");

                entity.Property(e => e.PrecioVenta).HasColumnName("precioVenta");

                entity.Property(e => e.SaldoInventario)
                    .HasColumnType("int(11)")
                    .HasColumnName("saldoInventario");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PRIMARY");

                entity.ToTable("proveedor");

                entity.Property(e => e.IdProveedor)
                    .HasColumnType("int(11)")
                    .HasColumnName("idProveedor");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .HasColumnName("contacto");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(50)
                    .HasColumnName("nombreProveedor");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");

                entity.Property(e => e.TipoProveedor)
                    .HasMaxLength(50)
                    .HasColumnName("tipoProveedor");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.ToTable("rol");

                entity.Property(e => e.IdRol)
                    .HasColumnType("int(11)")
                    .HasColumnName("idRol");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.NombreRol)
                    .HasMaxLength(50)
                    .HasColumnName("nombreRol");
            });

            modelBuilder.Entity<Rolxpermiso>(entity =>
            {
                entity.HasKey(e => e.IdRolXpermiso)
                    .HasName("PRIMARY");

                entity.ToTable("rolxpermiso");

                entity.HasIndex(e => e.IdPermiso, "idPermiso");

                entity.HasIndex(e => e.IdRol, "idRol");

                entity.Property(e => e.IdRolXpermiso)
                    .HasColumnType("int(11)")
                    .HasColumnName("idRolXPermiso");

                entity.Property(e => e.IdPermiso)
                    .HasColumnType("int(11)")
                    .HasColumnName("idPermiso");

                entity.Property(e => e.IdRol)
                    .HasColumnType("int(11)")
                    .HasColumnName("idRol");

                entity.HasOne(d => d.IdPermisoNavigation)
                    .WithMany(p => p.Rolxpermisos)
                    .HasForeignKey(d => d.IdPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rolxpermiso_ibfk_2");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Rolxpermisos)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rolxpermiso_ibfk_1");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PRIMARY");

                entity.ToTable("servicio");

                entity.HasIndex(e => e.IdEmpleado, "idEmpleado");

                entity.Property(e => e.IdServicio)
                    .HasColumnType("int(11)")
                    .HasColumnName("idServicio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Duracion)
                    .HasColumnType("int(11)")
                    .HasColumnName("duracion");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnType("int(11)")
                    .HasColumnName("idEmpleado");

                entity.Property(e => e.NombreServicio)
                    .HasMaxLength(50)
                    .HasColumnName("nombreServicio");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicio_ibfk_1");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.Correo, "correo")
                    .IsUnique();

                entity.HasIndex(e => e.IdRol, "idRol");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("int(11)")
                    .HasColumnName("idUsuario");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.IdRol)
                    .HasColumnType("int(11)")
                    .HasColumnName("idRol");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("nombreUsuario");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("usuario_ibfk_1");
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PRIMARY");

                entity.ToTable("venta");

                entity.HasIndex(e => e.IdCliente, "idCliente");

                entity.Property(e => e.IdVenta)
                    .HasColumnType("int(11)")
                    .HasColumnName("idVenta");

                entity.Property(e => e.Estado)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("estado");

                entity.Property(e => e.FechaVenta).HasColumnName("fechaVenta");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(50)
                    .HasColumnName("formaPago");

                entity.Property(e => e.IdCliente)
                    .HasColumnType("int(11)")
                    .HasColumnName("idCliente");

                entity.Property(e => e.PrecioVenta).HasColumnName("precioVenta");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("venta_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
