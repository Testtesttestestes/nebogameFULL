using System;
using Il2CppDummyDll;
using Mycom.Tracker.Unity.Internal.Interfaces;

namespace Mycom.Tracker.Unity.Internal
{
	// Token: 0x02001345 RID: 4933
	[Token(Token = "0x2001345")]
	internal static class PlatformFactory
	{
		// Token: 0x060074E2 RID: 29922 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60074E2")]
		[Address(RVA = "0xBEAE", Offset = "0xBEAE", VA = "0xBEAE")]
		internal static ITracker CreateTracker()
		{
			return null;
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60074E3")]
		[Address(RVA = "0xBEAF", Offset = "0xBEAF", VA = "0xBEAF")]
		internal static string GetInstanceId()
		{
		/* --- GHIDRA: GetInstanceId ---
		int Mycom_Tracker_Unity_Internal_PlatformFactory__GetInstanceId(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5970c == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTrackerParams_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Mycom_Tracker_Unity_Internal_Implementations_Fake_TrackerParams_TypeInfo);
		    DAT_ram_00a5970c = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Mycom_Tracker_Unity_Internal_Implementations_Fake_TrackerParams_TypeInfo);
		  iVar2 = unnamed_function_1417(Mycom_Tracker_Unity_MyTrackerParams_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  return iVar2;
		}
		*/

			return null;
		}
	}
}
