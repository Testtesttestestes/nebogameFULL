using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UI.Elements.Filters.GenericFilter;
using UI.Toggle;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000314 RID: 788
	[Token(Token = "0x2000314")]
	public class HistoryView : MonoBehaviourWithStates<HistoryView.State>
	{
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C1")]
		public DeselectableGenericFilterView ColossusFilter
		{
			[Token(Token = "0x600123E")]
			[Address(RVA = "0x6438", Offset = "0x6438", VA = "0x6438")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C2")]
		public GreenToggle MyBattlesToggle
		{
			[Token(Token = "0x600123F")]
			[Address(RVA = "0x6439", Offset = "0x6439", VA = "0x6439")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C3")]
		public BattleInfoView BattleInfoView
		{
			[Token(Token = "0x6001240")]
			[Address(RVA = "0x643A", Offset = "0x643A", VA = "0x643A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002C4")]
		public Button BackButton
		{
			[Token(Token = "0x6001241")]
			[Address(RVA = "0x643B", Offset = "0x643B", VA = "0x643B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C5")]
		public Action MoreItemsAfterNeededEvent
		{
			[Token(Token = "0x6001242")]
			[Address(RVA = "0x643C", Offset = "0x643C", VA = "0x643C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001243")]
			[Address(RVA = "0x643D", Offset = "0x643D", VA = "0x643D")]
			set
			{
			}
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001244")]
		[Address(RVA = "0x643E", Offset = "0x643E", VA = "0x643E")]
		public void Init(IList<BattleHistoryListElement.BattleHistoryListElementArgs> items)
		{
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x643F", Offset = "0x643F", VA = "0x643F")]
		public void Add(IList<BattleHistoryListElement.BattleHistoryListElementArgs> items)
		{
		/* --- GHIDRA: Add ---
		void Gameplay_WorldAxis_Office_View_History_HistoryView__Add
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a58bc2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_HistoryViewsHolder__BattleHistoryListElement_BattleHistoryListElementArgs__RemoveItems__
		              );
		    DAT_ram_00a58bc2 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___OnInitialized
		            (*(undefined4 *)(param1 + 0x1c),param2,param3,
		             Method_UI_OSAGenericBase_HistoryViewsHolder__BattleHistoryListElement_BattleHistoryListElementArgs__RemoveItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x6440", Offset = "0x6440", VA = "0x6440")]
		public void Remove(int count, bool fromEnd)
		{
		/* --- GHIDRA: Remove ---
		void Gameplay_WorldAxis_Office_View_History_HistoryView__Remove
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58bc3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_HistoryViewsHolder__BattleHistoryListElement_BattleHistoryListElementArgs__ActivateRequestBounds__
		              );
		    DAT_ram_00a58bc3 = '\x01';
		  }
		  UI_OSADynamicBase_object__object____ctor
		            (*(undefined4 *)(param1 + 0x1c),param2,0,
		             Method_UI_OSADynamicBase_HistoryViewsHolder__BattleHistoryListElement_BattleHistoryListElementArgs__ActivateRequestBounds__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x6441", Offset = "0x6441", VA = "0x6441")]
		public void ActivateUpperBound(bool activate)
		{
		/* --- GHIDRA: ActivateUpperBound ---
		void Gameplay_WorldAxis_Office_View_History_HistoryView__ActivateUpperBound
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bc4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_HistoryView_State___ctor__);
		    DAT_ram_00a58bc4 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_HistoryView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x6442", Offset = "0x6442", VA = "0x6442")]
		public HistoryView()
		{
		}

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HistoryOSAView _osaView;

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DeselectableGenericFilterView _colossusFilter;

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GreenToggle _myBattlesToggle;

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BattleInfoView _battleInfoView;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _backButton;

		// Token: 0x02000315 RID: 789
		[Token(Token = "0x2000315")]
		public enum State
		{
			// Token: 0x040009B9 RID: 2489
			[Token(Token = "0x40009B9")]
			UNKNOWN_STATE,
			// Token: 0x040009BA RID: 2490
			[Token(Token = "0x40009BA")]
			LIST,
			// Token: 0x040009BB RID: 2491
			[Token(Token = "0x40009BB")]
			INFO,
			// Token: 0x040009BC RID: 2492
			[Token(Token = "0x40009BC")]
			PENDING
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_MoreItemsAfterNeededEvent ---
		void Gameplay_WorldAxis_Office_View_History_HistoryView__set_MoreItemsAfterNeededEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58bc1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__HistoryViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_View_History_HistoryView___c__DisplayClass17_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_View_History_HistoryView___c__DisplayClass17_0_TypeInfo);
		    DAT_ram_00a58bc1 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Office_View_History_HistoryView___c__DisplayClass17_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar2 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0x3bc));
		  piVar1 = *(int **)(param1 + 0x1c);
		  if ((char)piVar1[0x14] != '\0') {
		    (**(code **)((ulonglong)
		                 *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + *piVar1 + 0x10) * 4))
		              (piVar1,*(undefined4 *)(param2_00 + 0xc),
		               *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + *piVar1 + 0x14));
		    return;
		  }
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param2_00,
		             Method_Gameplay_WorldAxis_Office_View_History_HistoryView___c__DisplayClass17_0__Init_b__0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x298) * 4))
		            (piVar1,param1_00,*(undefined4 *)(*piVar1 + 0x29c));
		  return;
		}
		*/

}
