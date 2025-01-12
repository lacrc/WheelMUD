//-----------------------------------------------------------------------------
// <copyright file="IWheelMudDbProvider.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

using System.Data;

namespace WheelMUD.Data
{
    /// <summary>Interface for supporting different database back ends under ORMLite.</summary>
    public interface IWheelMudRelationalDbProvider
    {
        string ConnectionString { get; set; }

        string DatabaseName { get; }

        IDbConnection CreateDatabaseSession();
    }
}