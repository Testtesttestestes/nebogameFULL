using System;
using System.Collections.Generic;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	public class ClanSeasonRatingsListElement : GenericListElement<ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs>
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B5")]
		public ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs Data
		{
			[Token(Token = "0x60011F4")]
			[Address(RVA = "0x63EF", Offset = "0x63EF", VA = "0x63EF")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011F5")]
			[Address(RVA = "0x63F0", Offset = "0x63F0", VA = "0x63F0")]
			set
			{
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x63F1", Offset = "0x63F1", VA = "0x63F1", Slot = "4")]
		protected override void OnInit(ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement__OnInit
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param2 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x63F2", Offset = "0x63F2", VA = "0x63F2")]
		private void OnClickEventHandler(ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs args)
		{
		/* --- GHIDRA: OnClickEventHandler ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement__OnClickEventHandler
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 *puVar2;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  iVar1 = param2[5];
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  Gameplay_WorldAxis_Office_View_Ratings_ClanInRatingViewElements__AssignAssets
		            (param1_00,iVar1,param3_00,param2);
		  iVar1 = *(int *)(param1 + 0x24);
		  if (*(int *)(*(int *)(iVar1 + 0xc) + 0xc) < param2[6]) {
		    puVar2 = (undefined4 *)(iVar1 + 0x14);
		    if ((char)param2[7] == '\0') {
		      puVar2 = (undefined4 *)(iVar1 + 0x10);
		    }
		  }
		  else {
		    puVar2 = (undefined4 *)(param2[6] * 4 + *(int *)(iVar1 + 0xc) + 0xc);
		  }
		  func_ii_7050(*(undefined4 *)(iVar1 + 8),*puVar2,0);
		  Gameplay_WorldAxis_Office_View_Ratings_MultipleScoresViewElement__Init
		            (*(undefined4 *)(param1 + 0x28),param2[3],param2[4],param2);
		  return;
		}
		*/

		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x63F3", Offset = "0x63F3", VA = "0x63F3")]
		private void ApplyArgs(ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs args)
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement__ApplyArgs
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ba1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___ctor__
		              );
		    DAT_ram_00a58ba1 = '\x01';
		  }
		  UI_Elements_GenericList_GenericListArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x63F4", Offset = "0x63F4", VA = "0x63F4")]
		public ClanSeasonRatingsListElement()
		{
		}

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanInRatingViewElements _baseElements;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DecorViewElements _decorElements;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MultipleScoresViewElement _scores;

		// Token: 0x020002FA RID: 762
		[Token(Token = "0x20002FA")]
		public class ClanSeasonRatingsListElementArgs : GenericListElementArgs
		{
			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x060011FA RID: 4602 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002B6")]
			public virtual string PlaceString
			{
				[Token(Token = "0x60011FA")]
				[Address(RVA = "0x63F5", Offset = "0x63F5", VA = "0x63F5", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060011FB RID: 4603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011FB")]
			[Address(RVA = "0x63F6", Offset = "0x63F6", VA = "0x63F6")]
			public ClanSeasonRatingsListElementArgs()
			{
			}

			// Token: 0x04000965 RID: 2405
			[Token(Token = "0x4000965")]
			[FieldOffset(Offset = "0xC")]
			public IList<int> ClanRatingsIndexes;

			// Token: 0x04000966 RID: 2406
			[Token(Token = "0x4000966")]
			[FieldOffset(Offset = "0x10")]
			public IList<long> Scores;

			// Token: 0x04000967 RID: 2407
			[Token(Token = "0x4000967")]
			[FieldOffset(Offset = "0x14")]
			public ClanData ClanData;

			// Token: 0x04000968 RID: 2408
			[Token(Token = "0x4000968")]
			[FieldOffset(Offset = "0x18")]
			public int Place;

			// Token: 0x04000969 RID: 2409
			[Token(Token = "0x4000969")]
			[FieldOffset(Offset = "0x1C")]
			public bool MyClan;

			// Token: 0x0400096A RID: 2410
			[Token(Token = "0x400096A")]
			[FieldOffset(Offset = "0x20")]
			public Action<ClanSeasonRatingsListElement> ButtonClickedEvent;
		}

		// Token: 0x020002FB RID: 763
		[Token(Token = "0x20002FB")]
		public class MyClanSeasonRatingsListElementArgs : ClanSeasonRatingsListElement.ClanSeasonRatingsListElementArgs
		{
			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x060011FC RID: 4604 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002B7")]
			public override string PlaceString
			{
				[Token(Token = "0x60011FC")]
				[Address(RVA = "0x63F7", Offset = "0x63F7", VA = "0x63F7", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060011FD RID: 4605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011FD")]
			[Address(RVA = "0x63F8", Offset = "0x63F8", VA = "0x63F8")]
			public MyClanSeasonRatingsListElementArgs()
			{
			}

			// Token: 0x0400096B RID: 2411
			[Token(Token = "0x400096B")]
			[FieldOffset(Offset = "0x24")]
			public string PlaceText;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement__get_Data
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 *puVar2;
		  
		  if (DAT_ram_00a58b9f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__get_Initted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__set_args__
		              );
		    DAT_ram_00a58b9f = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1,param2,
		               Method_UI_Elements_GenericList_GenericListElement_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__Init__
		              );
		    return;
		  }
		  *(int **)(param1 + 0x18) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  iVar1 = param2[5];
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  Gameplay_WorldAxis_Office_View_Ratings_ClanInRatingViewElements__AssignAssets
		            (param1_00,iVar1,param3_00,param2);
		  iVar1 = *(int *)(param1 + 0x24);
		  if (*(int *)(*(int *)(iVar1 + 0xc) + 0xc) < param2[6]) {
		    puVar2 = (undefined4 *)(iVar1 + 0x14);
		    if ((char)param2[7] == '\0') {
		      puVar2 = (undefined4 *)(iVar1 + 0x10);
		    }
		  }
		  else {
		    puVar2 = (undefined4 *)(param2[6] * 4 + *(int *)(iVar1 + 0xc) + 0xc);
		  }
		  func_ii_7050(*(undefined4 *)(iVar1 + 8),*puVar2,0);
		  Gameplay_WorldAxis_Office_View_Ratings_MultipleScoresViewElement__Init
		            (*(undefined4 *)(param1 + 0x28),param2[3],param2[4],param2);
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement__set_Data
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param3_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 *param4;
		  int param4_00;
		  
		  if (DAT_ram_00a58ba0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_OnClickEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               UnityEngine_Events_UnityAction_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__AddListener__
		              );
		    DAT_ram_00a58ba0 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x28);
		  param1_00 = (int *)param2[3];
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_int__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f817c2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_int__TypeInfo,0)
		  ;
		code_r0x80f817c2:
		  uVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		  Gameplay_WorldAxis_Office_View_Ratings_DecorViewElements___ctor(uVar3,uVar2,param3_00);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar3 = unnamed_function_1417
		                    (
		                    UnityEngine_Events_UnityAction_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__TypeInfo
		                    );
		  func_ii_7054(uVar3,param1,
		               Method_Gameplay_WorldAxis_Office_View_Ratings_ClanSeasonRatingsListElement_OnClickEventHandler__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar3,
		             Method_UnityEngine_Events_UnityEvent_ClanSeasonRatingsListElement_ClanSeasonRatingsListElementArgs__AddListener__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  iVar4 = param2[5];
		  param4_00 = *param2;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(param4_00 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(param4_00 + 0xe4));
		  Gameplay_WorldAxis_Office_View_Ratings_ClanInRatingViewElements__AssignAssets
		            (uVar2,iVar4,uVar3,param4_00);
		  iVar4 = *(int *)(param1 + 0x24);
		  if (*(int *)(*(int *)(iVar4 + 0xc) + 0xc) < param2[6]) {
		    param4 = (undefined4 *)(iVar4 + 0x14);
		    if ((char)param2[7] == '\0') {
		      param4 = (undefined4 *)(iVar4 + 0x10);
		    }
		  }
		  else {
		    param4 = (undefined4 *)(param2[6] * 4 + *(int *)(iVar4 + 0xc) + 0xc);
		  }
		  func_ii_7050(*(undefined4 *)(iVar4 + 8),*param4,0);
		  Gameplay_WorldAxis_Office_View_Ratings_MultipleScoresViewElement__Init
		            (*(undefined4 *)(param1 + 0x28),param2[3],param2[4],param4);
		  return;
		}
		*/

}
