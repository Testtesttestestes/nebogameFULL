using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol;
using Protocol.Themeduel;
using UI;
using UI.Price;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.ThemeDuel.View.ShopTab
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	[DisallowMultipleComponent]
	public class ThemeDuelShopItemView : AbstractDataRenderer<EventStoreItem>, IPointerEnterHandler, IEventSystemHandler, IToolTipDataProvider, IPointerClickHandler, IArtifactView
	{
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000555")]
		public IActionInfo Info
		{
			[Token(Token = "0x6001DBD")]
			[Address(RVA = "0x6F3B", Offset = "0x6F3B", VA = "0x6F3B", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DBE")]
			[Address(RVA = "0x6F3C", Offset = "0x6F3C", VA = "0x6F3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000556")]
		public BackTime Backtime
		{
			[Token(Token = "0x6001DBF")]
			[Address(RVA = "0x6F3D", Offset = "0x6F3D", VA = "0x6F3D", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DC0")]
			[Address(RVA = "0x6F3E", Offset = "0x6F3E", VA = "0x6F3E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x17000557")]
		public bool OnlyMarketAccount
		{
			[Token(Token = "0x6001DC1")]
			[Address(RVA = "0x6F3F", Offset = "0x6F3F", VA = "0x6F3F", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000558")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6001DC2")]
			[Address(RVA = "0x6F40", Offset = "0x6F40", VA = "0x6F40", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x000063A8 File Offset: 0x000045A8
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000559")]
		public ArtifactView.ArtifactViewArgs Args
		{
			[Token(Token = "0x6001DC3")]
			[Address(RVA = "0x6F41", Offset = "0x6F41", VA = "0x6F41", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x6001DC4")]
			[Address(RVA = "0x6F42", Offset = "0x6F42", VA = "0x6F42", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700055A")]
		public GameObject GameObject
		{
			[Token(Token = "0x6001DC5")]
			[Address(RVA = "0x6F43", Offset = "0x6F43", VA = "0x6F43", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x6F44", Offset = "0x6F44", VA = "0x6F44", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x6F45", Offset = "0x6F45", VA = "0x6F45", Slot = "20")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		int Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__OnPointerEnter
		              (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param4;
		  undefined4 param1_01;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a585c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_ToolTipData_IItemInformationProvider__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12536);
		    DAT_ram_00a585c5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12536,
		             Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80f0ef7f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0ef7f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80f0f031;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0f031:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param4 = Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__get_Marker
		                     (*(undefined4 *)(iVar6 + 0xc),uVar4);
		  param1_01 = unnamed_function_1417(Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		  Gameplay_Inventory_Model_InventoryUtils___ctor(param1_01,uVar3,uVar4,param4,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x6F46", Offset = "0x6F46", VA = "0x6F46", Slot = "21")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700055B")]
		public Image Marker
		{
			[Token(Token = "0x6001DC9")]
			[Address(RVA = "0x6F47", Offset = "0x6F47", VA = "0x6F47")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x6F48", Offset = "0x6F48", VA = "0x6F48")]
		private static ArtifactData GetArtifactData(ArtifactDetails artifactDetails)
		{
		/* --- GHIDRA: GetArtifactData ---
		void Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__GetArtifactData
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param3_00;
		  undefined4 param2_00;
		  undefined8 local_18;
		  undefined8 local_10 [2];
		  
		  if (DAT_ram_00a585c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ContextMenu_ContextMenuController_Show_ItemContextMenuOptions__ArtifactContextMenu___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ContextMenu_ItemContextMenuOptions_TypeInfo);
		    DAT_ram_00a585c7 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = Google_Protobuf_Reflection_EnumValueDescriptor__get_Name(uVar1,0);
		  param3_00 = unnamed_function_1417
		                        (Gameplay_Inventory_View_ContextMenu_ItemContextMenuOptions_TypeInfo);
		  *(undefined4 *)(param3_00 + 8) = param1;
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  func_ii_7888(local_10,param2_00,0);
		  local_18 = local_10[0];
		  UI_ContextMenu_ContextMenuController___Show_b__13_0___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (uVar1,2,param3_00,&local_18,
		             Method_UI_ContextMenu_ContextMenuController_Show_ItemContextMenuOptions__ArtifactContextMenu___
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0x6F49", Offset = "0x6F49", VA = "0x6F49", Slot = "22")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__OnPointerClick
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a585c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView_OnEventBalanceChanged__
		              );
		    DAT_ram_00a585c8 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x80f0f1fa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0f1fa:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  param1_01 = *(undefined4 *)(iVar6 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_long__TypeInfo);
		  System_Action_Int32Enum___Invoke
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView_OnEventBalanceChanged__,0)
		  ;
		  iVar5 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_long__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x20) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x20) = iVar4;
		    uVar3 = System_Action_long__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0x6F4A", Offset = "0x6F4A", VA = "0x6F4A", Slot = "17")]
		protected override void StartListenEvents(EventStoreItem data)
		{
		/* --- GHIDRA: StartListenEvents ---
		void Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__StartListenEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a585c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView_OnEventBalanceChanged__
		              );
		    DAT_ram_00a585c9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x80f0f358;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0f358:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  param1_01 = *(undefined4 *)(iVar6 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_long__TypeInfo);
		  System_Action_Int32Enum___Invoke
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView_OnEventBalanceChanged__,0)
		  ;
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_long__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x20) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x20) = iVar4;
		    uVar3 = System_Action_long__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_long__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCD")]
		[Address(RVA = "0x6F4B", Offset = "0x6F4B", VA = "0x6F4B", Slot = "18")]
		protected override void StopListenEvents(EventStoreItem data)
		{
		/* --- GHIDRA: StopListenEvents ---
		void Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__StopListenEvents
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,*(undefined4 *)(*param1 + 0x15c));
		  return;
		}
		*/

		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0x6F4C", Offset = "0x6F4C", VA = "0x6F4C")]
		private void OnEventBalanceChanged(long value)
		{
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700055C")]
		public IList<Sprite> MarkerSprites
		{
			[Token(Token = "0x6001DD0")]
			[Address(RVA = "0x6F4E", Offset = "0x6F4E", VA = "0x6F4E")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6001DCF")]
			[Address(RVA = "0x6F4D", Offset = "0x6F4D", VA = "0x6F4D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x6F4F", Offset = "0x6F4F", VA = "0x6F4F", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		/* --- GHIDRA: OnDataInvalidated ---
		void Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__OnDataInvalidated
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a585cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_EventStoreItem___ctor__);
		    DAT_ram_00a585cb = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_EventStoreItem___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD2")]
		[Address(RVA = "0x6F50", Offset = "0x6F50", VA = "0x6F50")]
		public ThemeDuelShopItemView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a585cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RulesView_RulesTabState___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RulesView_RulesTabState__set_CurrentState__);
		    DAT_ram_00a585cc = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_RulesView_RulesTabState___ctor__);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,0,Method_UI_MonoBehaviourWithStates_RulesView_RulesTabState__set_CurrentState__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PriceItemRenderer _price;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _marker;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OnlyMarketAccount ---
		undefined4
		Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__get_OnlyMarketAccount
		          (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__get_Marker
		                      (*(undefined4 *)(iVar1 + 0xc),param1);
		    return uVar2;
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_Marker ---
		int Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__get_Marker(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param3;
		  int *piVar6;
		  
		  if (DAT_ram_00a585c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtifactInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a585c6 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Protocol_Common_ArtifactInfo_TypeInfo);
		  Protocol_Common_ArtifactInfo__pb__Google_Protobuf_IMessage_get_Descriptor(iVar2,0);
		  iVar3 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(double *)(iVar3 + 0x28) = (double)*(ulonglong *)(param1 + 0x28);
		  *(int *)(iVar2 + 0x24) = iVar3;
		  *(undefined4 *)(iVar2 + 0x18) = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(iVar2 + 0x20) = *(undefined4 *)(param1 + 0x20);
		  *(undefined8 *)(iVar2 + 0x10) = *(undefined8 *)(param1 + 0x10);
		  Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		            (*(undefined4 *)(iVar2 + 0x1c),*(undefined4 *)(param1 + 0x1c),
		             Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		        goto code_r0x80f0ece7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0ece7:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x80f0ed99;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f0ed99:
		  param3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar2 = Core_Data_ArtifactData__IsGuideTarget(iVar2,uVar5,param3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		        goto code_r0x80f0ee4f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f0ee4f:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  *(undefined4 *)(iVar2 + 0x80) = 6;
		  *(undefined4 *)(iVar2 + 0x70) = uVar5;
		  return iVar2;
		}
		*/


		/* --- GHIDRA: get_MarkerSprites ---
		void Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__get_MarkerSprites
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 in_register_20000014;
		  undefined8 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  uint *puVar8;
		  float fVar9;
		  int iVar10;
		  int *piVar11;
		  ulonglong param1_00;
		  longlong lVar12;
		  uint uVar13;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a585ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Themeduel_ActionState_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_Sprite__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_Sprite__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16074);
		    DAT_ram_00a585ca = '\x01';
		  }
		  local_4 = 0;
		  UnityEngine_Object__op_Implicit(param1[0xb],0,0);
		  param1[0xc] = 0;
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x134));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		  if (iVar5 == 0) {
		    return;
		  }
		  iVar5 = 0;
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),param1);
		  uVar4 = CONCAT44((int)((ulonglong)uVar4 >> 0x20),*(undefined4 *)(*param1 + 0x134));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (*(int *)(iVar6 + 0x10) == 0) {
		    iVar6 = 0;
		  }
		  else {
		    uVar1 = CONCAT44(uVar2,param1);
		    uVar4 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x134));
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    iVar6 = Protocol_ActionInfoAdapter__Create(*(undefined4 *)(iVar6 + 0x10),0);
		  }
		  param1[0xc] = iVar6;
		  uVar1 = CONCAT44(uVar2,param1);
		  uVar4 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x134));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (*(int *)(iVar6 + 0x10) != 0) {
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(CONCAT44(uVar3,param1),uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    param1_00 = (ulonglong)*(uint *)(*(int *)(iVar5 + 0x10) + 0x20);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar9 = func_ii_7331(param1_00,0);
		    uVar3 = (undefined4)(param1_00 >> 0x20);
		    iVar5 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(iVar5,fVar9,0);
		  }
		  param1[0xd] = iVar5;
		  if (param1[0x12] != 0) {
		    uVar1 = CONCAT44(uVar3,param1);
		    uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (*(int *)(iVar5 + 0x10) != 0) {
		      uVar1 = CONCAT44(uVar3,param1);
		      uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		      uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		      uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      iVar5 = *(int *)(*(int *)(iVar5 + 0x10) + 0xc) + -1;
		      if (-1 < iVar5) {
		        piVar11 = (int *)param1[0x12];
		        iVar6 = *piVar11;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar13 = 0;
		          do {
		            if (System_Collections_Generic_ICollection_Sprite__TypeInfo ==
		                *(int *)(*(int *)(iVar6 + 0x58) + uVar13 * 8)) {
		              puVar8 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar13 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80f0f61c;
		            }
		            uVar13 = uVar13 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar13);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar11,
		                                      System_Collections_Generic_ICollection_Sprite__TypeInfo,0);
		code_r0x80f0f61c:
		        uVar1 = CONCAT44(uVar3,piVar11);
		        uVar4 = CONCAT44(uVar2,puVar8[1]);
		        iVar6 = (**(code **)((ulonglong)*puVar8 * 4))(uVar1,uVar4);
		        uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		        uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		        if (iVar5 < iVar6) {
		          uVar13 = 0;
		          iVar6 = param1[0xb];
		          piVar11 = (int *)param1[0x12];
		          iVar10 = *piVar11;
		          if (*(ushort *)(iVar10 + 0xb6) != 0) {
		            do {
		              if (System_Collections_Generic_IList_Sprite__TypeInfo ==
		                  *(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8)) {
		                puVar8 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x80f0f6ab;
		              }
		              uVar13 = uVar13 + 1;
		            } while (*(ushort *)(iVar10 + 0xb6) != uVar13);
		          }
		          puVar8 = (uint *)func_ii_1080(piVar11,System_Collections_Generic_IList_Sprite__TypeInfo,0)
		          ;
		code_r0x80f0f6ab:
		          uVar1 = CONCAT44(uVar3,piVar11);
		          uVar4 = CONCAT44(uVar2,iVar5);
		          uVar7 = (**(code **)((ulonglong)*puVar8 * 4))(uVar1,uVar4,puVar8[1]);
		          uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		          uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		          func_ii_7050(iVar6,uVar7,0);
		          goto code_r0x80f0f72e;
		        }
		      }
		      uVar1 = CONCAT44(uVar3,param1);
		      uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		      local_8 = *(undefined4 *)(*(int *)(iVar5 + 0x10) + 0xc);
		      uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		      uVar7 = func_ii_1081(Protocol_Themeduel_ActionState_TypeInfo,&local_8);
		      uVar7 = func_ii_4419(StringLiteral_16074,uVar7,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7109(uVar7,0);
		    }
		  }
		code_r0x80f0f72e:
		  piVar11 = (int *)param1[9];
		  uVar1 = CONCAT44(uVar3,param1);
		  uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar7 = Gameplay_ThemeDuel_View_ShopTab_ThemeDuelShopItemView__get_Marker
		                    (*(undefined4 *)(iVar5 + 0xc),param1);
		  iVar5 = *piVar11;
		  uVar1 = CONCAT44(uVar3,piVar11);
		  uVar4 = CONCAT44(uVar2,uVar7);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x138) * 4))(uVar1,uVar4,*(undefined4 *)(iVar5 + 0x13c))
		  ;
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar11 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar11;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar13 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar13 * 8)) {
		        puVar8 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar13 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x80f0f801;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar13);
		  }
		  puVar8 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0f801:
		  uVar1 = CONCAT44(uVar3,piVar11);
		  uVar4 = CONCAT44(uVar2,puVar8[1]);
		  iVar5 = (**(code **)((ulonglong)*puVar8 * 4))(uVar1,uVar4);
		  iVar6 = param1[10];
		  iVar5 = *(int *)(iVar5 + 0x14);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  fVar9 = func_ii_7103(*(undefined4 *)(iVar5 + 0x34),0);
		  if (0.0 < fVar9) {
		    uVar7 = *(undefined4 *)(iVar5 + 0x10);
		  }
		  else {
		    uVar7 = 0;
		  }
		  uVar7 = Core_Extensions_Dict_ThemeDuelDicExt__GetIconAssetId(uVar7,0);
		  UI_Price_PriceItemRenderer__SetIcon(iVar6,uVar7,0);
		  if (DAT_ram_00a58587 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		    DAT_ram_00a58587 = '\x01';
		  }
		  lVar12 = *(longlong *)(iVar5 + 0x20);
		  uVar1 = CONCAT44(uVar3,param1);
		  uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		  uVar13 = (uint)(*(longlong *)(*(int *)(iVar5 + 0xc) + 0x28) <= lVar12);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  UI_Price_PriceItemRenderer__set_TruncatePrice(param1[10],uVar13,0);
		  iVar5 = 0x24;
		  if (uVar13 == 0) {
		    iVar5 = 0x28;
		  }
		  local_4 = *(undefined4 *)(param1[10] + iVar5);
		  UI_Price_PriceItemRenderer__set_ResId(param1[10],&local_4,0);
		  iVar6 = param1[10];
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (CONCAT44(uVar3,param1),CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134)));
		  UI_Price_PriceItemRenderer__set_ValidIconEnabled
		            (iVar6,(double)*(ulonglong *)(*(int *)(iVar5 + 0xc) + 0x28),0);
		  return;
		}
		*/

}
