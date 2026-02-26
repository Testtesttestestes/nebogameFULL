using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab
{
	// Token: 0x02000A1E RID: 2590
	[Token(Token = "0x2000A1E")]
	public class ClanWarsHistoryView : MonoBehaviourWithStates<ClanWarsHistoryView.HistoryState>
	{
		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C37")]
		public ClanWarsHistoryInfoBox InfoBox
		{
			[Token(Token = "0x6003D81")]
			[Address(RVA = "0x8C40", Offset = "0x8C40", VA = "0x8C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C38")]
		public Button InfoButton
		{
			[Token(Token = "0x6003D82")]
			[Address(RVA = "0x8C41", Offset = "0x8C41", VA = "0x8C41")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C39")]
		public Button MembersButton
		{
			[Token(Token = "0x6003D83")]
			[Address(RVA = "0x8C42", Offset = "0x8C42", VA = "0x8C42")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06003D84 RID: 15748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C3A")]
		public Button WarButton
		{
			[Token(Token = "0x6003D84")]
			[Address(RVA = "0x8C43", Offset = "0x8C43", VA = "0x8C43")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3B")]
		public Action MoreItemsAfterNeededEvent
		{
			[Token(Token = "0x6003D85")]
			[Address(RVA = "0x8C44", Offset = "0x8C44", VA = "0x8C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D86")]
			[Address(RVA = "0x8C45", Offset = "0x8C45", VA = "0x8C45")]
			set
			{
			}
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D87")]
		[Address(RVA = "0x8C46", Offset = "0x8C46", VA = "0x8C46")]
		public void Init(IList<ClanWarHistoryListElement.ClanWarHistoryListElementArgs> items)
		{
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D88")]
		[Address(RVA = "0x8C47", Offset = "0x8C47", VA = "0x8C47")]
		public void Add(IList<ClanWarHistoryListElement.ClanWarHistoryListElementArgs> items)
		{
		/* --- GHIDRA: Add ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__Add
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57f52 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_ClanWarsHistoryViewsHolder__ClanWarHistoryListElement_ClanWarHistoryListElementArgs__RemoveItems__
		              );
		    DAT_ram_00a57f52 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___OnInitialized
		            (*(undefined4 *)(param1 + 0x1c),param2,param3,
		             Method_UI_OSAGenericBase_ClanWarsHistoryViewsHolder__ClanWarHistoryListElement_ClanWarHistoryListElementArgs__RemoveItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D89")]
		[Address(RVA = "0x8C48", Offset = "0x8C48", VA = "0x8C48")]
		public void Remove(int count, bool fromEnd)
		{
		/* --- GHIDRA: Remove ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__Remove
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57f53 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_ClanWarsHistoryViewsHolder__ClanWarHistoryListElement_ClanWarHistoryListElementArgs__ActivateRequestBounds__
		              );
		    DAT_ram_00a57f53 = '\x01';
		  }
		  UI_OSADynamicBase_object__object____ctor
		            (*(undefined4 *)(param1 + 0x1c),param2,0,
		             Method_UI_OSADynamicBase_ClanWarsHistoryViewsHolder__ClanWarHistoryListElement_ClanWarHistoryListElementArgs__ActivateRequestBounds__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D8A")]
		[Address(RVA = "0x8C49", Offset = "0x8C49", VA = "0x8C49")]
		public void ActivateUpperBound(bool activate)
		{
		/* --- GHIDRA: ActivateUpperBound ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__ActivateUpperBound
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanWarsHistoryView_HistoryState___ctor__);
		    DAT_ram_00a57f54 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ClanWarsHistoryView_HistoryState___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D8B")]
		[Address(RVA = "0x8C4A", Offset = "0x8C4A", VA = "0x8C4A")]
		public ClanWarsHistoryView()
		{
		}

		// Token: 0x0400225B RID: 8795
		[Token(Token = "0x400225B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanWarsHistoryOSAView _osaView;

		// Token: 0x0400225C RID: 8796
		[Token(Token = "0x400225C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanWarsHistoryInfoBox _infoBox;

		// Token: 0x0400225D RID: 8797
		[Token(Token = "0x400225D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x0400225E RID: 8798
		[Token(Token = "0x400225E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _membersButton;

		// Token: 0x02000A1F RID: 2591
		[Token(Token = "0x2000A1F")]
		public enum HistoryState
		{
			// Token: 0x04002260 RID: 8800
			[Token(Token = "0x4002260")]
			UNKNOWN_STATE,
			// Token: 0x04002261 RID: 8801
			[Token(Token = "0x4002261")]
			COMMON,
			// Token: 0x04002262 RID: 8802
			[Token(Token = "0x4002262")]
			NO_HISTORY
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MembersButton ---
		undefined4
		Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__get_MembersButton
		          (int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x20) + 0x2c);
		}
		*/


		/* --- GHIDRA: set_MoreItemsAfterNeededEvent ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView__set_MoreItemsAfterNeededEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57f51 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClanWarsHistoryViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView___c__DisplayClass16_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView___c__DisplayClass16_0_TypeInfo
		              );
		    DAT_ram_00a57f51 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView___c__DisplayClass16_0_TypeInfo
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
		             Method_Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryView___c__DisplayClass16_0__Init_b__0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x298) * 4))
		            (piVar1,param1_00,*(undefined4 *)(*piVar1 + 0x29c));
		  return;
		}
		*/

}
