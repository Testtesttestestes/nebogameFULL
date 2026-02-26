using System;
using System.Collections;
using Gameplay.Inventory.Controller;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000690 RID: 1680
	[Token(Token = "0x2000690")]
	public class UserInventoryChestWindow : InventoryChestWindow
	{
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007AF")]
		public override string WindowId
		{
			[Token(Token = "0x6002895")]
			[Address(RVA = "0x79B4", Offset = "0x79B4", VA = "0x79B4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007B0")]
		public GameObject SaleIcon
		{
			[Token(Token = "0x6002896")]
			[Address(RVA = "0x79B5", Offset = "0x79B5", VA = "0x79B5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007B1")]
		public TextMeshProUGUI DiscountText
		{
			[Token(Token = "0x6002897")]
			[Address(RVA = "0x79B6", Offset = "0x79B6", VA = "0x79B6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002898")]
		[Address(RVA = "0x79B7", Offset = "0x79B7", VA = "0x79B7")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Inventory_View_Chest_UserInventoryChestWindow__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5a10c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_InventoryChestWindowOptions__Awake__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_InventoryChestViewMediator_TypeInfo)
		    ;
		    DAT_ram_00a5a10c = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		        goto code_r0x811cde09;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811cde09:
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		        goto code_r0x811cdeb8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811cdeb8:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param3 = *(undefined4 *)(iVar4 + 0x20);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		        goto code_r0x811cdf67;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811cdf67:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Inventory_Controller_InventoryChestViewMediator_TypeInfo);
		  if (DAT_ram_00a5a168 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UserInventoryChestWindow___ctor__
		              );
		    DAT_ram_00a5a168 = '\x01';
		  }
		  Gameplay_Inventory_Controller_InventoryBaseController_object__object___Unequip
		            (param1_00,param2_00,param3,param4,
		             Method_Gameplay_Inventory_Controller_InventoryBaseViewMediator_InventoryModel__InventoryEvents__InventoryController__UserInventoryChestWindow___ctor__
		            );
		  *(undefined4 *)(param1 + 0x5c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002899")]
		[Address(RVA = "0x79B8", Offset = "0x79B8", VA = "0x79B8", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		int Gameplay_Inventory_View_Chest_UserInventoryChestWindow__Awake
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a10d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Chest_UserInventoryChestWindow__Start_d__12_TypeInfo);
		    DAT_ram_00a5a10d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Inventory_View_Chest_UserInventoryChestWindow__Start_d__12_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600289A")]
		[Address(RVA = "0x79B9", Offset = "0x79B9", VA = "0x79B9")]
		private IEnumerator Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Inventory_View_Chest_UserInventoryChestWindow__Start
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_InventoryChestWindowOptions___ctor__);
		    DAT_ram_00a5a0ef = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_InventoryChestWindowOptions___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600289B")]
		[Address(RVA = "0x79BA", Offset = "0x79BA", VA = "0x79BA")]
		public UserInventoryChestWindow()
		{
		}

		// Token: 0x04001667 RID: 5735
		[Token(Token = "0x4001667")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/UserInventoryChestWindow";

		// Token: 0x04001668 RID: 5736
		[Token(Token = "0x4001668")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _saleIcon;

		// Token: 0x04001669 RID: 5737
		[Token(Token = "0x4001669")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _discountText;

		// Token: 0x0400166A RID: 5738
		[Token(Token = "0x400166A")]
		[FieldOffset(Offset = "0x5C")]
		private InventoryChestViewMediator _chestViewMediator;
	}
}
