using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A3 RID: 1955
	[Token(Token = "0x20007A3")]
	public class EventMilestone_48 : AbstractTag
	{
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x170008FA")]
		public uint EventId
		{
			[Token(Token = "0x6002E6D")]
			[Address(RVA = "0x7EE8", Offset = "0x7EE8", VA = "0x7EE8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x170008FB")]
		public int MilestoneNumber
		{
			[Token(Token = "0x6002E6E")]
			[Address(RVA = "0x7EE9", Offset = "0x7EE9", VA = "0x7EE9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0x7EEA", Offset = "0x7EEA", VA = "0x7EEA", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x7EEB", Offset = "0x7EEB", VA = "0x7EEB")]
		public EventMilestone_48()
		{
		}

		// Token: 0x04001977 RID: 6519
		[Token(Token = "0x4001977")]
		public const string GAME_EVENT_TITLE = "game_event_title";

		// Token: 0x04001978 RID: 6520
		[Token(Token = "0x4001978")]
		public const string EVENT_MILESTONE_TITLE = "event_milestone_title";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_EventId ---
		undefined4
		Gameplay_GameEvents_Model_Tags_EventMilestone_48__get_EventId(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  
		  dVar1 = *(double *)(*(int *)(param1 + 0x14) + 0x18);
		  if (2147483648.0 <= ABS(dVar1)) {
		    return 0x80000000;
		  }
		  return (int)dVar1;
		}
		*/


		/* --- GHIDRA: get_MilestoneNumber ---
		undefined4
		Gameplay_GameEvents_Model_Tags_EventMilestone_48__get_MilestoneNumber
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
		          undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  undefined4 param3_00;
		  undefined4 param4_00;
		  undefined4 param1_00;
		  undefined4 *param2_00;
		  int *param1_01;
		  int iVar6;
		  double dVar7;
		  uint uVar8;
		  undefined4 local_10;
		  int local_c;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a574d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_7545);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23314);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23034);
		    DAT_ram_00a574d7 = '\x01';
		  }
		  local_4 = 0;
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 == 0) {
		    *param4 = 0;
		    return 0;
		  }
		  uVar8 = 0;
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		  *param4 = uVar1;
		  param1_01 = (int *)param1[2];
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80d951d1;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d951d1:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  dVar7 = *(double *)(param1[5] + 0x10);
		  if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		    iVar6 = (int)dVar7;
		  }
		  else {
		    iVar6 = 0;
		  }
		  if (ABS(dVar7) < 2147483648.0) {
		    iVar4 = (int)dVar7;
		  }
		  else {
		    iVar4 = -0x80000000;
		  }
		  if (0.0 <= dVar7) {
		    iVar4 = iVar6;
		  }
		  iVar6 = Core_Extensions_Dict_DictExt__GetClanRestriction(uVar1,iVar4,&local_4,0);
		  if (iVar6 == 0) {
		    dVar7 = *(double *)(param1[5] + 0x10);
		    if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		      iVar6 = (int)dVar7;
		    }
		    else {
		      iVar6 = 0;
		    }
		    if (ABS(dVar7) < 2147483648.0) {
		      local_8 = (int)dVar7;
		    }
		    else {
		      local_8 = -0x80000000;
		    }
		    if (0.0 <= dVar7) {
		      local_8 = iVar6;
		    }
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar1 = func_ii_4419(StringLiteral_7545,uVar1,0);
		    *param4 = uVar1;
		    return iVar2;
		  }
		  iVar6 = System_Collections_CollectionBase___ctor(param2,StringLiteral_23034,0);
		  if (iVar6 == 0) {
		    iVar6 = System_Collections_CollectionBase___ctor(param2,StringLiteral_23314,0);
		    if (iVar6 == 0) {
		      return iVar2;
		    }
		    uVar1 = Core_Extensions_Dict_GameActivityDicExt__GetWidgetImageAssetId(local_4,0);
		    *param4 = uVar1;
		    return iVar2;
		  }
		  DAT_ram_009d3e38 = 0;
		  if (ABS(*(double *)(param1[5] + 0x18)) < 2147483648.0) {
		    iVar6 = (int)*(double *)(param1[5] + 0x18);
		  }
		  else {
		    iVar6 = -0x80000000;
		  }
		  uVar1 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e0,
		                     *(undefined4 *)(local_4 + 0x28),iVar6 + -1,
		                     Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone__get_Item__
		                    );
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e1,uVar1,0)
		    ;
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      *param4 = uVar1;
		      return iVar2;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    puVar5 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*puVar5);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar4 != 0) {
		          import::env::__cxa_end_catch();
		          dVar7 = *(double *)(param1[5] + 0x10);
		          if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		            iVar6 = (int)dVar7;
		          }
		          else {
		            iVar6 = 0;
		          }
		          if (ABS(dVar7) < 2147483648.0) {
		            local_8 = (int)dVar7;
		          }
		          else {
		            local_8 = -0x80000000;
		          }
		          if (0.0 <= dVar7) {
		            local_8 = iVar6;
		          }
		          uVar1 = func_ii_1081(DAT_ram_00a66958,&local_8);
		          if (ABS(*(double *)(param1[5] + 0x18)) < 2147483648.0) {
		            local_c = (int)*(double *)(param1[5] + 0x18);
		          }
		          else {
		            local_c = -0x80000000;
		          }
		          param3_00 = func_ii_1081(DAT_ram_00a66954,&local_c);
		          iVar6 = *(int *)(local_4 + 0x28);
		          unnamed_function_2232
		                    (&
		                     Method_Google_Protobuf_Collections_RepeatedField_GameEventDic_Types_Milestone__get_Count__
		                    );
		          local_10 = *(undefined4 *)(iVar6 + 0xc);
		          param4_00 = func_ii_1081(DAT_ram_00a66954,&local_10);
		          param1_00 = unnamed_function_2232(&StringLiteral_7546);
		          uVar1 = func_ii_8529(param1_00,uVar1,param3_00,param4_00,0);
		          *param4 = uVar1;
		          return iVar2;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80d955db;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x80d955db:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
