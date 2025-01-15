// Type: ns0.Class0
// Assembly: JungleFlasher, Version=1.0.5004.40451, Culture=neutral, PublicKeyToken=7240d12d147b2b97
// MVID: 86B778B8-1293-454B-A759-8F0EBE32074A
// Assembly location: C:\Documents and Settings\User\Desktop\JungleFlasher-cleaned.exe

using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ns0
{
  internal class Class0
  {
    private Mutex mutex_0;

    public Class0(string string_0)
    {
      this.mutex_0 = new Mutex(false, string_0);
    }

    ~Class0()
    {
      try
      {
        this.mutex_0.ReleaseMutex();
      }
      catch (Exception ex)
      {
      }
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool method_0()
    {
      return !this.mutex_0.WaitOne(10, true);
    }

    public void method_1()
    {
      GC.SuppressFinalize((object) this);
      // ISSUE: explicit finalizer call
      this.Finalize();
    }
  }
}
