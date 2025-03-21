//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TerrainForces : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<TerrainForce>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TerrainForces(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TerrainForces obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TerrainForces() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          chrono_vehiclePINVOKE.delete_TerrainForces(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TerrainForces(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (TerrainForce element in c) {
      this.Add(element);
    }
  }

  public TerrainForces(global::System.Collections.Generic.IEnumerable<TerrainForce> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (TerrainForce element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public TerrainForce this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(TerrainForce[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(TerrainForce[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, TerrainForce[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public TerrainForce[] ToArray() {
    TerrainForce[] array = new TerrainForce[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<TerrainForce> global::System.Collections.Generic.IEnumerable<TerrainForce>.GetEnumerator() {
    return new TerrainForcesEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new TerrainForcesEnumerator(this);
  }

  public TerrainForcesEnumerator GetEnumerator() {
    return new TerrainForcesEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class TerrainForcesEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<TerrainForce>
  {
    private TerrainForces collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public TerrainForcesEnumerator(TerrainForces collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public TerrainForce Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (TerrainForce)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    chrono_vehiclePINVOKE.TerrainForces_Clear(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(TerrainForce x) {
    chrono_vehiclePINVOKE.TerrainForces_Add(swigCPtr, TerrainForce.getCPtr(x));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = chrono_vehiclePINVOKE.TerrainForces_size(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = chrono_vehiclePINVOKE.TerrainForces_capacity(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    chrono_vehiclePINVOKE.TerrainForces_reserve(swigCPtr, n);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public TerrainForces() : this(chrono_vehiclePINVOKE.new_TerrainForces__SWIG_0(), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public TerrainForces(TerrainForces other) : this(chrono_vehiclePINVOKE.new_TerrainForces__SWIG_1(TerrainForces.getCPtr(other)), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public TerrainForces(int capacity) : this(chrono_vehiclePINVOKE.new_TerrainForces__SWIG_2(capacity), true) {
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private TerrainForce getitemcopy(int index) {
    TerrainForce ret = new TerrainForce(chrono_vehiclePINVOKE.TerrainForces_getitemcopy(swigCPtr, index), true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private TerrainForce getitem(int index) {
    TerrainForce ret = new TerrainForce(chrono_vehiclePINVOKE.TerrainForces_getitem(swigCPtr, index), false);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, TerrainForce val) {
    chrono_vehiclePINVOKE.TerrainForces_setitem(swigCPtr, index, TerrainForce.getCPtr(val));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(TerrainForces values) {
    chrono_vehiclePINVOKE.TerrainForces_AddRange(swigCPtr, TerrainForces.getCPtr(values));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public TerrainForces GetRange(int index, int count) {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.TerrainForces_GetRange(swigCPtr, index, count);
    TerrainForces ret = (cPtr == global::System.IntPtr.Zero) ? null : new TerrainForces(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, TerrainForce x) {
    chrono_vehiclePINVOKE.TerrainForces_Insert(swigCPtr, index, TerrainForce.getCPtr(x));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, TerrainForces values) {
    chrono_vehiclePINVOKE.TerrainForces_InsertRange(swigCPtr, index, TerrainForces.getCPtr(values));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    chrono_vehiclePINVOKE.TerrainForces_RemoveAt(swigCPtr, index);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    chrono_vehiclePINVOKE.TerrainForces_RemoveRange(swigCPtr, index, count);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public static TerrainForces Repeat(TerrainForce value, int count) {
    global::System.IntPtr cPtr = chrono_vehiclePINVOKE.TerrainForces_Repeat(TerrainForce.getCPtr(value), count);
    TerrainForces ret = (cPtr == global::System.IntPtr.Zero) ? null : new TerrainForces(cPtr, true);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    chrono_vehiclePINVOKE.TerrainForces_Reverse__SWIG_0(swigCPtr);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    chrono_vehiclePINVOKE.TerrainForces_Reverse__SWIG_1(swigCPtr, index, count);
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, TerrainForces values) {
    chrono_vehiclePINVOKE.TerrainForces_SetRange(swigCPtr, index, TerrainForces.getCPtr(values));
    if (chrono_vehiclePINVOKE.SWIGPendingException.Pending) throw chrono_vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
