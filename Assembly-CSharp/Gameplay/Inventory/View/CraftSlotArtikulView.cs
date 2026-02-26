using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Craft;

namespace Gameplay.Inventory.View
{
	// Token: 0x0200065E RID: 1630
	[Token(Token = "0x200065E")]
	public sealed class CraftSlotArtikulView : ArtikulView
	{
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077B")]
		public override ArtikulData Data
		{
			[Token(Token = "0x6002797")]
			[Address(RVA = "0x78C8", Offset = "0x78C8", VA = "0x78C8", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002798")]
			[Address(RVA = "0x78C9", Offset = "0x78C9", VA = "0x78C9", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002799")]
		[Address(RVA = "0x78CA", Offset = "0x78CA", VA = "0x78CA")]
		public void SetData(CraftSchemeData.CraftSchemeInfo schemeInfo, UserCraftSlotInfo info)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Inventory_View_CraftSlotArtikulView__SetData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtikulData__set_Data__);
		    DAT_ram_00a5a0a4 = '\x01';
		  }
		  UI_AbstractDataRenderer_object___remove_DataChangedEvent
		            (param1,0,Method_UI_AbstractDataRenderer_ArtikulData__set_Data__);
		  return;
		}
		*/

		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600279A")]
		[Address(RVA = "0x78CB", Offset = "0x78CB", VA = "0x78CB", Slot = "10")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Inventory_View_CraftSlotArtikulView__Dispose(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a099 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtikulData___ctor__);
		    DAT_ram_00a5a099 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x44) = 1;
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_ArtikulData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x78CC", Offset = "0x78CC", VA = "0x78CC")]
		public CraftSlotArtikulView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_CraftSlotArtikulView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a0a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_EquipmentSlotView__TypeInfo);
		    DAT_ram_00a5a0a5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_EquipmentSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_EquipmentSlotView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Inventory_View_CraftSlotArtikulView__get_Data
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_17312);
		  System_NonSerializedAttribute___ctor(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Gameplay_Inventory_View_CraftSlotArtikulView_set_Data__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Inventory_View_CraftSlotArtikulView__set_Data
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a0a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtikulData__set_Data__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    DAT_ram_00a5a0a3 = '\x01';
		  }
		  local_8 = 0;
		  System_Data_SqlTypes_SqlInt32___ctor
		            (&local_8,*(undefined4 *)(param3 + 0x28),Method_System_Nullable_int___ctor__);
		  *(undefined1 *)(param1 + 0x38) = 1;
		  *(undefined8 *)(param1 + 0x3c) = local_8;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1,0);
		  UI_AbstractDataRenderer_object___remove_DataChangedEvent
		            (param1,*(undefined4 *)(param2 + 0x10),
		             Method_UI_AbstractDataRenderer_ArtikulData__set_Data__);
		  return;
		}
		*/

}
