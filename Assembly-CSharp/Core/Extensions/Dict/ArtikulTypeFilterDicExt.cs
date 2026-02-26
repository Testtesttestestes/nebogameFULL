using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F21 RID: 3873
	[Token(Token = "0x2000F21")]
	public static class ArtikulTypeFilterDicExt
	{
		// Token: 0x06005D8A RID: 23946 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D8A")]
		[Address(RVA = "0x1DE3", Offset = "0x1DE3", VA = "0x1DE3")]
		public static string GetTitle(this ArtikulTypeFilters dic)
		{
		/* --- GHIDRA: GetTitle ---
		void Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetTitle(int *param1,int *param2,int param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = *(int *)(param3 + 0x1c);
		  if (iVar6 == 0) {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    iVar6 = *(int *)(param3 + 0x1c);
		    if (iVar6 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      iVar6 = *(int *)(param3 + 0x1c);
		    }
		  }
		  iVar6 = *(int *)(iVar6 + 4);
		  if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		    iVar6 = func_ii_1079(iVar6);
		  }
		  if (param1 != (int *)0x0) {
		    iVar8 = *param1;
		    uVar1 = (uint)*(byte *)(iVar8 + 0xb8);
		    if ((*(byte *)(iVar6 + 0xb8) <= uVar1) &&
		       (*(int *)(*(int *)(iVar8 + 100) + (uint)*(byte *)(iVar6 + 0xb8) * 4 + -4) == iVar6)) {
		      iVar6 = *(int *)(*(int *)(param3 + 0x1c) + 4);
		      if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		        iVar6 = func_ii_1079(iVar6);
		        iVar8 = *param1;
		        uVar1 = (uint)*(byte *)(iVar8 + 0xb8);
		      }
		      if ((*(byte *)(iVar6 + 0xb8) <= uVar1) &&
		         (*(int *)(*(int *)(iVar8 + 100) + (uint)*(byte *)(iVar6 + 0xb8) * 4 + -4) == iVar6)) {
		        func_ii_6335(param1,param2,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0xc));
		        return;
		      }
		      System_Activator__CreateInstance(param1,iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar6 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		  if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		    iVar6 = func_ii_1079(iVar6);
		  }
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar6 == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x820e93ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,iVar6,0);
		code_r0x820e93ae:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x820e9478;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x820e96f3:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820e96fb;
		    }
		code_r0x820e9478:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x820e96f3;
		    if (iVar6 == 0) {
		      iVar6 = 0;
		      goto code_r0x820e9744;
		    }
		    iVar6 = *(int *)(*(int *)(param3 + 0x1c) + 0x14);
		    if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6);
		      if (DAT_ram_009d3e38 != 1) goto code_r0x820e9507;
		code_r0x820e96df:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820e96fb;
		    }
		code_r0x820e9507:
		    iVar8 = *piVar5;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (iVar6 == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x820e958d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,iVar6,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x820e96df;
		code_r0x820e958d:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x820e96df;
		    iVar6 = *(int *)(*(int *)(param3 + 0x1c) + 0x20);
		    if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    iVar8 = *param1;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (iVar6 == *piVar5) {
		          puVar3 = (undefined4 *)(piVar5[1] * 8 + iVar8 + 0xd0);
		          goto code_r0x820e9697;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param1,iVar6,2);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x820e9697:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar3,param1,uVar4,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x820e96fb:
		  iVar6 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar8) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar6 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x820e9744:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x820e97bc;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x820e97bc:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar6 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_0000404c + 0x35,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
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
		*/

			return null;
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D8B")]
		[Address(RVA = "0xA9F5", Offset = "0xA9F5", VA = "0xA9F5")]
		public static string GetIconEnabled(this ArtikulTypeFilters dic)
		{
		/* --- GHIDRA: GetIconEnabled ---
		undefined4
		Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetIconEnabled(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x6c) {
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

		// Token: 0x06005D8C RID: 23948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D8C")]
		[Address(RVA = "0xA9F6", Offset = "0xA9F6", VA = "0xA9F6")]
		public static string GetIconDisabled(this ArtikulTypeFilters dic)
		{
		/* --- GHIDRA: GetIconDisabled ---
		undefined4
		Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetIconDisabled(int param1,undefined4 param2)
		
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
		                             ), *(int *)(iVar1 + 0xc) != 0x2f) {
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
