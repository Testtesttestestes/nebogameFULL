using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Duel.View
{
	// Token: 0x0200085D RID: 2141
	[Token(Token = "0x200085D")]
	public class SkillCompareRow : MonoBehaviour
	{
		// Token: 0x170009EF RID: 2543
		// (set) Token: 0x0600324C RID: 12876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EF")]
		public int Index
		{
			[Token(Token = "0x600324C")]
			[Address(RVA = "0x82A2", Offset = "0x82A2", VA = "0x82A2")]
			set
			{
			}
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324D")]
		[Address(RVA = "0x1BBB", Offset = "0x1BBB", VA = "0x1BBB")]
		public void Init(UserSkillDic dic, long leftValue, long rightValue)
		{
		/* --- GHIDRA: Init ---
		int * Gameplay_Duel_View_SkillCompareRow__Init(int *param1)
		
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

		// Token: 0x0600324E RID: 12878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324E")]
		[Address(RVA = "0x82A3", Offset = "0x82A3", VA = "0x82A3")]
		private void AssignSprites(Sprite left, Sprite right)
		{
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324F")]
		[Address(RVA = "0x82A4", Offset = "0x82A4", VA = "0x82A4")]
		public SkillCompareRow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_View_SkillCompareRow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  float param3_00;
		  float param2_00;
		  undefined4 param2_01;
		  longlong param4_00;
		  longlong param5_00;
		  int iVar6;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  int local_8;
		  undefined4 uStack_4;
		  
		  bVar1 = false;
		  param3_00 = 0.0;
		  param2_00 = 0.0;
		  if (DAT_ram_00a57bd4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_int__SkillData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_int__SkillData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_int__SkillData__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_int__SkillData__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SkillCompareRow___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57bd4 = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,param2,
		             Method_System_Collections_Generic_Dictionary_int__SkillData__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x20e,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_int__SkillData__MoveNext__
		                      );
		    iVar4 = local_8;
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e32e06:
		      iVar6 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar4 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80e32e5c:
		          DAT_ram_009d3e38 = 0;
		          Gameplay_Duel_View_SkillsComparer___ctor
		                    (*(undefined4 *)(param1 + 0x18),param2_00,param3_00,&local_20);
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x35,&local_20);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
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
		    if (iVar2 == 0) goto code_r0x80e32e5c;
		    param4_00 = *(longlong *)(local_8 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,param3,uStack_c,
		                       Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e32e06;
		    }
		    param5_00 = *(longlong *)(iVar2 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33,param4,
		                       *(undefined4 *)(iVar4 + 8),0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e32e06;
		    }
		    param3_00 = param3_00 + *(float *)(iVar4 + 0x10) * (float)param5_00;
		    param2_00 = param2_00 + *(float *)(iVar4 + 0x10) * (float)param4_00;
		    uVar3 = *(undefined4 *)(param1 + 0x14);
		    param2_01 = *(undefined4 *)(param1 + 0x10);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e32e06;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_01,uVar3,
		                       Method_UnityEngine_Object_Instantiate_SkillCompareRow___);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e32e06;
		    }
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184077
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34,iVar2,iVar4,param4_00,
		               param5_00,&local_20);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e32e06;
		    }
		    iVar6 = 0x38;
		    if (!bVar1) {
		      iVar6 = 0x34;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 4,*(undefined4 *)(iVar2 + 0x10),
		               *(undefined4 *)(iVar2 + iVar6),0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e32e06;
		    }
		    bVar1 = (bool)(bVar1 ^ 1);
		  } while( true );
		}
		*/

		}

		// Token: 0x04001B81 RID: 7041
		[Token(Token = "0x4001B81")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04001B82 RID: 7042
		[Token(Token = "0x4001B82")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _leftStatus;

		// Token: 0x04001B83 RID: 7043
		[Token(Token = "0x4001B83")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _rightStatus;

		// Token: 0x04001B84 RID: 7044
		[Token(Token = "0x4001B84")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x04001B85 RID: 7045
		[Token(Token = "0x4001B85")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _leftValue;

		// Token: 0x04001B86 RID: 7046
		[Token(Token = "0x4001B86")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _rightValue;

		// Token: 0x04001B87 RID: 7047
		[Token(Token = "0x4001B87")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _lessSprite;

		// Token: 0x04001B88 RID: 7048
		[Token(Token = "0x4001B88")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _greaterSprite;

		// Token: 0x04001B89 RID: 7049
		[Token(Token = "0x4001B89")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _equalsSprite;

		// Token: 0x04001B8A RID: 7050
		[Token(Token = "0x4001B8A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _lighBg;

		// Token: 0x04001B8B RID: 7051
		[Token(Token = "0x4001B8B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _darkBg;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Index ---
		void Gameplay_Duel_View_SkillCompareRow__set_Index
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),param2,0);
		  func_ii_7050(*(undefined4 *)(param1 + 0x18),param3,0);
		  return;
		}
		*/

}
