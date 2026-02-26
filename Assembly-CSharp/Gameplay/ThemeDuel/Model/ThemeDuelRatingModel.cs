using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Gameplay.Rating.Model;
using Il2CppDummyDll;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.ThemeDuel.Model
{
	// Token: 0x020004E7 RID: 1255
	[Token(Token = "0x20004E7")]
	public class ThemeDuelRatingModel : RatingModel
	{
		// Token: 0x06001DFC RID: 7676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x6F7A", Offset = "0x6F7A", VA = "0x6F7A")]
		public ThemeDuelRatingModel(UserData user, ThemeRatingTypes themeRatingType)
		{
		/* --- GHIDRA: <PopulateUsers>b__7_1 ---
		void Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___PopulateUsers_b__7_1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a585d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo);
		    DAT_ram_00a585d8 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x17000574")]
		public ThemeRatingTypes ThemeRatingType
		{
			[Token(Token = "0x6001DFD")]
			[Address(RVA = "0x6F7B", Offset = "0x6F7B", VA = "0x6F7B")]
			[CompilerGenerated]
			get
			{
				return ThemeRatingTypes.Unknown;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000575")]
		public override FilterListElement.FilterData[] UserPeriodFilterDatas
		{
			[Token(Token = "0x6001DFE")]
			[Address(RVA = "0x6F7C", Offset = "0x6F7C", VA = "0x6F7C", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x6F7D", Offset = "0x6F7D", VA = "0x6F7D")]
		public void PopulateUsers(ProtoGetUserTDRatingAns user, ProtoGetAllUsersTDRatingAns msg, uint ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: PopulateUsers ---
		int Gameplay_ThemeDuel_Model_ThemeDuelRatingModel__PopulateUsers
		              (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *puVar2;
		  longlong lVar3;
		  undefined4 uVar4;
		  int *param1_01;
		  int iVar5;
		  longlong lVar6;
		  
		  if (DAT_ram_00a585d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a585d7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(param1_00,0);
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  param1_01 = *(int **)(param1 + 0x10);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f105e2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80f105e2:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,uVar4,puVar2[1]);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar4;
		  *(ulonglong *)(param1_00 + 0x20) = (ulonglong)*(uint *)(param2 + 0x14);
		  *(int *)(param1_00 + 0x28) = *param3 + 1;
		  lVar6 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  *(bool *)(param1_00 + 0x2c) = lVar6 == lVar3;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x6F7E", Offset = "0x6F7E", VA = "0x6F7E")]
		private UserInRatingListElement.UserInRatingListElementArgs ConstructArgs(UserInThemeduelRating userInRating, in int index)
		{
		/* --- GHIDRA: ConstructArgs ---
		undefined4
		Gameplay_ThemeDuel_Model_ThemeDuelRatingModel__ConstructArgs
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = param3;
		  uVar1 = Gameplay_ThemeDuel_Model_ThemeDuelRatingModel__PopulateUsers
		                    (param1,param2,&local_4,auStack_10);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0x48")]
		private FilterListElement.FilterData[] _usersFilterDatas;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ThemeRatingType ---
		int Gameplay_ThemeDuel_Model_ThemeDuelRatingModel__get_ThemeRatingType(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a585d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingPeriods___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__7B3B70304EA74BF607133D385B9D0DF38077AAF895D4E6E910688BB8B14CCF66
		              );
		    DAT_ram_00a585d5 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x48);
		  if (iVar1 == 0) {
		    param1_00 = Mono_Security_ASN1Convert__ToOid(Protocol_Rating_RatingPeriods___TypeInfo,3);
		    System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		              (param1_00,
		               Field__PrivateImplementationDetails__7B3B70304EA74BF607133D385B9D0DF38077AAF895D4E6E910688BB8B14CCF66
		               ,0);
		    iVar1 = Gameplay_Rating_Model_RatingModel__HasCultsCache(param1,param1_00,0);
		    *(int *)(param1 + 0x48) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_UserPeriodFilterDatas ---
		void Gameplay_ThemeDuel_Model_ThemeDuelRatingModel__get_UserPeriodFilterDatas
		               (undefined4 param1,int param2,int param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  bool bVar1;
		  double param5_00;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 *puVar9;
		  int iVar10;
		  int *piVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a585d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderByDescending_UserInThemeduelRating__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserInThemeduelRating__UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_UserInThemeduelRating___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserInThemeduelRating__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_UserInThemeduelRating__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserInThemeduelRating__int__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_UserInThemeduelRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_UserInThemeduelRating__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Model_ThemeDuelRatingModel__PopulateUsers_b__7_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c__PopulateUsers_b__7_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c__PopulateUsers_b__7_2__);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo);
		    DAT_ram_00a585d6 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  if (*(int *)(param2 + 0xc) != 0) {
		    uVar6 = *(uint *)(*(int *)(param2 + 0xc) + 0x14);
		    param5_00 = (double)uVar6;
		    if (uVar6 != 0) {
		      uVar8 = *(undefined4 *)(param3 + 0xc);
		      if (*(int *)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo);
		      }
		      puVar9 = *(undefined4 **)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x5c);
		      iVar7 = puVar9[1];
		      if (iVar7 == 0) {
		        if (*(int *)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo);
		          puVar9 = *(undefined4 **)
		                    (Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x5c);
		        }
		        uVar5 = *puVar9;
		        iVar7 = unnamed_function_1417(System_Func_UserInThemeduelRating__uint__TypeInfo);
		        System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                  (iVar7,uVar5,
		                   Method_Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c__PopulateUsers_b__7_2__,
		                   0);
		        *(int *)(*(int *)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x5c) + 4) =
		             iVar7;
		      }
		      uVar6 = 0;
		      piVar2 = (int *)System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                                (uVar8,iVar7,
		                                 Method_System_Linq_Enumerable_OrderByDescending_UserInThemeduelRating__uint___
		                                );
		      iVar7 = *piVar2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_UserInThemeduelRating__TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar6 * 8)) {
		            puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80f100f1;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar6);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,
		                                    System_Collections_Generic_IEnumerable_UserInThemeduelRating__TypeInfo
		                                    ,0);
		code_r0x80f100f1:
		      local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      local_c = 0;
		      local_8 = &local_4;
		      iVar7 = 1;
		      do {
		        piVar2 = local_4;
		        iVar10 = *local_4;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar6 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar6 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar9 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80f101b4;
		            }
		            uVar6 = uVar6 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar6);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar9 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f10302:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f1030a:
		          iVar10 = global_1;
		          iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar10 == iVar4) {
		            piVar2 = (int *)import::env::__cxa_begin_catch(uVar8);
		            iVar4 = *piVar2;
		            DAT_ram_009d3e38 = 0;
		            local_c = iVar4;
		            import::env::invoke_v(0x123);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            bVar1 = true;
		            if (iVar10 != 1) goto code_r0x80f10357;
		            uVar8 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x188,&local_c);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            import::env::__cxa_find_matching_catch_3(0);
		            unnamed_function_937();
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__resumeException(uVar8);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x80f101b4:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar9,piVar2,puVar9[1]);
		        piVar2 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f10302;
		        if (iVar10 == 0) goto code_r0x80f102db;
		        iVar10 = *local_4;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar6 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar6 * 8);
		            if (System_Collections_Generic_IEnumerator_UserInThemeduelRating__TypeInfo == *piVar11)
		            {
		              puVar9 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80f10292;
		            }
		            uVar6 = uVar6 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar6);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar9 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_UserInThemeduelRating__TypeInfo,0
		                           );
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f102e6:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f1030a;
		        }
		code_r0x80f10292:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar9,piVar2,puVar9[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f102e6;
		        if ((double)*(uint *)(iVar10 + 0x14) <= param5_00) goto code_r0x80f102db;
		        iVar7 = iVar7 + 1;
		      } while( true );
		    }
		    goto code_r0x80f103f7;
		  }
		  goto code_r0x80f103e7;
		code_r0x80f102db:
		  iVar4 = 0;
		  bVar1 = false;
		code_r0x80f10357:
		  piVar2 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar6 = 0;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar6 * 8)) {
		          puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f103cf;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar6);
		    }
		    puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f103cf:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  }
		  if (iVar4 != 0) {
		    System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (!bVar1) goto code_r0x80f103f7;
		code_r0x80f103e7:
		  iVar7 = 0;
		  param5_00 = 0.0;
		code_r0x80f103f7:
		  uVar8 = *(undefined4 *)(param3 + 0xc);
		  if (*(int *)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo);
		  }
		  puVar9 = *(undefined4 **)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x5c);
		  iVar10 = puVar9[2];
		  if (iVar10 == 0) {
		    if (*(int *)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo);
		      puVar9 = *(undefined4 **)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar9;
		    iVar10 = unnamed_function_1417(System_Func_UserInThemeduelRating__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar10,uVar5,
		               Method_Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c__PopulateUsers_b__7_0__,0);
		    *(int *)(*(int *)(Gameplay_ThemeDuel_Model_ThemeDuelRatingModel___c_TypeInfo + 0x5c) + 8) =
		         iVar10;
		  }
		  uVar8 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar8,iVar10,Method_System_Linq_Enumerable_Where_UserInThemeduelRating___);
		  uVar5 = unnamed_function_1417
		                    (
		                    System_Func_UserInThemeduelRating__int__UserInRatingListElement_UserInRatingListElementArgs__TypeInfo
		                    );
		  System_Func_object__int__long___Invoke
		            (uVar5,param1,
		             Method_Gameplay_ThemeDuel_Model_ThemeDuelRatingModel__PopulateUsers_b__7_1__,0);
		  uVar8 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (uVar8,uVar5,
		                     Method_System_Linq_Enumerable_Select_UserInThemeduelRating__UserInRatingListElement_UserInRatingListElementArgs___
		                    );
		  uVar8 = func_ii_6295(uVar8,
		                       Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		                      );
		  Gameplay_Rating_Model_RatingModel__PopulateUsers(param1,uVar8,param4,param5,param5_00,iVar7,0);
		  return;
		}
		*/

}
