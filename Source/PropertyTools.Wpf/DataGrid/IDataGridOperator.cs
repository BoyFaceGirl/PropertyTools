// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataGridOperator.cs" company="PropertyTools">
//   Copyright (c) 2014 PropertyTools contributors
// </copyright>
// <summary>
//   Specifies DataGrid functionality that depends on the type of items source.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PropertyTools.Wpf
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Specifies DataGrid functionality that depends on the type of items source.
    /// </summary>
    public interface IDataGridOperator
    {
        /// <summary>
        /// Auto-generates the columns.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        void AutoGenerateColumns(DataGrid owner);

        /// <summary>
        /// Updates the property definitions.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        void UpdatePropertyDefinitions(DataGrid owner);

        /// <summary>
        /// Gets the type of the property in the specified cell.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="cell">The cell.</param>
        /// <returns>
        /// The type of the property.
        /// </returns>
        Type GetPropertyType(DataGrid owner, CellRef cell);

        /// <summary>
        /// Gets the property descriptor.
        /// </summary>
        /// <param name="pd">The property definition.</param>
        /// <returns>The property descriptor.</returns>
        PropertyDescriptor GetPropertyDescriptor(PropertyDefinition pd);

        /// <summary>
        /// Gets the binding path for the specified cell.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="cell">The cell.</param>
        /// <returns>
        /// The binding path
        /// </returns>
        string GetBindingPath(DataGrid owner, CellRef cell);

        /// <summary>
        /// Gets the value in the specified cell.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="cell">The cell.</param>
        /// <returns>The value</returns>
        object GetCellValue(DataGrid owner, CellRef cell);

        /// <summary>
        /// Converts the items source index to a collection view index.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="index">The index in the items source.</param>
        /// <returns>The index in the collection view</returns>
        int GetCollectionViewIndex(DataGrid owner, int index);

        /// <summary>
        /// Converts the collection view index to an items source index.
        /// </summary>
        /// <param name="owner">The owner.</param>
        /// <param name="index">The index in the collection view.</param>
        /// <returns>The index in the items source</returns>
        int GetItemsSourceIndex(DataGrid owner, int index);

        /// <summary>
        /// Inserts an item at the specified index.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        /// The index of the inserted item if insertion is successful, <c>-1</c> otherwise.
        /// </returns>
        int InsertItem(DataGrid owner, int index);

        /// <summary>
        /// Gets the item in the specified cell.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="cell">The cell reference.</param>
        /// <returns>
        /// The <see cref="object" />.
        /// </returns>
        object GetItem(DataGrid owner, CellRef cell);

        /// <summary>
        /// Sets value of the specified cell to the specified value.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="cell">The cell to change.</param>
        /// <param name="value">The value.</param>
        void SetValue(DataGrid owner, CellRef cell, object value);

        /// <summary>
        /// Tries to set cell value in the specified cell.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="cell">The cell.</param>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the cell value was set.</returns>
        bool TrySetCellValue(DataGrid owner, CellRef cell, object value);

        /// <summary>
        /// Gets the data context for the specified cell.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="cell">The cell.</param>
        /// <returns>The context object.</returns>
        object GetDataContext(DataGrid owner, CellRef cell);

        /// <summary>
        /// Determines whether columns can be deleted.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <returns><c>true</c> if columns can be deleted; otherwise <c>false</c>.</returns>
        bool CanDeleteColumns(DataGrid owner);

        /// <summary>
        /// Determines whether rows can be deleted.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <returns><c>true</c> if rows can be deleted; otherwise <c>false</c>.</returns>
        bool CanDeleteRows(DataGrid owner);

        /// <summary>
        /// Determines whether columns can be inserted.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <returns><c>true</c> if columns can be inserted; otherwise <c>false</c>.</returns>
        bool CanInsertColumns(DataGrid owner);

        /// <summary>
        /// Determines whether rows can be inserted.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <returns><c>true</c> if rows can be inserted; otherwise <c>false</c>.</returns>
        bool CanInsertRows(DataGrid owner);

        /// <summary>
        /// Deletes columns at the specified index.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="index">The index.</param>
        /// <param name="n">The number of columns to delete.</param>
        void DeleteColumns(DataGrid owner, int index, int n);

        /// <summary>
        /// Deletes rows at the specified index.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="index">The index.</param>
        /// <param name="n">The number of rows to delete.</param>
        void DeleteRows(DataGrid owner, int index, int n);

        /// <summary>
        /// Inserts columns at the specified index.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="index">The index.</param>
        /// <param name="n">The number of columns to insert.</param>
        void InsertColumns(DataGrid owner, int index, int n);

        /// <summary>
        /// Inserts rows at the specified index.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="index">The index.</param>
        /// <param name="n">The number of rows to insert.</param>
        void InsertRows(DataGrid owner, int index, int n);

        /// <summary>
        /// Gets the number of rows.
        /// </summary>
        /// <param name="dataGrid">The data grid.</param>
        /// <returns>The number.</returns>
        int GetRowCount(DataGrid dataGrid);

        /// <summary>
        /// Gets the number of columns.
        /// </summary>
        /// <param name="dataGrid">The data grid.</param>
        /// <returns>The number.</returns>
        int GetColumnCount(DataGrid dataGrid);

        /// <summary>
        /// Determines whether items can be sorted by the specified column/row index.
        /// </summary>
        /// <param name="owner">The data grid.</param>
        /// <param name="index">The column index if items are in rows, otherwise the row index.</param>
        /// <returns>
        ///   <c>true</c> if the items can be sorted; <c>false</c> otherwise.
        /// </returns>
        bool CanSort(DataGrid owner, int index);
    }
}