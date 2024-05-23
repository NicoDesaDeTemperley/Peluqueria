﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using peluqueria.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace peluqueria.Models
{
    public partial class PeluqueriaContext
    {
        private IPeluqueriaContextProcedures _procedures;

        public virtual IPeluqueriaContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new PeluqueriaContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IPeluqueriaContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sp_obtener_clientesResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<sp_obtener_empleadosResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<sp_ObtenerProductosResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<sp_ObtenerServiciosResult>().HasNoKey().ToView(null);
        }
    }

    public partial class PeluqueriaContextProcedures : IPeluqueriaContextProcedures
    {
        private readonly PeluqueriaContext _context;

        public PeluqueriaContextProcedures(PeluqueriaContext context)
        {
            _context = context;
        }

        public virtual async Task<List<sp_obtener_clientesResult>> sp_obtener_clientesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_obtener_clientesResult>("EXEC @returnValue = [dbo].[sp_obtener_clientes]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_obtener_empleadosResult>> sp_obtener_empleadosAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_obtener_empleadosResult>("EXEC @returnValue = [dbo].[sp_obtener_empleados]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_ObtenerProductosResult>> sp_ObtenerProductosAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_ObtenerProductosResult>("EXEC @returnValue = [dbo].[sp_ObtenerProductos]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<sp_ObtenerServiciosResult>> sp_ObtenerServiciosAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<sp_ObtenerServiciosResult>("EXEC @returnValue = [dbo].[sp_ObtenerServicios]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> sp_ValidarUsuarioAsync(string nombre_usuario, string contraseña, OutputParameter<int?> existe, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterexiste = new SqlParameter
            {
                ParameterName = "existe",
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = existe?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            };
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "nombre_usuario",
                    Size = 50,
                    Value = nombre_usuario ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "contraseña",
                    Size = 50,
                    Value = contraseña ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterexiste,
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[sp_ValidarUsuario] @nombre_usuario, @contraseña, @existe OUTPUT", sqlParameters, cancellationToken);

            existe.SetValue(parameterexiste.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
