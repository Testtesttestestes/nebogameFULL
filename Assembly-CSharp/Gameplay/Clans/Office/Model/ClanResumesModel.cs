using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Dict;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Rating;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A4A RID: 2634
	[Token(Token = "0x2000A4A")]
	public class ClanResumesModel : AbstractModel
	{
		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06003E62 RID: 15970 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C81")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E62")]
			[Address(RVA = "0x8D21", Offset = "0x8D21", VA = "0x8D21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x0000C528 File Offset: 0x0000A728
		// (set) Token: 0x06003E64 RID: 15972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C82")]
		public int MaxListCount
		{
			[Token(Token = "0x6003E63")]
			[Address(RVA = "0x8D22", Offset = "0x8D22", VA = "0x8D22")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003E64")]
			[Address(RVA = "0x8D23", Offset = "0x8D23", VA = "0x8D23")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E65")]
		[Address(RVA = "0x8D24", Offset = "0x8D24", VA = "0x8D24")]
		public ClanResumesModel(UserData user, ClanInfoModel clanInfoModel)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Clans_Office_Model_ClanResumesModel___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57fa2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs___Peek__
		              );
		    DAT_ram_00a57fa2 = '\x01';
		  }
		  uVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                    (*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs___Peek__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E66")]
		[Address(RVA = "0x8D25", Offset = "0x8D25", VA = "0x8D25")]
		public IList<UserInRatingListElement.UserInRatingListElementArgs> GetLastPage()
		{
		/* --- GHIDRA: GetLastPage ---
		void Gameplay_Clans_Office_Model_ClanResumesModel__GetLastPage
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 param3_00;
		  int iVar4;
		  int iVar5;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57fa3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_UserInRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs___Clear__
		              );
		    DAT_ram_00a57fa3 = '\x01';
		  }
		  System_Collections_Generic_Stack_BindingRestrictions_TestBuilder_AndNode____ctor
		            (*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs___Clear__
		            );
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_UserInRating__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e8893a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_UserInRating__TypeInfo
		                                ,0);
		code_r0x80e8893a:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar4 = param1;
		  if (iVar3 < 1) {
		    param3_00 = 10;
		  }
		  else {
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (System_Collections_Generic_ICollection_UserInRating__TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e889cd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_UserInRating__TypeInfo,0);
		code_r0x80e889cd:
		    param3_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar3 < 1) {
		      iVar4 = 0;
		    }
		  }
		  *(undefined4 *)(iVar4 + 0x1c) = param3_00;
		  Gameplay_Clans_Office_Model_ClanResumesModel__CreateUsersList(param1,param2,param3_00);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E67")]
		[Address(RVA = "0x8D26", Offset = "0x8D26", VA = "0x8D26")]
		public void CreateUsersList(IList<UserInRating> usersList)
		{
		/* --- GHIDRA: CreateUsersList ---
		void Gameplay_Clans_Office_Model_ClanResumesModel__CreateUsersList
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57fa4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserInRating__UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserInRating__int__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs___Push__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs___get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_ClanResumesModel___c__DisplayClass13_0__AddUsersList_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_ClanResumesModel___c__DisplayClass13_0_TypeInfo);
		    DAT_ram_00a57fa4 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Clans_Office_Model_ClanResumesModel___c__DisplayClass13_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 8) = param1;
		  *(int *)(param2_00 + 0xc) = *(int *)(param1 + 0x1c) * *(int *)(*(int *)(param1 + 0x14) + 0xc);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_UserInRating__int__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                    );
		  System_Func_object__int__long___Invoke
		            (uVar1,param2_00,
		             Method_Gameplay_Clans_Office_Model_ClanResumesModel___c__DisplayClass13_0__AddUsersList_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_UserInRating__UserInRatingListElement_UserInRatingListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		                      );
		  System_Linq_Expressions_Expression__Parameter
		            (*(undefined4 *)(param1 + 0x14),uVar1,
		             Method_System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs___Push__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E68")]
		[Address(RVA = "0x8D27", Offset = "0x8D27", VA = "0x8D27")]
		public void AddUsersList(IList<UserInRating> usersList)
		{
		/* --- GHIDRA: AddUsersList ---
		int Gameplay_Clans_Office_Model_ClanResumesModel__AddUsersList
		              (int param1,int param2,int *param3,int *param4,undefined4 param5)
		
		{
		  int param1_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  double dVar4;
		  longlong lVar5;
		  uint uVar6;
		  longlong lVar7;
		  
		  if (DAT_ram_00a57fa5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a57fa5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a57f6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElementArgs_UserInRatingListElement___ctor__
		              );
		    DAT_ram_00a57f6d = '\x01';
		  }
		  uVar6 = 0;
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1_00,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_UserInRatingListElement___ctor__
		            );
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  param1_01 = *(int **)(param1 + 0x18);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8))
		      {
		        puVar1 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e88b9b;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80e88b9b:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,uVar2,puVar1[1]);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  dVar4 = *(double *)(param2 + 0x10);
		  if (dVar4 < 1.8446744073709552e+19 && 0.0 <= dVar4) {
		    lVar5 = (longlong)dVar4;
		  }
		  else {
		    lVar5 = 0;
		  }
		  if (ABS(dVar4) < 9.223372036854776e+18) {
		    lVar7 = (longlong)dVar4;
		  }
		  else {
		    lVar7 = -0x8000000000000000;
		  }
		  if (0.0 <= dVar4) {
		    lVar7 = lVar5;
		  }
		  *(longlong *)(param1_00 + 0x20) = lVar7;
		  *(int *)(param1_00 + 0x28) = *param3 + *param4 + 1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E69")]
		[Address(RVA = "0x8D28", Offset = "0x8D28", VA = "0x8D28")]
		private UserInRatingListElement.UserInRatingListElementArgs ConstructArgs(UserInRating userInRating, in int index, in int prevCount)
		{
			return null;
		}

		// Token: 0x04002311 RID: 8977
		[Token(Token = "0x4002311")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04002312 RID: 8978
		[Token(Token = "0x4002312")]
		[FieldOffset(Offset = "0x10")]
		public readonly ClanInfoModel ClanInfoModel;

		// Token: 0x04002313 RID: 8979
		[Token(Token = "0x4002313")]
		[FieldOffset(Offset = "0x14")]
		public readonly Stack<IList<UserInRatingListElement.UserInRatingListElementArgs>> UsersInRatingStack;

		// Token: 0x04002314 RID: 8980
		[Token(Token = "0x4002314")]
		[FieldOffset(Offset = "0x18")]
		private readonly IUserCache _userCache;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_MaxListCount ---
		void Gameplay_Clans_Office_Model_ClanResumesModel__set_MaxListCount
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57fa1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs___TypeInfo
		              );
		    DAT_ram_00a57fa1 = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs___TypeInfo
		                    );
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar2,
		             Method_System_Collections_Generic_Stack_IList_UserInRatingListElement_UserInRatingListElementArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x10) = param3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80e88796;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e88796:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x80e88845;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e88845:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined4 *)(param1 + 0x18) = *(undefined4 *)(iVar5 + 0x14);
		  return;
		}
		*/

}
