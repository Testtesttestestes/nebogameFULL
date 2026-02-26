using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F20 RID: 3872
	[Token(Token = "0x2000F20")]
	public static class ArtikulTypeDicExt
	{
		// Token: 0x06005D88 RID: 23944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D88")]
		[Address(RVA = "0x1D91", Offset = "0x1D91", VA = "0x1D91")]
		public static string GetTitle(this ArtikulTypeDic dic)
		{
		/* --- GHIDRA: GetTitle ---
		void Core_Extensions_Dict_ArtikulTypeDicExt__GetTitle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int param2_00;
		  uint uVar6;
		  undefined8 local_50;
		  uint local_48;
		  undefined8 local_40;
		  uint local_38;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a1a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtifactComparerPossibleArtifactView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtifactComparerPossibleArtifactView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ArtifactComparerPossibleArtifactView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactData__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerPossibleArtifactView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerPossibleArtifactView__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ArtifactComparerPossibleArtifactView__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Cache_ObjectPool_ArtifactComparerPossibleArtifactView__Get__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Cache_ObjectPool_ArtifactComparerPossibleArtifactView__Release__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView_ViewOnClickEvent__)
		    ;
		    DAT_ram_00a58a1a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,*(undefined4 *)(param1 + 0x20),
		             Method_System_Collections_Generic_List_ArtifactComparerPossibleArtifactView__GetEnumerator__
		            );
		  local_8 = local_28;
		  local_30 = 0;
		  puStack_2c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ArtifactComparerPossibleArtifactView__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f5e6ca;
		    }
		    if (iVar1 == 0) goto code_r0x80f5e720;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18,*(undefined4 *)(param1 + 0x1c)
		               ,local_8._4_4_,
		               Method_Utils_Cache_ObjectPool_ArtifactComparerPossibleArtifactView__Release__);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar5 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5e6ca:
		  iVar5 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f5e720:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = *(int *)(param1 + 0x20);
		      iVar1 = *(int *)(iVar5 + 0xc);
		      *(undefined4 *)(iVar5 + 0xc) = 0;
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar5 + 8),0,iVar1,0);
		      }
		      if (*(int *)(param1 + 0x2c) == 0) {
		        return;
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_30,*(int *)(param1 + 0x2c),
		                 Method_System_Collections_Generic_List_ArtifactData__GetEnumerator__);
		      local_18 = local_28;
		      local_20 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_20;
		code_r0x80f5e7e7:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                           Method_System_Collections_Generic_List_Enumerator_ArtifactData__MoveNext__
		                          );
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5eaf4;
		        }
		        iVar5 = local_30;
		        if (iVar1 == 0) goto code_r0x80f5eb3d;
		        DAT_ram_009d3e38 = 0;
		        uVar2 = local_18._4_4_;
		        iVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x200,
		                           *(undefined4 *)(param1 + 0x1c),
		                           Method_Utils_Cache_ObjectPool_ArtifactComparerPossibleArtifactView__Get__
		                          );
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5eaf4;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar1,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f5eaba:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5eaf4;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar4,1,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f5eaba;
		        iVar5 = **(int **)(iVar1 + 0x14);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(iVar5 + 0x138),*(int **)(iVar1 + 0x14),uVar2,
		                   *(undefined4 *)(iVar5 + 0x13c));
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5eaf4;
		        }
		        iVar5 = *(int *)(iVar1 + 0x14);
		        *(undefined4 *)(iVar5 + 0x24) = 1;
		        local_50 = *(undefined8 *)(iVar5 + 0x50);
		        local_48 = *(uint *)(iVar5 + 0x58) | 1;
		        DAT_ram_009d3e38 = 0;
		        local_40 = local_50;
		        local_38 = local_48;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x206,iVar5,&local_50,0);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5eaf4;
		        }
		        uVar4 = *(undefined4 *)(iVar1 + 0x14);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_ArtifactView__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f5ead8:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5eaf4;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		                   Method_Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView_ViewOnClickEvent__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f5ead8;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x207,uVar4,uVar2,0);
		        iVar5 = Method_System_Collections_Generic_List_ArtifactComparerPossibleArtifactView__Add__;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f5ead8;
		        param2_00 = *(int *)(param1 + 0x20);
		        *(int *)(param2_00 + 0x10) = *(int *)(param2_00 + 0x10) + 1;
		        uVar6 = *(uint *)(param2_00 + 0xc);
		        if (uVar6 < *(uint *)(*(int *)(param2_00 + 8) + 0xc)) {
		          *(uint *)(param2_00 + 0xc) = uVar6 + 1;
		          *(int *)(*(int *)(param2_00 + 8) + uVar6 * 4 + 0x10) = iVar1;
		          goto code_r0x80f5e7e7;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_00,iVar1,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar5 != 1);
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5eaf4:
		      iVar5 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar5 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar5 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar5;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x80f5eb3d:
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x208,&local_30);
		      goto joined_r0x80f5eb8e;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x205,&local_30);
		joined_r0x80f5eb8e:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
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

			return null;
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D89")]
		[Address(RVA = "0xA9F4", Offset = "0xA9F4", VA = "0xA9F4")]
		public static string GetDismantleRestrictionsTitle(this ArtikulTypeDic dic)
		{
		/* --- GHIDRA: GetDismantleRestrictionsTitle ---
		undefined4
		Core_Extensions_Dict_ArtikulTypeDicExt__GetDismantleRestrictionsTitle(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x24);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (*(int *)(param1_00 + 0xc) < 1) {
		    uVar2 = 0;
		  }
		  else {
		    while (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                             (param1_00,param2_00,
		                              Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                             ), *(int *)(iVar1 + 0xc) != 0x6b) {
		      param2_00 = param2_00 + 1;
		      if (*(int *)(param1_00 + 0xc) <= param2_00) {
		        return 0;
		      }
		    }
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}
	}
}
