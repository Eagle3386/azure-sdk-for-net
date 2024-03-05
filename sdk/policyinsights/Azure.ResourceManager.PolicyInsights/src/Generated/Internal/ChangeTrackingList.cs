// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.PolicyInsights
{
    internal class ChangeTrackingList<T> : IList<T>, IReadOnlyList<T>
    {
        private IList<T> _innerList;

        public ChangeTrackingList()
        {
        }

        public ChangeTrackingList(IList<T> innerList)
        {
            if (innerList != null)
            {
                _innerList = innerList;
            }
        }

        public ChangeTrackingList(IReadOnlyList<T> innerList)
        {
            if (innerList != null)
            {
                _innerList = innerList.ToList();
            }
        }

        public bool IsUndefined => _innerList == null;

        public int Count => IsUndefined ? 0 : EnsureList().Count;

        public bool IsReadOnly => IsUndefined ? false : EnsureList().IsReadOnly;

        public T this[int index]
        {
            get
            {
                if (IsUndefined)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return EnsureList()[index];
            }
            set
            {
                if (IsUndefined)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                EnsureList()[index] = value;
            }
        }

        public void Reset()
        {
            _innerList = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (IsUndefined)
            {
                IEnumerator<T> enumerateEmpty()
                {
                    yield break;
                }
                return enumerateEmpty();
            }
            return EnsureList().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            EnsureList().Add(item);
        }

        public void Clear()
        {
            EnsureList().Clear();
        }

        public bool Contains(T item)
        {
            if (IsUndefined)
            {
                return false;
            }
            return EnsureList().Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (IsUndefined)
            {
                return;
            }
            EnsureList().CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            if (IsUndefined)
            {
                return false;
            }
            return EnsureList().Remove(item);
        }

        public int IndexOf(T item)
        {
            if (IsUndefined)
            {
                return -1;
            }
            return EnsureList().IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            EnsureList().Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            if (IsUndefined)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            EnsureList().RemoveAt(index);
        }

        public IList<T> EnsureList()
        {
            return _innerList ??= new List<T>();
        }
    }
}
