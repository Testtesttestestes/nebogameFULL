using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Il2CppDummyDll;
using Protocol.System;

namespace ServicesNamespace
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	public class SystemService : AbstractService
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x170000AF")]
		public override short ServiceId
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x5A85", Offset = "0x5A85", VA = "0x5A85", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000A7 RID: 167
		// (add) Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A7")]
		public event Action<DisconnectCode> ConnectionClosedEvent
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x5A86", Offset = "0x5A86", VA = "0x5A86")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x5A87", Offset = "0x5A87", VA = "0x5A87")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A8 RID: 168
		// (add) Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600068A RID: 1674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A8")]
		public event Action ServerReadyToStopEvent
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x5A88", Offset = "0x5A88", VA = "0x5A88")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x5A89", Offset = "0x5A89", VA = "0x5A89")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x5A8A", Offset = "0x5A8A", VA = "0x5A8A", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x5A8B", Offset = "0x5A8B", VA = "0x5A8B")]
		public void EmulateDisconect(DisconnectCode code)
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x5A8C", Offset = "0x5A8C", VA = "0x5A8C")]
		public SystemService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_SystemService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DisconnectCode__TypeInfo);
		    DAT_ram_00a5b7b0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_DisconnectCode__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_DisconnectCode__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: add_ConnectionClosedEvent ---
		void ServicesNamespace_SystemService__add_ConnectionClosedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DisconnectCode__TypeInfo);
		    DAT_ram_00a5b7b1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_DisconnectCode__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_DisconnectCode__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ConnectionClosedEvent ---
		void ServicesNamespace_SystemService__remove_ConnectionClosedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5b7b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b7b2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ServerReadyToStopEvent ---
		void ServicesNamespace_SystemService__add_ServerReadyToStopEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5b7b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b7b3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ServerReadyToStopEvent ---
		void ServicesNamespace_SystemService__remove_ServerReadyToStopEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int *piVar3;
		  int *param2_00;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  int iVar9;
		  int iVar10;
		  int local_18;
		  int **local_14;
		  int local_10;
		  int **local_c;
		  int *local_8;
		  int *local_4;
		  
		  iVar9 = 0;
		  bVar1 = false;
		  uVar4 = 0;
		  iVar6 = 0;
		  if (DAT_ram_00a5b7b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_SystemEvents___);
		    Mono_Security_ASN1__get_Item(&System_IO_BinaryReader_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_MemoryStream_TypeInfo);
		    DAT_ram_00a5b7b4 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = (int *)0x0;
		  iVar10 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar10,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_SystemEvents___);
		  if (iVar10 != 1) {
		    if (iVar10 != 2) {
		      return;
		    }
		    iVar9 = *(int *)(param1 + 0x18);
		    if (iVar9 == 0) {
		      return;
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		              (*(undefined4 *)(iVar9 + 0x20),*(undefined4 *)(iVar9 + 0x14));
		    return;
		  }
		  if (*(int *)(param2 + 0x24) == 0) goto code_r0x8137d1a3;
		  uVar8 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0x10);
		  piVar3 = (int *)unnamed_function_1417(System_IO_MemoryStream_TypeInfo);
		  Pathfinding_Ionic_Zlib_ZlibStream___ctor(piVar3,uVar8,0);
		  DAT_ram_009d3e38 = 0;
		  local_10 = 0;
		  local_c = &local_4;
		  local_4 = piVar3;
		  param2_00 = (int *)import::env::invoke_ii
		                               (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                System_IO_BinaryReader_TypeInfo);
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x14b,param2_00,piVar3,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8137ce7c;
		    local_18 = 0;
		    local_14 = &local_8;
		    DAT_ram_009d3e38 = 0;
		    local_8 = param2_00;
		    uVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*param2_00 + 0x138),param2_00,
		                       *(undefined4 *)(*param2_00 + 0x13c));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar9 = global_1;
		      iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar10) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar8);
		        iVar9 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar9;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        bVar1 = true;
		        uVar4 = 0;
		        if (iVar10 != 1) goto code_r0x8137cee8;
		        uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar9 = global_1;
		      }
		      uVar4 = 0;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x151,&local_18);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) goto code_r0x8137d192;
		      goto code_r0x8137d056;
		    }
		    iVar6 = 4;
		code_r0x8137cee8:
		    piVar3 = local_8;
		    if (local_8 != (int *)0x0) {
		      uVar2 = 0;
		      iVar10 = *local_8;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		            puVar5 = (undefined4 *)
		                     (iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x8137cf89;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_IDisposable_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x8137cf89:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(*puVar5,piVar3,puVar5[1]);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x8137cfc5;
		      }
		code_r0x8137d002:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar9 = global_1;
		      goto code_r0x8137d056;
		    }
		code_r0x8137cfc5:
		    if (iVar9 != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar9);
		      if (DAT_ram_009d3e38 != 1) {
		        do {
		          halt_trap();
		        } while( true );
		      }
		      goto code_r0x8137d002;
		    }
		    iVar10 = 0;
		    if (bVar1) goto code_r0x8137d09d;
		code_r0x8137d0a2:
		    piVar3 = local_4;
		    DAT_ram_009d3e38 = 0;
		    if (local_4 != (int *)0x0) {
		      uVar2 = 0;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		            puVar7 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x8137d11a;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		      }
		      puVar7 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8137d11a:
		      (**(code **)((ulonglong)*puVar7 * 4))(piVar3,puVar7[1]);
		    }
		    if (iVar10 != 0) {
		      System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar6 != 0) {
		      if (iVar6 == 1) {
		        return;
		      }
		      if (iVar6 == 2) {
		        return;
		      }
		      if (iVar6 == 3) {
		        return;
		      }
		      if (iVar6 != 4) {
		        return;
		      }
		    }
		code_r0x8137d1a3:
		    iVar9 = *(int *)(param1 + 0x14);
		    if (iVar9 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))
		                (*(undefined4 *)(iVar9 + 0x20),uVar4,*(undefined4 *)(iVar9 + 0x14));
		    }
		    return;
		  }
		code_r0x8137ce7c:
		  DAT_ram_009d3e38 = 0;
		  uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar9 = global_1;
		code_r0x8137d056:
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar9) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar8);
		    iVar10 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_10 = iVar10;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x8137d09d:
		      iVar6 = 0;
		      goto code_r0x8137d0a2;
		    }
		    uVar8 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x152,&local_10);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
		    import::env::__resumeException(uVar8);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x8137d192:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
