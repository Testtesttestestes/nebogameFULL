using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B0 RID: 1968
	[Token(Token = "0x20007B0")]
	public class PromotionTag_38 : AbstractTag
	{
		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x1700090B")]
		public uint PromoId
		{
			[Token(Token = "0x6002E98")]
			[Address(RVA = "0x7F13", Offset = "0x7F13", VA = "0x7F13")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0x7F14", Offset = "0x7F14", VA = "0x7F14")]
		public PromotionTag_38()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_GameEvents_Model_Tags_PromotionTag_38___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a574e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&double___TypeInfo);
		    DAT_ram_00a574e2 = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		  iVar1 = Mono_Security_ASN1Convert__ToOid(double___TypeInfo,param2_00);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  if (iVar2 != 0) {
		    iVar2 = 0;
		    do {
		      *(undefined8 *)(iVar1 + iVar2 * 8 + 0x10) = *(undefined8 *)(param1[5] + iVar2 * 8 + 0x10);
		      iVar2 = iVar2 + 1;
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		    } while ((longlong)iVar2 < (longlong)(ulonglong)uVar3);
		  }
		  return iVar1;
		}
		*/

		}
	}
}
