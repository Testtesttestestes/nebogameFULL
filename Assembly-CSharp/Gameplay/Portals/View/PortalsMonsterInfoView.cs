using System;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.View
{
	// Token: 0x020005B0 RID: 1456
	[Token(Token = "0x20005B0")]
	public class PortalsMonsterInfoView : MonsterInfoView2
	{
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000661")]
		public Button ReturnButton
		{
			[Token(Token = "0x60022F3")]
			[Address(RVA = "0x7447", Offset = "0x7447", VA = "0x7447")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000662")]
		public Price ReturnPrice
		{
			[Token(Token = "0x60022F4")]
			[Address(RVA = "0x7448", Offset = "0x7448", VA = "0x7448")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x7449", Offset = "0x7449", VA = "0x7449")]
		public void SetLevel(uint level)
		{
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F6")]
		[Address(RVA = "0x744A", Offset = "0x744A", VA = "0x744A")]
		public PortalsMonsterInfoView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_View_PortalsMonsterInfoView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a580e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12144);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12145);
		    DAT_ram_00a580e4 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x2c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_12145,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x28) = uVar1;
		  iVar2 = *(int *)(param1 + 0x30);
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_12144,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x28) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400130B RID: 4875
		[Token(Token = "0x400130B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ButtonWithCost _returnButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ReturnButton ---
		undefined4
		Gameplay_Portals_View_PortalsMonsterInfoView__get_ReturnButton(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x30) + 0xb8);
		}
		*/


		/* --- GHIDRA: get_ReturnPrice ---
		void Gameplay_Portals_View_PortalsMonsterInfoView__get_ReturnPrice
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a580e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2621);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28682);
		    DAT_ram_00a580e3 = '\x01';
		  }
		  param1_00 = Gameplay_Isles_User_View_MonsterInfoView2__get_TitledList(param1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2621,1,0,1,0,0,0,0);
		  local_4 = param2;
		  param3_00 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28682,uVar1,param3_00,0);
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(param1_00,uVar1,0);
		  return;
		}
		*/

}
