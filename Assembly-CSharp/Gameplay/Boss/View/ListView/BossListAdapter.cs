using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.ListView
{
	// Token: 0x02000B68 RID: 2920
	[Token(Token = "0x2000B68")]
	public class BossListAdapter : OSA<BaseParamsWithPrefab, BossListItemViewHolder>
	{
		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E11")]
		public SimpleDataHelper<BossInstance> Data
		{
			[Token(Token = "0x60046D3")]
			[Address(RVA = "0x9569", Offset = "0x9569", VA = "0x9569")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60046D4")]
			[Address(RVA = "0x956A", Offset = "0x956A", VA = "0x956A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001BA RID: 442
		// (add) Token: 0x060046D5 RID: 18133 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046D6 RID: 18134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BA")]
		public event Action<BossInstance> SelectedEvent
		{
			[Token(Token = "0x60046D5")]
			[Address(RVA = "0x956B", Offset = "0x956B", VA = "0x956B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046D6")]
			[Address(RVA = "0x956C", Offset = "0x956C", VA = "0x956C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001BB RID: 443
		// (add) Token: 0x060046D7 RID: 18135 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046D8 RID: 18136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BB")]
		public event Action<BossInstance> QuestionButtonClickedEvent
		{
			[Token(Token = "0x60046D7")]
			[Address(RVA = "0x956D", Offset = "0x956D", VA = "0x956D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046D8")]
			[Address(RVA = "0x956E", Offset = "0x956E", VA = "0x956E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E12")]
		public BossInstance SelectedItem
		{
			[Token(Token = "0x60046D9")]
			[Address(RVA = "0x956F", Offset = "0x956F", VA = "0x956F")]
			get
			{
				return null;
			}
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DA")]
		[Address(RVA = "0x9570", Offset = "0x9570", VA = "0x9570", Slot = "67")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		int Gameplay_Boss_View_ListView_BossListAdapter__Awake
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int param1_00;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a579fe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_ListView_BossListAdapter_BossListItemViewOnQuestionClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_ListView_BossListAdapter_BossListItemViewOnSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_View_ListView_BossListItemViewHolder_TypeInfo);
		    DAT_ram_00a579fe = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Boss_View_ListView_BossListItemViewHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  iVar7 = *(int *)(param1_00 + 0x14);
		  uVar5 = unnamed_function_1417(System_Action_BossInstance__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Boss_View_ListView_BossListAdapter_BossListItemViewOnSelectedEvent__,0)
		  ;
		  if (DAT_ram_00a57a07 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a57a07 = '\x01';
		  }
		  iVar3 = *(int *)(iVar7 + 0x50);
		  while( true ) {
		    iVar4 = 0;
		    iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		    uVar2 = System_Action_BossInstance__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar4 = func_ii_1082(iVar6,System_Action_BossInstance__TypeInfo), iVar4 == 0)) break;
		    iVar4 = func_ii_4329(iVar7 + 0x50,iVar4,iVar3);
		    bVar1 = iVar4 == iVar3;
		    iVar3 = iVar4;
		    if (bVar1) {
		      iVar7 = *(int *)(param1_00 + 0x14);
		      uVar5 = unnamed_function_1417(System_Action_BossInstance__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Boss_View_ListView_BossListAdapter_BossListItemViewOnQuestionClickedEvent__
		                 ,0);
		      if (DAT_ram_00a57a09 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		        DAT_ram_00a57a09 = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 0x54);
		      while( true ) {
		        iVar4 = 0;
		        iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		        uVar2 = System_Action_BossInstance__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar4 = func_ii_1082(iVar6,System_Action_BossInstance__TypeInfo), iVar4 == 0)) break;
		        iVar4 = func_ii_4329(iVar7 + 0x54,iVar4,iVar3);
		        bVar1 = iVar4 == iVar3;
		        iVar3 = iVar4;
		        if (bVar1) {
		          return param1_00;
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060046DB RID: 18139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60046DB")]
		[Address(RVA = "0x9571", Offset = "0x9571", VA = "0x9571", Slot = "99")]
		protected override BossListItemViewHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Boss_View_ListView_BossListAdapter__CreateViewsHolder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xa8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DC")]
		[Address(RVA = "0x9572", Offset = "0x9572", VA = "0x9572")]
		private void BossListItemViewOnQuestionClickedEvent(BossInstance data)
		{
		/* --- GHIDRA: BossListItemViewOnQuestionClickedEvent ---
		void Gameplay_Boss_View_ListView_BossListAdapter__BossListItemViewOnQuestionClickedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Boss_View_ListView_BossListAdapter__BossListItemViewOnSelectedEvent(param1,param2,param2)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060046DD RID: 18141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DD")]
		[Address(RVA = "0x9573", Offset = "0x9573", VA = "0x9573")]
		private void BossListItemViewOnSelectedEvent(BossInstance bossInstance)
		{
		/* --- GHIDRA: BossListItemViewOnSelectedEvent ---
		void Gameplay_Boss_View_ListView_BossListAdapter__BossListItemViewOnSelectedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a579ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInstance__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossListItemViewHolder__GetItemViewsHolderIfVisible__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__get_List__)
		    ;
		    DAT_ram_00a579ff = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0xac);
		  *(int *)(param1 + 0xac) = param2;
		  if (iVar2 != 0) {
		    uVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                      (*(undefined4 *)(*(int *)(param1 + 0xa0) + 0xc),iVar2,
		                       Method_System_Collections_Generic_List_BossInstance__IndexOf__);
		    iVar2 = Com_TheFallenGames_OSA_Core_OSA_object__object___GetItemViewsHolder
		                      (param1,uVar1,
		                       Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossListItemViewHolder__GetItemViewsHolderIfVisible__
		                      );
		    if (iVar2 != 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		    }
		    param2 = *(int *)(param1 + 0xac);
		  }
		  if (param2 != 0) {
		    uVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                      (*(undefined4 *)(*(int *)(param1 + 0xa0) + 0xc),param2,
		                       Method_System_Collections_Generic_List_BossInstance__IndexOf__);
		    iVar2 = Com_TheFallenGames_OSA_Core_OSA_object__object___GetItemViewsHolder
		                      (param1,uVar1,
		                       Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossListItemViewHolder__GetItemViewsHolderIfVisible__
		                      );
		    if (iVar2 != 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,1,0);
		    }
		  }
		  iVar2 = *(int *)(param1 + 0xa4);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param1 + 0xac),
		               *(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060046DE RID: 18142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DE")]
		[Address(RVA = "0x9574", Offset = "0x9574", VA = "0x9574")]
		public void Select(BossInstance instanceInfo)
		{
		/* --- GHIDRA: Select ---
		void Gameplay_Boss_View_ListView_BossListAdapter__Select(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57a00 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__get_Item__)
		    ;
		    DAT_ram_00a57a00 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  param2_00 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                        (param1_00,uVar1,
		                         Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__get_Item__
		                        );
		  Gameplay_Boss_View_ListView_BossListItemView__get_BossInstance(param2[5],param2_00,param2);
		  iVar2 = *(int *)(param1 + 0xac);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param2[5] + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(iVar2 == param2_00),0);
		  return;
		}
		*/

		}

		// Token: 0x060046DF RID: 18143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DF")]
		[Address(RVA = "0x9575", Offset = "0x9575", VA = "0x9575", Slot = "100")]
		protected override void UpdateViewsHolder(BossListItemViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Boss_View_ListView_BossListAdapter__UpdateViewsHolder
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57a01 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_ListView_BossListAdapter_BossListItemViewOnQuestionClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_ListView_BossListAdapter_BossListItemViewOnSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossListItemViewHolder__OnBeforeDestroyViewsHolder__
		              );
		    DAT_ram_00a57a01 = '\x01';
		  }
		  iVar7 = *(int *)(param2 + 0x14);
		  uVar5 = unnamed_function_1417(System_Action_BossInstance__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Boss_View_ListView_BossListAdapter_BossListItemViewOnSelectedEvent__,0)
		  ;
		  if (DAT_ram_00a57a08 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a57a08 = '\x01';
		  }
		  iVar3 = *(int *)(iVar7 + 0x50);
		  while( true ) {
		    iVar4 = 0;
		    iVar6 = func_ii_7048(iVar3,uVar5,0);
		    uVar2 = System_Action_BossInstance__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar4 = func_ii_1082(iVar6,System_Action_BossInstance__TypeInfo), iVar4 == 0)) break;
		    iVar4 = func_ii_4329(iVar7 + 0x50,iVar4,iVar3);
		    bVar1 = iVar4 == iVar3;
		    iVar3 = iVar4;
		    if (bVar1) {
		      iVar7 = *(int *)(param2 + 0x14);
		      uVar5 = unnamed_function_1417(System_Action_BossInstance__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Boss_View_ListView_BossListAdapter_BossListItemViewOnQuestionClickedEvent__
		                 ,0);
		      if (DAT_ram_00a57a09 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		        DAT_ram_00a57a09 = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 0x54);
		      while( true ) {
		        iVar4 = 0;
		        iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		        uVar2 = System_Action_BossInstance__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar4 = func_ii_1082(iVar6,System_Action_BossInstance__TypeInfo), iVar4 == 0)) break;
		        iVar4 = func_ii_4329(iVar7 + 0x54,iVar4,iVar3);
		        bVar1 = iVar4 == iVar3;
		        iVar3 = iVar4;
		        if (bVar1) {
		          return;
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E0")]
		[Address(RVA = "0x9576", Offset = "0x9576", VA = "0x9576", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossListItemViewHolder vh, bool isActive)
		{
		/* --- GHIDRA: OnBeforeDestroyViewsHolder ---
		void Gameplay_Boss_View_ListView_BossListAdapter__OnBeforeDestroyViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57a02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__InsertItems__
		              );
		    DAT_ram_00a57a02 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object____ctor
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__InsertItems__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E1")]
		[Address(RVA = "0x9577", Offset = "0x9577", VA = "0x9577")]
		public void AddItemsAt(int index, IList<BossInstance> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_Boss_View_ListView_BossListAdapter__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57a03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__RemoveItems__
		              );
		    DAT_ram_00a57a03 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__RemoveItems__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E2")]
		[Address(RVA = "0x9578", Offset = "0x9578", VA = "0x9578")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_Boss_View_ListView_BossListAdapter__RemoveItemsFrom
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57a04 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__ResetItems__
		              );
		    DAT_ram_00a57a04 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__ResetItems__);
		  return;
		}
		*/

		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E3")]
		[Address(RVA = "0x9579", Offset = "0x9579", VA = "0x9579")]
		public void SetItems(IList<BossInstance> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Boss_View_ListView_BossListAdapter__SetItems(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a05 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossListItemViewHolder___ctor__
		              );
		    DAT_ram_00a57a05 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossListItemViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E4")]
		[Address(RVA = "0x957A", Offset = "0x957A", VA = "0x957A")]
		public BossListAdapter()
		{
		}

		// Token: 0x040026D0 RID: 9936
		[Token(Token = "0x40026D0")]
		[FieldOffset(Offset = "0xAC")]
		private BossInstance _selectedItem;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Boss_View_ListView_BossListAdapter__set_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a579f9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossInstance__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInstance__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa4,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectedEvent ---
		void Gameplay_Boss_View_ListView_BossListAdapter__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a579fa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossInstance__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInstance__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa4,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SelectedEvent ---
		void Gameplay_Boss_View_ListView_BossListAdapter__remove_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a579fb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossInstance__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInstance__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa8,iVar2,param1_00);
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


		/* --- GHIDRA: add_QuestionButtonClickedEvent ---
		void Gameplay_Boss_View_ListView_BossListAdapter__add_QuestionButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579fc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a579fc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossInstance__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInstance__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa8,iVar2,param1_00);
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


		/* --- GHIDRA: get_SelectedItem ---
		void Gameplay_Boss_View_ListView_BossListAdapter__get_SelectedItem(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossListItemViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__TypeInfo);
		    DAT_ram_00a579fd = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance__TypeInfo)
		  ;
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInstance___ctor__);
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossListItemViewHolder__Start__
		            );
		  return;
		}
		*/

}
