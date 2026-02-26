using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Discounts.Model
{
	// Token: 0x0200089C RID: 2204
	[Token(Token = "0x200089C")]
	public class DiscountsProviderDecorator : IDiscountsProvider, IDisposable
	{
		// Token: 0x060033E7 RID: 13287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E7")]
		[Address(RVA = "0x841F", Offset = "0x841F", VA = "0x841F")]
		public void SetProviderImplementation(IDiscountsProvider provider)
		{
		/* --- GHIDRA: SetProviderImplementation ---
		undefined4
		Gameplay_Discounts_Model_DiscountsProviderDecorator__SetProviderImplementation
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57cc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo);
		    DAT_ram_00a57cc0 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e45d7a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,0);
		code_r0x80e45d7a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,param3,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x60033E8")]
		[Address(RVA = "0x8420", Offset = "0x8420", VA = "0x8420", Slot = "4")]
		public bool TryGetDiscount(DiscountTargets type, out DiscountData data)
		{
		/* --- GHIDRA: TryGetDiscount ---
		undefined4
		Gameplay_Discounts_Model_DiscountsProviderDecorator__TryGetDiscount
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57cc1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo);
		    DAT_ram_00a57cc1 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80e45e25;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Discounts_Model_IDiscountsProvider_TypeInfo,1);
		code_r0x80e45e25:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,param3,puVar2[1]);
		  return uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x60033E9")]
		[Address(RVA = "0x8421", Offset = "0x8421", VA = "0x8421", Slot = "5")]
		public bool TryGetDiscountCoeff(DiscountTargets target, out double discountCoeff)
		{
			return default(bool);
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EA")]
		[Address(RVA = "0x8422", Offset = "0x8422", VA = "0x8422", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x8423", Offset = "0x8423", VA = "0x8423")]
		public DiscountsProviderDecorator()
		{
		}

		// Token: 0x04001C48 RID: 7240
		[Token(Token = "0x4001C48")]
		[FieldOffset(Offset = "0x8")]
		private IDiscountsProvider _provider;
	}
}
