using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Gameplay;
using Gameplay.Portals.View.RatingTab;
using Il2CppDummyDll;
using MVC;
using Protocol.Rating;
using Utils;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x20005D2")]
	public class PortalsRatingModel : AbstractModel
	{
		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006BF")]
		public IGame Game
		{
			[Token(Token = "0x60023DB")]
			[Address(RVA = "0x752D", Offset = "0x752D", VA = "0x752D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x00006F90 File Offset: 0x00005190
		// (set) Token: 0x060023DD RID: 9181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C0")]
		public bool IsAwaitReceivingData
		{
			[Token(Token = "0x60023DC")]
			[Address(RVA = "0x752E", Offset = "0x752E", VA = "0x752E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60023DD")]
			[Address(RVA = "0x752F", Offset = "0x752F", VA = "0x752F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x7530", Offset = "0x7530", VA = "0x7530")]
		public PortalsRatingModel(float cacheTtl, UserData user, IGame game, IUserCache userCache)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Portals_Model_PortalsRatingModel___ctor
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5812e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____get_Item__
		              );
		    DAT_ram_00a5812e = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x10),param3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____get_Item__
		                    );
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____get_Item__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x7531", Offset = "0x7531", VA = "0x7531")]
		public UserInPortalRatingListElement.UserInPortalRatingListElementArgs[] GetPortalRatingUsers(uint ratingType = 0U, RatingPeriods period = RatingPeriods.UnknownRatingPeriod)
		{
		/* --- GHIDRA: GetPortalRatingUsers ---
		undefined4
		Gameplay_Portals_Model_PortalsRatingModel__GetPortalRatingUsers
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5812f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___get_Item__
		              );
		    DAT_ram_00a5812f = '\x01';
		  }
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x14),param3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___get_Item__
		                    );
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (uVar1,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__get_Item__
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x7532", Offset = "0x7532", VA = "0x7532")]
		public UserInPortalRatingListElement.UserInPortalRatingListElementArgs GetPortalRatingMyUser(uint ratingType = 0U, RatingPeriods period = RatingPeriods.UnknownRatingPeriod)
		{
		/* --- GHIDRA: GetPortalRatingMyUser ---
		void Gameplay_Portals_Model_PortalsRatingModel__GetPortalRatingMyUser
		               (int param1,int param2,int param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 *puVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 param7;
		  uint uVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 param1_00;
		  double param5_00;
		  int *piVar9;
		  uint uVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar7 = 0;
		  iVar8 = 0;
		  param7 = 0;
		  if (DAT_ram_00a58130 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserInPortalRating__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserInPortalRatingListElement_UserInPortalRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserInPortalRating__int__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_UserInPortalRating__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Model_PortalsRatingModel__PopulateUsers_b__15_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserInPortalRating__GetEnumerator__
		              );
		    DAT_ram_00a58130 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar5 = *(int *)(param2 + 0xc);
		  if (iVar5 == 0) {
		    param5_00 = 0.0;
		code_r0x80ea6cb6:
		    param1_00 = *(undefined4 *)(param3 + 0xc);
		    uVar4 = unnamed_function_1417
		                      (
		                      System_Func_UserInPortalRating__int__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__TypeInfo
		                      );
		    System_Func_object__int__long___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Portals_Model_PortalsRatingModel__PopulateUsers_b__15_0__,0);
		    uVar4 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                      (param1_00,uVar4,
		                       Method_System_Linq_Enumerable_Select_UserInPortalRating__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___
		                      );
		    uVar4 = func_ii_6295(uVar4,
		                         Method_System_Linq_Enumerable_ToArray_UserInPortalRatingListElement_UserInPortalRatingListElementArgs___
		                        );
		    Gameplay_Portals_Model_PortalsRatingModel__PopulateUsers
		              (param1,uVar4,param4,param5,param5_00,iVar7,param7,param1_00);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_
		              (*(undefined4 *)(param1 + 0x20),*(float *)(param1 + 0x24),0);
		    return;
		  }
		  param7 = *(undefined4 *)(iVar5 + 0x14);
		  uVar6 = *(uint *)(iVar5 + 0x10);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param3 + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_UserInPortalRating__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  iVar7 = 1;
		  while( true ) {
		    piVar2 = local_4;
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar1 = (undefined4 *)(iVar5 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80ea6a83;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80ea6a83:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar1,piVar2,puVar1[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) break;
		    if (iVar5 == 0) goto code_r0x80ea6c1e;
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8);
		        if (System_Collections_Generic_IEnumerator_UserInPortalRating__TypeInfo == *piVar9) {
		          puVar1 = (undefined4 *)(iVar5 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80ea6b5e;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_UserInPortalRating__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ea6bcd:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ea6bd5;
		    }
		code_r0x80ea6b5e:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar1,piVar2,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ea6bcd;
		    if (*(longlong *)(*(int *)(iVar5 + 0xc) + 0x10) ==
		        *(longlong *)(*(int *)(*(int *)(param2 + 0xc) + 0xc) + 0x10)) goto code_r0x80ea6c1e;
		    iVar7 = iVar7 + 1;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ea6bd5:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80ea6c1e:
		      piVar2 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar10 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80ea6c96;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ea6c96:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      }
		      if (iVar8 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param5_00 = (double)uVar6;
		      goto code_r0x80ea6cb6;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x113,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x7533", Offset = "0x7533", VA = "0x7533")]
		public void PopulateUsers(ProtoGetUserPortalRatingAns user, ProtoGetAllUsersPortalRatingAns msg, uint ratingType = 0U, RatingPeriods period = RatingPeriods.UnknownRatingPeriod)
		{
		/* --- GHIDRA: PopulateUsers ---
		void Gameplay_Portals_Model_PortalsRatingModel__PopulateUsers
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,double param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  longlong lVar7;
		  uint uVar8;
		  longlong lVar9;
		  float8 local_8;
		  
		  local_8 = (float8)param5;
		  if (DAT_ram_00a58131 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58131 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x10),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x10);
		    uVar2 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____TypeInfo
		                      );
		    System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		              (uVar2,
		               Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____ctor__
		              );
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (uVar3,param4,uVar2,
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____set_Item__
		              );
		  }
		  uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x10),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____get_Item__
		                    );
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (uVar2,param3,param2,
		             Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____set_Item__
		            );
		  iVar1 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x14),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x14);
		    uVar2 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__TypeInfo
		                      );
		    System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		              (uVar2,
		               Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___ctor__
		              );
		    System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		              (uVar3,param4,uVar2,
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___set_Item__
		              );
		  }
		  uVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(param1 + 0x14),param4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___get_Item__
		                    );
		  uVar2 = 0xbff00000;
		  iVar1 = System_Double__Equals(&local_8,-1.0,0);
		  if (iVar1 == 0) {
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		                      );
		    Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(iVar1,0);
		    uVar5 = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(iVar1 + 0x28) = param6;
		    *(undefined4 *)(iVar1 + 0x1c) = uVar5;
		    *(undefined4 *)(iVar1 + 0x30) = param7;
		    if ((double)local_8 < 1.8446744073709552e+19 && 0.0 <= (double)local_8) {
		      lVar7 = (longlong)(double)local_8;
		    }
		    else {
		      lVar7 = 0;
		    }
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      lVar9 = (longlong)(double)local_8;
		    }
		    else {
		      lVar9 = -0x8000000000000000;
		    }
		    if (0.0 <= (double)local_8) {
		      lVar9 = lVar7;
		    }
		    *(longlong *)(iVar1 + 0x20) = lVar9;
		    param1_00 = *(int **)(param1 + 0x18);
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0x290);
		          goto code_r0x80ea6ffe;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea6ffe:
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,CONCAT44(uVar2,puVar4[1]));
		    uVar2 = Core_Extensions_Dict_PortalDicExt__GetAssetId
		                      (*(undefined4 *)(*(int *)(iVar6 + 0x10) + 0x3c),0);
		    *(undefined1 *)(iVar1 + 0x2c) = 1;
		    *(undefined4 *)(iVar1 + 0x34) = uVar2;
		    Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		              (iVar1,1,0);
		  }
		  else {
		    iVar1 = 0;
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (uVar3,param3,iVar1,
		             Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__set_Item__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x7534", Offset = "0x7534", VA = "0x7534")]
		private void DoPopulateUsers(UserInPortalRatingListElement.UserInPortalRatingListElementArgs[] usersInRatingArgs, uint ratingType, RatingPeriods period, double userRating, int userPlace, uint userParticipantNum)
		{
		/* --- GHIDRA: DoPopulateUsers ---
		int Gameplay_Portals_Model_PortalsRatingModel__DoPopulateUsers
		              (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *puVar2;
		  longlong lVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  longlong lVar7;
		  
		  if (DAT_ram_00a58132 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58132 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(param1_00,0);
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  piVar5 = *(int **)(param1 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ea7120;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80ea7120:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,puVar2[1]);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar4;
		  *(ulonglong *)(param1_00 + 0x20) = (ulonglong)*(uint *)(param2 + 0x10);
		  *(int *)(param1_00 + 0x28) = *param3 + 1;
		  uVar1 = 0;
		  lVar7 = *(longlong *)(*(int *)(param2 + 0xc) + 0x10);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  *(bool *)(param1_00 + 0x2c) = lVar7 == lVar3;
		  *(undefined4 *)(param1_00 + 0x30) = *(undefined4 *)(param2 + 0x14);
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x290);
		        goto code_r0x80ea71e4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea71e4:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = Core_Extensions_Dict_PortalDicExt__GetAssetId
		                    (*(undefined4 *)(*(int *)(iVar6 + 0x10) + 0x3c),0);
		  *(undefined4 *)(param1_00 + 0x34) = uVar4;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x7535", Offset = "0x7535", VA = "0x7535")]
		private UserInPortalRatingListElement.UserInPortalRatingListElementArgs ConstructArgs(UserInPortalRating userInRating, in int place)
		{
		/* --- GHIDRA: ConstructArgs ---
		undefined4
		Gameplay_Portals_Model_PortalsRatingModel__ConstructArgs
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = param3;
		  uVar1 = Gameplay_Portals_Model_PortalsRatingModel__DoPopulateUsers
		                    (param1,param2,&local_4,auStack_10);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x040013C2 RID: 5058
		[Token(Token = "0x40013C2")]
		[FieldOffset(Offset = "0xC")]
		protected readonly IUserCache _userCache;

		// Token: 0x040013C3 RID: 5059
		[Token(Token = "0x40013C3")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, UserInPortalRatingListElement.UserInPortalRatingListElementArgs[]>> _usersCache;

		// Token: 0x040013C4 RID: 5060
		[Token(Token = "0x40013C4")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<RatingPeriods, Dictionary<uint, UserInPortalRatingListElement.UserInPortalRatingListElementArgs>> _myUserCache;

		// Token: 0x040013C7 RID: 5063
		[Token(Token = "0x40013C7")]
		[FieldOffset(Offset = "0x20")]
		public readonly BackTime CacheBackTime;

		// Token: 0x040013C8 RID: 5064
		[Token(Token = "0x40013C8")]
		[FieldOffset(Offset = "0x24")]
		private readonly float _cacheTtl;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsAwaitReceivingData ---
		void Gameplay_Portals_Model_PortalsRatingModel__set_IsAwaitReceivingData
		               (int param1,float param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5812d == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs______ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____TypeInfo
		              );
		    DAT_ram_00a5812d = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs______ctor__
		            );
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,0.0,0);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(float *)(param1 + 0x24) = param2;
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(undefined4 *)(param1 + 0xc) = param5;
		  return;
		}
		*/

}
