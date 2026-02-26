using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Accounts;
using Core.Gameplay;
using Gameplay.Assistants.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Craft;
using Protocol.Dic;

namespace Gameplay.Assistants.Manufacture.Model
{
	// Token: 0x02000CAE RID: 3246
	[Token(Token = "0x2000CAE")]
	public class ManufactureAssistModel : BaseAssistantModel
	{
		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06004F06 RID: 20230 RVA: 0x0000E868 File Offset: 0x0000CA68
		// (set) Token: 0x06004F07 RID: 20231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001012")]
		public int LastSlotId
		{
			[Token(Token = "0x6004F06")]
			[Address(RVA = "0x9D2E", Offset = "0x9D2E", VA = "0x9D2E")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004F07")]
			[Address(RVA = "0x9D2F", Offset = "0x9D2F", VA = "0x9D2F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x0000E880 File Offset: 0x0000CA80
		// (set) Token: 0x06004F09 RID: 20233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001013")]
		public bool SortByTypeRewardsEnabled
		{
			[Token(Token = "0x6004F08")]
			[Address(RVA = "0x9D30", Offset = "0x9D30", VA = "0x9D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F09")]
			[Address(RVA = "0x9D31", Offset = "0x9D31", VA = "0x9D31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F0B RID: 20235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001014")]
		public ProtoManufactureGetInfoAns Info
		{
			[Token(Token = "0x6004F0A")]
			[Address(RVA = "0x9D32", Offset = "0x9D32", VA = "0x9D32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F0B")]
			[Address(RVA = "0x9D33", Offset = "0x9D33", VA = "0x9D33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001015")]
		public ArtifactInfo CurrentDismantledArtifact
		{
			[Token(Token = "0x6004F0C")]
			[Address(RVA = "0x9D34", Offset = "0x9D34", VA = "0x9D34")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0D")]
		[Address(RVA = "0x9D35", Offset = "0x9D35", VA = "0x9D35")]
		public ManufactureAssistModel(AssistantsDic dic, AssistantStatus status, IGame game, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  param1_00 = func_ii_7504(*(undefined4 *)(param1 + 8),0);
		  iVar1 = Core_Data_UserData__get_Accounts(param1_00,3,&local_4,0);
		  if (iVar1 == 0) {
		    local_4 = 0;
		  }
		  return local_4;
		}
		*/

		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06004F0E RID: 20238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001016")]
		public IAccountData Account
		{
			[Token(Token = "0x6004F0E")]
			[Address(RVA = "0x9D36", Offset = "0x9D36", VA = "0x9D36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x17001017")]
		public double TotalStackSize
		{
			[Token(Token = "0x6004F0F")]
			[Address(RVA = "0x9D37", Offset = "0x9D37", VA = "0x9D37")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x6004F10")]
		[Address(RVA = "0x9D38", Offset = "0x9D38", VA = "0x9D38")]
		public bool CheckStartDisassembleCommon(ArtifactData artifact, out ManufactureAssistModel.StartFailDisassembleReasons reason)
		{
		/* --- GHIDRA: CheckStartDisassembleCommon ---
		undefined4
		Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__CheckStartDisassembleCommon
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int local_4;
		  
		  if (DAT_ram_00a58984 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58984 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x80f512e4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f512e4:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar5 = **(int **)(iVar3 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(iVar3 + 0x10),*(undefined4 *)(iVar5 + 0x104));
		  if (DAT_ram_00a589da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		              );
		    DAT_ram_00a589da = '\x01';
		  }
		  iVar5 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar3 + 0x14),7,&local_4,
		                     Method_System_Collections_Generic_Dictionary_DropTypes__ArtifactDropModel_ArtifactDrop__TryGetValue__
		                    );
		  iVar3 = Method_System_Array_Empty_ArtifactData___;
		  if (iVar5 == 0) {
		    iVar5 = *(int *)(Method_System_Array_Empty_ArtifactData___ + 0x1c);
		    if (iVar5 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_ArtifactData___);
		      iVar5 = *(int *)(iVar3 + 0x1c);
		    }
		    iVar5 = *(int *)(iVar5 + 8);
		    if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		      iVar5 = func_ii_1079(iVar5);
		    }
		    if (*(int *)(iVar5 + 0x74) == 0) {
		      func_ii_306000(iVar5);
		    }
		    iVar3 = *(int *)(*(int *)(iVar3 + 0x1c) + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    puVar4 = *(undefined4 **)(iVar3 + 0x5c);
		  }
		  else {
		    puVar4 = (undefined4 *)(local_4 + 0xc);
		  }
		  return *puVar4;
		}
		*/

			return default(bool);
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001018")]
		public IEnumerable<ArtifactData> Drop
		{
			[Token(Token = "0x6004F11")]
			[Address(RVA = "0x9D39", Offset = "0x9D39", VA = "0x9D39")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x6004F12")]
		[Address(RVA = "0x9D3A", Offset = "0x9D3A", VA = "0x9D3A")]
		public bool CheckStartDisassemblePart(ArtifactData artifact, out ManufactureAssistModel.StartFailDisassembleReasons reason)
		{
			return default(bool);
		}

		// Token: 0x02000CAF RID: 3247
		[Token(Token = "0x2000CAF")]
		public enum StartFailDisassembleReasons
		{
			// Token: 0x04002B22 RID: 11042
			[Token(Token = "0x4002B22")]
			UNKNOWN,
			// Token: 0x04002B23 RID: 11043
			[Token(Token = "0x4002B23")]
			NO_ARTIFACT_IN_SLOT,
			// Token: 0x04002B24 RID: 11044
			[Token(Token = "0x4002B24")]
			IS_NO_STACKABLE,
			// Token: 0x04002B25 RID: 11045
			[Token(Token = "0x4002B25")]
			ACCOUNT_EXPIRED,
			// Token: 0x04002B26 RID: 11046
			[Token(Token = "0x4002B26")]
			REQUIRED_PICKUP_DROP
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Info ---
		undefined4
		Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__set_Info(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58981 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		    DAT_ram_00a58981 = '\x01';
		  }
		  param1_00 = *(int *)(*(int *)(param1 + 0x24) + 0x14);
		  if (*(int *)(param1_00 + 0xc) < 1) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (param1_00,0,
		                       Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_CurrentDismantledArtifact ---
		void Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__get_CurrentDismantledArtifact
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58977 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    DAT_ram_00a58977 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param5,0);
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined4 *)(param1 + 0xc) = param4;
		  return;
		}
		*/


		/* --- GHIDRA: get_Account ---
		double Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__get_Account
		                 (int param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *piVar3;
		  uint *puVar4;
		  double dVar5;
		  int iVar6;
		  double dVar7;
		  int *piVar8;
		  uint uVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  dVar7 = 0.0;
		  if (DAT_ram_00a58982 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ArtifactInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a58982 = '\x01';
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param1 + 0x24) + 0x14),
		                              Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar3 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar1 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f50e18;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f50f9e:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f50fa6;
		    }
		code_r0x80f50e18:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar3,puVar1[1]);
		    piVar3 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f50f9e;
		    if (iVar6 == 0) {
		      iVar6 = 0;
		      goto code_r0x80f50fef;
		    }
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		        if (System_Collections_Generic_IEnumerator_ArtifactInfo__TypeInfo == *piVar8) {
		          puVar1 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f50ef2;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ArtifactInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f50f8a:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f50fa6;
		    }
		code_r0x80f50ef2:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar3,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f50f8a;
		    DAT_ram_009d3e38 = 0;
		    dVar5 = import::env::invoke_diii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e1,
		                       *(undefined4 *)(*(int *)(iVar6 + 0x20) + 0xc),1,
		                       Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) break;
		    dVar7 = dVar7 + dVar5;
		  } while( true );
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f50fa6:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar6 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x80f50fef:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar9 = 0;
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		              puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f51067;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f51067:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		      }
		      if (iVar6 == 0) {
		        return (double)*(uint *)(*(int *)(param1 + 0x24) + 0x10) - dVar7;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1e2,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_TotalStackSize ---
		uint Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__get_TotalStackSize
		               (int param1,int param2,undefined4 *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  int *param1_00;
		  int local_8;
		  int *local_4;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a58983 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a58983 = '\x01';
		  }
		  local_8 = 0;
		  uVar1 = 3;
		  uVar3 = func_ii_7504(*(undefined4 *)(param1 + 8),0);
		  iVar4 = Core_Data_UserData__get_Accounts(uVar3,3,&local_8,0);
		  if ((iVar4 != 0) && (local_8 != 0)) {
		    uVar2 = 0;
		    local_4 = (int *)0x0;
		    uVar1 = func_ii_7504(*(undefined4 *)(param1 + 8),0);
		    iVar4 = Core_Data_UserData__get_Accounts(uVar1,3,&local_4,0);
		    param1_00 = local_4;
		    if (iVar4 == 0) {
		      param1_00 = (int *)0x0;
		    }
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)
		           ) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x80f511da;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f511da:
		    uVar2 = 0;
		    uVar1 = 3;
		    iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		    if (iVar4 == 0) {
		      if (param2 == 0) {
		        uVar1 = 1;
		      }
		      else {
		        uVar1 = 4;
		        uVar3 = Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__CheckStartDisassembleCommon
		                          (param1,3);
		        uVar2 = System_Linq_Enumerable__OrderBy_object__ulong_
		                          (uVar3,Method_System_Linq_Enumerable_Any_ArtifactData___);
		        if (uVar2 == 0) {
		          uVar1 = 0;
		        }
		        uVar2 = uVar2 ^ 1;
		      }
		    }
		  }
		  *param3 = uVar1;
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_Drop ---
		int Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__get_Drop
		              (undefined4 param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  iVar1 = 0;
		  iVar2 = Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel__get_TotalStackSize
		                    (param1,param2,param3,param3);
		  if (iVar2 != 0) {
		    uVar3 = 0;
		    iVar1 = Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById(param2,0);
		    if (iVar1 == 0) {
		      uVar3 = 2;
		    }
		    *param3 = uVar3;
		  }
		  return iVar1;
		}
		*/

}
