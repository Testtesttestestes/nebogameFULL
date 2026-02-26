using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Protocol.Main;
using Utils;

namespace Gameplay.Aprs.Model
{
	// Token: 0x02000D60 RID: 3424
	[Token(Token = "0x2000D60")]
	public class AprData : IAprDataDiscountProvider
	{
		// Token: 0x14000200 RID: 512
		// (add) Token: 0x060053D5 RID: 21461 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060053D6 RID: 21462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000200")]
		public event AprData.CurrentMedalChanged CurrentMedalChangedEvent
		{
			[Token(Token = "0x60053D5")]
			[Address(RVA = "0xA191", Offset = "0xA191", VA = "0xA191")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60053D6")]
			[Address(RVA = "0xA192", Offset = "0xA192", VA = "0xA192")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x060053D7 RID: 21463 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053D8 RID: 21464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001107")]
		public AprDicGroup AprDicGroup
		{
			[Token(Token = "0x60053D7")]
			[Address(RVA = "0xA193", Offset = "0xA193", VA = "0xA193")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053D8")]
			[Address(RVA = "0xA194", Offset = "0xA194", VA = "0xA194")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x060053D9 RID: 21465 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053DA RID: 21466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001108")]
		public MedalDicWrapper CurrentMedal
		{
			[Token(Token = "0x60053D9")]
			[Address(RVA = "0xA195", Offset = "0xA195", VA = "0xA195")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053DA")]
			[Address(RVA = "0xA196", Offset = "0xA196", VA = "0xA196")]
			private set
			{
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x060053DB RID: 21467 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053DC RID: 21468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001109")]
		public AprDicWrapper CurrentApr
		{
			[Token(Token = "0x60053DB")]
			[Address(RVA = "0xA197", Offset = "0xA197", VA = "0xA197")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053DC")]
			[Address(RVA = "0xA198", Offset = "0xA198", VA = "0xA198")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x060053DD RID: 21469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700110A")]
		public UserData LoggedUser
		{
			[Token(Token = "0x60053DD")]
			[Address(RVA = "0xA199", Offset = "0xA199", VA = "0xA199")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700110B")]
		public UserData User
		{
			[Token(Token = "0x60053DE")]
			[Address(RVA = "0xA19A", Offset = "0xA19A", VA = "0xA19A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x060053DF RID: 21471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700110C")]
		public SortedList<uint, MedalInfo> MedalInfos
		{
			[Token(Token = "0x60053DF")]
			[Address(RVA = "0xA19B", Offset = "0xA19B", VA = "0xA19B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700110D")]
		public BackTime Backtime
		{
			[Token(Token = "0x60053E0")]
			[Address(RVA = "0xA19C", Offset = "0xA19C", VA = "0xA19C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053E1")]
			[Address(RVA = "0xA19D", Offset = "0xA19D", VA = "0xA19D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700110E")]
		[CanBeNull]
		public SaleMarkersDic SaleMarkersDic
		{
			[Token(Token = "0x60053E2")]
			[Address(RVA = "0xA19E", Offset = "0xA19E", VA = "0xA19E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053E3")]
			[Address(RVA = "0xA19F", Offset = "0xA19F", VA = "0xA19F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700110F")]
		public string Title
		{
			[Token(Token = "0x60053E4")]
			[Address(RVA = "0xA1A0", Offset = "0xA1A0", VA = "0xA1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x060053E5 RID: 21477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001110")]
		public string FilterTitle
		{
			[Token(Token = "0x60053E5")]
			[Address(RVA = "0xA1A1", Offset = "0xA1A1", VA = "0xA1A1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x060053E6 RID: 21478 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		[Token(Token = "0x17001111")]
		public uint CurrentCollectionRank
		{
			[Token(Token = "0x60053E6")]
			[Address(RVA = "0xA1A2", Offset = "0xA1A2", VA = "0xA1A2")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x060053E7 RID: 21479 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x17001112")]
		public bool HasDiscount
		{
			[Token(Token = "0x60053E7")]
			[Address(RVA = "0xA1A3", Offset = "0xA1A3", VA = "0xA1A3", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x060053E8 RID: 21480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001113")]
		private AprData AprData
		{
			[Token(Token = "0x60053E8")]
			[Address(RVA = "0xA1A4", Offset = "0xA1A4", VA = "0xA1A4", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E9")]
		[Address(RVA = "0xA1A5", Offset = "0xA1A5", VA = "0xA1A5")]
		private AprData(AprDicGroup aprDicGroup, UserData user, UserData loggedUser)
		{
		/* --- GHIDRA: <InvalidateSaleMarkerInfo>b__53_0 ---
		void Gameplay_Aprs_Model_AprData___InvalidateSaleMarkerInfo_b__53_0
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar4;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x01') {
		      if (*(char *)(param1 + 0x38) == '\0') {
		        *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a8;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a7;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a6;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a5;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a4;
		        }
		      }
		    }
		    else {
		      if (param2 == 0) {
		        uVar4 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar4,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a3;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a9;
		  return;
		}
		*/

		/* --- GHIDRA: <IsAvailToBuy>b__51_0 ---
		uint Gameplay_Aprs_Model_AprData___IsAvailToBuy_b__51_0(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  double dVar2;
		  
		  if (DAT_ram_00a59438 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a59438 = '\x01';
		  }
		  dVar2 = *(double *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x60);
		  if (*(double *)(param2 + 0x10) < dVar2) {
		    uVar1 = (uint)(dVar2 <= *(double *)(param2 + 0x18));
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Aprs_Model_AprData___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5942d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_MedalInfo___);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Values__);
		    DAT_ram_00a5942d = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x18);
		  if (*(int *)(*(int *)(param1 + 0x28) + 0x10) != 0) {
		    uVar3 = System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                      (*(int *)(param1 + 0x28),
		                       Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Values__);
		    iVar4 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                      (uVar3,Method_System_Linq_Enumerable_Last_MedalInfo___);
		    uVar3 = *(undefined4 *)(iVar4 + 0xc);
		    if (DAT_ram_00a5943a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__get_Item__);
		      DAT_ram_00a5943a = '\x01';
		    }
		    uVar3 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar5 + 0xc),uVar3,
		                       Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__get_Item__
		                      );
		    return uVar3;
		  }
		  uVar1 = 0;
		  param1_00 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                               (*(undefined4 *)(iVar5 + 8),
		                                Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                               );
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_MedalDicWrapper__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81000f7b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_MedalDicWrapper__TypeInfo
		                                ,0);
		code_r0x81000f7b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,0,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x060053EA RID: 21482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053EA")]
		[Address(RVA = "0xA1A6", Offset = "0xA1A6", VA = "0xA1A6")]
		private MedalDicWrapper GetCurrentMedal()
		{
		/* --- GHIDRA: GetCurrentMedal ---
		void Gameplay_Aprs_Model_AprData__GetCurrentMedal
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  uint uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 local_18;
		  int local_14;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a59430 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_KeyValuePair_uint__MedalInfo___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_uint__MedalInfo__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_uint__MedalInfo__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__Remove__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3185);
		    DAT_ram_00a59430 = '\x01';
		  }
		  local_4 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_set_Item
		                             (*(undefined4 *)(param1 + 0x28),
		                              Method_System_Collections_Generic_SortedList_uint__MedalInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81001ea8;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81001f1d:
		      DAT_ram_009d3e38 = 0;
		      puVar1 = (uint *)0x0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8100215d;
		    }
		code_r0x81001ea8:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) goto code_r0x81001f1d;
		    if (iVar5 == 0) {
		      if (local_4 == (int *)0x0) goto code_r0x810021f1;
		      uVar2 = 0;
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) == 0) goto code_r0x81001f65;
		      goto code_r0x81001f2d;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IEnumerator_KeyValuePair_uint__MedalInfo___TypeInfo ==
		            *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81002017;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_KeyValuePair_uint__MedalInfo___TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8100214d:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      puVar1 = (uint *)0x0;
		      goto code_r0x8100215d;
		    }
		code_r0x81002017:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar3,&local_18,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8100214d;
		  } while (*(int *)(local_14 + 0xc) != param2);
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_iiii
		            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2af,*(undefined4 *)(param1 + 0x28),
		             local_18,Method_System_Collections_Generic_SortedList_uint__MedalInfo__Remove__);
		  piVar6 = local_4;
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  puVar1 = (uint *)0x1;
		  if (iVar7 != 1) {
		    *(undefined4 *)(param1 + 0x2c) = 0;
		    if (local_4 != (int *)0x0) {
		      uVar2 = 0;
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		            puVar1 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x8100212e;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		      }
		      puVar1 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8100212e:
		      (**(code **)((ulonglong)*puVar1 * 4))(piVar6,puVar1[1]);
		    }
		    goto code_r0x8100223c;
		  }
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8100215d:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 != iVar7) {
		code_r0x810021bb:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b0,&local_c);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      import::env::__resumeException(uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		  local_c = *piVar6;
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_v(0x123);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		    goto code_r0x810021bb;
		  }
		  Unity_Services_Core_Scheduler_Internal_MinimumBinaryHeap_object___Insert(&local_c);
		  if (puVar1 != (uint *)0x0) goto code_r0x8100223c;
		  goto code_r0x810021f1;
		  while (uVar2 = uVar2 + 1, *(ushort *)(iVar7 + 0xb6) != uVar2) {
		code_r0x81001f2d:
		    if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		      puVar1 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		      goto code_r0x81001f6f;
		    }
		  }
		code_r0x81001f65:
		  puVar1 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81001f6f:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar6,puVar1[1]);
		code_r0x810021f1:
		  local_c = param2;
		  uVar4 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  puVar1 = (uint *)func_ii_4419(StringLiteral_3185,uVar4,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7109(puVar1,0);
		code_r0x8100223c:
		  func_ii_7762(param1,param3,puVar1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EB")]
		[Address(RVA = "0x1E53", Offset = "0x1E53", VA = "0x1E53")]
		private void ValidateState(IDictProvider dictionaries)
		{
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EC")]
		[Address(RVA = "0x1E43", Offset = "0x1E43", VA = "0x1E43")]
		public void AddMedalInfo(MedalInfo medalInfo, IDictProvider dictionaries)
		{
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053ED")]
		[Address(RVA = "0xA1A7", Offset = "0xA1A7", VA = "0xA1A7")]
		public void RemoveMedalById(uint medalId, IDictProvider dictionaries)
		{
		/* --- GHIDRA: RemoveMedalById ---
		uint Gameplay_Aprs_Model_AprData__RemoveMedalById(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59431 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		    DAT_ram_00a59431 = '\x01';
		  }
		  return (uint)(0 < *(int *)(*(int *)(param1 + 0x28) + 0x10));
		}
		*/

		}

		// Token: 0x060053EE RID: 21486 RVA: 0x0000F210 File Offset: 0x0000D410
		[Token(Token = "0x60053EE")]
		[Address(RVA = "0xA1A8", Offset = "0xA1A8", VA = "0xA1A8")]
		public bool IsAprAchieved()
		{
		/* --- GHIDRA: IsAprAchieved ---
		uint Gameplay_Aprs_Model_AprData__IsAprAchieved(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  longlong lVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a59432 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Model_AprData__IsAvailToBuy_b__51_0__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_MedalInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalInfo__bool__TypeInfo);
		    DAT_ram_00a59432 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Func_MedalInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,param1,Method_Gameplay_Aprs_Model_AprData__IsAvailToBuy_b__51_0__,0);
		  iVar2 = System_Func_object__bool____ctor
		                    (param2,param1_00,Method_System_Linq_Enumerable_FirstOrDefault_MedalInfo___);
		  lVar4 = *(longlong *)(*(int *)(*(int *)(param1 + 0x1c) + 0x10) + 0x18);
		  iVar3 = Core_Extensions_Dict_ResourceSetExt__GetDelta
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x24),0);
		  if (iVar3 == 0) {
		    if (iVar2 == 0) {
		      uVar1 = 1;
		    }
		    else {
		      uVar1 = (uint)(*(longlong *)(iVar2 + 0x20) == 0);
		    }
		  }
		  return lVar4 == 0 & uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x0000F228 File Offset: 0x0000D428
		[Token(Token = "0x60053EF")]
		[Address(RVA = "0xA1A9", Offset = "0xA1A9", VA = "0xA1A9")]
		public bool IsAvailToBuy(IEnumerable<MedalInfo> medals)
		{
		/* --- GHIDRA: IsAvailToBuy ---
		void Gameplay_Aprs_Model_AprData__IsAvailToBuy
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  func_ii_7762(param1,param2,param2);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F0")]
		[Address(RVA = "0xA1AA", Offset = "0xA1AA", VA = "0xA1AA")]
		public void InvalidateUser(IDictProvider dictionaries)
		{
		/* --- GHIDRA: InvalidateUser ---
		undefined4
		Gameplay_Aprs_Model_AprData__InvalidateUser
		          (undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *param4_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a59435 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a59435 = '\x01';
		  }
		  iVar3 = *param3;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param4_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x810015aa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param4_00 = (uint *)func_ii_1080(param3,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x810015aa:
		  uVar2 = (**(code **)((ulonglong)*param4_00 * 4))(param3,param4_00[1]);
		  uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                    (uVar2,param1,0);
		  uVar2 = Gameplay_Aprs_Model_AprData__GetAppropriateApr(uVar2,param2,param3,param4_00);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F1")]
		[Address(RVA = "0x1E51", Offset = "0x1E51", VA = "0x1E51")]
		public void InvalidateSaleMarkerInfo(IDictProvider dictProvider)
		{
		/* --- GHIDRA: InvalidateSaleMarkerInfo ---
		int * Gameplay_Aprs_Model_AprData__InvalidateSaleMarkerInfo(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053F2")]
		[Address(RVA = "0x1E3E", Offset = "0x1E3E", VA = "0x1E3E")]
		public static AprData Create(AprDicGroup aprDicGroup, UserData user, UserData loggedUser, IDictProvider dictProvider)
		{
			return null;
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053F3")]
		[Address(RVA = "0xA1AB", Offset = "0xA1AB", VA = "0xA1AB")]
		public static AprDicWrapper GetAppropriateApr(uint medalId, UserData userData, IDictProvider dictionaries)
		{
		/* --- GHIDRA: GetAppropriateApr ---
		uint Gameplay_Aprs_Model_AprData__GetAppropriateApr(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  
		  uVar1 = 0;
		  iVar3 = *(int *)(param1 + 0x14);
		  iVar2 = func_ii_6965(param2,0);
		  if ((iVar3 == iVar2) || (*(int *)(param1 + 0x14) == 0)) {
		    uVar1 = 1;
		    iVar3 = *(int *)(param1 + 0x10);
		    iVar2 = Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__uint___GetWrapper
		                      (param2,0);
		    if (iVar3 != iVar2) {
		      uVar1 = (uint)(*(int *)(param1 + 0x10) == 0);
		    }
		  }
		  return uVar1;
		}
		*/

		/* --- GHIDRA: GetAppropriateApr ---
		uint Gameplay_Aprs_Model_AprData__GetAppropriateApr(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  
		  uVar1 = 0;
		  iVar3 = *(int *)(param1 + 0x14);
		  iVar2 = func_ii_6965(param2,0);
		  if ((iVar3 == iVar2) || (*(int *)(param1 + 0x14) == 0)) {
		    uVar1 = 1;
		    iVar3 = *(int *)(param1 + 0x10);
		    iVar2 = Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__uint___GetWrapper
		                      (param2,0);
		    if (iVar3 != iVar2) {
		      uVar1 = (uint)(*(int *)(param1 + 0x10) == 0);
		    }
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053F4")]
		[Address(RVA = "0xA1AC", Offset = "0xA1AC", VA = "0xA1AC")]
		public static AprDicWrapper GetAppropriateApr(MedalDic medalDic, UserData userData, IDictProvider dictionaries)
		{
			return null;
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x0000F240 File Offset: 0x0000D440
		[Token(Token = "0x60053F5")]
		[Address(RVA = "0xA1AD", Offset = "0xA1AD", VA = "0xA1AD")]
		public static bool IsAppropriateApr(AprDic aprDic, UserData user)
		{
		/* --- GHIDRA: IsAppropriateApr ---
		uint Gameplay_Aprs_Model_AprData__IsAppropriateApr(int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a59437 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a59437 = '\x01';
		  }
		  return (uint)(*(int *)(param2 + 0xc) == *(int *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0xc));
		}
		*/

			return default(bool);
		}

		// Token: 0x04002D74 RID: 11636
		[Token(Token = "0x4002D74")]
		[FieldOffset(Offset = "0xC")]
		private string _filterTitle;

		// Token: 0x04002D75 RID: 11637
		[Token(Token = "0x4002D75")]
		[FieldOffset(Offset = "0x10")]
		private uint _currentCollectionRank;

		// Token: 0x04002D76 RID: 11638
		[Token(Token = "0x4002D76")]
		[FieldOffset(Offset = "0x14")]
		private MedalDicWrapper _currentMedal;

		// Token: 0x02000D61 RID: 3425
		// (Invoke) Token: 0x060053F9 RID: 21497
		[Token(Token = "0x2000D61")]
		public delegate void CurrentMedalChanged(MedalDicWrapper from, MedalDicWrapper to);
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_CurrentMedalChangedEvent ---
		void Gameplay_Aprs_Model_AprData__add_CurrentMedalChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a59429 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		    DAT_ram_00a59429 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (param1_01,Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_CurrentMedal ---
		void Gameplay_Aprs_Model_AprData__get_CurrentMedal(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  *(int *)(param1 + 0x14) = param2;
		  if ((param2 != iVar1) && (iVar2 = *(int *)(param1 + 8), iVar2 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),iVar1,param2,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_SaleMarkersDic ---
		undefined4 Gameplay_Aprs_Model_AprData__set_SaleMarkersDic(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5942a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a5942a = '\x01';
		  }
		  uVar1 = func_ii_14054(*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Title ---
		int Gameplay_Aprs_Model_AprData__get_Title(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 == 0) {
		    if (DAT_ram_00a5942a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__)
		      ;
		      DAT_ram_00a5942a = '\x01';
		    }
		    param1_00 = func_ii_14054(*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),0);
		    iVar1 = func_ii_7775(param1_00,0);
		    *(int *)(param1 + 0xc) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_CurrentCollectionRank ---
		undefined4 Gameplay_Aprs_Model_AprData__get_CurrentCollectionRank(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5942b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a5942b = '\x01';
		  }
		  iVar2 = Core_Gameplay_Managers_DiscountsManager__Handle(*(undefined4 *)(param1 + 0x24),0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a59431 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		      DAT_ram_00a59431 = '\x01';
		    }
		    if (*(int *)(*(int *)(param1 + 0x28) + 0x10) < 1) {
		      uVar1 = func_ii_7735(*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Gameplay.Discounts.Model.IAprDataDiscountProvider.get_AprData ---
		void Gameplay_Aprs_Model_AprData__Gameplay_Discounts_Model_IAprDataDiscountProvider_get_AprData
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5942c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_SortedList_uint__MedalInfo__TypeInfo);
		    DAT_ram_00a5942c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_SortedList_uint__MedalInfo__TypeInfo)
		  ;
		  System_Collections_Generic_SortedList_object__object___set_Capacity
		            (param1_00,Method_System_Collections_Generic_SortedList_uint__MedalInfo___ctor__);
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  *(undefined4 *)(param1 + 0x24) = param3;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  *(undefined4 *)(param1 + 0x20) = param4;
		  return;
		}
		*/

}
