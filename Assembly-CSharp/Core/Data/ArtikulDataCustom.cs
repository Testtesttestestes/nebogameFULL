using System;
using Core.Dict;
using Il2CppDummyDll;

namespace Core.Data
{
	// Token: 0x020010B6 RID: 4278
	[Token(Token = "0x20010B6")]
	public class ArtikulDataCustom : ArtikulData
	{
		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060063B4 RID: 25524 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x170013FE")]
		public override int CurrentDurability
		{
			[Token(Token = "0x60063B4")]
			[Address(RVA = "0xAFB6", Offset = "0xAFB6", VA = "0xAFB6", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B5")]
		[Address(RVA = "0xAFB7", Offset = "0xAFB7", VA = "0xAFB7")]
		public void SetCurrentDurability(int value)
		{
		/* --- GHIDRA: SetCurrentDurability ---
		undefined4
		Core_Data_ArtikulDataCustom__SetCurrentDurability(undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  uint *param4;
		  undefined4 param2_00;
		  int iVar1;
		  uint uVar2;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a607a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtikulDataCustom_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a607a1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Data_ArtikulDataCustom_TypeInfo);
		  Core_Data_ArtikulData__set_TempItemCriticalTtl(param1_00,0);
		  iVar1 = *param2;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8)) {
		        param4 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8 + 4) * 8 + iVar1 + 0xd8);
		        goto code_r0x81ce190b;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		  }
		  param4 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x81ce190b:
		  iVar1 = (**(code **)((ulonglong)*param4 * 4))(param2,param4[1]);
		  param2_00 = func_ii_7730(*(undefined4 *)(iVar1 + 8),param1,
		                           Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_ArtikulDicWrapper__uint__GetWrapper__
		                          );
		  Core_Data_ArtikulData__get_MiddleBgSubstrateAssetId(param1_00,param2_00,param2,param4);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60063B6")]
		[Address(RVA = "0xAFB8", Offset = "0xAFB8", VA = "0xAFB8")]
		public new static ArtikulDataCustom Create(uint artikulId, IDictProvider provider)
		{
		/* --- GHIDRA: Create ---
		void Core_Data_ArtikulDataCustom__Create(undefined4 param1,undefined4 param2)
		
		{
		  Core_Data_ArtikulData__set_TempItemCriticalTtl(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063B7")]
		[Address(RVA = "0xAFB9", Offset = "0xAFB9", VA = "0xAFB9")]
		public ArtikulDataCustom()
		{
		}

		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x38")]
		private int _currentDurability;
	}
}
