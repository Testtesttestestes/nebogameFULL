using System;
using Core.Data;
using Il2CppDummyDll;
using MVC;
using UI.Elements;
using UI.Windows.Buildings.ShopWindow;

namespace Gameplay.Shop
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	public class ShopViewMediator : AbstractViewMediator<ShopModel, ShopEvents, ShopController, ShopWindow>
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205F")]
		[Address(RVA = "0x71C4", Offset = "0x71C4", VA = "0x71C4")]
		public ShopViewMediator(ShopModel model, ShopEvents events, ShopController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Shop_ShopViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58314 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ShopModel__ShopEvents__ShopController__ShopWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ShopModel__ShopEvents__ShopController__ShopWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_int__ShopItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopViewMediator_OnSelectSlotEvent__);
		    DAT_ram_00a58314 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_int__ShopItem__TypeInfo);
		    System_Action_int__int___Invoke
		              (uVar3,param1,Method_Gameplay_Shop_ShopViewMediator_OnSelectSlotEvent__,0);
		    UI_Windows_Buildings_ShopWindow_ShopWindow__add_SelectSlotEvent(uVar1,uVar3,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_int__ShopItem__TypeInfo);
		    System_Action_int__int___Invoke
		              (uVar3,param1,Method_Gameplay_Shop_ShopViewMediator_OnSelectSlotEvent__,0);
		    UI_Windows_Buildings_ShopWindow_ShopWindow__get_GoldItems(uVar1,uVar3,0);
		    Gameplay_Shop_ShopModel___ctor(param1[2],param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(iVar2 + 0x1c) != '\0') {
		      Gameplay_Shop_ShopViewMediator__set_Events(param1,param1);
		      Gameplay_Shop_ShopViewMediator__InitEventHandler(param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170005E7 RID: 1511
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E7")]
		public override ShopWindow View
		{
			[Token(Token = "0x6002060")]
			[Address(RVA = "0x71C5", Offset = "0x71C5", VA = "0x71C5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E8")]
		public override ShopEvents Events
		{
			[Token(Token = "0x6002061")]
			[Address(RVA = "0x71C6", Offset = "0x71C6", VA = "0x71C6", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002062")]
		[Address(RVA = "0x71C7", Offset = "0x71C7", VA = "0x71C7")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Shop_ShopViewMediator__Init(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Shop_ShopViewMediator__set_Events(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002063")]
		[Address(RVA = "0x71C8", Offset = "0x71C8", VA = "0x71C8")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_Shop_ShopViewMediator__InitEventHandler(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58317 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ShopModel__ShopEvents__ShopController__ShopWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Skip_ShopArtifactDataDecorator___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Take_ShopArtifactDataDecorator___);
		    DAT_ram_00a58317 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = param1[2];
		  uVar4 = *(undefined4 *)(iVar3 + 0xc);
		  uVar2 = System_Linq_Enumerable__Sum___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(iVar3 + 0x2c),*(undefined4 *)(*(int *)(iVar3 + 0x18) + 0x10),
		                     Method_System_Linq_Enumerable_Take_ShopArtifactDataDecorator___);
		  UI_Windows_Buildings_ShopWindow_ShopWindow__Init(uVar1,uVar4,uVar2,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = param1[2];
		  uVar4 = *(undefined4 *)(iVar3 + 0xc);
		  uVar2 = System_Linq_Enumerable__SingleOrDefault___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(iVar3 + 0x2c),*(undefined4 *)(iVar3 + 0x24),
		                     Method_System_Linq_Enumerable_Skip_ShopArtifactDataDecorator___);
		  UI_Windows_Buildings_ShopWindow_ShopWindow__UpdateCommonItems
		            (uVar1,uVar4,uVar2,(uint)*(byte *)(param1[2] + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002064")]
		[Address(RVA = "0x71C9", Offset = "0x71C9", VA = "0x71C9")]
		private void ItemsUpdatedEventHandler()
		{
		/* --- GHIDRA: ItemsUpdatedEventHandler ---
		void Gameplay_Shop_ShopViewMediator__ItemsUpdatedEventHandler
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58318 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ShopModel__ShopEvents__ShopController__ShopWindow__get_Model__
		              );
		    DAT_ram_00a58318 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 8);
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar3 + 8),0);
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar3 + 0xc),0);
		  if (((lVar1 == lVar2) && (iVar3 = *(int *)(param3 + 0x40), iVar3 != 0)) &&
		     ((iVar3 == 1 || (iVar3 != 2)))) {
		    *(undefined4 *)(*(int *)(param1 + 8) + 0x28) = param2;
		    Gameplay_Shop_ShopViewMediator__OnSelectSlotEvent(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002065")]
		[Address(RVA = "0x71CA", Offset = "0x71CA", VA = "0x71CA")]
		private void OnSelectSlotEvent(int shopSlotId, ShopItem shopItem)
		{
		/* --- GHIDRA: OnSelectSlotEvent ---
		void Gameplay_Shop_ShopViewMediator__OnSelectSlotEvent(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  int *param1_03;
		  int iVar3;
		  
		  if (DAT_ram_00a58319 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopViewMediator_FilterShopArtifacts__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__791A3409E059F1AD29ACBF661081E4AB8EE384A43D34B8A54A5F59F05AED4F27
		              );
		    DAT_ram_00a58319 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_03 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_03;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80ed07f7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_03,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80ed07f7:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_03,puVar2[1]);
		  param1_01 = Mono_Security_ASN1Convert__ToOid
		                        (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,3);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (param1_01,
		             Field__PrivateImplementationDetails__791A3409E059F1AD29ACBF661081E4AB8EE384A43D34B8A54A5F59F05AED4F27
		             ,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 0x1d;
		  param1_02 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		                        );
		  Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		            (param1_02,param1,Method_Gameplay_Shop_ShopViewMediator_FilterShopArtifacts__,0);
		  Core_Gameplay_Managers_Inventory_InventoryManager__DismantleArtifact
		            (param1_00,param1_01,iVar3,param1_02,0);
		  return;
		}
		*/

		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002066")]
		[Address(RVA = "0x71CB", Offset = "0x71CB", VA = "0x71CB")]
		private void SelectArtifactFromInventory()
		{
		/* --- GHIDRA: SelectArtifactFromInventory ---
		undefined4
		Gameplay_Shop_ShopViewMediator__SelectArtifactFromInventory
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Data_ArtikulData__get_ShowDismantleAlert(param2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x6002067")]
		[Address(RVA = "0x71CC", Offset = "0x71CC", VA = "0x71CC")]
		private bool FilterShopArtifacts(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		private const string MY_SHOP_TIP = "SHOP/MY_SHOP_TIP";

		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x40011AD")]
		private const string ANOTHER_SHOP_TIP = "SHOP/ANOTHER_SHOP_TIP";

		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x40011AE")]
		private const string MY_ITEMS_TIP = "SHOP/MY_ITEMS_TIP";

		// Token: 0x040011AF RID: 4527
		[Token(Token = "0x40011AF")]
		private const string ANOTHER_ITEMS_TIP = "SHOP/ANOTHER_ITEMS_TIP";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Shop_ShopViewMediator__set_View(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58315 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ShopModel__ShopEvents__ShopController__ShopWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopViewMediator_InitEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopViewMediator_ItemsUpdatedEventHandler__);
		    DAT_ram_00a58315 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Shop_ShopViewMediator_InitEventHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Shop_ShopViewMediator_ItemsUpdatedEventHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Shop_ShopViewMediator_InitEventHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Shop_ShopViewMediator_ItemsUpdatedEventHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Shop_ShopViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  longlong lVar5;
		  longlong lVar6;
		  longlong lVar7;
		  int iVar8;
		  undefined4 param1_01;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58316 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ShopModel__ShopEvents__ShopController__ShopWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13812);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13815);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13813);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13814);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25504);
		    DAT_ram_00a58316 = '\x01';
		  }
		  iVar8 = param1[2];
		  lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar8 + 8),0);
		  lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar8 + 0xc),0);
		  uVar2 = StringLiteral_13815;
		  uVar1 = StringLiteral_13813;
		  iVar8 = param1[2];
		  lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar8 + 8),0);
		  lVar7 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar8 + 0xc),0);
		  param1_01 = StringLiteral_13814;
		  uVar3 = StringLiteral_13812;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  if (lVar4 != lVar5) {
		    uVar2 = uVar1;
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  iVar8 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar2 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                    (*(undefined4 *)(param1[2] + 8),0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_25504,uVar2,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar8 + 0x10) = local_8;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,iVar8,0);
		  UI_Windows_Buildings_ShopWindow_ShopWindow__UpdateGoldItems(param1_00,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (lVar6 != lVar7) {
		    param1_01 = uVar3;
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(param1_01,1,0,1,0,0,0,0);
		  UI_Windows_Buildings_ShopWindow_ShopWindow__SetShopTip(uVar1,uVar3,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Windows_Buildings_ShopWindow_ShopWindow__OnShopItemClick
		            (uVar3,*(undefined4 *)(param1[2] + 0x24),*(undefined4 *)(param1[2] + 0x1c),0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Windows_Buildings_ShopWindow_ShopWindow__SetItemsTip(uVar3,1,0);
		  return;
		}
		*/


		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Competition_Control_Sections_ShopViewMediator__SetupEvents
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b0d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_ShopViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_ShopViewMediator_BankOptionsListViewOnFaqButtonClickedEvent__
		              );
		    DAT_ram_00a63b0d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Competition_Control_Sections_ShopViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		             ,0);
		  Gameplay_Bank_View_BankOptionsListView__add_BuyButtonClickedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_BankOptionView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Competition_Control_Sections_ShopViewMediator_BankOptionsListViewOnFaqButtonClickedEvent__
		             ,0);
		  Gameplay_Bank_View_BankOptionsListView__add_FaqButtonClickedEvent(uVar3,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: ResetView ---
		void Gameplay_Competition_Control_Sections_ShopViewMediator__ResetView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a63b0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ShopModel__ShopEvents__ShopController__ShopView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_ShopViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_ShopViewMediator_BankOptionsListViewOnFaqButtonClickedEvent__
		              );
		    DAT_ram_00a63b0e = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x24);
		  uVar3 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Competition_Control_Sections_ShopViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		             ,0);
		  Gameplay_Bank_View_BankOptionView___ctor(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x24);
		  uVar3 = unnamed_function_1417(System_Action_BankOptionView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Competition_Control_Sections_ShopViewMediator_BankOptionsListViewOnFaqButtonClickedEvent__
		             ,0);
		  Gameplay_Bank_View_BankOptionsListView__remove_BuyButtonClickedEvent(uVar5,uVar3,0);
		  param1_00 = *(int **)(*(int *)(*(int *)(param1[2] + 0x14) + 0xc) + 0x2c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x268);
		        goto code_r0x8233ede4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x8233ede4:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  uVar3 = *(undefined4 *)(iVar2 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Cysharp_Threading_Tasks_Triggers_AsyncTriggerBase_AsyncTriggerEnumerator_float____cctor
		            (*(undefined4 *)(iVar2 + 0x24),uVar3,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Bank_View_BankOptionsListView__get_Data
		            (*(undefined4 *)(iVar2 + 0x24),*(undefined4 *)(param1[2] + 0x18),0);
		  return;
		}
		*/


		/* --- GHIDRA: SetupView ---
		void Gameplay_Competition_Control_Sections_ShopViewMediator__SetupView
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int iVar4;
		  
		  if (DAT_ram_00a63b0f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_IBankOptionView_TypeInfo);
		    DAT_ram_00a63b0f = '\x01';
		  }
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Bank_View_IBankOptionView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8233eeef;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Bank_View_IBankOptionView_TypeInfo,0);
		code_r0x8233eeef:
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		  Gameplay_Bank_Controller_BankController__RequestActivePromotions
		            (*(undefined4 *)(iVar4 + 0x10),param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: BankOptionsListViewOnBuyButtonClickedEvent ---
		void Gameplay_Competition_Control_Sections_ShopViewMediator__BankOptionsListViewOnBuyButtonClickedEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a63b10 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ShopModel__ShopEvents__ShopController__ShopView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63b10 = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x14) + 0xc) + 0x2c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 400);
		        goto code_r0x8233efc6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x8233efc6:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x130) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x134));
		  Core_Gameplay_Managers_BankManager__ShowBankWindow(param1_00,param2_00,0);
		  return;
		}
		*/

}
