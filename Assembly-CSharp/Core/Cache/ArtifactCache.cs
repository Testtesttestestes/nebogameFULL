using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Cache
{
	// Token: 0x020010FB RID: 4347
	[Token(Token = "0x20010FB")]
	public class ArtifactCache : IDisposable
	{
		// Token: 0x0600658A RID: 25994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600658A")]
		[Address(RVA = "0xB12F", Offset = "0xB12F", VA = "0xB12F")]
		public ArtifactCache(UserData loggedUser, IDictProvider provider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Cache_ArtifactCache___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60852 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__Clear__);
		    DAT_ram_00a60852 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x0600658B RID: 25995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600658B")]
		[Address(RVA = "0x216A", Offset = "0x216A", VA = "0x216A")]
		public ArtifactData GetArtifact(ArtifactInfo artifactInfo, UserData ownerUser)
		{
		/* --- GHIDRA: GetArtifact ---
		void Core_Cache_ArtifactCache__GetArtifact(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x7c) != param2) {
		    *(int *)(param1 + 0x7c) = param2;
		    iVar1 = *(int *)(param1 + 0x4c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600658C")]
		[Address(RVA = "0xB130", Offset = "0xB130", VA = "0xB130", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Cache_ArtifactCache__Dispose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int *piVar6;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a60853 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_ulong__UserData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_IDisposable__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_IDisposable__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_IDisposable__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_IDisposable__Clear__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_IDisposable__GetEnumerator__);
		    DAT_ram_00a60853 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  func_ii_16538(&local_18,*(undefined4 *)(param1 + 0x20),
		                Method_System_Collections_Generic_LinkedList_IDisposable__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                       Method_System_Collections_Generic_LinkedList_Enumerator_IDisposable__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cee463;
		    }
		    if (iVar2 == 0) goto code_r0x81cee4b9;
		    piVar4 = local_10._4_4_;
		    iVar5 = *local_10._4_4_;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_IDisposable_TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(iVar5 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x81cee406;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                        System_IDisposable_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81cee406:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar3,piVar4,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cee463:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81cee4b9:
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		                (*(undefined4 *)(param1 + 0x20),
		                 Method_System_Collections_Generic_LinkedList_IDisposable__Clear__);
		      *(undefined8 *)(param1 + 0x24) = 0;
		      Core_Cache_AbstractCache_ulong__object___Complete
		                (param1,Method_Core_Cache_AbstractCache_ulong__UserData__Dispose__);
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 9,&local_20);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
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

		}

		// Token: 0x04003642 RID: 13890
		[Token(Token = "0x4003642")]
		[FieldOffset(Offset = "0x8")]
		private readonly UserData _loggedUser;

		// Token: 0x04003643 RID: 13891
		[Token(Token = "0x4003643")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04003644 RID: 13892
		[Token(Token = "0x4003644")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<ulong, ArtifactData> _allArtifacts;
	}
}
