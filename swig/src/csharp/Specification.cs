/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Indri {

using System;
using System.Runtime.InteropServices;

public class Specification : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Specification(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Specification obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Specification() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          indri_csharpPINVOKE.delete_Specification(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public string name {
    set {
      indri_csharpPINVOKE.Specification_name_set(swigCPtr, value);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = indri_csharpPINVOKE.Specification_name_get(swigCPtr);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string parser {
    set {
      indri_csharpPINVOKE.Specification_parser_set(swigCPtr, value);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = indri_csharpPINVOKE.Specification_parser_get(swigCPtr);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string tokenizer {
    set {
      indri_csharpPINVOKE.Specification_tokenizer_set(swigCPtr, value);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = indri_csharpPINVOKE.Specification_tokenizer_get(swigCPtr);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string iterator {
    set {
      indri_csharpPINVOKE.Specification_iterator_set(swigCPtr, value);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = indri_csharpPINVOKE.Specification_iterator_get(swigCPtr);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string startDocTag {
    set {
      indri_csharpPINVOKE.Specification_startDocTag_set(swigCPtr, value);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = indri_csharpPINVOKE.Specification_startDocTag_get(swigCPtr);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string endDocTag {
    set {
      indri_csharpPINVOKE.Specification_endDocTag_set(swigCPtr, value);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = indri_csharpPINVOKE.Specification_endDocTag_get(swigCPtr);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string endMetadataTag {
    set {
      indri_csharpPINVOKE.Specification_endMetadataTag_set(swigCPtr, value);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = indri_csharpPINVOKE.Specification_endMetadataTag_get(swigCPtr);
      if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public StringVector include {
    set {
      indri_csharpPINVOKE.Specification_include_set(swigCPtr, StringVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = indri_csharpPINVOKE.Specification_include_get(swigCPtr);
      StringVector ret = (cPtr == IntPtr.Zero) ? null : new StringVector(cPtr, false);
      return ret;
    } 
  }

  public StringVector exclude {
    set {
      indri_csharpPINVOKE.Specification_exclude_set(swigCPtr, StringVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = indri_csharpPINVOKE.Specification_exclude_get(swigCPtr);
      StringVector ret = (cPtr == IntPtr.Zero) ? null : new StringVector(cPtr, false);
      return ret;
    } 
  }

  public StringVector index {
    set {
      indri_csharpPINVOKE.Specification_index_set(swigCPtr, StringVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = indri_csharpPINVOKE.Specification_index_get(swigCPtr);
      StringVector ret = (cPtr == IntPtr.Zero) ? null : new StringVector(cPtr, false);
      return ret;
    } 
  }

  public StringVector metadata {
    set {
      indri_csharpPINVOKE.Specification_metadata_set(swigCPtr, StringVector.getCPtr(value));
    } 
    get {
      IntPtr cPtr = indri_csharpPINVOKE.Specification_metadata_get(swigCPtr);
      StringVector ret = (cPtr == IntPtr.Zero) ? null : new StringVector(cPtr, false);
      return ret;
    } 
  }

  public ConfMap conflations {
    set {
      indri_csharpPINVOKE.Specification_conflations_set(swigCPtr, ConfMap.getCPtr(value));
    } 
    get {
      IntPtr cPtr = indri_csharpPINVOKE.Specification_conflations_get(swigCPtr);
      ConfMap ret = (cPtr == IntPtr.Zero) ? null : new ConfMap(cPtr, false);
      return ret;
    } 
  }

  public Specification() : this(indri_csharpPINVOKE.new_Specification(), true) {
  }

}

}