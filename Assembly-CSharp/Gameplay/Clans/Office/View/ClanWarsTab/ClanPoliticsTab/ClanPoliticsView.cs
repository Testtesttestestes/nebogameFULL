using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UI.Elements.Filters.GenericFilter;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab
{
	// Token: 0x02000A26 RID: 2598
	[Token(Token = "0x2000A26")]
	public class ClanPoliticsView : MonoBehaviour
	{
		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C3E")]
		public SearchInput SearchInput
		{
			[Token(Token = "0x6003D9E")]
			[Address(RVA = "0x8C5D", Offset = "0x8C5D", VA = "0x8C5D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06003D9F RID: 15775 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C3F")]
		public Button SearchButton
		{
			[Token(Token = "0x6003D9F")]
			[Address(RVA = "0x8C5E", Offset = "0x8C5E", VA = "0x8C5E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06003DA0 RID: 15776 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C40")]
		public GenericFilterView FilterView
		{
			[Token(Token = "0x6003DA0")]
			[Address(RVA = "0x8C5F", Offset = "0x8C5F", VA = "0x8C5F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06003DA1 RID: 15777 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C41")]
		public GenericSubFilterView SubFilters
		{
			[Token(Token = "0x6003DA1")]
			[Address(RVA = "0x8C60", Offset = "0x8C60", VA = "0x8C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06003DA2 RID: 15778 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C42")]
		public ClanPolicyListElement MyClan
		{
			[Token(Token = "0x6003DA2")]
			[Address(RVA = "0x8C61", Offset = "0x8C61", VA = "0x8C61")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06003DA3 RID: 15779 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C43")]
		public ClanPolicyInfoBox InfoBox
		{
			[Token(Token = "0x6003DA3")]
			[Address(RVA = "0x8C62", Offset = "0x8C62", VA = "0x8C62")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06003DA4 RID: 15780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C44")]
		public Button MyZigguratButton
		{
			[Token(Token = "0x6003DA4")]
			[Address(RVA = "0x8C63", Offset = "0x8C63", VA = "0x8C63")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06003DA5 RID: 15781 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003DA6 RID: 15782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C45")]
		public Action MoreItemsAfterNeededEvent
		{
			[Token(Token = "0x6003DA5")]
			[Address(RVA = "0x8C64", Offset = "0x8C64", VA = "0x8C64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DA6")]
			[Address(RVA = "0x8C65", Offset = "0x8C65", VA = "0x8C65")]
			set
			{
			}
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA7")]
		[Address(RVA = "0x8C66", Offset = "0x8C66", VA = "0x8C66")]
		public void Init(IList<ClanPolicyListElement.ClanPolicyListElementArgs> items)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar1 + 8) * 4
		              ))(*(int **)(param1 + 0x10),param2,1,
		                 *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar1 + 0xc));
		  return;
		}
		*/

		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA8")]
		[Address(RVA = "0x8C67", Offset = "0x8C67", VA = "0x8C67")]
		public void Add(IList<ClanPolicyListElement.ClanPolicyListElementArgs> items)
		{
		/* --- GHIDRA: Add ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__Add
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57f61 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_ClansPoliciesViewsHolder__ClanPolicyListElement_ClanPolicyListElementArgs__ActivateRequestBounds__
		              );
		    DAT_ram_00a57f61 = '\x01';
		  }
		  UI_OSADynamicBase_object__object____ctor
		            (*(undefined4 *)(param1 + 0x10),param2,0,
		             Method_UI_OSADynamicBase_ClansPoliciesViewsHolder__ClanPolicyListElement_ClanPolicyListElementArgs__ActivateRequestBounds__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA9")]
		[Address(RVA = "0x8C68", Offset = "0x8C68", VA = "0x8C68")]
		public void ActivateUpperBound(bool activate)
		{
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DAA")]
		[Address(RVA = "0x8C69", Offset = "0x8C69", VA = "0x8C69")]
		public ClanPoliticsView()
		{
		}

		// Token: 0x04002270 RID: 8816
		[Token(Token = "0x4002270")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ClanPoliciesOSAView _osaView;

		// Token: 0x04002271 RID: 8817
		[Token(Token = "0x4002271")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GenericFilterView _filterView;

		// Token: 0x04002272 RID: 8818
		[Token(Token = "0x4002272")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GenericSubFilterView _subFilters;

		// Token: 0x04002273 RID: 8819
		[Token(Token = "0x4002273")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SearchInput _searchInput;

		// Token: 0x04002274 RID: 8820
		[Token(Token = "0x4002274")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _searchButton;

		// Token: 0x04002275 RID: 8821
		[Token(Token = "0x4002275")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ClanPolicyListElement _myClan;

		// Token: 0x04002276 RID: 8822
		[Token(Token = "0x4002276")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClanPolicyInfoBox _infoBox;

		// Token: 0x04002277 RID: 8823
		[Token(Token = "0x4002277")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _myZigguratButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MyZigguratButton ---
		undefined4
		Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MyZigguratButton
		          (int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0xa8);
		}
		*/


		/* --- GHIDRA: get_MoreItemsAfterNeededEvent ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__get_MoreItemsAfterNeededEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 0x10) + 0xa8) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_MoreItemsAfterNeededEvent ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView__set_MoreItemsAfterNeededEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57f60 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClansPoliciesViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView___c__DisplayClass25_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView___c__DisplayClass25_0_TypeInfo
		              );
		    DAT_ram_00a57f60 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView___c__DisplayClass25_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar2 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0x3bc));
		  piVar1 = *(int **)(param1 + 0x10);
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
		             Method_Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliticsView___c__DisplayClass25_0__Init_b__0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x298) * 4))
		            (piVar1,param1_00,*(undefined4 *)(*piVar1 + 0x29c));
		  return;
		}
		*/

}
