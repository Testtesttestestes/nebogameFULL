using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001392 RID: 5010
	[Token(Token = "0x2001392")]
	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
	{
		// Token: 0x06007745 RID: 30533 RVA: 0x00015BA0 File Offset: 0x00013DA0
		[Token(Token = "0x6007745")]
		[Address(RVA = "0xC0A6", Offset = "0xC0A6", VA = "0xC0A6", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
		/* --- GHIDRA: CanLocalize ---
		void I2_Loc_LocalizeTargetDesc_Prefab__CanLocalize(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60544 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_I2_Loc_LocalizeTargetDesc_LocalizeTarget_UnityStandard_Prefab___ctor__);
		    DAT_ram_00a60544 = '\x01';
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007746")]
		[Address(RVA = "0xC0A7", Offset = "0xC0A7", VA = "0xC0A7")]
		public LocalizeTargetDesc_Prefab()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LocalizeTargetDesc_Prefab___ctor(undefined4 param1)
		
		{
		  I2_Loc_LocalizeTarget_UnityStandard_Prefab___cctor(0);
		  return;
		}
		*/

		}
	}
}
