using System;
using System.Collections;
using Gameplay.Clans.Buildings.Golem.Controller;
using Gameplay.Inventory.View.Chest;
using Il2CppDummyDll;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AC5 RID: 2757
	[Token(Token = "0x2000AC5")]
	public class GolemInventoryChestWindow : InventoryChestWindow
	{
		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D17")]
		public override string WindowId
		{
			[Token(Token = "0x600427B")]
			[Address(RVA = "0x912F", Offset = "0x912F", VA = "0x912F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427C")]
		[Address(RVA = "0x9130", Offset = "0x9130", VA = "0x9130")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Buildings_Golem_View_GolemInventoryChestWindow__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5783d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_InventoryChestWindowOptions__Awake__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5783d = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,Method_UI_Windows_ClosableBaseWindow_InventoryChestWindowOptions__Awake__);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x238);
		        goto code_r0x80de7362;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80de7362:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param2_00 = *(undefined4 *)(iVar4 + 0x10);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x238);
		        goto code_r0x80de7411;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80de7411:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param3 = *(undefined4 *)(iVar4 + 0x18);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x238);
		        goto code_r0x80de74c0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80de74c0:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryViewMediator_TypeInfo
		                        );
		  Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryController___c__DisplayClass14_0___MoveItemToChest_b__0
		            (param1_00,param2_00,param3,param4,0);
		  *(undefined4 *)(param1 + 0x54) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600427D RID: 17021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427D")]
		[Address(RVA = "0x9131", Offset = "0x9131", VA = "0x9131", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		int Gameplay_Clans_Buildings_Golem_View_GolemInventoryChestWindow__Awake
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5783e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_View_GolemInventoryChestWindow__Start_d__6_TypeInfo);
		    DAT_ram_00a5783e = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Buildings_Golem_View_GolemInventoryChestWindow__Start_d__6_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600427E RID: 17022 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600427E")]
		[Address(RVA = "0x9132", Offset = "0x9132", VA = "0x9132")]
		private IEnumerator Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Clans_Buildings_Golem_View_GolemInventoryChestWindow__Start
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Inventory_View_Chest_UserInventoryChestWindow__Start(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427F")]
		[Address(RVA = "0x9133", Offset = "0x9133", VA = "0x9133")]
		public GolemInventoryChestWindow()
		{
		}

		// Token: 0x040024AD RID: 9389
		[Token(Token = "0x40024AD")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Golem/GolemInventoryWindow";

		// Token: 0x040024AE RID: 9390
		[Token(Token = "0x40024AE")]
		[FieldOffset(Offset = "0x54")]
		private GolemInventoryViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Clans_Buildings_Golem_View_GolemInventoryChestWindow__get_WindowId
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x54);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x54) = 0;
		  return;
		}
		*/

}
