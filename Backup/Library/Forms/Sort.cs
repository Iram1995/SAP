
// Type: SAP2012.Library.Forms.Sort




using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SAP2012.Library.Forms
{
  [StandardModule]
  internal sealed class Sort
  {
    public class SortableBindingList<T> : BindingList<T> where T : class
    {
      private bool _isSorted;
      private ListSortDirection _sortDirection;
      private PropertyDescriptor _sortProperty;

      public SortableBindingList() => this._sortDirection = ListSortDirection.Ascending;

      public SortableBindingList(IList<T> list)
        : base(list)
      {
        this._sortDirection = ListSortDirection.Ascending;
      }

      protected override bool SupportsSortingCore => true;

      protected override bool IsSortedCore => this._isSorted;

      protected override ListSortDirection SortDirectionCore => this._sortDirection;

      protected override PropertyDescriptor SortPropertyCore => this._sortProperty;

      protected override void RemoveSortCore()
      {
        this._sortDirection = ListSortDirection.Ascending;
        this._sortProperty = (PropertyDescriptor) null;
        this._isSorted = false;
      }

      protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
      {
        this._sortProperty = prop;
        this._sortDirection = direction;
        if (!(this.Items is List<T> items))
          return;
        items.Sort(new Comparison<T>(this.Compare));
        this._isSorted = true;
        this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
      }

      private int Compare(T lhs, T rhs)
      {
        int num = this.OnComparison(lhs, rhs);
        if (this._sortDirection == ListSortDirection.Descending)
          num = checked (-num);
        return num;
      }

      private int OnComparison(T lhs, T rhs)
      {
        object objectValue1 = RuntimeHelpers.GetObjectValue((object) lhs == null ? (object) null : this._sortProperty.GetValue((object) lhs));
        object objectValue2 = RuntimeHelpers.GetObjectValue((object) rhs == null ? (object) null : this._sortProperty.GetValue((object) rhs));
        if (objectValue1 == null)
          return objectValue2 == null ? 0 : -1;
        if (objectValue2 == null)
          return 1;
        if (objectValue1 is IComparable)
          return ((IComparable) objectValue1).CompareTo(RuntimeHelpers.GetObjectValue(objectValue2));
        return objectValue1.Equals(RuntimeHelpers.GetObjectValue(objectValue2)) ? 0 : objectValue1.ToString().CompareTo(objectValue2.ToString());
      }
    }
  }
}
