using System;
using Com.TheFallenGames.OSA.Core;
using Gameplay.Bank.View;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.View.Picker
{
	// Token: 0x02000502 RID: 1282
	[Token(Token = "0x2000502")]
	public class BankOptionPickerOsaViewHolder : BaseItemViewsHolder
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x7011", Offset = "0x7011", VA = "0x7011", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x7012", Offset = "0x7012", VA = "0x7012")]
		public BankOptionPickerOsaViewHolder()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_SpecialOffers_View_Picker_BankOptionPickerOsaViewHolder___ctor
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5862d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5862d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f16599;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f16599:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x040010A2 RID: 4258
		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x14")]
		public BankOptionListElement BankOption;
	}
}
