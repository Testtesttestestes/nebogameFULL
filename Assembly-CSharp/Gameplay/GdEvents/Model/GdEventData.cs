using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.InfoRows;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Collections.Model.Factories;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Utils;

namespace Gameplay.GdEvents.Model
{
	// Token: 0x0200074D RID: 1869
	[Token(Token = "0x200074D")]
	public class GdEventData : IDisposable
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088C")]
		[NotNull]
		public GameEventDic GameEventDic
		{
			[Token(Token = "0x6002C7E")]
			[Address(RVA = "0x7D0D", Offset = "0x7D0D", VA = "0x7D0D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C7F")]
			[Address(RVA = "0x7D0E", Offset = "0x7D0E", VA = "0x7D0E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088D")]
		[CanBeNull]
		public AbstractGdEventCatData Category
		{
			[Token(Token = "0x6002C80")]
			[Address(RVA = "0x7D0F", Offset = "0x7D0F", VA = "0x7D0F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C81")]
			[Address(RVA = "0x7D10", Offset = "0x7D10", VA = "0x7D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000087D8 File Offset: 0x000069D8
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088E")]
		public bool IsNewestInMainCategory
		{
			[Token(Token = "0x6002C82")]
			[Address(RVA = "0x7D11", Offset = "0x7D11", VA = "0x7D11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C83")]
			[Address(RVA = "0x7D12", Offset = "0x7D12", VA = "0x7D12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C85 RID: 11397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088F")]
		public UserData User
		{
			[Token(Token = "0x6002C84")]
			[Address(RVA = "0x7D13", Offset = "0x7D13", VA = "0x7D13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C85")]
			[Address(RVA = "0x7D14", Offset = "0x7D14", VA = "0x7D14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000890")]
		public IRequirementValidator RequirementValidator
		{
			[Token(Token = "0x6002C86")]
			[Address(RVA = "0x7D15", Offset = "0x7D15", VA = "0x7D15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C87")]
			[Address(RVA = "0x7D16", Offset = "0x7D16", VA = "0x7D16")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C89 RID: 11401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000891")]
		public IRewardProvider RewardProvider
		{
			[Token(Token = "0x6002C88")]
			[Address(RVA = "0x7D17", Offset = "0x7D17", VA = "0x7D17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C89")]
			[Address(RVA = "0x7D18", Offset = "0x7D18", VA = "0x7D18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C8B RID: 11403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000892")]
		public MilestoneData SelectedMilestone
		{
			[Token(Token = "0x6002C8A")]
			[Address(RVA = "0x7D19", Offset = "0x7D19", VA = "0x7D19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C8B")]
			[Address(RVA = "0x7D1A", Offset = "0x7D1A", VA = "0x7D1A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0x218D", Offset = "0x218D", VA = "0x218D", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int * Gameplay_GdEvents_Model_GdEventData__Dispose(int *param1)
		
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

		// Token: 0x06002C8D RID: 11405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x7D1B", Offset = "0x7D1B", VA = "0x7D1B")]
		public GdEventData(GameEventDic gameEventDic, IRequirementValidator requirementValidator, IRewardProvider rewardProvider, UserData user, EventTabs tabs, ValueRow progressValueRow)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_Model_GdEventData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a5a2c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MilestoneData__Clear__);
		    DAT_ram_00a5a2c8 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x28);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  *(undefined4 *)(param1 + 0x34) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0x7D1C", Offset = "0x7D1C", VA = "0x7D1C")]
		public void ResetMilestones()
		{
		/* --- GHIDRA: ResetMilestones ---
		undefined4
		Gameplay_GdEvents_Model_GdEventData__ResetMilestones(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int param1_01;
		  uint uVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5a2c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MilestoneData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MilestoneData__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MilestoneData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_Milestone_MilestoneData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone__get_Item__
		              );
		    DAT_ram_00a5a2c9 = '\x01';
		  }
		  if ((*(int *)(*(int *)(param1 + 0x28) + 0xc) == 0) &&
		     (iVar3 = *(int *)(*(int *)(param1 + 0x10) + 0x28), 0 < *(int *)(iVar3 + 0xc))) {
		    do {
		      uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar3,iVar5,
		                         Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone__get_Item__
		                        );
		      param1_01 = *(int *)(param1 + 0x28);
		      iVar3 = unnamed_function_1417(Gameplay_GdEvents_Model_Milestone_MilestoneData_TypeInfo);
		      if (DAT_ram_00a5a2e0 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_List_ActivityGroupData___ctor__);
		        Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ActivityGroupData__TypeInfo);
		        DAT_ram_00a5a2e0 = '\x01';
		      }
		      param1_00 = unnamed_function_1417(System_Collections_Generic_List_ActivityGroupData__TypeInfo)
		      ;
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (param1_00,Method_System_Collections_Generic_List_ActivityGroupData___ctor__);
		      *(undefined4 *)(iVar3 + 0x28) = param1_00;
		      *(undefined4 *)(iVar3 + 0x20) = param2;
		      *(undefined4 *)(iVar3 + 8) = uVar2;
		      *(int *)(iVar3 + 0x1c) = param1;
		      iVar1 = Method_System_Collections_Generic_List_MilestoneData__Add__;
		      *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		      uVar4 = *(uint *)(param1_01 + 0xc);
		      if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		        *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		        *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = iVar3;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      iVar5 = iVar5 + 1;
		      iVar3 = *(int *)(*(int *)(param1 + 0x10) + 0x28);
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		    if (0 < *(int *)(*(int *)(param1 + 0x28) + 0xc)) {
		      iVar5 = System_Linq_Enumerable__ToList_object_
		                        (*(int *)(param1 + 0x28),0,
		                         Method_System_Collections_Generic_List_MilestoneData__get_Item__);
		      iVar3 = *(int *)(param1 + 0x34);
		      if (iVar5 != iVar3) {
		        *(int *)(param1 + 0x34) = iVar5;
		        if (iVar5 != 0) {
		          *(undefined1 *)(iVar5 + 0x24) = 1;
		        }
		        if (iVar3 != 0) {
		          *(undefined1 *)(iVar3 + 0x24) = 0;
		        }
		      }
		    }
		  }
		  return *(undefined4 *)(param1 + 0x28);
		}
		*/

		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x7D1D", Offset = "0x7D1D", VA = "0x7D1D")]
		public List<MilestoneData> GetMilestones(ICollectionDataFactory collectionDataFactory)
		{
		/* --- GHIDRA: GetMilestones ---
		undefined4 Gameplay_GdEvents_Model_GdEventData__GetMilestones(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  float fVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  undefined4 param1_00;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  undefined8 local_28;
		  ushort local_1a;
		  longlong local_18;
		  int *local_c;
		  int local_8;
		  int local_4;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a5a2ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_GameEventDic_Types_Milestone__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone__get_Count__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_22118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27779);
		    DAT_ram_00a5a2ca = '\x01';
		  }
		  local_4 = 0;
		  iVar9 = *(int *)(*(int *)(param1 + 0x10) + 0x28);
		  iVar10 = *(int *)(iVar9 + 0xc);
		  local_8 = iVar10;
		  local_c = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (iVar9,
		                              Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone__GetEnumerator__
		                             );
		  local_18 = ZEXT48(&local_c) << 0x20;
		code_r0x811f3cfb:
		  piVar6 = local_c;
		  iVar9 = *local_c;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		        puVar2 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		        goto code_r0x811f3d93;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x811f3ddb:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f3f24;
		  }
		code_r0x811f3d93:
		  DAT_ram_009d3e38 = 0;
		  iVar9 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		  piVar6 = local_c;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x811f3ddb;
		  if (iVar9 == 0) {
		    iVar9 = 0;
		    goto code_r0x811f3f6d;
		  }
		  iVar9 = *local_c;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		      if (System_Collections_Generic_IEnumerator_GameEventDic_Types_Milestone__TypeInfo == *piVar11)
		      {
		        puVar2 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		        goto code_r0x811f3e80;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                      System_Collections_Generic_IEnumerator_GameEventDic_Types_Milestone__TypeInfo,
		                      0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x811f3f12:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f3f24;
		  }
		code_r0x811f3e80:
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		  iVar9 = DAT_ram_009d3e38;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x811f3f12;
		  DAT_ram_009d3e38 = 0;
		  fVar4 = import::env::invoke_fiii
		                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x283,param1,uVar3,iVar9);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
		    if (1.0 <= fVar4) {
		      iVar8 = iVar8 + 1;
		      local_4 = iVar8;
		    }
		    goto code_r0x811f3cfb;
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811f3f24:
		  iVar9 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar9 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_18 = CONCAT44(local_18._4_4_,iVar9);
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x811f3f6d:
		      piVar6 = local_c;
		      DAT_ram_009d3e38 = 0;
		      if (local_c != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_c;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar7 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811f3fe5;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar7 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x811f3fe5:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      }
		      if (iVar9 == 0) {
		        iVar9 = *(int *)(param1 + 0x30);
		        local_1a = 0;
		        System_Data_SqlTypes_SqlByte__ToSqlInt64
		                  (&local_1a,(uint)(iVar10 <= iVar8),Method_System_Nullable_bool___ctor__);
		        *(ushort *)(iVar9 + 0x10) = local_1a;
		        iVar9 = *(int *)(param1 + 0x30);
		        param1_00 = *(undefined4 *)(param1 + 0x2c);
		        iVar8 = Mono_Security_ASN1Convert__ToOid
		                          (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		        uVar3 = func_ii_4443(&local_4,0);
		        local_18 = 0;
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (&local_18,StringLiteral_22118,uVar3,
		                   Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		        *(longlong *)(iVar8 + 0x10) = local_18;
		        uVar3 = func_ii_4443(&local_8,0);
		        local_28 = 0;
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (&local_28,StringLiteral_27779,uVar3,
		                   Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		        *(undefined8 *)(iVar8 + 0x18) = local_28;
		        uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                          (param1_00,iVar8,0);
		        *(undefined4 *)(iVar9 + 0x18) = uVar3;
		        return *(undefined4 *)(param1 + 0x30);
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x284,&local_18);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C90")]
		[Address(RVA = "0x7D1E", Offset = "0x7D1E", VA = "0x7D1E")]
		public ValueRow GetProgress()
		{
		/* --- GHIDRA: GetProgress ---
		float Gameplay_GdEvents_Model_GdEventData__GetProgress
		                (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  float fVar1;
		  double dVar2;
		  int iVar3;
		  double param1_00;
		  ulonglong uVar4;
		  undefined1 auStack_10 [8];
		  float8 local_8;
		  
		  fVar1 = func_ii_8582(param1,param2,auStack_10);
		  fVar1 = fVar1 * 100.0;
		  if (99.0 < fVar1) {
		    if (DAT_ram_00a648ed == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		      DAT_ram_00a648ed = '\x01';
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    if (ABS(FLOOR(fVar1)) < 2.1474836e+09) {
		      iVar3 = (int)FLOOR(fVar1);
		      goto code_r0x811f0570;
		    }
		  }
		  else if (fVar1 < 1.0) {
		    if (DAT_ram_00a63a16 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		      DAT_ram_00a63a16 = '\x01';
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    if (ABS(CEIL(fVar1)) < 2.1474836e+09) {
		      iVar3 = (int)CEIL(fVar1);
		      goto code_r0x811f0570;
		    }
		  }
		  else {
		    if (DAT_ram_00a6445d == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		      DAT_ram_00a6445d = '\x01';
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    param1_00 = (double)fVar1;
		    dVar2 = unnamed_function_4206(param1_00,&local_8);
		    if (0.0 <= fVar1) {
		      if (dVar2 == 0.5) {
		        if (ABS((double)local_8) < 9.223372036854776e+18) {
		          uVar4 = (ulonglong)(double)local_8;
		        }
		        else {
		          uVar4 = 0;
		        }
		        if ((uVar4 & 1) != 0) {
		          local_8 = (float8)((double)local_8 + 1.0);
		        }
		      }
		      else {
		        local_8 = (float8)FLOOR(param1_00 + 0.5);
		      }
		    }
		    else if (dVar2 == -0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar4 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar4 = 0;
		      }
		      if ((uVar4 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + -1.0);
		      }
		    }
		    else {
		      local_8 = (float8)CEIL(param1_00 + -0.5);
		    }
		    if (ABS((double)local_8) < 2147483648.0) {
		      iVar3 = (int)(double)local_8;
		      goto code_r0x811f0570;
		    }
		  }
		  iVar3 = -0x80000000;
		code_r0x811f0570:
		  return (float)iVar3;
		}
		*/

		/* --- GHIDRA: GetProgress ---
		float Gameplay_GdEvents_Model_GdEventData__GetProgress
		                (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  float fVar1;
		  double dVar2;
		  int iVar3;
		  double param1_00;
		  ulonglong uVar4;
		  undefined1 auStack_10 [8];
		  float8 local_8;
		  
		  fVar1 = func_ii_8582(param1,param2,auStack_10);
		  fVar1 = fVar1 * 100.0;
		  if (99.0 < fVar1) {
		    if (DAT_ram_00a648ed == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		      DAT_ram_00a648ed = '\x01';
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    if (ABS(FLOOR(fVar1)) < 2.1474836e+09) {
		      iVar3 = (int)FLOOR(fVar1);
		      goto code_r0x811f0570;
		    }
		  }
		  else if (fVar1 < 1.0) {
		    if (DAT_ram_00a63a16 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		      DAT_ram_00a63a16 = '\x01';
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    if (ABS(CEIL(fVar1)) < 2.1474836e+09) {
		      iVar3 = (int)CEIL(fVar1);
		      goto code_r0x811f0570;
		    }
		  }
		  else {
		    if (DAT_ram_00a6445d == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		      DAT_ram_00a6445d = '\x01';
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    param1_00 = (double)fVar1;
		    dVar2 = unnamed_function_4206(param1_00,&local_8);
		    if (0.0 <= fVar1) {
		      if (dVar2 == 0.5) {
		        if (ABS((double)local_8) < 9.223372036854776e+18) {
		          uVar4 = (ulonglong)(double)local_8;
		        }
		        else {
		          uVar4 = 0;
		        }
		        if ((uVar4 & 1) != 0) {
		          local_8 = (float8)((double)local_8 + 1.0);
		        }
		      }
		      else {
		        local_8 = (float8)FLOOR(param1_00 + 0.5);
		      }
		    }
		    else if (dVar2 == -0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar4 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar4 = 0;
		      }
		      if ((uVar4 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + -1.0);
		      }
		    }
		    else {
		      local_8 = (float8)CEIL(param1_00 + -0.5);
		    }
		    if (ABS((double)local_8) < 2147483648.0) {
		      iVar3 = (int)(double)local_8;
		      goto code_r0x811f0570;
		    }
		  }
		  iVar3 = -0x80000000;
		code_r0x811f0570:
		  return (float)iVar3;
		}
		*/

			return null;
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000087F0 File Offset: 0x000069F0
		[Token(Token = "0x6002C91")]
		[Address(RVA = "0x2187", Offset = "0x2187", VA = "0x2187")]
		public float GetProgress(GameEventDic.Types.Milestone milestoneDic)
		{
			return 0f;
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x00008808 File Offset: 0x00006A08
		[Token(Token = "0x6002C92")]
		[Address(RVA = "0x7D1F", Offset = "0x7D1F", VA = "0x7D1F")]
		public float GetRoundedPercentage(GameEventDic.Types.Milestone milestoneDic)
		{
		/* --- GHIDRA: GetRoundedPercentage ---
		undefined4
		Gameplay_GdEvents_Model_GdEventData__GetRoundedPercentage
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float fVar2;
		  
		  uVar1 = 0;
		  if ((*(char *)(*(int *)(*(int *)(param2 + 0x1c) + 0x10) + 0x10) != '\0') &&
		     (fVar2 = func_ii_8582(param1,*(undefined4 *)(param2 + 8),param2), 0.0 < fVar2)) {
		    uVar1 = 1;
		    if (1.0 <= fVar2) {
		      uVar1 = 2;
		    }
		    if (fVar2 <= 0.0) {
		      uVar1 = 2;
		    }
		  }
		  return uVar1;
		}
		*/

			return 0f;
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x00008820 File Offset: 0x00006A20
		[Token(Token = "0x6002C93")]
		[Address(RVA = "0x7D20", Offset = "0x7D20", VA = "0x7D20")]
		public MilestoneProgressState GetProgressState(MilestoneData milestone)
		{
		/* --- GHIDRA: GetProgressState ---
		void Gameplay_GdEvents_Model_GdEventData__GetProgressState(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x34);
		  if (iVar1 != param2) {
		    *(int *)(param1 + 0x34) = param2;
		    if (param2 != 0) {
		      *(undefined1 *)(param2 + 0x24) = 1;
		    }
		    if (iVar1 != 0) {
		      *(undefined1 *)(iVar1 + 0x24) = 0;
		    }
		  }
		  return;
		}
		*/

			return MilestoneProgressState.Unknown;
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C94")]
		[Address(RVA = "0x7D21", Offset = "0x7D21", VA = "0x7D21")]
		public void SetSelectedMileStone(MilestoneData value)
		{
		/* --- GHIDRA: SetSelectedMileStone ---
		void Gameplay_GdEvents_Model_GdEventData__SetSelectedMileStone
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a2cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_JsonUtility_FromJson_GdEventIdsPrefs_ValuesWrapper___);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_GdEventIdsPrefs_ValuesWrapper_TypeInfo);
		    DAT_ram_00a5a2cc = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  uVar1 = UnityEngine_PlayerPrefs__GetInt(param2,0);
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar1,0);
		  if (iVar2 == 0) {
		    uVar1 = func_ii_5995(uVar1,
		                         Method_UnityEngine_JsonUtility_FromJson_GdEventIdsPrefs_ValuesWrapper___);
		    *(undefined4 *)(param1 + 0xc) = uVar1;
		    return;
		  }
		  iVar2 = unnamed_function_1417(Gameplay_GdEvents_Model_GdEventIdsPrefs_ValuesWrapper_TypeInfo);
		  if (DAT_ram_00a5a2d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    DAT_ram_00a5a2d1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_uint___ctor__);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  *(int *)(param1 + 0xc) = iVar2;
		  return;
		}
		*/

		}

		// Token: 0x04001876 RID: 6262
		[Token(Token = "0x4001876")]
		[FieldOffset(Offset = "0x8")]
		[NotNull]
		public readonly EventTabs Tabs;

		// Token: 0x04001877 RID: 6263
		[Token(Token = "0x4001877")]
		[FieldOffset(Offset = "0xC")]
		[NotNull]
		public readonly BackTime BackTime;

		// Token: 0x0400187E RID: 6270
		[Token(Token = "0x400187E")]
		[FieldOffset(Offset = "0x28")]
		private List<MilestoneData> _milestones;

		// Token: 0x0400187F RID: 6271
		[Token(Token = "0x400187F")]
		[FieldOffset(Offset = "0x2C")]
		private readonly string _progressValueTextTemplate;

		// Token: 0x04001880 RID: 6272
		[Token(Token = "0x4001880")]
		[FieldOffset(Offset = "0x30")]
		private ValueRow _progressValueRow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_SelectedMilestone ---
		void Gameplay_GdEvents_Model_GdEventData__set_SelectedMilestone
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,int param7,undefined4 param8)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MilestoneData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MilestoneData__TypeInfo);
		    DAT_ram_00a5a2c7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,0.0,0);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_MilestoneData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_MilestoneData___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  *(undefined4 *)(param1 + 0x24) = param4;
		  *(undefined4 *)(param1 + 0x20) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(int *)(param1 + 0x30) = param7;
		  *(undefined4 *)(param1 + 8) = param6;
		  *(undefined4 *)(param1 + 0x2c) = *(undefined4 *)(param7 + 0x18);
		  return;
		}
		*/

}
