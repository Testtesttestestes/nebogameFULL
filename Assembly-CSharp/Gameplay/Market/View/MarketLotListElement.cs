using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Inventory.View;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Market.View
{
	// Token: 0x0200061C RID: 1564
	[Token(Token = "0x200061C")]
	public class MarketLotListElement : GenericListElement<MarketLotListElement.MarketLotListElementArgs>
	{
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x17000720")]
		public bool IsMasterElement
		{
			[Token(Token = "0x60025F1")]
			[Address(RVA = "0x772F", Offset = "0x772F", VA = "0x772F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000721")]
		public MarketLotListElement.MarketLotListElementArgs Data
		{
			[Token(Token = "0x60025F2")]
			[Address(RVA = "0x7730", Offset = "0x7730", VA = "0x7730")]
			get
			{
				return null;
			}
			[Token(Token = "0x60025F3")]
			[Address(RVA = "0x7731", Offset = "0x7731", VA = "0x7731")]
			set
			{
			}
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x7732", Offset = "0x7732", VA = "0x7732")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Market_View_MarketLotListElement__Awake(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Market_View_MarketLotListElement__get_Data(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x7733", Offset = "0x7733", VA = "0x7733")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Market_View_MarketLotListElement__OnDestroy(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a59fe9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__RegisterEvents__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_View_MarketLotListElement_SelectChangedEventHandler__);
		    DAT_ram_00a59fe9 = '\x01';
		  }
		  UI_Elements_GenericList_GenericListElement_object___OnDestroy
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__RegisterEvents__
		            );
		  iVar3 = *(int *)(param1 + 0x18);
		  param1_01 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (param1_01,param1,
		             Method_Gameplay_Market_View_MarketLotListElement_SelectChangedEventHandler__,0);
		  if (DAT_ram_00a59fec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a59fec = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x7734", Offset = "0x7734", VA = "0x7734", Slot = "5")]
		protected override void RegisterEvents()
		{
		/* --- GHIDRA: RegisterEvents ---
		void Gameplay_Market_View_MarketLotListElement__RegisterEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Market_View_MarketLotListElement__CallElementClickedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x7735", Offset = "0x7735", VA = "0x7735", Slot = "4")]
		protected override void OnInit(MarketLotListElement.MarketLotListElementArgs args)
		{
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x7736", Offset = "0x7736", VA = "0x7736")]
		private void CallElementClickedEvent(MarketLotListElement.MarketLotListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_Market_View_MarketLotListElement__CallElementClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *param4;
		  undefined4 uVar3;
		  int *param1_00;
		  int param2_00;
		  int iVar4;
		  
		  if (DAT_ram_00a59fea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59fea = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x28);
		  param2_00 = *(int *)(*(int *)(param1 + 0x18) + 0xc);
		  uVar2 = Core_Data_ArtikulData__get_IsSellable(*(undefined4 *)(param2_00 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar4 = **(int **)(param1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		            (*(int **)(param1 + 0x24),*(undefined4 *)(param2_00 + 8),*(undefined4 *)(iVar4 + 0x13c))
		  ;
		  *(undefined1 *)(*(int *)(param1 + 0x24) + 0x44) = 0;
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        param4 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x811af19b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  param4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811af19b:
		  uVar3 = (**(code **)((ulonglong)*param4 * 4))(param1_00,param4[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  Gameplay_Market_View_MarketLotListElement_MarketLotListElementArgs__set_Selected
		            (uVar2,param2_00,uVar3,param4);
		  AssetContent_GameImage__get_AssetId
		            (*(undefined4 *)(param1 + 0x30),*(undefined4 *)(param2_00 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x20),(uint)*(byte *)(*(int *)(param1 + 0x18) + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x7737", Offset = "0x7737", VA = "0x7737")]
		private void ApplyArgs()
		{
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FA")]
		[Address(RVA = "0x7738", Offset = "0x7738", VA = "0x7738")]
		private void SelectChangedEventHandler(bool select)
		{
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x7739", Offset = "0x7739", VA = "0x7739")]
		private void Select(bool isSelected)
		{
		/* --- GHIDRA: Select ---
		void Gameplay_Market_View_MarketLotListElement__Select(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59feb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs___ctor__
		              );
		    DAT_ram_00a59feb = '\x01';
		  }
		  UI_Elements_GenericList_GenericListArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FC")]
		[Address(RVA = "0x773A", Offset = "0x773A", VA = "0x773A")]
		public MarketLotListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Market_View_MarketLotListElement___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Unity_Collections_NativeArray_ReadOnly_Enumerator_Painter2D_Painter2DJobData___MoveNext(param1,0);
		  *(undefined4 *)(param1 + 0xc) = param2;
		  return;
		}
		*/

		}

		// Token: 0x040014B5 RID: 5301
		[Token(Token = "0x40014B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x040014B6 RID: 5302
		[Token(Token = "0x40014B6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x040014B7 RID: 5303
		[Token(Token = "0x40014B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040014B8 RID: 5304
		[Token(Token = "0x40014B8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private MarketLotPriceView _priceView;

		// Token: 0x040014B9 RID: 5305
		[Token(Token = "0x40014B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameImage _ribbonIcon;

		// Token: 0x040014BA RID: 5306
		[Token(Token = "0x40014BA")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Такие же элементы дублируются в другом списке, нам нужно их различать")]
		[SerializeField]
		private bool _isMasterElement;

		// Token: 0x0200061D RID: 1565
		[Token(Token = "0x200061D")]
		public class MarketLotListElementArgs : GenericListElementArgs
		{
			// Token: 0x060025FD RID: 9725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60025FD")]
			[Address(RVA = "0x773B", Offset = "0x773B", VA = "0x773B")]
			public MarketLotListElementArgs(MarketLotData data)
			{
			}

			// Token: 0x14000150 RID: 336
			// (add) Token: 0x060025FE RID: 9726 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x060025FF RID: 9727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000150")]
			public event Action<bool> SelectChangedEvent
			{
				[Token(Token = "0x60025FE")]
				[Address(RVA = "0x773C", Offset = "0x773C", VA = "0x773C")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x60025FF")]
				[Address(RVA = "0x773D", Offset = "0x773D", VA = "0x773D")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x06002600 RID: 9728 RVA: 0x000073E0 File Offset: 0x000055E0
			// (set) Token: 0x06002601 RID: 9729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000722")]
			public bool Selected
			{
				[Token(Token = "0x6002600")]
				[Address(RVA = "0x773E", Offset = "0x773E", VA = "0x773E")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002601")]
				[Address(RVA = "0x773F", Offset = "0x773F", VA = "0x773F")]
				set
				{
				}
			}

			// Token: 0x040014BB RID: 5307
			[Token(Token = "0x40014BB")]
			[FieldOffset(Offset = "0xC")]
			public readonly MarketLotData MarketLotData;

			// Token: 0x040014BC RID: 5308
			[Token(Token = "0x40014BC")]
			[FieldOffset(Offset = "0x10")]
			private bool _selected;

			// Token: 0x040014BD RID: 5309
			[Token(Token = "0x40014BD")]
			[FieldOffset(Offset = "0x14")]
			public Action<MarketLotListElement> MarketLotButtonClickedEvent;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsMasterElement ---
		undefined4
		Gameplay_Market_View_MarketLotListElement__get_IsMasterElement(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59fe6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__get_args__
		              );
		    DAT_ram_00a59fe6 = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0x18);
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Market_View_MarketLotListElement__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a59fe7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__get_Initted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__set_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_View_MarketLotListElement_SelectChangedEventHandler__);
		    DAT_ram_00a59fe7 = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1,param2,
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__Init__
		              );
		    return;
		  }
		  iVar6 = *(int *)(param1 + 0x18);
		  if (iVar6 != 0) {
		    uVar4 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Market_View_MarketLotListElement_SelectChangedEventHandler__,0);
		    if (DAT_ram_00a59fed == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		      DAT_ram_00a59fed = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x18);
		    do {
		      iVar5 = 0;
		      param1_00 = func_ii_7048(iVar3,uVar4,0);
		      uVar2 = System_Action_bool__TypeInfo;
		      if ((param1_00 != 0) &&
		         (iVar5 = func_ii_1082(param1_00,System_Action_bool__TypeInfo), iVar5 == 0)) {
		        System_Activator__CreateInstance(param1_00,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(iVar6 + 0x18,iVar5,iVar3);
		      bVar1 = iVar5 != iVar3;
		      iVar3 = iVar5;
		    } while (bVar1);
		  }
		  *(int *)(param1 + 0x18) = param2;
		  if (param2 != 0) {
		    uVar4 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Market_View_MarketLotListElement_SelectChangedEventHandler__,0);
		    if (DAT_ram_00a59fec == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		      DAT_ram_00a59fec = '\x01';
		    }
		    iVar6 = *(int *)(param2 + 0x18);
		    do {
		      iVar3 = 0;
		      iVar5 = UnityEngine_UI_Image__set_sprite(iVar6,uVar4,0);
		      uVar2 = System_Action_bool__TypeInfo;
		      if ((iVar5 != 0) && (iVar3 = func_ii_1082(iVar5,System_Action_bool__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(param2 + 0x18,iVar3,iVar6);
		      bVar1 = iVar3 != iVar6;
		      iVar6 = iVar3;
		    } while (bVar1);
		    Gameplay_Market_View_MarketLotListElement__CallElementClickedEvent(param1,iVar3);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Market_View_MarketLotListElement__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59fe8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_View_MarketLotListElement_CallElementClickedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               UnityEngine_Events_UnityAction_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_MarketLotListElement_MarketLotListElementArgs__AddListener__
		              );
		    DAT_ram_00a59fe8 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        UnityEngine_Events_UnityAction_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                        );
		  func_ii_7054(param1_00,param1,
		               Method_Gameplay_Market_View_MarketLotListElement_CallElementClickedEvent__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,
		             Method_UnityEngine_Events_UnityEvent_MarketLotListElement_MarketLotListElementArgs__AddListener__
		            );
		  return;
		}
		*/

}
