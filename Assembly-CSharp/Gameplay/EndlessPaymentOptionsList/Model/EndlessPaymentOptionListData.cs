using System;
using Il2CppDummyDll;
using Protocol.Dic;
using Utils;

namespace Gameplay.EndlessPaymentOptionsList.Model
{
	// Token: 0x02000846 RID: 2118
	[Token(Token = "0x2000846")]
	public class EndlessPaymentOptionListData
	{
		// Token: 0x060031CA RID: 12746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CA")]
		[Address(RVA = "0x8221", Offset = "0x8221", VA = "0x8221")]
		public EndlessPaymentOptionListData(EndlessPaymentOptionListDic dic, BackTime backTime)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionListData___ctor
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57646 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57646 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80dbcf20;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dbcf20:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x04001B4E RID: 6990
		[Token(Token = "0x4001B4E")]
		[FieldOffset(Offset = "0x8")]
		public readonly EndlessPaymentOptionListDic ListDic;

		// Token: 0x04001B4F RID: 6991
		[Token(Token = "0x4001B4F")]
		[FieldOffset(Offset = "0xC")]
		public readonly BackTime BackTime;
	}
}
