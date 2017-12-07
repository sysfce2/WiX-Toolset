// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data.WindowsInstaller.Rows
{
    /// <summary>
    /// Specialization of a row for the Variable table.
    /// </summary>
    public sealed class WixBundleVariableRow : Row
    {
        /// <summary>
        /// Creates a Variable row that does not belong to a table.
        /// </summary>
        /// <param name="sourceLineNumbers">Original source lines for this row.</param>
        /// <param name="tableDef">TableDefinition this Media row belongs to and should get its column definitions from.</param>
        public WixBundleVariableRow(SourceLineNumber sourceLineNumbers, TableDefinition tableDef) :
            base(sourceLineNumbers, tableDef)
        {
        }

        /// <summary>
        /// Creates a Variable row that belongs to a table.
        /// </summary>
        /// <param name="sourceLineNumbers">Original source lines for this row.</param>
        /// <param name="table">Table this Media row belongs to and should get its column definitions from.</param>
        public WixBundleVariableRow(SourceLineNumber sourceLineNumbers, Table table)
            : base(sourceLineNumbers, table)
        {
        }

        /// <summary>
        /// Gets or sets the variable identifier.
        /// </summary>
        /// <value>The variable identifier.</value>
        public string Id
        {
            get { return (string)this.Fields[0].Data; }
            set { this.Fields[0].Data = value; }
        }

        /// <summary>
        /// Gets or sets the variable's value.
        /// </summary>
        /// <value>The variable's value.</value>
        public string Value
        {
            get { return (string)this.Fields[1].Data; }
            set { this.Fields[1].Data = value; }
        }

        /// <summary>
        /// Gets or sets the variable's type.
        /// </summary>
        /// <value>The variable's type.</value>
        public string Type
        {
            get { return (string)this.Fields[2].Data; }
            set { this.Fields[2].Data = value; }
        }

        /// <summary>
        /// Gets or sets whether this variable is hidden.
        /// </summary>
        /// <value>Whether this variable is hidden.</value>
        public bool Hidden
        {
            get { return (null == this.Fields[3].Data || 0 == ((int)this.Fields[3].Data)) ? false : true; }
            set { this.Fields[3].Data = value ? 1 : 0; }
        }

        /// <summary>
        /// Gets or sets whether this variable is persisted.
        /// </summary>
        /// <value>Whether this variable is persisted.</value>
        public bool Persisted
        {
            get { return (null == this.Fields[4].Data || 0 == ((int)this.Fields[4].Data)) ? false : true; }
            set { this.Fields[4].Data = value ? 1 : 0; }
        }
    }
}
