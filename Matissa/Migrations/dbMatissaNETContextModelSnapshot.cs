﻿// <auto-generated />
using System;
using Matissa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Matissa.Migrations
{
    [DbContext(typeof(dbMatissaNETContext))]
    partial class dbMatissaNETContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Matissa.Model.Permiso", b =>
                {
                    b.Property<int>("IdPermiso")
                        .HasColumnType("int")
                        .HasColumnName("idPermiso");

                    b.Property<string>("Descripción")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("descripción");

                    b.Property<string>("Modulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("modulo");

                    b.HasKey("IdPermiso")
                        .HasName("PK__permiso__06A58486FA2DAA24");

                    b.ToTable("permiso", (string)null);
                });

            modelBuilder.Entity("Matissa.Model.RolXpermiso", b =>
                {
                    b.Property<int>("IdRolXpermiso")
                        .HasColumnType("int")
                        .HasColumnName("idRolXPermiso");

                    b.Property<int>("IdPermiso")
                        .HasColumnType("int")
                        .HasColumnName("idPermiso");

                    b.Property<int>("IdRol")
                        .HasColumnType("int")
                        .HasColumnName("idRol");

                    b.HasKey("IdRolXpermiso")
                        .HasName("PK__rolXPerm__3DC6779B486DF950");

                    b.HasIndex("IdPermiso");

                    b.HasIndex("IdRol");

                    b.ToTable("rolXPermiso", (string)null);
                });

            modelBuilder.Entity("Matissa.Model.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("idUsuario");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contraseña");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correo");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int")
                        .HasColumnName("idRol");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombreUsuario");

                    b.HasKey("IdUsuario")
                        .HasName("PK__usuario__645723A6099093C0");

                    b.HasIndex("IdRol");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.Citum", b =>
                {
                    b.Property<int>("IdCita")
                        .HasColumnType("int")
                        .HasColumnName("idCita");

                    b.Property<double>("CostoTotal")
                        .HasColumnType("float")
                        .HasColumnName("costoTotal");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("date")
                        .HasColumnName("fechaRegistro");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    b.HasKey("IdCita")
                        .HasName("PK__cita__814F31263DA04DE3");

                    b.HasIndex("IdCliente");

                    b.ToTable("cita", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    b.Property<string>("ApellidoCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellidoCliente");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correo");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("dirección");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("date")
                        .HasColumnName("nacimiento");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombreCliente");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("teléfono");

                    b.HasKey("IdCliente")
                        .HasName("PK__cliente__885457EE5A51A261");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .HasColumnType("int")
                        .HasColumnName("idCompra");

                    b.Property<double>("CostoTotalCompra")
                        .HasColumnType("float")
                        .HasColumnName("costoTotalCompra");

                    b.Property<string>("Descripción")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("descripción");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<string>("Factura")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("factura");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("date")
                        .HasColumnName("fechaCompra");

                    b.HasKey("IdCompra")
                        .HasName("PK__compra__48B99DB7A13325F8");

                    b.ToTable("compra", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.DetalleCitum", b =>
                {
                    b.Property<int>("IdDetalleCita")
                        .HasColumnType("int")
                        .HasColumnName("idDetalleCita");

                    b.Property<double>("CostoServicio")
                        .HasColumnType("float")
                        .HasColumnName("costoServicio");

                    b.Property<double>("Descuento")
                        .HasColumnType("float")
                        .HasColumnName("descuento");

                    b.Property<int>("DuraciónServicio")
                        .HasColumnType("int")
                        .HasColumnName("duraciónServicio");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("date")
                        .HasColumnName("fechaCita");

                    b.Property<int>("HoraFin")
                        .HasColumnType("int")
                        .HasColumnName("horaFin");

                    b.Property<int>("HoraInicio")
                        .HasColumnType("int")
                        .HasColumnName("horaInicio");

                    b.Property<int>("IdCita")
                        .HasColumnType("int")
                        .HasColumnName("idCita");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int")
                        .HasColumnName("idEmpleado");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int")
                        .HasColumnName("idServicio");

                    b.HasKey("IdDetalleCita")
                        .HasName("PK__detalleC__031271117A36A6BB");

                    b.HasIndex("IdCita");

                    b.HasIndex("IdEmpleado");

                    b.HasIndex("IdServicio");

                    b.ToTable("detalleCita", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.DetallePedido", b =>
                {
                    b.Property<int>("IdDetallePedido")
                        .HasColumnType("int")
                        .HasColumnName("idDetallePedido");

                    b.Property<int>("CantidadProducto")
                        .HasColumnType("int")
                        .HasColumnName("cantidadProducto");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int")
                        .HasColumnName("idPedido");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int")
                        .HasColumnName("idProducto");

                    b.Property<double>("PrecioUnitario")
                        .HasColumnType("float")
                        .HasColumnName("precioUnitario");

                    b.HasKey("IdDetallePedido")
                        .HasName("PK__detalleP__610F0056E942CCDA");

                    b.HasIndex("IdPedido");

                    b.HasIndex("IdProducto");

                    b.ToTable("detallePedido", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.Empleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int")
                        .HasColumnName("idEmpleado");

                    b.Property<string>("ApellidoEmpleado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellidoEmpleado");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correo");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("dirección");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaContrato")
                        .HasColumnType("date")
                        .HasColumnName("fechaContrato");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("date")
                        .HasColumnName("fechaNacimiento");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("genero");

                    b.Property<string>("NombreEmpleado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombreEmpleado");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("teléfono");

                    b.HasKey("IdEmpleado")
                        .HasName("PK__empleado__5295297C9779403D");

                    b.ToTable("empleado", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .HasColumnType("int")
                        .HasColumnName("idPedido");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaPedido")
                        .HasColumnType("date")
                        .HasColumnName("fechaPedido");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    b.Property<double>("PrecioTotalPedido")
                        .HasColumnType("float")
                        .HasColumnName("precioTotalPedido");

                    b.HasKey("IdPedido")
                        .HasName("PK__pedido__A9F619B752D55725");

                    b.HasIndex("IdCliente");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .HasColumnType("int")
                        .HasColumnName("idProducto");

                    b.Property<string>("Descripción")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("descripción");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaCaducidad")
                        .HasColumnType("date")
                        .HasColumnName("fechaCaducidad");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombreProducto");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float")
                        .HasColumnName("precioVenta");

                    b.Property<int>("SaldoInventario")
                        .HasColumnType("int")
                        .HasColumnName("saldoInventario");

                    b.HasKey("IdProducto")
                        .HasName("PK__producto__07F4A132E6BA3F28");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .HasColumnType("int")
                        .HasColumnName("idRol");

                    b.Property<byte?>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombreRol");

                    b.HasKey("IdRol")
                        .HasName("PK__rol__3C872F7600876082");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.Servicio", b =>
                {
                    b.Property<int>("IdServicio")
                        .HasColumnType("int")
                        .HasColumnName("idServicio");

                    b.Property<string>("Descripción")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("descripción");

                    b.Property<int>("Duración")
                        .HasColumnType("int")
                        .HasColumnName("duración");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<int>("IdTipoServicio")
                        .HasColumnType("int")
                        .HasColumnName("idTipoServicio");

                    b.Property<string>("NombreServicio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombreServicio");

                    b.Property<double>("Precio")
                        .HasColumnType("float")
                        .HasColumnName("precio");

                    b.HasKey("IdServicio")
                        .HasName("PK__servicio__CEB98119B2088B0F");

                    b.HasIndex("IdTipoServicio");

                    b.ToTable("servicio", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.TipoServicio", b =>
                {
                    b.Property<int>("IdTipoServicio")
                        .HasColumnType("int")
                        .HasColumnName("idTipoServicio");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("IdTipoServicio")
                        .HasName("PK__tipoServ__278616767C8DCAAE");

                    b.ToTable("tipoServicio", (string)null);
                });

            modelBuilder.Entity("Matissa.Models.VentaServicio", b =>
                {
                    b.Property<int>("IdVentaServicio")
                        .HasColumnType("int")
                        .HasColumnName("idVentaServicio");

                    b.Property<byte>("Estado")
                        .HasColumnType("tinyint")
                        .HasColumnName("estado");

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("date")
                        .HasColumnName("fechaVenta");

                    b.Property<string>("FormaPago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("formaPago");

                    b.Property<int>("IdCita")
                        .HasColumnType("int")
                        .HasColumnName("idCita");

                    b.Property<double>("ValorVenta")
                        .HasColumnType("float")
                        .HasColumnName("valorVenta");

                    b.HasKey("IdVentaServicio")
                        .HasName("PK__ventaSer__59B03D9C75C79989");

                    b.HasIndex("IdCita");

                    b.ToTable("ventaServicio", (string)null);
                });

            modelBuilder.Entity("Matissa.Model.RolXpermiso", b =>
                {
                    b.HasOne("Matissa.Model.Permiso", "IdPermisoNavigation")
                        .WithMany("RolXpermisos")
                        .HasForeignKey("IdPermiso")
                        .IsRequired()
                        .HasConstraintName("FK__rolXPermi__idPer__3F466844");

                    b.HasOne("Matissa.Models.Rol", "IdRolNavigation")
                        .WithMany("RolXpermisos")
                        .HasForeignKey("IdRol")
                        .IsRequired()
                        .HasConstraintName("FK__rolXPermi__idRol__3E52440B");

                    b.Navigation("IdPermisoNavigation");

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("Matissa.Model.Usuario", b =>
                {
                    b.HasOne("Matissa.Models.Rol", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .HasConstraintName("FK__usuario__idRol__3B75D760");

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("Matissa.Models.Citum", b =>
                {
                    b.HasOne("Matissa.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Cita")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK__cita__idCliente__4F7CD00D");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("Matissa.Models.DetalleCitum", b =>
                {
                    b.HasOne("Matissa.Models.Citum", "IdCitaNavigation")
                        .WithMany("DetalleCita")
                        .HasForeignKey("IdCita")
                        .IsRequired()
                        .HasConstraintName("FK__detalleCi__idCit__52593CB8");

                    b.HasOne("Matissa.Models.Empleado", "IdEmpleadoNavigation")
                        .WithMany("DetalleCita")
                        .HasForeignKey("IdEmpleado")
                        .IsRequired()
                        .HasConstraintName("FK__detalleCi__idEmp__534D60F1");

                    b.HasOne("Matissa.Models.Servicio", "IdServicioNavigation")
                        .WithMany("DetalleCita")
                        .HasForeignKey("IdServicio")
                        .IsRequired()
                        .HasConstraintName("FK__detalleCi__idSer__5441852A");

                    b.Navigation("IdCitaNavigation");

                    b.Navigation("IdEmpleadoNavigation");

                    b.Navigation("IdServicioNavigation");
                });

            modelBuilder.Entity("Matissa.Models.DetallePedido", b =>
                {
                    b.HasOne("Matissa.Models.Pedido", "IdPedidoNavigation")
                        .WithMany("DetallePedidos")
                        .HasForeignKey("IdPedido")
                        .IsRequired()
                        .HasConstraintName("FK__detallePe__idPed__628FA481");

                    b.HasOne("Matissa.Models.Producto", "IdProductoNavigation")
                        .WithMany("DetallePedidos")
                        .HasForeignKey("IdProducto")
                        .IsRequired()
                        .HasConstraintName("FK__detallePe__idPro__619B8048");

                    b.Navigation("IdPedidoNavigation");

                    b.Navigation("IdProductoNavigation");
                });

            modelBuilder.Entity("Matissa.Models.Pedido", b =>
                {
                    b.HasOne("Matissa.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK__pedido__idClient__5EBF139D");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("Matissa.Models.Servicio", b =>
                {
                    b.HasOne("Matissa.Models.TipoServicio", "IdTipoServicioNavigation")
                        .WithMany("Servicios")
                        .HasForeignKey("IdTipoServicio")
                        .IsRequired()
                        .HasConstraintName("FK__servicio__idTipo__4CA06362");

                    b.Navigation("IdTipoServicioNavigation");
                });

            modelBuilder.Entity("Matissa.Models.VentaServicio", b =>
                {
                    b.HasOne("Matissa.Models.Citum", "IdCitaNavigation")
                        .WithMany("VentaServicios")
                        .HasForeignKey("IdCita")
                        .IsRequired()
                        .HasConstraintName("FK__ventaServ__idCit__68487DD7");

                    b.Navigation("IdCitaNavigation");
                });

            modelBuilder.Entity("Matissa.Model.Permiso", b =>
                {
                    b.Navigation("RolXpermisos");
                });

            modelBuilder.Entity("Matissa.Models.Citum", b =>
                {
                    b.Navigation("DetalleCita");

                    b.Navigation("VentaServicios");
                });

            modelBuilder.Entity("Matissa.Models.Cliente", b =>
                {
                    b.Navigation("Cita");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Matissa.Models.Empleado", b =>
                {
                    b.Navigation("DetalleCita");
                });

            modelBuilder.Entity("Matissa.Models.Pedido", b =>
                {
                    b.Navigation("DetallePedidos");
                });

            modelBuilder.Entity("Matissa.Models.Producto", b =>
                {
                    b.Navigation("DetallePedidos");
                });

            modelBuilder.Entity("Matissa.Models.Rol", b =>
                {
                    b.Navigation("RolXpermisos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Matissa.Models.Servicio", b =>
                {
                    b.Navigation("DetalleCita");
                });

            modelBuilder.Entity("Matissa.Models.TipoServicio", b =>
                {
                    b.Navigation("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}