using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Net
{
	// Token: 0x02000E8A RID: 3722
	[Token(Token = "0x2000E8A")]
	public class PacketParser : IPacketParser
	{
		// Token: 0x14000222 RID: 546
		// (add) Token: 0x06005A88 RID: 23176 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005A89 RID: 23177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000222")]
		public event Action<PacketParser.Packet> CompleteEvent
		{
			[Token(Token = "0x6005A88")]
			[Address(RVA = "0xA778", Offset = "0xA778", VA = "0xA778", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005A89")]
			[Address(RVA = "0xA779", Offset = "0xA779", VA = "0xA779", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A8A")]
		[Address(RVA = "0xA77A", Offset = "0xA77A", VA = "0xA77A", Slot = "6")]
		public byte[] Serialize(SrvCommand command)
		{
		/* --- GHIDRA: Serialize ---
		/* WARNING: Removing unreachable block (ram,0x81ca9e5b) */
		
		int Core_Net_PacketParser__Serialize(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  longlong lVar6;
		  longlong lVar7;
		  undefined8 uVar8;
		  int iVar9;
		  int iVar10;
		  uint uVar11;
		  undefined1 auStack_10 [4];
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a6058c == '\0') {
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PacketParser_Packet__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PacketParser_Packet___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_PacketParser_Packet__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_MemoryStream_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_PacketParser_Packet_TypeInfo);
		    DAT_ram_00a6058c = '\x01';
		  }
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_PacketParser_Packet__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_PacketParser_Packet___ctor__);
		  piVar2 = (int *)unnamed_function_1417(System_IO_MemoryStream_TypeInfo);
		  System_IO_IOException___ctor(piVar2,param2,0,0);
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = piVar2;
		code_r0x81ca9d4a:
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    lVar6 = unnamed_function_184054
		                      (*(undefined4 *)(*local_4 + 0x120),local_4,*(undefined4 *)(*local_4 + 0x124));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    DAT_ram_009d3e38 = 0;
		    lVar7 = unnamed_function_184054
		                      (*(undefined4 *)(*local_4 + 0x118),local_4,*(undefined4 *)(*local_4 + 0x11c));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    if (lVar7 <= lVar6) goto code_r0x81caa68b;
		    iVar10 = *(int *)(param1 + 0xc);
		    if (iVar10 != 0) break;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Core_Net_PacketParser_Packet_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(undefined4 *)(param1 + 0x10) = 0;
		    *(undefined4 *)(param1 + 0xc) = uVar3;
		code_r0x81caa5cd:
		    DAT_ram_009d3e38 = 0;
		    uVar11 = import::env::invoke_iii
		                       (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4))
		    ;
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 8) = *(uint *)(*(int *)(param1 + 0xc) + 8) | uVar11;
		    *(undefined4 *)(param1 + 0x10) = 1;
		  }
		  iVar4 = *(int *)(param1 + 0x10);
		  if (iVar4 == 0) goto code_r0x81caa5cd;
		  if (iVar4 == 1) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 8) = *(uint *)(*(int *)(param1 + 0xc) + 8) | iVar4 << 8;
		    *(undefined4 *)(param1 + 0x10) = 2;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 2) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 8) = *(uint *)(*(int *)(param1 + 0xc) + 8) | iVar4 << 0x10;
		    *(undefined4 *)(param1 + 0x10) = 3;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 3) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 8) = *(uint *)(*(int *)(param1 + 0xc) + 8) | iVar4 << 0x18;
		    *(undefined4 *)(param1 + 0x10) = 4;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 4) {
		    DAT_ram_009d3e38 = 0;
		    uVar11 = import::env::invoke_iii
		                       (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4))
		    ;
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 0xc) = *(uint *)(*(int *)(param1 + 0xc) + 0xc) | uVar11;
		    *(undefined4 *)(param1 + 0x10) = 5;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 5) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 0xc) = *(uint *)(*(int *)(param1 + 0xc) + 0xc) | iVar4 << 8;
		    *(undefined4 *)(param1 + 0x10) = 6;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 6) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 0xc) =
		         *(uint *)(*(int *)(param1 + 0xc) + 0xc) | iVar4 << 0x10;
		    *(undefined4 *)(param1 + 0x10) = 7;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 != 7) {
		    if (iVar4 == 8) {
		      iVar9 = *(int *)(iVar10 + 0x14);
		      iVar4 = *(int *)(iVar10 + 0xc);
		      DAT_ram_009d3e38 = 0;
		      lVar6 = unnamed_function_184054
		                        (*(undefined4 *)(*local_4 + 0x118),local_4,*(undefined4 *)(*local_4 + 0x11c)
		                        );
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81caa642;
		      }
		      DAT_ram_009d3e38 = 0;
		      lVar7 = unnamed_function_184054
		                        (*(undefined4 *)(*local_4 + 0x120),local_4,*(undefined4 *)(*local_4 + 0x124)
		                        );
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81caa4bf:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81caa642;
		      }
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Math_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81caa4bf;
		      }
		      DAT_ram_009d3e38 = 0;
		      lVar6 = lVar6 - lVar7;
		      uVar8 = unnamed_function_184066
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0xde,lVar6,0,0);
		      iVar10 = DAT_ram_009d3e38;
		      in_register_20000014 = (undefined4)((ulonglong)lVar6 >> 0x20);
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81caa642;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = iVar4 - iVar9;
		      if ((int)uVar8 <= iVar4) {
		        iVar4 = (int)uVar8;
		      }
		      import::env::invoke_iiiiii
		                (*(undefined4 *)(*local_4 + 0x1d0),local_4,
		                 *(undefined4 *)(*(int *)(param1 + 0xc) + 0x10),
		                 *(undefined4 *)(*(int *)(param1 + 0xc) + 0x14),iVar4,
		                 *(undefined4 *)(*local_4 + 0x1d4));
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81caa642;
		      }
		      iVar10 = *(int *)(param1 + 0xc);
		      iVar4 = *(int *)(iVar10 + 0x14) + iVar4;
		      *(int *)(iVar10 + 0x14) = iVar4;
		      if (*(int *)(iVar10 + 0xc) - iVar4 < 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x22,param1,iVar10,
		                           auStack_10);
		        iVar4 = DAT_ram_009d3e38;
		        iVar10 = Method_System_Collections_Generic_List_PacketParser_Packet__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81caa642;
		        }
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar11 = *(uint *)(iVar1 + 0xc);
		        if (uVar11 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		          *(uint *)(iVar1 + 0xc) = uVar11 + 1;
		          *(undefined4 *)(*(int *)(iVar1 + 8) + uVar11 * 4 + 0x10) = uVar3;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar3,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81caa642;
		          }
		        }
		      }
		      else {
		        *(undefined4 *)(param1 + 0x10) = 8;
		      }
		    }
		    goto code_r0x81ca9d4a;
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar4 = import::env::invoke_iii
		                    (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81caa642;
		  }
		  iVar9 = *(int *)(param1 + 0xc);
		  uVar11 = *(uint *)(iVar9 + 0xc) | iVar4 << 0x18;
		  *(uint *)(iVar9 + 0xc) = uVar11;
		  *(undefined4 *)(param1 + 0x10) = 8;
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::invoke_iii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,byte___TypeInfo,uVar11)
		  ;
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81caa642;
		  }
		  *(undefined4 *)(iVar9 + 0x10) = uVar3;
		  if (*(int *)(*(int *)(param1 + 0xc) + 0xc) != 0) goto code_r0x81ca9d4a;
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::invoke_iiii
		                    (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x22,param1,
		                     *(int *)(param1 + 0xc),auStack_10);
		  iVar4 = DAT_ram_009d3e38;
		  iVar10 = Method_System_Collections_Generic_List_PacketParser_Packet__Add__;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81caa642;
		  }
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar11 = *(uint *)(iVar1 + 0xc);
		  if (uVar11 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar11 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar11 * 4 + 0x10) = uVar3;
		    goto code_r0x81ca9d4a;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar3,
		             *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 != 1) goto code_r0x81ca9d4a;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81caa642:
		  iVar10 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar4) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_c = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x81caa68b:
		      DAT_ram_009d3e38 = 0;
		      piVar2 = *local_8;
		      if (piVar2 != (int *)0x0) {
		        uVar11 = 0;
		        iVar10 = *piVar2;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		              puVar5 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x81caa706;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar2,System_IDisposable_TypeInfo,0);
		code_r0x81caa706:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar2,CONCAT44(in_register_20000014,puVar5[1]));
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return iVar1;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x23,&local_c);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar3);
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

		/* --- GHIDRA: Serialize ---
		/* WARNING: Removing unreachable block (ram,0x81ca9e5b) */
		
		int Core_Net_PacketParser__Serialize(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  longlong lVar6;
		  longlong lVar7;
		  undefined8 uVar8;
		  int iVar9;
		  int iVar10;
		  uint uVar11;
		  undefined1 auStack_10 [4];
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a6058c == '\0') {
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PacketParser_Packet__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PacketParser_Packet___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_PacketParser_Packet__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_MemoryStream_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_PacketParser_Packet_TypeInfo);
		    DAT_ram_00a6058c = '\x01';
		  }
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_PacketParser_Packet__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_PacketParser_Packet___ctor__);
		  piVar2 = (int *)unnamed_function_1417(System_IO_MemoryStream_TypeInfo);
		  System_IO_IOException___ctor(piVar2,param2,0,0);
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = piVar2;
		code_r0x81ca9d4a:
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    lVar6 = unnamed_function_184054
		                      (*(undefined4 *)(*local_4 + 0x120),local_4,*(undefined4 *)(*local_4 + 0x124));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    DAT_ram_009d3e38 = 0;
		    lVar7 = unnamed_function_184054
		                      (*(undefined4 *)(*local_4 + 0x118),local_4,*(undefined4 *)(*local_4 + 0x11c));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    if (lVar7 <= lVar6) goto code_r0x81caa68b;
		    iVar10 = *(int *)(param1 + 0xc);
		    if (iVar10 != 0) break;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Core_Net_PacketParser_Packet_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(undefined4 *)(param1 + 0x10) = 0;
		    *(undefined4 *)(param1 + 0xc) = uVar3;
		code_r0x81caa5cd:
		    DAT_ram_009d3e38 = 0;
		    uVar11 = import::env::invoke_iii
		                       (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4))
		    ;
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 8) = *(uint *)(*(int *)(param1 + 0xc) + 8) | uVar11;
		    *(undefined4 *)(param1 + 0x10) = 1;
		  }
		  iVar4 = *(int *)(param1 + 0x10);
		  if (iVar4 == 0) goto code_r0x81caa5cd;
		  if (iVar4 == 1) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 8) = *(uint *)(*(int *)(param1 + 0xc) + 8) | iVar4 << 8;
		    *(undefined4 *)(param1 + 0x10) = 2;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 2) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 8) = *(uint *)(*(int *)(param1 + 0xc) + 8) | iVar4 << 0x10;
		    *(undefined4 *)(param1 + 0x10) = 3;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 3) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 8) = *(uint *)(*(int *)(param1 + 0xc) + 8) | iVar4 << 0x18;
		    *(undefined4 *)(param1 + 0x10) = 4;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 4) {
		    DAT_ram_009d3e38 = 0;
		    uVar11 = import::env::invoke_iii
		                       (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4))
		    ;
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 0xc) = *(uint *)(*(int *)(param1 + 0xc) + 0xc) | uVar11;
		    *(undefined4 *)(param1 + 0x10) = 5;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 5) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 0xc) = *(uint *)(*(int *)(param1 + 0xc) + 0xc) | iVar4 << 8;
		    *(undefined4 *)(param1 + 0x10) = 6;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 == 6) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81caa642;
		    }
		    *(uint *)(*(int *)(param1 + 0xc) + 0xc) =
		         *(uint *)(*(int *)(param1 + 0xc) + 0xc) | iVar4 << 0x10;
		    *(undefined4 *)(param1 + 0x10) = 7;
		    goto code_r0x81ca9d4a;
		  }
		  if (iVar4 != 7) {
		    if (iVar4 == 8) {
		      iVar9 = *(int *)(iVar10 + 0x14);
		      iVar4 = *(int *)(iVar10 + 0xc);
		      DAT_ram_009d3e38 = 0;
		      lVar6 = unnamed_function_184054
		                        (*(undefined4 *)(*local_4 + 0x118),local_4,*(undefined4 *)(*local_4 + 0x11c)
		                        );
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81caa642;
		      }
		      DAT_ram_009d3e38 = 0;
		      lVar7 = unnamed_function_184054
		                        (*(undefined4 *)(*local_4 + 0x120),local_4,*(undefined4 *)(*local_4 + 0x124)
		                        );
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81caa4bf:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81caa642;
		      }
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Math_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81caa4bf;
		      }
		      DAT_ram_009d3e38 = 0;
		      lVar6 = lVar6 - lVar7;
		      uVar8 = unnamed_function_184066
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0xde,lVar6,0,0);
		      iVar10 = DAT_ram_009d3e38;
		      in_register_20000014 = (undefined4)((ulonglong)lVar6 >> 0x20);
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81caa642;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = iVar4 - iVar9;
		      if ((int)uVar8 <= iVar4) {
		        iVar4 = (int)uVar8;
		      }
		      import::env::invoke_iiiiii
		                (*(undefined4 *)(*local_4 + 0x1d0),local_4,
		                 *(undefined4 *)(*(int *)(param1 + 0xc) + 0x10),
		                 *(undefined4 *)(*(int *)(param1 + 0xc) + 0x14),iVar4,
		                 *(undefined4 *)(*local_4 + 0x1d4));
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81caa642;
		      }
		      iVar10 = *(int *)(param1 + 0xc);
		      iVar4 = *(int *)(iVar10 + 0x14) + iVar4;
		      *(int *)(iVar10 + 0x14) = iVar4;
		      if (*(int *)(iVar10 + 0xc) - iVar4 < 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x22,param1,iVar10,
		                           auStack_10);
		        iVar4 = DAT_ram_009d3e38;
		        iVar10 = Method_System_Collections_Generic_List_PacketParser_Packet__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81caa642;
		        }
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar11 = *(uint *)(iVar1 + 0xc);
		        if (uVar11 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		          *(uint *)(iVar1 + 0xc) = uVar11 + 1;
		          *(undefined4 *)(*(int *)(iVar1 + 8) + uVar11 * 4 + 0x10) = uVar3;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar3,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81caa642;
		          }
		        }
		      }
		      else {
		        *(undefined4 *)(param1 + 0x10) = 8;
		      }
		    }
		    goto code_r0x81ca9d4a;
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar4 = import::env::invoke_iii
		                    (*(undefined4 *)(*local_4 + 0x1e0),local_4,*(undefined4 *)(*local_4 + 0x1e4));
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81caa642;
		  }
		  iVar9 = *(int *)(param1 + 0xc);
		  uVar11 = *(uint *)(iVar9 + 0xc) | iVar4 << 0x18;
		  *(uint *)(iVar9 + 0xc) = uVar11;
		  *(undefined4 *)(param1 + 0x10) = 8;
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::invoke_iii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,byte___TypeInfo,uVar11)
		  ;
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81caa642;
		  }
		  *(undefined4 *)(iVar9 + 0x10) = uVar3;
		  if (*(int *)(*(int *)(param1 + 0xc) + 0xc) != 0) goto code_r0x81ca9d4a;
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::invoke_iiii
		                    (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x22,param1,
		                     *(int *)(param1 + 0xc),auStack_10);
		  iVar4 = DAT_ram_009d3e38;
		  iVar10 = Method_System_Collections_Generic_List_PacketParser_Packet__Add__;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x81caa642;
		  }
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar11 = *(uint *)(iVar1 + 0xc);
		  if (uVar11 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar11 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar11 * 4 + 0x10) = uVar3;
		    goto code_r0x81ca9d4a;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar3,
		             *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 != 1) goto code_r0x81ca9d4a;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81caa642:
		  iVar10 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar4) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_c = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x81caa68b:
		      DAT_ram_009d3e38 = 0;
		      piVar2 = *local_8;
		      if (piVar2 != (int *)0x0) {
		        uVar11 = 0;
		        iVar10 = *piVar2;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		              puVar5 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x81caa706;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar2,System_IDisposable_TypeInfo,0);
		code_r0x81caa706:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar2,CONCAT44(in_register_20000014,puVar5[1]));
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return iVar1;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x23,&local_c);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar3);
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

		// Token: 0x06005A8B RID: 23179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A8B")]
		[Address(RVA = "0xA77B", Offset = "0xA77B", VA = "0xA77B")]
		public byte[] Serialize(string sessionId, short serviceId, uint commandIndex, short commandId, byte[] payload)
		{
			return null;
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A8C")]
		[Address(RVA = "0x362D", Offset = "0x362D", VA = "0x362D")]
		private PacketParser.Packet CompletePacket(PacketParser.Packet packet)
		{
			return null;
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0xA77C", Offset = "0xA77C", VA = "0xA77C", Slot = "7")]
		public IList<PacketParser.Packet> Deserialize(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8E")]
		[Address(RVA = "0xA77D", Offset = "0xA77D", VA = "0xA77D", Slot = "8")]
		public void Reset()
		{
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0xA77E", Offset = "0xA77E", VA = "0xA77E")]
		public PacketParser()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Net_PacketParser___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 local_14;
		  undefined2 local_e;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6058d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_14243);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5514);
		    Mono_Security_ASN1__get_Item(&StringLiteral_215);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28654);
		    DAT_ram_00a6058d = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 8);
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  local_8 = *(undefined4 *)(param1 + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_5514,uVar1,uVar2,0);
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  local_c = *(undefined4 *)(param1 + 0x14);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_c);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28654,uVar4,uVar2,0);
		  local_e = *(undefined2 *)(param1 + 0x18);
		  uVar4 = func_ii_1081(DAT_ram_00a6694c,&local_e);
		  uVar4 = func_ii_4419(StringLiteral_14243,uVar4,0);
		  local_14 = *(undefined4 *)(param1 + 0x1c);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_14);
		  uVar3 = func_ii_4419(StringLiteral_215,uVar3,0);
		  uVar1 = System_Int32__ToString(uVar1,uVar2,uVar4,uVar3,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x04003164 RID: 12644
		[Token(Token = "0x4003164")]
		[FieldOffset(Offset = "0xC")]
		private PacketParser.Packet _currentPacket;

		// Token: 0x04003165 RID: 12645
		[Token(Token = "0x4003165")]
		[FieldOffset(Offset = "0x10")]
		private PacketParser.ReaderState _readerState;

		// Token: 0x02000E8B RID: 3723
		[Token(Token = "0x2000E8B")]
		private enum ReaderState
		{
			// Token: 0x04003167 RID: 12647
			[Token(Token = "0x4003167")]
			PACKETREADER_STATE_CMDNUM_B1,
			// Token: 0x04003168 RID: 12648
			[Token(Token = "0x4003168")]
			PACKETREADER_STATE_CMDNUM_B2,
			// Token: 0x04003169 RID: 12649
			[Token(Token = "0x4003169")]
			PACKETREADER_STATE_CMDNUM_B3,
			// Token: 0x0400316A RID: 12650
			[Token(Token = "0x400316A")]
			PACKETREADER_STATE_CMDNUM_B4,
			// Token: 0x0400316B RID: 12651
			[Token(Token = "0x400316B")]
			PACKETREADER_STATE_DATALEN_B1,
			// Token: 0x0400316C RID: 12652
			[Token(Token = "0x400316C")]
			PACKETREADER_STATE_DATALEN_B2,
			// Token: 0x0400316D RID: 12653
			[Token(Token = "0x400316D")]
			PACKETREADER_STATE_DATALEN_B3,
			// Token: 0x0400316E RID: 12654
			[Token(Token = "0x400316E")]
			PACKETREADER_STATE_DATALEN_B4,
			// Token: 0x0400316F RID: 12655
			[Token(Token = "0x400316F")]
			PACKETREADER_STATE_READING_ANSWER
		}

		// Token: 0x02000E8C RID: 3724
		[Token(Token = "0x2000E8C")]
		public class Packet
		{
			// Token: 0x06005A90 RID: 23184 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005A90")]
			[Address(RVA = "0xA77F", Offset = "0xA77F", VA = "0xA77F", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06005A91 RID: 23185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A91")]
			[Address(RVA = "0xA780", Offset = "0xA780", VA = "0xA780")]
			public Packet()
			{
			}

			// Token: 0x04003170 RID: 12656
			[Token(Token = "0x4003170")]
			[FieldOffset(Offset = "0x8")]
			public uint CmdIndex;

			// Token: 0x04003171 RID: 12657
			[Token(Token = "0x4003171")]
			[FieldOffset(Offset = "0xC")]
			public uint PacketContentLen;

			// Token: 0x04003172 RID: 12658
			[Token(Token = "0x4003172")]
			[FieldOffset(Offset = "0x10")]
			public byte[] AnswerContent;

			// Token: 0x04003173 RID: 12659
			[Token(Token = "0x4003173")]
			[FieldOffset(Offset = "0x14")]
			public int ReceivedPacketContentByteCount;

			// Token: 0x04003174 RID: 12660
			[Token(Token = "0x4003174")]
			[FieldOffset(Offset = "0x18")]
			public short ServiceId;

			// Token: 0x04003175 RID: 12661
			[Token(Token = "0x4003175")]
			[FieldOffset(Offset = "0x1C")]
			public uint EventId;

			// Token: 0x04003176 RID: 12662
			[Token(Token = "0x4003176")]
			[FieldOffset(Offset = "0x20")]
			public int RawEventId;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_CompleteEvent ---
		void Core_Net_PacketParser__add_CompleteEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a60589 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PacketParser_Packet__TypeInfo);
		    DAT_ram_00a60589 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_PacketParser_Packet__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_PacketParser_Packet__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_CompleteEvent ---
		undefined4
		Core_Net_PacketParser__remove_CompleteEvent(undefined4 param1,int param2,undefined4 param3)
		
		{
		  short sVar1;
		  short sVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int param6;
		  
		  sVar1 = *(short *)(param2 + 0x12);
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  sVar2 = *(short *)(param2 + 0x10);
		  param2_00 = *(undefined4 *)(param2 + 8);
		  param6 = *(int *)(param2 + 0x3c);
		  if (param6 == 0) {
		    if (*(int *)(param2 + 0x30) == 0) {
		      param6 = 0;
		    }
		    else {
		      param6 = Google_Protobuf_MessageExtensions__MergeDelimitedFrom(*(int *)(param2 + 0x30),0);
		      *(int *)(param2 + 0x3c) = param6;
		    }
		  }
		  uVar3 = Core_Net_PacketParser__Serialize
		                    (param2,param2_00,(int)sVar2,uVar3,(int)sVar1,param6,param2);
		  return uVar3;
		}
		*/

}
