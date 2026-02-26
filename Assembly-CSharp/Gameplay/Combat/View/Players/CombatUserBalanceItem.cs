using System;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x0200094C RID: 2380
	[Token(Token = "0x200094C")]
	[Serializable]
	public class CombatUserBalanceItem
	{
		// Token: 0x0600385C RID: 14428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385C")]
		[Address(RVA = "0x8813", Offset = "0x8813", VA = "0x8813")]
		public CombatUserBalanceItem()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Players_CombatUserBalanceItem___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  undefined4 param1_01;
		  int iVar8;
		  int *piVar9;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a566fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a566fc = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar4) {
		    do {
		      iVar5 = *(int *)(*(int *)(param1 + 0x10) + iVar8 * 4 + 0x10);
		      iVar6 = *(int *)(iVar5 + 0xc);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *param1_00;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		            puVar2 = (uint *)(piVar9[1] * 8 + iVar7 + 0x178);
		            goto code_r0x80c6c4ee;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80c6c4ee:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      uVar3 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar3,*(undefined4 *)(iVar5 + 8),0);
		      *(undefined4 *)(iVar6 + 0x20) = uVar3;
		      param1_01 = *(undefined4 *)(iVar6 + 0x10);
		      uVar3 = func_ii_7611(uVar3,0);
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_01,uVar3,0);
		      iVar8 = iVar8 + 1;
		    } while (iVar8 != iVar4);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001F31 RID: 7985
		[Token(Token = "0x4001F31")]
		[FieldOffset(Offset = "0x8")]
		public Resources ResourceId;

		// Token: 0x04001F32 RID: 7986
		[Token(Token = "0x4001F32")]
		[FieldOffset(Offset = "0xC")]
		public CombatUserBalanceItemRenderer ItemRenderer;
	}
}
