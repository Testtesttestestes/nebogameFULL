using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	public class SkillsInfoView : BaseInfoBox
	{
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042C")]
		public UserData User
		{
			[Token(Token = "0x60017FB")]
			[Address(RVA = "0x69B6", Offset = "0x69B6", VA = "0x69B6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017FC")]
			[Address(RVA = "0x69B7", Offset = "0x69B7", VA = "0x69B7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700042D")]
		public GameRawImage ExpIcon
		{
			[Token(Token = "0x60017FD")]
			[Address(RVA = "0x69B8", Offset = "0x69B8", VA = "0x69B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700042E")]
		public TextMeshProUGUI ExpLabelField
		{
			[Token(Token = "0x60017FE")]
			[Address(RVA = "0x69B9", Offset = "0x69B9", VA = "0x69B9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700042F")]
		public TextMeshProUGUI ExpValueField
		{
			[Token(Token = "0x60017FF")]
			[Address(RVA = "0x69BA", Offset = "0x69BA", VA = "0x69BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000430")]
		public GameObject ExpBlock
		{
			[Token(Token = "0x6001800")]
			[Address(RVA = "0x69BB", Offset = "0x69BB", VA = "0x69BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x69BC", Offset = "0x69BC", VA = "0x69BC")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_UserInfo_View_SkillsInfoView__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int param2_00;
		  int *piVar6;
		  undefined4 param2_01;
		  int *piVar7;
		  uint uVar8;
		  int *piVar9;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  uVar8 = 0;
		  if (DAT_ram_00a598e8 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SkillRow___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		              );
		    DAT_ram_00a598e8 = '\x01';
		  }
		  if (*(char *)(param1 + 0x14) == '\0') {
		    return;
		  }
		  Gameplay_UserInfo_View_BaseInfoBox__SwitchVisible(param1,0);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x152,local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8108a8e6:
		      iVar1 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar4) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar4 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x35,&local_20);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
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
		    if (iVar4 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x10);
		    param2_01 = *(undefined4 *)(param1 + 0x18);
		    iVar1 = local_8._4_4_;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8108a8e6;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar6 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_01,
		                               uVar3,Method_UnityEngine_Object_Instantiate_SkillRow___);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8108a8e6;
		    }
		    piVar6[10] = uVar8;
		    iVar4 = 0x10;
		    if ((uVar8 & 1) == 0) {
		      iVar4 = 0x14;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 4,piVar6[6],
		               *(undefined4 *)((int)piVar6 + iVar4),0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8108a8e6;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8108a8e6;
		      }
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar7;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		          puVar5 = (undefined4 *)(piVar9[1] * 8 + iVar4 + 0x178);
		          goto code_r0x8108a5dd;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                        Core_Gameplay_IGame_TypeInfo,0x17);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8108a8ac:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8108a8e6;
		    }
		code_r0x8108a5dd:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8108a8ac;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8108a8e6;
		    }
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33,uVar3,
		                           *(undefined4 *)(iVar1 + 8),0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8108a8e6;
		    }
		    piVar6[0x10] = *(int *)(param1 + 0x2c);
		    piVar6[0xf] = iVar1;
		    piVar6[0xe] = param2_00;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x33,param2_00,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8108a8ca:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8108a8e6;
		    }
		    if (DAT_ram_00a598e9 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&StringLiteral_2003);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8108a8ca;
		      DAT_ram_00a598e9 = '\x01';
		    }
		    piVar7 = (int *)piVar6[7];
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,uVar3,
		                       StringLiteral_2003,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8108a8ca;
		    iVar4 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar4 + 0x2d0),piVar7,uVar3,*(undefined4 *)(iVar4 + 0x2d4));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8108a8ca;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x34,param2_00,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8108a8ca;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x62,piVar6[9],uVar3,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8108a8ca;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x259,iVar1,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8108a8d4:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8108a8e6;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar6 + 0xe8),piVar6,uVar3,*(undefined4 *)(*piVar6 + 0xec));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8108a8d4;
		    uVar8 = uVar8 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x69BD", Offset = "0x69BD", VA = "0x69BD", Slot = "5")]
		public override void UpdateInfo()
		{
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001803")]
		[Address(RVA = "0x69BE", Offset = "0x69BE", VA = "0x69BE")]
		public SkillsInfoView()
		{
		}

		// Token: 0x04000CB8 RID: 3256
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkillRow _skillPrefab;

		// Token: 0x04000CB9 RID: 3257
		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _expLabelField;

		// Token: 0x04000CBA RID: 3258
		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _expValueField;

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameRawImage _expIcon;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _expBlock;

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x30")]
		public SkillCollection UserSkills;
	}
}
