using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ArtifactComparer.Model
{
	// Token: 0x02000CE4 RID: 3300
	[Token(Token = "0x2000CE4")]
	public class ArtifactComparerModel : AbstractModel
	{
		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06005050 RID: 20560 RVA: 0x0000EB68 File Offset: 0x0000CD68
		// (set) Token: 0x06005051 RID: 20561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001040")]
		public bool DebugMode
		{
			[Token(Token = "0x6005050")]
			[Address(RVA = "0x9E61", Offset = "0x9E61", VA = "0x9E61")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005051")]
			[Address(RVA = "0x9E62", Offset = "0x9E62", VA = "0x9E62")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06005052 RID: 20562 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005053 RID: 20563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001041")]
		public InventoryBaseModel InventoryModel
		{
			[Token(Token = "0x6005052")]
			[Address(RVA = "0x9E63", Offset = "0x9E63", VA = "0x9E63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005053")]
			[Address(RVA = "0x9E64", Offset = "0x9E64", VA = "0x9E64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06005054 RID: 20564 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005055 RID: 20565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001042")]
		public ArtifactData TargetArtifact
		{
			[Token(Token = "0x6005054")]
			[Address(RVA = "0x9E65", Offset = "0x9E65", VA = "0x9E65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005055")]
			[Address(RVA = "0x9E66", Offset = "0x9E66", VA = "0x9E66")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06005056 RID: 20566 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005057 RID: 20567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001043")]
		public ArtifactData ComparableArtifact
		{
			[Token(Token = "0x6005056")]
			[Address(RVA = "0x9E67", Offset = "0x9E67", VA = "0x9E67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005057")]
			[Address(RVA = "0x9E68", Offset = "0x9E68", VA = "0x9E68")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06005058 RID: 20568 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005059 RID: 20569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001044")]
		public List<int> AllSkillIds
		{
			[Token(Token = "0x6005058")]
			[Address(RVA = "0x9E69", Offset = "0x9E69", VA = "0x9E69")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005059")]
			[Address(RVA = "0x9E6A", Offset = "0x9E6A", VA = "0x9E6A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x0600505A RID: 20570 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600505B RID: 20571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001045")]
		public HashSet<int> EnabledSkillIds
		{
			[Token(Token = "0x600505A")]
			[Address(RVA = "0x9E6B", Offset = "0x9E6B", VA = "0x9E6B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600505B")]
			[Address(RVA = "0x9E6C", Offset = "0x9E6C", VA = "0x9E6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600505C")]
		[Address(RVA = "0x9E6D", Offset = "0x9E6D", VA = "0x9E6D")]
		public ArtifactComparerModel(UserData user, InventoryBaseModel inventoryModel)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_Model_ArtifactComparerModel___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  int local_20;
		  int **local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a58a30 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Enumerator_int__Dispose__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Enumerator_int__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_int__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_int__Add__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_UserSkillDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserSkillDic__GetEnumerator__);
		    DAT_ram_00a58a30 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80f61b9e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f61b9e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar7 + 0x5c),
		                              Method_Google_Protobuf_Collections_RepeatedField_UserSkillDic__GetEnumerator__
		                             );
		  local_20 = 0;
		  local_1c = &local_4;
		code_r0x80f61bde:
		  do {
		    do {
		      piVar6 = local_4;
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		            puVar4 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80f61c8a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f61cd2:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f61e6d;
		      }
		code_r0x80f61c8a:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f61cd2;
		      if (iVar7 == 0) {
		        iVar7 = 0;
		        goto code_r0x80f61eb6;
		      }
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_UserSkillDic__TypeInfo == *piVar8) {
		            puVar4 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80f61d79;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_UserSkillDic__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f61dc6:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f61e6d;
		      }
		code_r0x80f61d79:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		      iVar7 = Method_System_Collections_Generic_List_int__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f61dc6;
		    } while (*(float *)(iVar5 + 0x10) <= 0.0);
		    uVar3 = *(undefined4 *)(iVar5 + 0xc);
		    iVar5 = *(int *)(param1 + 0x1c);
		    *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar5 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		      *(uint *)(iVar5 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar5 + 8) + uVar1 * 4 + 0x10) = uVar3;
		      goto code_r0x80f61bde;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x9a,iVar5,uVar3,
		               *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f61e6d:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar7 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar7;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80f61eb6:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f61f2e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f61f2e:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar7 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_18,*(undefined4 *)(param1 + 0x1c),
		                 Method_System_Collections_Generic_List_int__GetEnumerator__);
		      local_20 = 0;
		      local_1c = (int **)&local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x216,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_int__MoveNext__);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f6204c;
		        }
		        if (iVar5 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_iiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x214,
		                   *(undefined4 *)(param1 + 0x20),local_10._4_4_,
		                   Method_System_Collections_Generic_HashSet_int__Add__);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar7 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f6204c:
		      iVar7 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar5) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar5 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar5;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          if (iVar5 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x215,&local_20);
		      goto joined_r0x80f620db;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x213,&local_20);
		joined_r0x80f620db:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600505D RID: 20573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600505D")]
		[Address(RVA = "0x9E6E", Offset = "0x9E6E", VA = "0x9E6E")]
		private void InitSkillIds()
		{
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600505E")]
		[Address(RVA = "0x9E6F", Offset = "0x9E6F", VA = "0x9E6F")]
		public void SetTargetArtifact(ArtifactData artifactData)
		{
		/* --- GHIDRA: SetTargetArtifact ---
		void Gameplay_ArtifactComparer_Model_ArtifactComparerModel__SetTargetArtifact
		               (int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x10) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600505F RID: 20575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600505F")]
		[Address(RVA = "0x9E70", Offset = "0x9E70", VA = "0x9E70", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005060")]
		[Address(RVA = "0x9E71", Offset = "0x9E71", VA = "0x9E71")]
		public void SetDebugMode(bool debug)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_EnabledSkillIds ---
		void Gameplay_ArtifactComparer_Model_ArtifactComparerModel__set_EnabledSkillIds
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a2f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_int___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    DAT_ram_00a58a2f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_int__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_int___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_int__TypeInfo);
		  System_Collections_Generic_HashSet_char___get_Count
		            (uVar1,Method_System_Collections_Generic_HashSet_int___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x10) = param3;
		  Gameplay_ArtifactComparer_Model_ArtifactComparerModel___ctor(param1,param1);
		  return;
		}
		*/

}
