using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements.SubRatings;
using UI.Toggle;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.VacanciesTab
{
	// Token: 0x02000A09 RID: 2569
	[Token(Token = "0x2000A09")]
	public class VacanciesView : MonoBehaviour
	{
		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06003D02 RID: 15618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C09")]
		public SubRatingsList SubRatings
		{
			[Token(Token = "0x6003D02")]
			[Address(RVA = "0x8BC2", Offset = "0x8BC2", VA = "0x8BC2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0A")]
		public GenericFilterView FilterView
		{
			[Token(Token = "0x6003D03")]
			[Address(RVA = "0x8BC3", Offset = "0x8BC3", VA = "0x8BC3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06003D04 RID: 15620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0B")]
		public ClanVacancyInfoBox ClanInfoBox
		{
			[Token(Token = "0x6003D04")]
			[Address(RVA = "0x8BC4", Offset = "0x8BC4", VA = "0x8BC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0C")]
		public SearchInput SearchInput
		{
			[Token(Token = "0x6003D05")]
			[Address(RVA = "0x8BC5", Offset = "0x8BC5", VA = "0x8BC5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06003D06 RID: 15622 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0D")]
		public GreenToggle AvailableFilter
		{
			[Token(Token = "0x6003D06")]
			[Address(RVA = "0x8BC6", Offset = "0x8BC6", VA = "0x8BC6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06003D07 RID: 15623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0E")]
		public Button SearchButton
		{
			[Token(Token = "0x6003D07")]
			[Address(RVA = "0x8BC7", Offset = "0x8BC7", VA = "0x8BC7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06003D08 RID: 15624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C0F")]
		public Button ResetButton
		{
			[Token(Token = "0x6003D08")]
			[Address(RVA = "0x8BC8", Offset = "0x8BC8", VA = "0x8BC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C10")]
		public RequestedClanListElement RequestedClan
		{
			[Token(Token = "0x6003D09")]
			[Address(RVA = "0x8BC9", Offset = "0x8BC9", VA = "0x8BC9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C11")]
		public Button InfoButton
		{
			[Token(Token = "0x6003D0A")]
			[Address(RVA = "0x8BCA", Offset = "0x8BCA", VA = "0x8BCA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D0C RID: 15628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C12")]
		public Action MoreItemsAfterNeededEvent
		{
			[Token(Token = "0x6003D0B")]
			[Address(RVA = "0x8BCB", Offset = "0x8BCB", VA = "0x8BCB")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D0C")]
			[Address(RVA = "0x8BCC", Offset = "0x8BCC", VA = "0x8BCC")]
			set
			{
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D0E RID: 15630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C13")]
		public Action MoreItemsBeforeNeededEvent
		{
			[Token(Token = "0x6003D0D")]
			[Address(RVA = "0x8BCD", Offset = "0x8BCD", VA = "0x8BCD")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D0E")]
			[Address(RVA = "0x8BCE", Offset = "0x8BCE", VA = "0x8BCE")]
			set
			{
			}
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D0F")]
		[Address(RVA = "0x8BCF", Offset = "0x8BCF", VA = "0x8BCF")]
		public void Init(IList<ClanInRatingListElement.ClanInRatingListElementArgs> items)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__Init
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar1 + 8) * 4
		              ))(*(int **)(param1 + 0x10),param2,param3,
		                 *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar1 + 0xc));
		  return;
		}
		*/

		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x8BD0", Offset = "0x8BD0", VA = "0x8BD0")]
		public void Add(IList<ClanInRatingListElement.ClanInRatingListElementArgs> items, bool atEnd)
		{
		/* --- GHIDRA: Add ---
		void Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__Add
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57f17 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_ClansInRatingsViewsHolder__ClanInRatingListElement_ClanInRatingListElementArgs__RemoveItems__
		              );
		    DAT_ram_00a57f17 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___OnInitialized
		            (*(undefined4 *)(param1 + 0x10),param2,param3,
		             Method_UI_OSAGenericBase_ClansInRatingsViewsHolder__ClanInRatingListElement_ClanInRatingListElementArgs__RemoveItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x8BD1", Offset = "0x8BD1", VA = "0x8BD1")]
		public void Remove(int count, bool fromEnd)
		{
		/* --- GHIDRA: Remove ---
		void Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__Remove
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57f18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_ClansInRatingsViewsHolder__ClanInRatingListElement_ClanInRatingListElementArgs__ActivateRequestBounds__
		              );
		    DAT_ram_00a57f18 = '\x01';
		  }
		  UI_OSADynamicBase_object__object____ctor
		            (*(undefined4 *)(param1 + 0x10),param2,param3,
		             Method_UI_OSADynamicBase_ClansInRatingsViewsHolder__ClanInRatingListElement_ClanInRatingListElementArgs__ActivateRequestBounds__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x8BD2", Offset = "0x8BD2", VA = "0x8BD2")]
		public void SetScrollBounds(bool activateUpperBound, bool activateLowerBound)
		{
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D13")]
		[Address(RVA = "0x8BD3", Offset = "0x8BD3", VA = "0x8BD3")]
		public VacanciesView()
		{
		}

		// Token: 0x040021E0 RID: 8672
		[Token(Token = "0x40021E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ClansInRatingsOSAView _osaView;

		// Token: 0x040021E1 RID: 8673
		[Token(Token = "0x40021E1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SubRatingsList _subRatings;

		// Token: 0x040021E2 RID: 8674
		[Token(Token = "0x40021E2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GenericFilterView _filterView;

		// Token: 0x040021E3 RID: 8675
		[Token(Token = "0x40021E3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanVacancyInfoBox _clanInfoBox;

		// Token: 0x040021E4 RID: 8676
		[Token(Token = "0x40021E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GreenToggle _availableFilter;

		// Token: 0x040021E5 RID: 8677
		[Token(Token = "0x40021E5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SearchInput _searchInput;

		// Token: 0x040021E6 RID: 8678
		[Token(Token = "0x40021E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _searchButton;

		// Token: 0x040021E7 RID: 8679
		[Token(Token = "0x40021E7")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _resetButton;

		// Token: 0x040021E8 RID: 8680
		[Token(Token = "0x40021E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RequestedClanListElement _requestedClan;

		// Token: 0x040021E9 RID: 8681
		[Token(Token = "0x40021E9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _infoButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_MoreItemsAfterNeededEvent ---
		undefined4
		Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__set_MoreItemsAfterNeededEvent
		          (int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0xac);
		}
		*/


		/* --- GHIDRA: get_MoreItemsBeforeNeededEvent ---
		void Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__get_MoreItemsBeforeNeededEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 0x10) + 0xac) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_MoreItemsBeforeNeededEvent ---
		void Gameplay_Clans_Office_View_VacanciesTab_VacanciesView__set_MoreItemsBeforeNeededEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57f16 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClansInRatingsViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_VacanciesTab_VacanciesView___c__DisplayClass34_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_View_VacanciesTab_VacanciesView___c__DisplayClass34_0_TypeInfo
		              );
		    DAT_ram_00a57f16 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_VacanciesTab_VacanciesView___c__DisplayClass34_0_TypeInfo
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
		             Method_Gameplay_Clans_Office_View_VacanciesTab_VacanciesView___c__DisplayClass34_0__Init_b__0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x298) * 4))
		            (piVar1,param1_00,*(undefined4 *)(*piVar1 + 0x29c));
		  return;
		}
		*/

}
