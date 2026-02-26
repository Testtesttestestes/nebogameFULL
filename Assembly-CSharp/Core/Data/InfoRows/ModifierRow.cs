using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Data.InfoRows
{
	// Token: 0x020010E3 RID: 4323
	[Token(Token = "0x20010E3")]
	public class ModifierRow : CommonRow
	{
		// Token: 0x06006523 RID: 25891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006523")]
		[Address(RVA = "0xB0F3", Offset = "0xB0F3", VA = "0xB0F3")]
		private ModifierRow(ModifierData modifier)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Data_InfoRows_ModifierRow___ctor
		              (undefined4 param1,int param2,int param3,int param4,int param5,undefined4 param6)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6083c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ModifierRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15116);
		    DAT_ram_00a6083c = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Data_InfoRows_ModifierRow_TypeInfo);
		  *(int *)(iVar1 + 0x1c) = param5;
		  *(int *)(iVar1 + 0x18) = param4;
		  *(int *)(iVar1 + 0x14) = param3;
		  *(int *)(iVar1 + 0x10) = param2;
		  *(undefined4 *)(iVar1 + 8) = 4;
		  *(undefined4 *)(iVar1 + 0x20) = param1;
		  if (param2 != 0) {
		    uVar2 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId(param2,0);
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  }
		  if (param3 != 0) {
		    uVar2 = Core_Extensions_Dict_DictExt__GetArtikul(*(undefined4 *)(*(int *)(param3 + 8) + 0x10),0)
		    ;
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  }
		  if (param4 != 0) {
		    uVar2 = func_ii_14054(param4,0);
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  }
		  if (param5 != 0) {
		    *(undefined4 *)(iVar1 + 0xc) = StringLiteral_15116;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06006524 RID: 25892 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006524")]
		[Address(RVA = "0xB0F4", Offset = "0xB0F4", VA = "0xB0F4")]
		public static ModifierRow Create(ModifierData mod, SpellDic spellDic, ArtikulData artikul, MedalDic medalDic, ClanLeagueDic clanLeagueDic)
		{
		/* --- GHIDRA: Create ---
		void Core_Data_InfoRows_ModifierRow__Create
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined4 *)(param1 + 8) = 5;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0400360C RID: 13836
		[Token(Token = "0x400360C")]
		[FieldOffset(Offset = "0x10")]
		public SpellDic SpellDic;

		// Token: 0x0400360D RID: 13837
		[Token(Token = "0x400360D")]
		[FieldOffset(Offset = "0x14")]
		public ArtikulData Artikul;

		// Token: 0x0400360E RID: 13838
		[Token(Token = "0x400360E")]
		[FieldOffset(Offset = "0x18")]
		public MedalDic MedalDic;

		// Token: 0x0400360F RID: 13839
		[Token(Token = "0x400360F")]
		[FieldOffset(Offset = "0x1C")]
		public ClanLeagueDic ClanLeagueDic;

		// Token: 0x04003610 RID: 13840
		[Token(Token = "0x4003610")]
		[FieldOffset(Offset = "0x20")]
		public readonly ModifierData Modifier;
	}
}
