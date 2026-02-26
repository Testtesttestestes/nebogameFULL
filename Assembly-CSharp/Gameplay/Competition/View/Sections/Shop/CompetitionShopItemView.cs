using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Competition.Model;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol;
using UI;
using UI.Price;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Competition.View.Sections.Shop
{
	// Token: 0x020008E2 RID: 2274
	[Token(Token = "0x20008E2")]
	[DisallowMultipleComponent]
	public class CompetitionShopItemView : AbstractDataRenderer<ShopItemData>, IPointerEnterHandler, IEventSystemHandler, IToolTipDataProvider, IPointerClickHandler, IArtifactView
	{
		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A91")]
		public IActionInfo Info
		{
			[Token(Token = "0x600357D")]
			[Address(RVA = "0x858B", Offset = "0x858B", VA = "0x858B", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600357E")]
			[Address(RVA = "0x858C", Offset = "0x858C", VA = "0x858C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A92")]
		public BackTime Backtime
		{
			[Token(Token = "0x600357F")]
			[Address(RVA = "0x858D", Offset = "0x858D", VA = "0x858D", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003580")]
			[Address(RVA = "0x858E", Offset = "0x858E", VA = "0x858E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x17000A93")]
		public bool OnlyMarketAccount
		{
			[Token(Token = "0x6003581")]
			[Address(RVA = "0x858F", Offset = "0x858F", VA = "0x858F", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06003582 RID: 13698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A94")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6003582")]
			[Address(RVA = "0x8590", Offset = "0x8590", VA = "0x8590", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x0000AD88 File Offset: 0x00008F88
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A95")]
		public ArtifactView.ArtifactViewArgs Args
		{
			[Token(Token = "0x6003583")]
			[Address(RVA = "0x8591", Offset = "0x8591", VA = "0x8591", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x6003584")]
			[Address(RVA = "0x8592", Offset = "0x8592", VA = "0x8592", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A96")]
		public GameObject GameObject
		{
			[Token(Token = "0x6003585")]
			[Address(RVA = "0x8593", Offset = "0x8593", VA = "0x8593", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003586")]
		[Address(RVA = "0x8594", Offset = "0x8594", VA = "0x8594", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003587")]
		[Address(RVA = "0x8595", Offset = "0x8595", VA = "0x8595", Slot = "20")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		int Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView__OnPointerEnter
		              (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a63a8c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_ToolTipData_IItemInformationProvider__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12536);
		    DAT_ram_00a63a8c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_IItemInformationProvider__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12536,
		             Method_UI_ToolTip_ToolTipData_IItemInformationProvider___ctor__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param2_00 = *(undefined4 *)(*(int *)(iVar1 + 8) + 0x6c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param3 = *(undefined4 *)(*(int *)(iVar1 + 8) + 0x6c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param4 = *(undefined4 *)(iVar1 + 8);
		  param1_01 = unnamed_function_1417(Gameplay_Inventory_Model_ToolTipArtifactInfoProvider_TypeInfo);
		  Gameplay_Inventory_Model_InventoryUtils___ctor(param1_01,param2_00,param3,param4,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003588 RID: 13704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003588")]
		[Address(RVA = "0x8596", Offset = "0x8596", VA = "0x8596", Slot = "21")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A97")]
		public Image Marker
		{
			[Token(Token = "0x6003589")]
			[Address(RVA = "0x8597", Offset = "0x8597", VA = "0x8597")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358A")]
		[Address(RVA = "0x8598", Offset = "0x8598", VA = "0x8598", Slot = "22")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView__OnPointerClick
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a63a8e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView_UserBalanceUpdatedHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63a8e = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x2a0);
		        goto code_r0x8233614f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3c);
		code_r0x8233614f:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar6 + 0x114));
		  param1_01 = *(undefined4 *)(iVar5 + 0x18);
		  uVar3 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar3,param1,
		             Method_Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView_UserBalanceUpdatedHandler__
		             ,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar5 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,Core_ChangedFromTo_OwnerRating__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar5 + 0x18) = iVar4;
		    uVar3 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    iVar5 = func_ii_1082(iVar6,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar5 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358B")]
		[Address(RVA = "0x8599", Offset = "0x8599", VA = "0x8599", Slot = "17")]
		protected override void StartListenEvents(ShopItemData data)
		{
		/* --- GHIDRA: StartListenEvents ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView__StartListenEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a63a8f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView_UserBalanceUpdatedHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63a8f = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x2a0);
		        goto code_r0x823362c3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3c);
		code_r0x823362c3:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar6 + 0x114));
		  param1_01 = *(undefined4 *)(iVar5 + 0x18);
		  uVar3 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar3,param1,
		             Method_Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView_UserBalanceUpdatedHandler__
		             ,0);
		  iVar6 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar5 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,Core_ChangedFromTo_OwnerRating__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar5 + 0x18) = iVar4;
		    uVar3 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    iVar5 = func_ii_1082(iVar6,Core_ChangedFromTo_OwnerRating__TypeInfo);
		    if (iVar5 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x859A", Offset = "0x859A", VA = "0x859A", Slot = "18")]
		protected override void StopListenEvents(ShopItemData data)
		{
		/* --- GHIDRA: StopListenEvents ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView__StopListenEvents
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,*(undefined4 *)(*param1 + 0x15c));
		  return;
		}
		*/

		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x859B", Offset = "0x859B", VA = "0x859B")]
		private void UserBalanceUpdatedHandler(OwnerRating from, OwnerRating to)
		{
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600358E RID: 13710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A98")]
		public IList<Sprite> MarkerSprites
		{
			[Token(Token = "0x600358F")]
			[Address(RVA = "0x859D", Offset = "0x859D", VA = "0x859D")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600358E")]
			[Address(RVA = "0x859C", Offset = "0x859C", VA = "0x859C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x859E", Offset = "0x859E", VA = "0x859E", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		/* --- GHIDRA: OnDataInvalidated ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView__OnDataInvalidated
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a91 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ShopItemData___ctor__);
		    DAT_ram_00a63a91 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_ShopItemData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x859F", Offset = "0x859F", VA = "0x859F")]
		public CompetitionShopItemView()
		{
		}

		// Token: 0x04001D42 RID: 7490
		[Token(Token = "0x4001D42")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04001D43 RID: 7491
		[Token(Token = "0x4001D43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PriceItemRenderer _price;

		// Token: 0x04001D44 RID: 7492
		[Token(Token = "0x4001D44")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _marker;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OnlyMarketAccount ---
		undefined4
		Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView__get_OnlyMarketAccount
		          (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  return *(undefined4 *)(iVar1 + 8);
		}
		*/


		/* --- GHIDRA: get_GameObject ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView__get_GameObject
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x144));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Marker ---
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView__get_Marker
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param3_00;
		  undefined4 param2_00;
		  undefined8 local_18;
		  undefined8 local_10 [2];
		  
		  if (DAT_ram_00a63a8d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ContextMenu_ContextMenuController_Show_ItemContextMenuOptions__ArtifactContextMenu___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ContextMenu_ItemContextMenuOptions_TypeInfo);
		    DAT_ram_00a63a8d = '\x01';
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
		void Gameplay_Competition_View_Sections_Shop_CompetitionShopItemView__get_MarkerSprites
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63a90 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a63a90 = '\x01';
		  }
		  UnityEngine_Object__op_Implicit(param1[0xb],0,0);
		  param1[0xc] = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar2 != 0) {
		    piVar4 = (int *)param1[9];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar5 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0x138) * 4))
		              (piVar4,*(undefined4 *)(iVar2 + 8),*(undefined4 *)(iVar5 + 0x13c));
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x290);
		          goto code_r0x823364a0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x823364a0:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    iVar5 = param1[10];
		    param2_00 = Core_Extensions_Dict_PortalDicExt__GetAssetId
		                          (*(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x3c),0);
		    UI_Price_PriceItemRenderer__SetIcon(iVar5,param2_00,0);
		  }
		  return;
		}
		*/

}
