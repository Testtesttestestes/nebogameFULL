using System;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity.Ads
{
	// Token: 0x0200134E RID: 4942
	[Token(Token = "0x200134E")]
	public static class AdFormat
	{
		// Token: 0x04003D50 RID: 15696
		[Token(Token = "0x4003D50")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string Banner;

		// Token: 0x04003D51 RID: 15697
		[Token(Token = "0x4003D51")]
		[FieldOffset(Offset = "0x4")]
		public static readonly string Interstitial;

		// Token: 0x04003D52 RID: 15698
		[Token(Token = "0x4003D52")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string Native;

		// Token: 0x04003D53 RID: 15699
		[Token(Token = "0x4003D53")]
		[FieldOffset(Offset = "0xC")]
		public static readonly string Rewarded;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		undefined4
		Mycom_Tracker_Unity_Ads_AdFormat___cctor(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a59715 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a59715 = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                    (piVar2,param1,param2,*(undefined4 *)(*piVar2 + 0xec));
		  return uVar1;
		}
		*/

}
