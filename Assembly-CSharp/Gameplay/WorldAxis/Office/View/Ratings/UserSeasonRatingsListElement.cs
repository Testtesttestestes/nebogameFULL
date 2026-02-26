using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000304")]
	public class UserSeasonRatingsListElement : GenericListElement<UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs>
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		public UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs Data
		{
			[Token(Token = "0x6001215")]
			[Address(RVA = "0x6410", Offset = "0x6410", VA = "0x6410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001216")]
			[Address(RVA = "0x6411", Offset = "0x6411", VA = "0x6411")]
			set
			{
			}
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x6412", Offset = "0x6412", VA = "0x6412", Slot = "4")]
		protected override void OnInit(UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement__OnInit
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  
		  iVar2 = param2[5];
		  iVar3 = *(int *)(param1 + 0x20);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  Gameplay_Rating_View_UserView__get_UserData(*(undefined4 *)(iVar3 + 8),iVar2,0);
		  uVar4 = *(undefined4 *)(iVar3 + 0xc);
		  uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                    (*(undefined4 *)(iVar2 + 0x4c),0);
		  AssetContent_GameImage__get_AssetId(uVar4,uVar1,0);
		  uVar4 = *(undefined4 *)(iVar3 + 0x10);
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(iVar2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(iVar3 + 0x14),param2_00,0);
		  iVar2 = *(int *)(param1 + 0x24);
		  if (*(int *)(*(int *)(iVar2 + 0xc) + 0xc) < param2[6]) {
		    puVar5 = (undefined4 *)(iVar2 + 0x14);
		    if ((char)param2[7] == '\0') {
		      puVar5 = (undefined4 *)(iVar2 + 0x10);
		    }
		  }
		  else {
		    puVar5 = (undefined4 *)(param2[6] * 4 + *(int *)(iVar2 + 0xc) + 0xc);
		  }
		  func_ii_7050(*(undefined4 *)(iVar2 + 8),*puVar5,0);
		  Gameplay_WorldAxis_Office_View_Ratings_MultipleScoresViewElement__Init
		            (*(undefined4 *)(param1 + 0x28),param2[3],param2[4],param2);
		  return;
		}
		*/

		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x6413", Offset = "0x6413", VA = "0x6413")]
		private void ApplyArgs(UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs args)
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement__ApplyArgs
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58baf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___ctor__
		              );
		    DAT_ram_00a58baf = '\x01';
		  }
		  UI_Elements_GenericList_GenericListArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001219")]
		[Address(RVA = "0x6414", Offset = "0x6414", VA = "0x6414")]
		public UserSeasonRatingsListElement()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement___ctor
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = func_ii_4443(param1 + 0x18,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UserInRatingViewElements _baseElements;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DecorViewElements _decorElements;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MultipleScoresViewElement _scores;

		// Token: 0x02000305 RID: 773
		[Token(Token = "0x2000305")]
		public class UserSeasonRatingsListElementArgs : GenericListElementArgs
		{
			// Token: 0x170002BE RID: 702
			// (get) Token: 0x0600121A RID: 4634 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002BE")]
			public virtual string PlaceString
			{
				[Token(Token = "0x600121A")]
				[Address(RVA = "0x6415", Offset = "0x6415", VA = "0x6415", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600121B RID: 4635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600121B")]
			[Address(RVA = "0x6416", Offset = "0x6416", VA = "0x6416")]
			public UserSeasonRatingsListElementArgs()
			{
			}

			// Token: 0x04000982 RID: 2434
			[Token(Token = "0x4000982")]
			[FieldOffset(Offset = "0xC")]
			public IList<int> UserRatingsIndexes;

			// Token: 0x04000983 RID: 2435
			[Token(Token = "0x4000983")]
			[FieldOffset(Offset = "0x10")]
			public IList<long> Scores;

			// Token: 0x04000984 RID: 2436
			[Token(Token = "0x4000984")]
			[FieldOffset(Offset = "0x14")]
			public UserData UserData;

			// Token: 0x04000985 RID: 2437
			[Token(Token = "0x4000985")]
			[FieldOffset(Offset = "0x18")]
			public int Place;

			// Token: 0x04000986 RID: 2438
			[Token(Token = "0x4000986")]
			[FieldOffset(Offset = "0x1C")]
			public bool MyUser;
		}

		// Token: 0x02000306 RID: 774
		[Token(Token = "0x2000306")]
		public class MyUserSeasonRatingsListElementArgs : UserSeasonRatingsListElement.UserSeasonRatingsListElementArgs
		{
			// Token: 0x170002BF RID: 703
			// (get) Token: 0x0600121C RID: 4636 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170002BF")]
			public override string PlaceString
			{
				[Token(Token = "0x600121C")]
				[Address(RVA = "0x6417", Offset = "0x6417", VA = "0x6417", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600121D RID: 4637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600121D")]
			[Address(RVA = "0x6418", Offset = "0x6418", VA = "0x6418")]
			public MyUserSeasonRatingsListElementArgs()
			{
			}

			// Token: 0x04000987 RID: 2439
			[Token(Token = "0x4000987")]
			[FieldOffset(Offset = "0x20")]
			public string PlaceText;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement__get_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58bad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__get_Initted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__set_args__
		              );
		    DAT_ram_00a58bad = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1,param2,
		               Method_UI_Elements_GenericList_GenericListElement_UserSeasonRatingsListElement_UserSeasonRatingsListElementArgs__Init__
		              );
		    return;
		  }
		  *(undefined4 *)(param1 + 0x18) = param2;
		  Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement__OnInit(param1,param2,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement__set_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param3_00;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58bae == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_int__TypeInfo);
		    DAT_ram_00a58bae = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x28);
		  param1_01 = *(int **)(param2 + 0xc);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_int__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f82218;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_01,System_Collections_Generic_ICollection_int__TypeInfo,0)
		  ;
		code_r0x80f82218:
		  param2_00 = (**(code **)((ulonglong)*param3_00 * 4))(param1_01,param3_00[1]);
		  Gameplay_WorldAxis_Office_View_Ratings_DecorViewElements___ctor(param1_00,param2_00,param3_00);
		  Gameplay_WorldAxis_Office_View_Ratings_UserSeasonRatingsListElement__OnInit
		            (param1,param2,param3_00);
		  return;
		}
		*/

}
