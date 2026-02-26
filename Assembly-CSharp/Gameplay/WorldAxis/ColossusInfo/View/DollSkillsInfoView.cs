using System;
using System.Collections.Generic;
using Core.Data.Skills;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x02000324 RID: 804
	[Token(Token = "0x2000324")]
	public class DollSkillsInfoView : BaseInfoBox
	{
		// Token: 0x06001282 RID: 4738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x647C", Offset = "0x647C", VA = "0x647C")]
		public void Init(SkillCollection dollSkills, StoneDic stone, HashSet<uint> customSkillIds)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_ColossusInfo_View_DollSkillsInfoView__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int param2_00;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  int *param2_01;
		  int iVar9;
		  int *piVar10;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  iVar9 = 0;
		  if (DAT_ram_00a58bd2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Contains__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_DollSkillRow___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		              );
		    DAT_ram_00a58bd2 = '\x01';
		  }
		  if (*(char *)(param1 + 0x14) == '\0') {
		    return;
		  }
		  Gameplay_UserInfo_View_BaseInfoBox__SwitchVisible(param1,0);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x152,local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f85d44:
		      iVar9 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar6) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar6 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar6;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          if (iVar6 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x25a,&local_20);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar2 = *(undefined4 *)(param1 + 0x10);
		    uVar8 = *(undefined4 *)(param1 + 0x18);
		    iVar6 = local_8._4_4_;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f85d44;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar7 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar8,uVar2,
		                               Method_UnityEngine_Object_Instantiate_DollSkillRow___);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f85d44;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe2,piVar7,iVar9,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f85d44;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f85d44;
		      }
		      DAT_ram_00a6456f = '\x01';
		    }
		    param2_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param2_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		          puVar4 = (undefined4 *)(piVar10[1] * 8 + iVar3 + 0x178);
		          goto code_r0x80f859ba;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2_01,
		                        Core_Gameplay_IGame_TypeInfo,0x17);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f85bad:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f85d44;
		    }
		code_r0x80f859ba:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(*puVar4,param2_01,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f85bad;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f85d44;
		    }
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x254,uVar2,
		                           *(undefined4 *)(iVar6 + 8),0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f85d44;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3bc,
		                       *(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2_00 + 0xc),
		                       Method_System_Collections_Generic_HashSet_uint__Contains__);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f85d44;
		    }
		    if (iVar5 != 0) {
		      uVar8 = *(undefined4 *)(param1 + 0x1c);
		      piVar7[0xe] = param2_00;
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x255,uVar8,0);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe4,piVar7,uVar2,0);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x256,uVar8,0);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe6,piVar7,uVar2,0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x80f85c9d;
		          }
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f85d44;
		    }
		    piVar7[0xe] = param2_00;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 599,param2_00,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f85d28:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f85d44;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe4,piVar7,uVar2,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f85d28;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 600,param2_00,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f85d28;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe6,piVar7,uVar2,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f85d28;
		code_r0x80f85c9d:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x259,iVar6,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f85d32:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f85d44;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar7 + 0xe8),piVar7,uVar2,*(undefined4 *)(*piVar7 + 0xec));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f85d32;
		    iVar9 = iVar9 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x647D", Offset = "0x647D", VA = "0x647D", Slot = "5")]
		public override void UpdateInfo()
		{
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x647E", Offset = "0x647E", VA = "0x647E")]
		public DollSkillsInfoView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ColossusInfo_View_DollSkillsInfoView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  longlong local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  uint local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58bd3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_TreasuryOptionListElement_TreasuryOptionListElementArgs__Awake__
		              );
		    DAT_ram_00a58bd3 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElement_object____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_TreasuryOptionListElement_TreasuryOptionListElementArgs__Awake__
		            );
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  local_8 = Mono_Security_ASN1Convert__ToOid
		                      (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		  *(undefined4 *)(local_8 + 0x10) = 5;
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0;
		  local_18 = (ulonglong)local_8 << 0x20;
		  func_ii_7564(param1_00,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DollSkillRow _skillPrefab;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		[FieldOffset(Offset = "0x1C")]
		private StoneDic _stone;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		[FieldOffset(Offset = "0x20")]
		private SkillCollection _dollSkills;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		[FieldOffset(Offset = "0x24")]
		private HashSet<uint> _customSkillIds;
	}
}
