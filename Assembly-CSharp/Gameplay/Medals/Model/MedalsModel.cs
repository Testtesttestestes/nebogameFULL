using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Main;

namespace Gameplay.Medals.Model
{
	// Token: 0x02000605 RID: 1541
	[Token(Token = "0x2000605")]
	public class MedalsModel : AbstractModel
	{
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000707")]
		public Dictionaries Dict
		{
			[Token(Token = "0x600255E")]
			[Address(RVA = "0x76A4", Offset = "0x76A4", VA = "0x76A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000708")]
		public UserData LoggedUser
		{
			[Token(Token = "0x600255F")]
			[Address(RVA = "0x76A5", Offset = "0x76A5", VA = "0x76A5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002560")]
			[Address(RVA = "0x76A6", Offset = "0x76A6", VA = "0x76A6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000709")]
		public MedalDicGroupStorage MedalDicGroupStorage
		{
			[Token(Token = "0x6002561")]
			[Address(RVA = "0x76A7", Offset = "0x76A7", VA = "0x76A7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002562")]
			[Address(RVA = "0x76A8", Offset = "0x76A8", VA = "0x76A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070A")]
		public Dictionary<uint, Dictionary<uint, List<MedalData>>> VisibleMedals
		{
			[Token(Token = "0x6002563")]
			[Address(RVA = "0x76A9", Offset = "0x76A9", VA = "0x76A9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002564")]
			[Address(RVA = "0x76AA", Offset = "0x76AA", VA = "0x76AA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070B")]
		public Dictionary<uint, List<MedalData>> AllVisibleMedalsByCategoryId
		{
			[Token(Token = "0x6002565")]
			[Address(RVA = "0x76AB", Offset = "0x76AB", VA = "0x76AB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002566")]
			[Address(RVA = "0x76AC", Offset = "0x76AC", VA = "0x76AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070C")]
		public Dictionary<uint, MedalData> MedalDataByMedalId
		{
			[Token(Token = "0x6002567")]
			[Address(RVA = "0x76AD", Offset = "0x76AD", VA = "0x76AD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002568")]
			[Address(RVA = "0x76AE", Offset = "0x76AE", VA = "0x76AE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x00007218 File Offset: 0x00005418
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070D")]
		public int BuyProcessCount
		{
			[Token(Token = "0x6002569")]
			[Address(RVA = "0x76AF", Offset = "0x76AF", VA = "0x76AF")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600256A")]
			[Address(RVA = "0x76B0", Offset = "0x76B0", VA = "0x76B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700070E")]
		public IGame Game
		{
			[Token(Token = "0x600256B")]
			[Address(RVA = "0x76B1", Offset = "0x76B1", VA = "0x76B1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600256C")]
			[Address(RVA = "0x76B2", Offset = "0x76B2", VA = "0x76B2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x76B3", Offset = "0x76B3", VA = "0x76B3", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Medals_Model_MedalsModel__Dispose
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57dab == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57dab = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(int **)(param1 + 0x28) = param2;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80e5a796;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e5a796:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  *(undefined4 *)(param1 + 0x14) = param5;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x76B4", Offset = "0x76B4", VA = "0x76B4")]
		public MedalsModel(IGame game, UserData user, UserData loggedUser, MedalDicGroupStorage medalDicGroupStorage)
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x80e5d5aa) */
		/* WARNING: Removing unreachable block (ram,0x80e5dfa7) */
		/* WARNING: Removing unreachable block (ram,0x80e5e0c3) */
		/* WARNING: Type propagation algorithm not settling */
		
		void Gameplay_Medals_Model_MedalsModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  uint *puVar8;
		  undefined4 uVar9;
		  int iVar10;
		  undefined4 param3_00;
		  undefined4 uVar11;
		  uint uVar12;
		  int *piVar13;
		  int iVar14;
		  int local_90;
		  undefined8 *local_8c;
		  int local_88;
		  int **ppiStack_84;
		  undefined8 local_80;
		  undefined8 local_78;
		  int local_70;
		  int **local_6c;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  int *local_44;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined4 uStack_24;
		  undefined4 local_20;
		  undefined4 uStack_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57dac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_MedalData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_MedalData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_MedalData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__Dictionary_uint__List_MedalData____Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalDicGroup__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__Dictionary_uint__List_MedalData____Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalDicGroup__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__Dictionary_uint__List_MedalData____MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__Dictionary_uint__List_MedalData____MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__Dictionary_uint__List_MedalData____get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalDicGroup__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__Dictionary_uint__List_MedalData____get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_MedalData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_uint__Dictionary_uint__List_MedalData____get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_uint__Dictionary_uint__List_MedalData____get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalDicGroup__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Medals_Model_MedalsModel___c__SetMedals_b__33_0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalsModel___c_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__Dictionary_uint__List_MedalData____GetEnumerator__
		              );
		    DAT_ram_00a57dac = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  local_20 = 0;
		  uStack_1c = 0;
		  local_28 = 0;
		  uStack_24 = 0;
		  local_30 = 0;
		  local_38 = 0;
		  local_40 = 0;
		  local_44 = (int *)0x0;
		  local_50 = 0;
		  local_58 = 0;
		  local_60 = 0;
		  local_68 = 0;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData_____ctor__
		            );
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__MedalData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar3,Method_System_Collections_Generic_Dictionary_uint__MedalData___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_88,*(undefined4 *)(*(int *)(param1 + 0x14) + 0xc),
		             Method_System_Collections_Generic_List_MedalDicGroup__GetEnumerator__);
		  local_8 = local_80;
		  local_88 = 0;
		  ppiStack_84 = (int **)&local_10;
		code_r0x80e5c6b4:
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_MedalDicGroup__MoveNext__
		                        );
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x80e5cfb7;
		      }
		      if (iVar4 == 0) {
		        iVar4 = 9;
		        iVar10 = local_88;
		        goto code_r0x80e5d002;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar14 = local_8._4_4_;
		      uVar9 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x70,local_8._4_4_,0);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x80e5cfb7;
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar5 = (int *)import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x71,
		                                 *(undefined4 *)(iVar14 + 8),
		                                 Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                                );
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x80e5cfb7;
		      }
		      iVar10 = *piVar5;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar12 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8);
		          if (System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo == *piVar13) {
		            puVar7 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x80e5c7ff;
		          }
		          uVar12 = uVar12 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar7 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                          System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5c86c:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x80e5cfb7;
		      }
		code_r0x80e5c7ff:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = (int *)import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e5c86c;
		      local_70 = 0;
		      local_6c = &local_14;
		      local_14 = piVar5;
		      do {
		        piVar5 = local_14;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		              puVar7 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80e5c91b;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e5c91b:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        piVar5 = local_14;
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar10 == 0) {
		          iVar4 = 6;
		          goto code_r0x80e5cae0;
		        }
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8);
		            if (System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo == *piVar13) {
		              puVar7 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80e5c9f5;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e5c9f5:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,
		                   *(undefined4 *)(param1 + 0x20),*(undefined4 *)(*(int *)(iVar10 + 0x10) + 0xc),
		                   uVar9,Method_System_Collections_Generic_Dictionary_uint__MedalData__set_Item__);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 != iVar4) {
		code_r0x80e5cc23:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x72,&local_70);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) goto code_r0x80e5cfb7;
		        goto code_r0x80e5e21b;
		      }
		      piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		      local_70 = *piVar5;
		      iVar4 = 0;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x80e5cc23;
		      }
		code_r0x80e5cae0:
		      piVar5 = *local_6c;
		      if (piVar5 != (int *)0x0) {
		        iVar10 = *piVar5;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8);
		            if (System_IDisposable_TypeInfo == *piVar13) {
		              puVar7 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80e5cb80;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                            System_IDisposable_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x80e5cb80:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(*puVar7,piVar5,puVar7[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80e5cbbc;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x80e5cfb7;
		      }
		code_r0x80e5cbbc:
		      if (local_70 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_70);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) goto code_r0x80e5e240;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x80e5cfb7;
		      }
		      if ((iVar4 != 0) &&
		         (((((iVar10 = local_88, iVar4 == 1 || (iVar4 == 2)) || (iVar4 == 3)) ||
		           ((iVar4 == 4 || (iVar4 == 5)))) || (iVar4 != 6)))) goto code_r0x80e5d002;
		    } while (*(char *)(iVar14 + 0x18) == '\0');
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,uVar2,
		                       *(undefined4 *)(*(int *)(iVar14 + 0x1c) + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____ContainsKey__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e5cfb7;
		    }
		    if (iVar4 == 0) {
		      uVar11 = *(undefined4 *)(*(int *)(iVar14 + 0x1c) + 0xc);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Collections_Generic_Dictionary_uint__List_MedalData___TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x225,uVar3,
		                   Method_System_Collections_Generic_Dictionary_uint__List_MedalData____ctor__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar2,uVar11,uVar3,
		                     Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____set_Item__
		                    );
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80e5cd56;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e5cfb7;
		    }
		code_r0x80e5cd56:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar2,
		                       *(undefined4 *)(*(int *)(iVar14 + 0x1c) + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Item__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e5cfb7;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,uVar3,
		                       *(undefined4 *)(*(int *)(iVar14 + 0x14) + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__List_MedalData___ContainsKey__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e5cfb7;
		    }
		    if (iVar4 == 0) {
		      uVar6 = *(undefined4 *)(*(int *)(iVar14 + 0x14) + 0xc);
		      DAT_ram_009d3e38 = 0;
		      uVar11 = import::env::invoke_ii
		                         (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                          System_Collections_Generic_List_MedalData__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar11,
		                   Method_System_Collections_Generic_List_MedalData___ctor__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar3,uVar6,uVar11,
		                     Method_System_Collections_Generic_Dictionary_uint__List_MedalData___set_Item__)
		          ;
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80e5cea9;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e5cfb7;
		    }
		code_r0x80e5cea9:
		    DAT_ram_009d3e38 = 0;
		    iVar14 = import::env::invoke_iiii
		                       (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar3,
		                        *(undefined4 *)(*(int *)(iVar14 + 0x14) + 0xc),
		                        Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__
		                       );
		    iVar4 = DAT_ram_009d3e38;
		    iVar10 = Method_System_Collections_Generic_List_MedalData__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e5cfb7;
		    }
		    *(int *)(iVar14 + 0x10) = *(int *)(iVar14 + 0x10) + 1;
		    uVar12 = *(uint *)(iVar14 + 0xc);
		    if (uVar12 < *(uint *)(*(int *)(iVar14 + 8) + 0xc)) {
		      *(uint *)(iVar14 + 0xc) = uVar12 + 1;
		      *(undefined4 *)(*(int *)(iVar14 + 8) + uVar12 * 4 + 0x10) = uVar9;
		      goto code_r0x80e5c6b4;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar14,uVar9,
		               *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar10 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar10 = global_1;
		code_r0x80e5cfb7:
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar10) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar10 = *piVar5;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_88 = iVar10;
		    import::env::invoke_v(0x123);
		    iVar14 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar14 != 1) {
		code_r0x80e5d002:
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar4 != 0) {
		        if (iVar4 == 1) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 2) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 3) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 4) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 5) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 6) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 7) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 == 8) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        if (iVar4 != 9) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		      }
		      uVar3 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____TypeInfo
		                        );
		      System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		                (uVar3,
		                 Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData_____ctor__
		                );
		      *(undefined4 *)(param1 + 0x18) = uVar3;
		      System_Collections_Generic_List_object___GetEnumerator
		                (&local_88,uVar2,
		                 Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____GetEnumerator__
		                );
		      local_20 = (undefined4)local_78;
		      uStack_1c = (undefined4)((ulonglong)local_78 >> 0x20);
		      local_28 = (undefined4)local_80;
		      uStack_24 = (undefined4)((ulonglong)local_80 >> 0x20);
		      local_30 = CONCAT44(ppiStack_84,local_88);
		      local_70 = 0;
		      local_6c = (int **)&local_30;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x155,&local_30,
		                           Method_System_Collections_Generic_Dictionary_Enumerator_uint__Dictionary_uint__List_MedalData____MoveNext__
		                          );
		        uVar3 = local_20;
		        uVar2 = uStack_24;
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar10 = global_1;
		          goto code_r0x80e5d663;
		        }
		        if (iVar4 == 0) goto code_r0x80e5d6cd;
		        uVar11 = *(undefined4 *)(param1 + 0x18);
		        DAT_ram_009d3e38 = 0;
		        uVar9 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_Dictionary_uint__List_MedalData___TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5d26f:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar10 = global_1;
		code_r0x80e5d663:
		          iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar4 == iVar10) {
		            piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		            iVar4 = *piVar5;
		            DAT_ram_009d3e38 = 0;
		            local_70 = iVar4;
		            import::env::invoke_v(0x123);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 != 1) {
		              if (iVar4 != 0) {
		                System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              goto code_r0x80e5d6cd;
		            }
		            uVar3 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x7a,&local_70);
		          goto joined_r0x80e5d728;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x225,uVar9,
		                   Method_System_Collections_Generic_Dictionary_uint__List_MedalData____ctor__);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e5d26f;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar11,uVar2,uVar9,
		                   Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____set_Item__
		                  );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e5d26f;
		        DAT_ram_009d3e38 = 0;
		        uVar9 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x74,uVar3,
		                           Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Keys__
		                          );
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar10 = global_1;
		          goto code_r0x80e5d663;
		        }
		        DAT_ram_009d3e38 = 0;
		        System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                  (&local_88,uVar9,
		                   Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_MedalData___GetEnumerator__
		                  );
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar10 = global_1;
		          goto code_r0x80e5d663;
		        }
		        local_38 = local_80;
		        local_40 = CONCAT44(ppiStack_84,local_88);
		        local_88 = 0;
		        ppiStack_84 = (int **)&local_40;
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar10 = import::env::invoke_iii
		                             (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,&local_40,
		                              Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___MoveNext__
		                             );
		          if (DAT_ram_009d3e38 == 1) break;
		          if (iVar10 == 0) {
		            iVar10 = 10;
		            bVar1 = false;
		            goto code_r0x80e5d578;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar9 = local_38._4_4_;
		          uVar11 = import::env::invoke_iiii
		                             (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                              *(undefined4 *)(param1 + 0x18),uVar2,
		                              Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Item__
		                             );
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar3,uVar9,
		                             Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__
		                            );
		          if (DAT_ram_009d3e38 == 1) break;
		          if (*(int *)(Gameplay_Medals_Model_MedalsModel___c_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Gameplay_Medals_Model_MedalsModel___c_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		          }
		          puVar7 = *(undefined4 **)(Gameplay_Medals_Model_MedalsModel___c_TypeInfo + 0x5c);
		          iVar10 = puVar7[1];
		          if (iVar10 == 0) {
		            if (*(int *)(Gameplay_Medals_Model_MedalsModel___c_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         Gameplay_Medals_Model_MedalsModel___c_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) break;
		              puVar7 = *(undefined4 **)(Gameplay_Medals_Model_MedalsModel___c_TypeInfo + 0x5c);
		            }
		            param3_00 = *puVar7;
		            DAT_ram_009d3e38 = 0;
		            iVar10 = import::env::invoke_ii
		                               (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                System_Func_MedalData__uint__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x76,iVar10,param3_00,
		                       Method_Gameplay_Medals_Model_MedalsModel___c__SetMedals_b__33_0__,0);
		            if (DAT_ram_009d3e38 == 1) break;
		            *(int *)(*(int *)(Gameplay_Medals_Model_MedalsModel___c_TypeInfo + 0x5c) + 4) = iVar10;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x77,uVar6,iVar10,
		                             Method_System_Linq_Enumerable_OrderBy_MedalData__uint___);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x229,uVar6,
		                             Method_System_Linq_Enumerable_ToList_MedalData___);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar11,uVar9,uVar6,
		                     Method_System_Collections_Generic_Dictionary_uint__List_MedalData___set_Item__)
		          ;
		        } while (DAT_ram_009d3e38 != 1);
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar10 != iVar4) {
		code_r0x80e5d621:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(0x1c00,&local_88);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 != 1) goto code_r0x80e5d663;
		          goto code_r0x80e5e21b;
		        }
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        local_88 = *piVar5;
		        iVar10 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        bVar1 = true;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar10 = global_1;
		          goto code_r0x80e5d621;
		        }
		code_r0x80e5d578:
		        if (local_88 != 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_88);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar10 = global_1;
		            goto code_r0x80e5d663;
		          }
		          goto code_r0x80e5e240;
		        }
		      } while ((iVar10 == 0) ||
		              ((((((iVar10 != 1 && (iVar10 != 2)) &&
		                  ((iVar10 != 3 && (((iVar10 != 4 && (iVar10 != 5)) && (iVar10 != 6)))))) &&
		                 ((iVar10 != 7 && (iVar10 != 8)))) && (iVar10 != 9)) && (iVar10 == 10))));
		      if (!bVar1) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		code_r0x80e5d6cd:
		      DAT_ram_009d3e38 = 0;
		      local_44 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                  (param2,
		                                   Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__GetEnumerator__
		                                  );
		      local_88 = 0;
		      ppiStack_84 = &local_44;
		      do {
		        piVar5 = local_44;
		        iVar10 = *local_44;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		              puVar7 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80e5d7da;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_44,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5d994:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e5d99c;
		        }
		code_r0x80e5d7da:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        piVar5 = local_44;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e5d994;
		        if (iVar10 == 0) {
		          iVar10 = 0x12;
		          iVar4 = 0;
		          goto code_r0x80e5d9e9;
		        }
		        iVar10 = *local_44;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar12 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8);
		            if (System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo == *piVar13) {
		              puVar7 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80e5d8b4;
		            }
		            uVar12 = uVar12 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_44,
		                            System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5d976:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e5d99c;
		        }
		code_r0x80e5d8b4:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e5d976;
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                           *(undefined4 *)(param1 + 0x20),*(undefined4 *)(iVar10 + 0xc),
		                           Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__)
		        ;
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e5d99c;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x7b,uVar2,iVar10,0);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar10 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e5d99c:
		      iVar10 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        iVar10 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_88 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar14 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar14 != 1) {
		code_r0x80e5d9e9:
		          piVar5 = local_44;
		          DAT_ram_009d3e38 = 0;
		          if (local_44 != (int *)0x0) {
		            uVar12 = 0;
		            iVar14 = *local_44;
		            if (*(ushort *)(iVar14 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar14 + 0x58) + uVar12 * 8)) {
		                  puVar8 = (uint *)(iVar14 + *(int *)(*(int *)(iVar14 + 0x58) + uVar12 * 8 + 4) * 8
		                                   + 0xc0);
		                  goto code_r0x80e5da61;
		                }
		                uVar12 = uVar12 + 1;
		              } while (*(ushort *)(iVar14 + 0xb6) != uVar12);
		            }
		            puVar8 = (uint *)func_ii_1080(local_44,System_IDisposable_TypeInfo,0);
		code_r0x80e5da61:
		            (**(code **)((ulonglong)*puVar8 * 4))(piVar5,puVar8[1]);
		          }
		          if (iVar4 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar10 != 0) {
		            if (iVar10 == 1) {
		              return;
		            }
		            if (iVar10 == 2) {
		              return;
		            }
		            if (iVar10 == 3) {
		              return;
		            }
		            if (iVar10 == 4) {
		              return;
		            }
		            if (iVar10 == 5) {
		              return;
		            }
		            if (iVar10 == 6) {
		              return;
		            }
		            if (iVar10 == 7) {
		              return;
		            }
		            if (iVar10 == 8) {
		              return;
		            }
		            if (iVar10 == 9) {
		              return;
		            }
		            if (iVar10 == 10) {
		              return;
		            }
		            if (iVar10 == 0xb) {
		              return;
		            }
		            if (iVar10 == 0xc) {
		              return;
		            }
		            if (iVar10 == 0xd) {
		              return;
		            }
		            if (iVar10 == 0xe) {
		              return;
		            }
		            if (iVar10 == 0xf) {
		              return;
		            }
		            if (iVar10 == 0x10) {
		              return;
		            }
		            if (iVar10 == 0x11) {
		              return;
		            }
		            if (iVar10 != 0x12) {
		              return;
		            }
		          }
		          uVar2 = unnamed_function_1417
		                            (System_Collections_Generic_Dictionary_uint__List_MedalData___TypeInfo);
		          System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		                    (uVar2,
		                     Method_System_Collections_Generic_Dictionary_uint__List_MedalData____ctor__);
		          *(undefined4 *)(param1 + 0x1c) = uVar2;
		          uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                            (*(undefined4 *)(param1 + 0x18),
		                             Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Values__
		                            );
		          System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                    (&local_88,uVar2,
		                     Method_System_Collections_Generic_Dictionary_ValueCollection_uint__Dictionary_uint__List_MedalData____GetEnumerator__
		                    );
		          local_50 = local_80;
		          local_58 = CONCAT44(ppiStack_84,local_88);
		          local_70 = 0;
		          local_6c = (int **)&local_58;
		          while( true ) {
		            DAT_ram_009d3e38 = 0;
		            iVar4 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_58,
		                               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__Dictionary_uint__List_MedalData____MoveNext__
		                              );
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar10 = global_1;
		              goto code_r0x80e5e180;
		            }
		            iVar10 = local_70;
		            if (iVar4 == 0) break;
		            DAT_ram_009d3e38 = 0;
		            uVar2 = local_50._4_4_;
		            uVar3 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x74,local_50._4_4_
		                               ,
		                               Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Keys__
		                              );
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar10 = global_1;
		              goto code_r0x80e5e180;
		            }
		            DAT_ram_009d3e38 = 0;
		            System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                      (&local_88,uVar3,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_MedalData___GetEnumerator__
		                      );
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar10 = global_1;
		              goto code_r0x80e5e180;
		            }
		            local_38 = local_80;
		            local_40 = CONCAT44(ppiStack_84,local_88);
		            local_90 = 0;
		            local_8c = &local_40;
		            do {
		              DAT_ram_009d3e38 = 0;
		              iVar10 = import::env::invoke_iii
		                                 (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,&local_40,
		                                  Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___MoveNext__
		                                 );
		              if (DAT_ram_009d3e38 == 1) goto code_r0x80e5dfe0;
		              if (iVar10 == 0) {
		                iVar4 = 0x13;
		                break;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar3 = local_38._4_4_;
		              iVar10 = import::env::invoke_iiii
		                                 (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,
		                                  *(undefined4 *)(param1 + 0x1c),local_38._4_4_,
		                                  Method_System_Collections_Generic_Dictionary_uint__List_MedalData___ContainsKey__
		                                 );
		              if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5dfe0:
		                DAT_ram_009d3e38 = 0;
		                uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                iVar10 = global_1;
		code_r0x80e5e046:
		                iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		                if (iVar4 == iVar10) {
		                  piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		                  local_90 = *piVar5;
		                  iVar4 = 0;
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_v(0x123);
		                  iVar10 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar10 != 1) break;
		                  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  iVar10 = global_1;
		                }
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_ii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x7e,&local_90);
		                iVar4 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar4 != 1) goto code_r0x80e5e180;
		                goto code_r0x80e5e21b;
		              }
		              if (iVar10 == 0) {
		                uVar11 = *(undefined4 *)(param1 + 0x1c);
		                DAT_ram_009d3e38 = 0;
		                uVar9 = import::env::invoke_ii
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                   System_Collections_Generic_List_MedalData__TypeInfo);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_vii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar9,
		                             Method_System_Collections_Generic_List_MedalData___ctor__);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,uVar11,uVar3,
		                               uVar9,
		                               Method_System_Collections_Generic_Dictionary_uint__List_MedalData___Add__
		                              );
		                    if (DAT_ram_009d3e38 != 1) goto code_r0x80e5dd75;
		                  }
		                }
		                goto code_r0x80e5dfe0;
		              }
		code_r0x80e5dd75:
		              DAT_ram_009d3e38 = 0;
		              uVar9 = import::env::invoke_iiii
		                                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar2,uVar3
		                                 ,
		                                 Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__
		                                );
		              if (DAT_ram_009d3e38 == 1) goto code_r0x80e5dfe0;
		              DAT_ram_009d3e38 = 0;
		              System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                        (&local_88,uVar9,
		                         Method_System_Collections_Generic_List_MedalData__GetEnumerator__);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x80e5dfe0;
		              local_60 = local_80;
		              local_68 = CONCAT44(ppiStack_84,local_88);
		              local_88 = 0;
		              ppiStack_84 = (int **)&local_68;
		              do {
		                while( true ) {
		                  DAT_ram_009d3e38 = 0;
		                  iVar10 = import::env::invoke_iii
		                                     (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,
		                                      &local_68,
		                                      Method_System_Collections_Generic_List_Enumerator_MedalData__MoveNext__
		                                     );
		                  if (DAT_ram_009d3e38 == 1) goto code_r0x80e5df1f;
		                  if (iVar10 == 0) {
		                    iVar4 = 0x15;
		                    goto code_r0x80e5df75;
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  uVar9 = local_60._4_4_;
		                  iVar4 = import::env::invoke_iiii
		                                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                                     *(undefined4 *)(param1 + 0x1c),uVar3,
		                                     Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__
		                                    );
		                  iVar10 = Method_System_Collections_Generic_List_MedalData__Add__;
		                  if (DAT_ram_009d3e38 == 1) goto code_r0x80e5df1f;
		                  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		                  uVar12 = *(uint *)(iVar4 + 0xc);
		                  if (*(uint *)(*(int *)(iVar4 + 8) + 0xc) <= uVar12) break;
		                  *(uint *)(iVar4 + 0xc) = uVar12 + 1;
		                  *(undefined4 *)(*(int *)(iVar4 + 8) + uVar12 * 4 + 0x10) = uVar9;
		                }
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,uVar9,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		              } while (DAT_ram_009d3e38 != 1);
		code_r0x80e5df1f:
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar10 = global_1;
		              iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		              if (iVar10 != iVar4) {
		code_r0x80e5e015:
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_ii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x7d,&local_88);
		                iVar4 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar4 != 1) goto code_r0x80e5e046;
		                goto code_r0x80e5e21b;
		              }
		              piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		              local_88 = *piVar5;
		              iVar4 = 0;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_v(0x123);
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar10 == 1) {
		                uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                iVar10 = global_1;
		                goto code_r0x80e5e015;
		              }
		code_r0x80e5df75:
		              if (local_88 != 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_88);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x80e5dfe0;
		                goto code_r0x80e5e240;
		              }
		            } while ((iVar4 == 0x15) || (iVar4 == 0));
		            if (local_90 != 0) goto code_r0x80e5e0ce;
		            if ((iVar4 != 0) &&
		               ((((((iVar10 = local_70, iVar4 == 1 || (iVar4 == 2)) || (iVar4 == 3)) ||
		                  (((iVar4 == 4 || (iVar4 == 5)) || ((iVar4 == 6 || ((iVar4 == 7 || (iVar4 == 8)))))
		                   ))) || ((iVar4 == 9 ||
		                           ((((iVar4 == 10 || (iVar4 == 0xb)) || (iVar4 == 0xc)) ||
		                            ((iVar4 == 0xd || (iVar4 == 0xe)))))))) ||
		                (((iVar4 == 0xf || ((iVar4 == 0x10 || (iVar4 == 0x11)))) ||
		                 ((iVar4 == 0x12 || (iVar4 != 0x13)))))))) break;
		          }
		          goto code_r0x80e5e1c7;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x7c,&local_88);
		      goto joined_r0x80e5d728;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x73,&local_88);
		joined_r0x80e5d728:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80e5e21b:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		code_r0x80e5e0ce:
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_90);
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 != 1) {
		code_r0x80e5e240:
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar10 = global_1;
		code_r0x80e5e180:
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar10) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar10 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_70 = iVar10;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80e5e1c7:
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x7f,&local_70);
		  goto joined_r0x80e5d728;
		}
		*/

		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256F")]
		[Address(RVA = "0x76B5", Offset = "0x76B5", VA = "0x76B5")]
		public void SetMedals(RepeatedField<MedalInfo> medalInfos)
		{
		/* --- GHIDRA: SetMedals ---
		void Gameplay_Medals_Model_MedalsModel__SetMedals(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57dad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    DAT_ram_00a57dad = '\x01';
		  }
		  param1_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1 + 0x20),param2,
		                         Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___MedalInfoViewMediator__HandleBuyMedalConfirmation_d__18_
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x76B6", Offset = "0x76B6", VA = "0x76B6")]
		public void RemoveMedal(uint medalId)
		{
		/* --- GHIDRA: RemoveMedal ---
		void Gameplay_Medals_Model_MedalsModel__RemoveMedal(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57daf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalsModel___c_TypeInfo);
		    DAT_ram_00a57daf = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Medals_Model_MedalsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Medals_Model_MedalsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00007230 File Offset: 0x00005430
		[Token(Token = "0x6002571")]
		[Address(RVA = "0x1C19", Offset = "0x1C19", VA = "0x1C19")]
		public bool AddMedal(MedalInfo mi)
		{
		/* --- GHIDRA: AddMedal ---
		void Gameplay_Medals_Model_MedalsModel__AddMedal(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 param4;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 param5;
		  
		  if (DAT_ram_00a57dcf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_MedalsScope_MedalEventArgs_TypeInfo);
		    DAT_ram_00a57dcf = '\x01';
		  }
		  Gameplay_Medals_Controller_MedalsController__MainServiceOnNewMedalsEvent
		            (param1,*(undefined4 *)(param2 + 0xc),param1);
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x50) + 8);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = System_Collections_Generic_List_object___get_Item
		                       (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(param2 + 0xc),
		                        Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    param5 = *(undefined4 *)(param2 + 0xc);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_MedalsScope_MedalEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (param1_00,param2_00,param3_00,param4,param5,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04001477 RID: 5239
		[Token(Token = "0x4001477")]
		[FieldOffset(Offset = "0xC")]
		private readonly DictManager _dictManager;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Game ---
		void Gameplay_Medals_Model_MedalsModel__set_Game(int param1,undefined4 param2)
		
		{
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  *(undefined4 *)(param1 + 0x14) = 0;
		  *(undefined4 *)(param1 + 0x28) = 0;
		  return;
		}
		*/

}
