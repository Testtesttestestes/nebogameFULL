using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using Protocol;
using UI;
using UI.Price;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Portals.View.ShopTab
{
	// Token: 0x020005BF RID: 1471
	[Token(Token = "0x20005BF")]
	[DisallowMultipleComponent]
	public class PortalsShopItemView : AbstractDataRenderer<ShopItemData>, IPointerEnterHandler, IEventSystemHandler, IToolTipDataProvider, IPointerClickHandler, IArtifactView
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000685")]
		public IActionInfo Info
		{
			[Token(Token = "0x600233D")]
			[Address(RVA = "0x7491", Offset = "0x7491", VA = "0x7491", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600233E")]
			[Address(RVA = "0x7492", Offset = "0x7492", VA = "0x7492")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000686")]
		public BackTime Backtime
		{
			[Token(Token = "0x600233F")]
			[Address(RVA = "0x7493", Offset = "0x7493", VA = "0x7493", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002340")]
			[Address(RVA = "0x7494", Offset = "0x7494", VA = "0x7494")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x17000687")]
		public bool OnlyMarketAccount
		{
			[Token(Token = "0x6002341")]
			[Address(RVA = "0x7495", Offset = "0x7495", VA = "0x7495", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000688")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6002342")]
			[Address(RVA = "0x7496", Offset = "0x7496", VA = "0x7496", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x00006DF8 File Offset: 0x00004FF8
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000689")]
		public ArtifactView.ArtifactViewArgs Args
		{
			[Token(Token = "0x6002343")]
			[Address(RVA = "0x7497", Offset = "0x7497", VA = "0x7497", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x6002344")]
			[Address(RVA = "0x7498", Offset = "0x7498", VA = "0x7498", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068A")]
		public GameObject GameObject
		{
			[Token(Token = "0x6002345")]
			[Address(RVA = "0x7499", Offset = "0x7499", VA = "0x7499", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x749A", Offset = "0x749A", VA = "0x749A", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002347")]
		[Address(RVA = "0x749B", Offset = "0x749B", VA = "0x749B", Slot = "20")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		int Gameplay_Portals_View_ShopTab_PortalsShopItemView__OnPointerEnter(int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a580fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_ToolTipData_IItemInformationProvider__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12536);
		    DAT_ram_00a580fd = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12536,
		             Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param2_00 = *(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x6c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param3 = *(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x6c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param4 = *(undefined4 *)(iVar1 + 0xc);
		  param1_01 = unnamed_function_1417(Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		  Gameplay_Inventory_Model_InventoryUtils___ctor(param1_01,param2_00,param3,param4,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x749C", Offset = "0x749C", VA = "0x749C", Slot = "21")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068B")]
		public Image Marker
		{
			[Token(Token = "0x6002349")]
			[Address(RVA = "0x749D", Offset = "0x749D", VA = "0x749D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x749E", Offset = "0x749E", VA = "0x749E", Slot = "22")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Portals_View_ShopTab_PortalsShopItemView__OnPointerClick
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a580ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_ShopTab_PortalsShopItemView_UserBalanceUpdatedHandler__
		              );
		    DAT_ram_00a580ff = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80ea2436;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea2436:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x14);
		  param1_01 = *(undefined4 *)(iVar5 + 0x28);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Portals_View_ShopTab_PortalsShopItemView_UserBalanceUpdatedHandler__,0)
		  ;
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x28) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x28) = piVar3, *piVar3 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x749F", Offset = "0x749F", VA = "0x749F", Slot = "17")]
		protected override void StartListenEvents(ShopItemData data)
		{
		/* --- GHIDRA: StartListenEvents ---
		void Gameplay_Portals_View_ShopTab_PortalsShopItemView__StartListenEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58100 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_ShopTab_PortalsShopItemView_UserBalanceUpdatedHandler__
		              );
		    DAT_ram_00a58100 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80ea2582;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea2582:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x14);
		  param1_01 = *(undefined4 *)(iVar5 + 0x28);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Portals_View_ShopTab_PortalsShopItemView_UserBalanceUpdatedHandler__,0)
		  ;
		  piVar3 = (int *)func_ii_7048(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x28) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x28) = piVar3, *piVar3 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x74A0", Offset = "0x74A0", VA = "0x74A0", Slot = "18")]
		protected override void StopListenEvents(ShopItemData data)
		{
		/* --- GHIDRA: StopListenEvents ---
		void Gameplay_Portals_View_ShopTab_PortalsShopItemView__StopListenEvents
		               (int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,*(undefined4 *)(*param1 + 0x15c));
		  return;
		}
		*/

		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x74A1", Offset = "0x74A1", VA = "0x74A1")]
		private void UserBalanceUpdatedHandler()
		{
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068C")]
		public IList<Sprite> MarkerSprites
		{
			[Token(Token = "0x600234F")]
			[Address(RVA = "0x74A3", Offset = "0x74A3", VA = "0x74A3")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600234E")]
			[Address(RVA = "0x74A2", Offset = "0x74A2", VA = "0x74A2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002350")]
		[Address(RVA = "0x74A4", Offset = "0x74A4", VA = "0x74A4", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		/* --- GHIDRA: OnDataInvalidated ---
		void Gameplay_Portals_View_ShopTab_PortalsShopItemView__OnDataInvalidated
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58102 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ShopItemData___ctor__);
		    DAT_ram_00a58102 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_ShopItemData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x74A5", Offset = "0x74A5", VA = "0x74A5")]
		public PortalsShopItemView()
		{
		}

		// Token: 0x04001360 RID: 4960
		[Token(Token = "0x4001360")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04001361 RID: 4961
		[Token(Token = "0x4001361")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PriceItemRenderer _price;

		// Token: 0x04001362 RID: 4962
		[Token(Token = "0x4001362")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _marker;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Marker ---
		void Gameplay_Portals_View_ShopTab_PortalsShopItemView__get_Marker
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param3_00;
		  undefined4 param2_00;
		  undefined8 local_18;
		  undefined8 local_10 [2];
		  
		  if (DAT_ram_00a580fe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ContextMenu_ContextMenuController_Show_ItemContextMenuOptions__ArtifactContextMenu___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ContextMenu_ItemContextMenuOptions_TypeInfo);
		    DAT_ram_00a580fe = '\x01';
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


		/* --- GHIDRA: get_MarkerSprites ---
		void Gameplay_Portals_View_ShopTab_PortalsShopItemView__get_MarkerSprites
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
		  float param2_00;
		  uint *puVar7;
		  undefined4 uVar8;
		  int iVar9;
		  int *piVar10;
		  ulonglong uVar11;
		  uint uVar12;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58101 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ActionState_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_Sprite__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_Sprite__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12475);
		    DAT_ram_00a58101 = '\x01';
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
		  if (*(int *)(*(int *)(iVar6 + 8) + 0x10) == 0) {
		    iVar6 = 0;
		  }
		  else {
		    uVar1 = CONCAT44(uVar2,param1);
		    uVar4 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x134));
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    iVar6 = Protocol_ActionInfoAdapter__Create(*(undefined4 *)(*(int *)(iVar6 + 8) + 0x10),0);
		  }
		  param1[0xc] = iVar6;
		  uVar1 = CONCAT44(uVar2,param1);
		  uVar4 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x134));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (*(int *)(*(int *)(iVar6 + 8) + 0x10) != 0) {
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(CONCAT44(uVar3,param1),uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar11 = (ulonglong)*(uint *)(*(int *)(*(int *)(iVar5 + 8) + 0x10) + 0x20);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = func_ii_7331(uVar11,0);
		    uVar3 = (undefined4)(uVar11 >> 0x20);
		    iVar5 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(iVar5,param2_00,0);
		  }
		  param1[0xd] = iVar5;
		  if (param1[0x12] != 0) {
		    uVar1 = CONCAT44(uVar3,param1);
		    uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (*(int *)(*(int *)(iVar5 + 8) + 0x10) != 0) {
		      uVar1 = CONCAT44(uVar3,param1);
		      uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		      uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		      uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      iVar5 = *(int *)(*(int *)(*(int *)(iVar5 + 8) + 0x10) + 0xc) + -1;
		      if (-1 < iVar5) {
		        piVar10 = (int *)param1[0x12];
		        iVar6 = *piVar10;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            if (System_Collections_Generic_ICollection_Sprite__TypeInfo ==
		                *(int *)(*(int *)(iVar6 + 0x58) + uVar12 * 8)) {
		              puVar7 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar12 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80ea2846;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar12);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar10,
		                                      System_Collections_Generic_ICollection_Sprite__TypeInfo,0);
		code_r0x80ea2846:
		        uVar1 = CONCAT44(uVar3,piVar10);
		        uVar4 = CONCAT44(uVar2,puVar7[1]);
		        iVar6 = (**(code **)((ulonglong)*puVar7 * 4))(uVar1,uVar4);
		        uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		        uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		        if (iVar5 < iVar6) {
		          uVar12 = 0;
		          iVar6 = param1[0xb];
		          piVar10 = (int *)param1[0x12];
		          iVar9 = *piVar10;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            do {
		              if (System_Collections_Generic_IList_Sprite__TypeInfo ==
		                  *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8)) {
		                puVar7 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x80ea28d5;
		              }
		              uVar12 = uVar12 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		          }
		          puVar7 = (uint *)func_ii_1080(piVar10,System_Collections_Generic_IList_Sprite__TypeInfo,0)
		          ;
		code_r0x80ea28d5:
		          uVar1 = CONCAT44(uVar3,piVar10);
		          uVar4 = CONCAT44(uVar2,iVar5);
		          uVar8 = (**(code **)((ulonglong)*puVar7 * 4))(uVar1,uVar4,puVar7[1]);
		          uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		          uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		          func_ii_7050(iVar6,uVar8,0);
		          goto code_r0x80ea295b;
		        }
		      }
		      uVar1 = CONCAT44(uVar3,param1);
		      uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		      local_8 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 8) + 0x10) + 0xc);
		      uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		      uVar8 = func_ii_1081(Protocol_Portal_ActionState_TypeInfo,&local_8);
		      uVar8 = func_ii_4419(StringLiteral_12475,uVar8,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7109(uVar8,0);
		    }
		  }
		code_r0x80ea295b:
		  piVar10 = (int *)param1[9];
		  uVar1 = CONCAT44(uVar3,param1);
		  uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		  iVar6 = *piVar10;
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),piVar10);
		  uVar4 = CONCAT44((int)((ulonglong)uVar4 >> 0x20),*(undefined4 *)(iVar5 + 0xc));
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x138) * 4))(uVar1,uVar4,*(undefined4 *)(iVar6 + 0x13c))
		  ;
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar10;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar12 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar12 * 8)) {
		        puVar7 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar12 * 8 + 4) * 8 + iVar5 + 0x290);
		        goto code_r0x80ea2a28;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar12);
		  }
		  puVar7 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea2a28:
		  uVar1 = CONCAT44(uVar3,piVar10);
		  uVar4 = CONCAT44(uVar2,puVar7[1]);
		  iVar5 = (**(code **)((ulonglong)*puVar7 * 4))(uVar1,uVar4);
		  iVar6 = param1[10];
		  iVar5 = *(int *)(iVar5 + 0x10);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar8 = Core_Extensions_Dict_PortalDicExt__GetAssetId(*(undefined4 *)(iVar5 + 0x3c),0);
		  UI_Price_PriceItemRenderer__SetIcon(iVar6,uVar8,0);
		  iVar5 = *(int *)(iVar5 + 0x18);
		  if (iVar5 == 0) {
		    uVar11 = 0;
		  }
		  else {
		    uVar11 = *(ulonglong *)(iVar5 + 0x10);
		  }
		  uVar1 = CONCAT44(uVar3,param1);
		  uVar4 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))(uVar1,uVar4);
		  uVar12 = (uint)(*(ulonglong *)(*(int *)(*(int *)(iVar5 + 8) + 0xc) + 0x28) <= uVar11);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  UI_Price_PriceItemRenderer__set_TruncatePrice(param1[10],uVar12,0);
		  iVar5 = 0x24;
		  if (uVar12 == 0) {
		    iVar5 = 0x28;
		  }
		  local_4 = *(undefined4 *)(param1[10] + iVar5);
		  UI_Price_PriceItemRenderer__set_ResId(param1[10],&local_4,0);
		  iVar6 = param1[10];
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (CONCAT44(uVar3,param1),CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x134)));
		  UI_Price_PriceItemRenderer__set_ValidIconEnabled
		            (iVar6,(double)*(ulonglong *)(*(int *)(*(int *)(iVar5 + 8) + 0xc) + 0x28),0);
		  return;
		}
		*/

}
