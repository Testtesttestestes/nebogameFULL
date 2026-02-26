using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Utils;

namespace Core.Rounting
{
	// Token: 0x02000E81 RID: 3713
	[Token(Token = "0x2000E81")]
	public class Path : IDisposable
	{
		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06005A59 RID: 23129 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005A5A RID: 23130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001269")]
		public Uri Uri
		{
			[Token(Token = "0x6005A59")]
			[Address(RVA = "0xA75A", Offset = "0xA75A", VA = "0xA75A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A5A")]
			[Address(RVA = "0xA75B", Offset = "0xA75B", VA = "0xA75B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5B")]
		[Address(RVA = "0xA75C", Offset = "0xA75C", VA = "0xA75C", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Rounting_Path__Dispose
		               (int param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  int *local_4;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a60578 == '\0') {
		    Mono_Security_ASN1__get_Item(&char___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_IPathNodeFactoryRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_IPathNodeFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AbstractPathNode__AddLast__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AbstractPathNode___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_AbstractPathNode__TypeInfo);
		    DAT_ram_00a60578 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_LinkedList_AbstractPathNode__TypeInfo);
		  *(undefined4 *)(param1 + 8) = uVar2;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(char___TypeInfo,1);
		  *(undefined2 *)(iVar3 + 0x10) = 0x2f;
		  *(int *)(param1 + 0xc) = iVar3;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  uVar2 = System_Net_NetRes__GetWebStatusString(param5,0);
		  iVar3 = System_String__Split(uVar2,*(undefined4 *)(param1 + 0xc),0xff,1,0);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      uVar2 = *(undefined4 *)(iVar3 + iVar5 * 4 + 0x10);
		      iVar7 = *param4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Rounting_IPathNodeFactoryRepository_TypeInfo == *piVar8) {
		            puVar4 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x81ca73bf;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(param4,Core_Rounting_IPathNodeFactoryRepository_TypeInfo,0);
		code_r0x81ca73bf:
		      iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(param4,uVar2,&local_4,puVar4[1]);
		      piVar8 = local_4;
		      if (iVar7 != 0) {
		        param1_00 = *(undefined4 *)(param1 + 8);
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (Core_Rounting_IPathNodeFactory_TypeInfo == *piVar6) {
		              puVar4 = (uint *)(piVar6[1] * 8 + iVar7 + 200);
		              goto code_r0x81ca7443;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,Core_Rounting_IPathNodeFactory_TypeInfo,1);
		code_r0x81ca7443:
		        iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,uVar2,param2,param3,puVar4[1]);
		        System_Collections_Generic_LinkedList_object___Remove
		                  (param1_00,*(undefined4 *)(iVar7 + 0xc),
		                   Method_System_Collections_Generic_LinkedList_AbstractPathNode__AddLast__);
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005A5C RID: 23132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5C")]
		[Address(RVA = "0xA75D", Offset = "0xA75D", VA = "0xA75D")]
		public Path(IGame game, OpTokenRepository tokenRepository, IPathNodeFactoryRepository repository, Uri uri)
		{
		/* --- GHIDRA: .ctor ---
		void DG_Tweening_Plugins_Core_PathCore_Path___ctor(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 200) = 0x3f8000003f800000;
		  *(undefined4 *)(param1 + 0x30) = 0xffffffff;
		  *(undefined8 *)(param1 + 0xd0) = 0x3f3333333f800000;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void DG_Tweening_Plugins_Core_PathCore_Path___ctor(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 200) = 0x3f8000003f800000;
		  *(undefined4 *)(param1 + 0x30) = 0xffffffff;
		  *(undefined8 *)(param1 + 0xd0) = 0x3f3333333f800000;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		uint Core_Rounting_Path___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a60579 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AbstractPathNode__GetEnumerator__);
		    DAT_ram_00a60579 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  func_ii_16538(&local_18,*(undefined4 *)(param1 + 8),
		                Method_System_Collections_Generic_LinkedList_AbstractPathNode__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                       Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81ca75c8:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return 1;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x19,&local_20);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(param1_00);
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
		    if (uVar2 == 0) break;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_10._4_4_ + 0xe0),local_10._4_4_,
		                       *(undefined4 *)(*local_10._4_4_ + 0xe4));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ca75c8;
		    }
		  } while (iVar3 != 0);
		  DAT_ram_009d3e38 = 0;
		  return uVar2 ^ 1;
		}
		*/

		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x6005A5D")]
		[Address(RVA = "0xA75E", Offset = "0xA75E", VA = "0xA75E")]
		public bool Check()
		{
		/* --- GHIDRA: Check ---
		void Core_Rounting_Path__Check(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6057a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_AbstractPathNode__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AbstractPathNode__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AbstractPathNode__get_First__);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_LocatorPayload_TypeInfo);
		    DAT_ram_00a6057a = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 8) + 0xc) == 0) {
		    uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_12320);
		    System_String__Concat(uVar1,uVar2,0);
		    uVar2 = unnamed_function_2232(&Method_Core_Rounting_Path_Run__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x14);
		  uVar1 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___ConfigurationManager__HandleConfigurationProvider_d__19_
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar2 = System_Uri__get_Query(*(undefined4 *)(param1 + 0x10),0);
		  param2_00 = unnamed_function_1417(Core_Rounting_LocatorPayload_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = uVar2;
		  *(undefined4 *)(param2_00 + 8) = uVar1;
		  Core_Rounting_AbstractPathNode___ctor(param1_00,param2_00,param2_00);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5E")]
		[Address(RVA = "0xA75F", Offset = "0xA75F", VA = "0xA75F")]
		public void Run()
		{
		/* --- GHIDRA: Run ---
		undefined4 Core_Rounting_Path__Run(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a6057b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AbstractPathNode__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6057b = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  func_ii_16538(&local_18,*(undefined4 *)(param1 + 8),
		                Method_System_Collections_Generic_LinkedList_AbstractPathNode__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                       Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ca7872;
		    }
		    if (iVar2 == 0) goto code_r0x81ca78c8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s___Scripting__UnityEngine__Contex_ram_0000360b + 0x1a,param1_00,local_10._4_4_,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81ca7872:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81ca78c8:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		      return uVar3;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x1b,&local_20);
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
		*/

		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A5F")]
		[Address(RVA = "0xA760", Offset = "0xA760", VA = "0xA760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400314F RID: 12623
		[Token(Token = "0x400314F")]
		[FieldOffset(Offset = "0x8")]
		private readonly LinkedList<AbstractPathNode> _nodes;

		// Token: 0x04003150 RID: 12624
		[Token(Token = "0x4003150")]
		[FieldOffset(Offset = "0xC")]
		private readonly char[] _pathDelimiter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Uri ---
		void Core_Rounting_Path__set_Uri(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a60577 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AbstractPathNode__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AbstractPathNode__GetEnumerator__);
		    DAT_ram_00a60577 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  func_ii_16538(&local_18,*(undefined4 *)(param1 + 8),
		                Method_System_Collections_Generic_LinkedList_AbstractPathNode__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                       Method_System_Collections_Generic_LinkedList_Enumerator_AbstractPathNode__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) break;
		    if (iVar2 == 0) goto code_r0x81ca71f3;
		    *(undefined8 *)(local_10._4_4_ + 0xc) = 0;
		    *(undefined4 *)(local_10._4_4_ + 0x14) = 0;
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81ca71f3:
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		                (*(undefined4 *)(param1 + 8),
		                 Method_System_Collections_Generic_LinkedList_AbstractPathNode__Clear__);
		      *(undefined4 *)(param1 + 0x10) = 0;
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Contex_ram_0000360b + 0x18,&local_20);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
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


		/* --- GHIDRA: get_minInputWaypoints ---
		void DG_Tweening_Plugins_Core_PathCore_Path__get_minInputWaypoints
		               (int param1,undefined4 param2,int param3,undefined4 param4,char *param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined8 *puVar2;
		  int iVar3;
		  uint uVar4;
		  int iVar5;
		  uint uVar6;
		  undefined8 uVar7;
		  uint param2_00;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar6 = 0;
		  uVar4 = 0;
		  if (DAT_ram_00a64028 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TweenCallback__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Color__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Color__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_Plugins_Core_PathCore_Path_Draw__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_TweenManager_TypeInfo);
		    DAT_ram_00a64028 = '\x01';
		  }
		  *(undefined8 *)(param1 + 200) = 0x3f8000003f800000;
		  *(undefined4 *)(param1 + 0x30) = 0xffffffff;
		  *(undefined8 *)(param1 + 0xd0) = 0x3f3333333f800000;
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  if (*param5 != '\0') {
		    System_Nullable_JsonPosition___get_HasValue
		              (&local_10,param5,Method_System_Nullable_Color__get_Value__);
		    param5 = (char *)(param1 + 200);
		    *(undefined8 *)(param1 + 0xd0) = local_8;
		    *(undefined8 *)param5 = local_10;
		  }
		  if (DAT_ram_00a6402d == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a6402d = '\x01';
		  }
		  param2_00 = *(uint *)(param3 + 0xc);
		  uVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,param2_00);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  if (0 < (int)param2_00) {
		    param5 = (char *)0x0;
		    if (3 < param2_00) {
		      do {
		        iVar3 = param3 + 0x10;
		        puVar2 = (undefined8 *)(iVar3 + (int)param5 * 0xc);
		        uVar7 = *puVar2;
		        iVar5 = *(int *)(param1 + 0xc) + (int)param5 * 0xc;
		        *(undefined4 *)(iVar5 + 0x18) = *(undefined4 *)(puVar2 + 1);
		        *(undefined8 *)(iVar5 + 0x10) = uVar7;
		        iVar5 = ((uint)param5 | 1) * 0xc;
		        puVar2 = (undefined8 *)(iVar3 + iVar5);
		        uVar7 = *puVar2;
		        iVar5 = *(int *)(param1 + 0xc) + iVar5;
		        *(undefined4 *)(iVar5 + 0x18) = *(undefined4 *)(puVar2 + 1);
		        *(undefined8 *)(iVar5 + 0x10) = uVar7;
		        iVar5 = ((uint)param5 | 2) * 0xc;
		        puVar2 = (undefined8 *)(iVar3 + iVar5);
		        uVar7 = *puVar2;
		        iVar5 = *(int *)(param1 + 0xc) + iVar5;
		        *(undefined4 *)(iVar5 + 0x18) = *(undefined4 *)(puVar2 + 1);
		        *(undefined8 *)(iVar5 + 0x10) = uVar7;
		        iVar5 = ((uint)param5 | 3) * 0xc;
		        puVar2 = (undefined8 *)(iVar3 + iVar5);
		        uVar7 = *puVar2;
		        iVar5 = *(int *)(param1 + 0xc) + iVar5;
		        *(undefined4 *)(iVar5 + 0x18) = *(undefined4 *)(puVar2 + 1);
		        *(undefined8 *)(iVar5 + 0x10) = uVar7;
		        param5 = param5 + 4;
		        uVar6 = uVar6 + 4;
		      } while (uVar6 != (param2_00 & 0xfffffffc));
		    }
		    if ((param2_00 & 3) != 0) {
		      do {
		        iVar3 = param3 + (int)param5 * 0xc;
		        uVar7 = *(undefined8 *)(iVar3 + 0x10);
		        iVar5 = *(int *)(param1 + 0xc) + (int)param5 * 0xc;
		        *(undefined4 *)(iVar5 + 0x18) = *(undefined4 *)(iVar3 + 0x18);
		        *(undefined8 *)(iVar5 + 0x10) = uVar7;
		        param5 = param5 + 1;
		        uVar4 = uVar4 + 1;
		      } while (uVar4 != (param2_00 & 3));
		    }
		  }
		  DG_Tweening_Plugins_Core_PathCore_Path__AssignWaypoints(param1,param2,param5);
		  if (*(int *)(DG_Tweening_Core_TweenManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_Core_TweenManager_TypeInfo);
		  }
		  if (**(char **)(DG_Tweening_Core_TweenManager_TypeInfo + 0x5c) != '\0') {
		    if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		      func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		    }
		    iVar5 = *(int *)(*(int *)(DG_Tweening_DOTween_TypeInfo + 0x5c) + 0x78);
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar1,param1,Method_DG_Tweening_Plugins_Core_PathCore_Path_Draw__,0);
		    iVar3 = Method_System_Collections_Generic_List_TweenCallback__Add__;
		    *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		    uVar6 = *(uint *)(iVar5 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		      *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		      *(undefined4 *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = uVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar5,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: FinalizePath ---
		void DG_Tweening_Plugins_Core_PathCore_Path__FinalizePath
		               (undefined8 *param1,int param2,float param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  float fVar2;
		  int iVar3;
		  float fVar4;
		  float fVar5;
		  float fVar6;
		  float fVar7;
		  int iVar8;
		  int iVar9;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  fVar5 = 0.0;
		  fVar6 = 0.0;
		  fVar7 = 0.0;
		  fVar2 = param3;
		  if ((param4 != 0) && (*(int *)(param2 + 0x10) != 0)) {
		    if ((0.0 < param3) && (param3 < 1.0)) {
		      if (*(float *)(param2 + 0x20) <= 0.0) goto code_r0x823f8eb1;
		      fVar2 = *(float *)(param2 + 0x20) * param3;
		      iVar9 = *(int *)(param2 + 0x2c);
		      if (*(int *)(iVar9 + 0xc) < 1) {
		code_r0x823f8e71:
		        fVar4 = 0.0;
		      }
		      else {
		        iVar3 = *(int *)(param2 + 0x28);
		        fVar4 = *(float *)(iVar9 + 0x10);
		        if (fVar4 <= fVar2) {
		          iVar8 = 0;
		          do {
		            iVar1 = iVar8;
		            iVar8 = iVar1 + 1;
		            if (*(int *)(iVar9 + 0xc) == iVar8) {
		              fVar5 = *(float *)(iVar3 + iVar1 * 4 + 0x10);
		              goto code_r0x823f8e71;
		            }
		            fVar4 = *(float *)(iVar9 + iVar8 * 4 + 0x10);
		          } while (fVar4 <= fVar2);
		          fVar7 = *(float *)(iVar3 + 0x10 + iVar8 * 4);
		          fVar5 = *(float *)(iVar3 + 0x10 + iVar1 * 4);
		          fVar6 = *(float *)(iVar1 * 4 + iVar9 + 0x10);
		        }
		        else {
		          fVar7 = *(float *)(iVar3 + 0x10);
		        }
		      }
		      param3 = fVar5 + (fVar7 - fVar5) * ((fVar2 - fVar6) / (fVar4 - fVar6));
		    }
		    if (param3 <= 1.0) {
		      fVar2 = 0.0;
		      if (0.0 <= param3) {
		        fVar2 = param3;
		      }
		    }
		    else {
		      fVar2 = 1.0;
		    }
		  }
		code_r0x823f8eb1:
		  iVar9 = **(int **)(param2 + 0xa0);
		  (**(code **)((ulonglong)*(uint *)(iVar9 + 0xe8) * 4))
		            (&local_c,*(int **)(param2 + 0xa0),fVar2,*(undefined4 *)(param2 + 0xc),param2,
		             *(undefined4 *)(param2 + 0x1c),*(undefined4 *)(iVar9 + 0xec));
		  *(undefined4 *)(param1 + 1) = local_4;
		  *param1 = local_c;
		  return;
		}
		*/


		/* --- GHIDRA: GetPoint ---
		float DG_Tweening_Plugins_Core_PathCore_Path__GetPoint(int param1,float param2,undefined4 param3)
		
		{
		  float fVar1;
		  int iVar2;
		  int iVar3;
		  float fVar4;
		  int iVar5;
		  float fVar6;
		  float fVar7;
		  float fVar8;
		  
		  fVar7 = 0.0;
		  fVar8 = 0.0;
		  fVar6 = 0.0;
		  if (*(int *)(param1 + 0x10) == 0) {
		    return param2;
		  }
		  if ((0.0 < param2) && (param2 < 1.0)) {
		    if (*(float *)(param1 + 0x20) <= 0.0) {
		      return param2;
		    }
		    fVar4 = *(float *)(param1 + 0x20) * param2;
		    fVar1 = 0.0;
		    iVar5 = *(int *)(param1 + 0x2c);
		    if (0 < *(int *)(iVar5 + 0xc)) {
		      iVar2 = 0;
		      fVar1 = *(float *)(iVar5 + 0x10);
		      if (fVar4 < fVar1) {
		        fVar8 = 0.0;
		      }
		      else {
		        do {
		          iVar3 = iVar2;
		          iVar2 = iVar3 + 1;
		          if (iVar2 == *(int *)(iVar5 + 0xc)) {
		            fVar8 = *(float *)(*(int *)(param1 + 0x28) + iVar3 * 4 + 0x10);
		            fVar1 = 0.0;
		            goto code_r0x823f8d45;
		          }
		          fVar1 = *(float *)(iVar5 + iVar2 * 4 + 0x10);
		        } while (fVar1 <= fVar4);
		        fVar8 = *(float *)(*(int *)(param1 + 0x28) + iVar3 * 4 + 0x10);
		      }
		      fVar6 = *(float *)(*(int *)(param1 + 0x28) + iVar2 * 4 + 0x10);
		      if (iVar2 != 0) {
		        fVar7 = *(float *)(iVar2 * 4 + iVar5 + 0xc);
		      }
		    }
		code_r0x823f8d45:
		    param2 = fVar8 + (fVar6 - fVar8) * ((fVar4 - fVar7) / (fVar1 - fVar7));
		  }
		  fVar7 = 0.0;
		  if (0.0 <= param2) {
		    fVar7 = param2;
		  }
		  fVar8 = 1.0;
		  if (param2 <= 1.0) {
		    fVar8 = fVar7;
		  }
		  return fVar8;
		}
		*/


		/* --- GHIDRA: ConvertToConstantPathPerc ---
		int DG_Tweening_Plugins_Core_PathCore_Path__ConvertToConstantPathPerc
		              (int param1,float param2,uint param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  float fVar4;
		  float fVar5;
		  
		  if (1.0 <= param2) {
		    return *(int *)(*(int *)(param1 + 0xc) + 0xc) + -1;
		  }
		  iVar2 = 0;
		  if (0.0 < param2) {
		    iVar3 = *(int *)(param1 + 8);
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      iVar2 = *(int *)(iVar3 + 0xc) + -1;
		      if (iVar2 != 0) {
		        fVar4 = *(float *)(param1 + 0x20) * param2;
		        fVar5 = *(float *)(iVar3 + 0x10) + 0.0;
		        iVar1 = 0;
		        do {
		          if (fVar4 <= fVar5) {
		            return iVar1 - (fVar4 < fVar5 & param3);
		          }
		          iVar1 = iVar1 + 1;
		          fVar5 = fVar5 + *(float *)(iVar3 + iVar1 * 4 + 0x10);
		        } while (iVar1 != iVar2);
		      }
		      iVar2 = iVar2 - param3;
		    }
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: GetWaypointIndexFromPerc ---
		int DG_Tweening_Plugins_Core_PathCore_Path__GetWaypointIndexFromPerc
		              (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a64029 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a64029 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0xc);
		  if (*(int *)(param1 + 0x10) != 0) {
		    iVar3 = *(int *)(iVar1 + 0xc) * param2;
		    iVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,iVar3 + 1);
		    if (-1 < iVar3) {
		      do {
		        iVar4 = **(int **)(param1 + 0xa0);
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		                  (&local_c,*(int **)(param1 + 0xa0),(float)iVar2 / (float)iVar3,
		                   *(undefined4 *)(param1 + 0xc),param1,*(undefined4 *)(param1 + 0x1c),
		                   *(undefined4 *)(iVar4 + 0xec));
		        iVar4 = iVar1 + iVar2 * 0xc;
		        *(undefined4 *)(iVar4 + 0x18) = local_4;
		        *(undefined8 *)(iVar4 + 0x10) = local_c;
		        iVar2 = iVar2 + 1;
		      } while (iVar2 <= iVar3);
		    }
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: GetDrawPoints ---
		void DG_Tweening_Plugins_Core_PathCore_Path__GetDrawPoints(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  uint uVar3;
		  int iVar4;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6402a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a6402a = '\x01';
		  }
		  uVar2 = *(int *)(*(int *)(param1 + 0xc) + 0xc) * 10;
		  if ((*(int *)(param1 + 0xa8) == 0) || (*(uint *)(*(int *)(param1 + 0xa8) + 0xc) != (uVar2 | 1))) {
		    uVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,uVar2 | 1);
		    *(undefined4 *)(param1 + 0xa8) = uVar1;
		  }
		  uVar3 = 0;
		  if (-1 < (int)uVar2) {
		    do {
		      iVar4 = **(int **)(param1 + 0xa0);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		                (&local_c,*(int **)(param1 + 0xa0),(float)(int)uVar3 / (float)(int)uVar2,
		                 *(undefined4 *)(param1 + 0xc),param1,*(undefined4 *)(param1 + 0x1c),
		                 *(undefined4 *)(iVar4 + 0xec));
		      iVar4 = *(int *)(param1 + 0xa8) + uVar3 * 0xc;
		      *(undefined4 *)(iVar4 + 0x18) = local_4;
		      *(undefined8 *)(iVar4 + 0x10) = local_c;
		      uVar3 = uVar3 + 1;
		    } while (uVar3 != (uVar2 | 1));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: RefreshNonLinearDrawWps ---
		void DG_Tweening_Plugins_Core_PathCore_Path__RefreshNonLinearDrawWps(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6402b == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TweenCallback__Remove__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_Plugins_Core_PathCore_Path_Draw__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_TweenManager_TypeInfo);
		    DAT_ram_00a6402b = '\x01';
		  }
		  if (*(int *)(DG_Tweening_Core_TweenManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_Core_TweenManager_TypeInfo);
		  }
		  if (**(char **)(DG_Tweening_Core_TweenManager_TypeInfo + 0x5c) != '\0') {
		    if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		      func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		    }
		    param1_01 = *(undefined4 *)(*(int *)(DG_Tweening_DOTween_TypeInfo + 0x5c) + 0x78);
		    param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (param1_00,param1,Method_DG_Tweening_Plugins_Core_PathCore_Path_Draw__,0);
		    func_ii_4876(param1_01,param1_00,Method_System_Collections_Generic_List_TweenCallback__Remove__)
		    ;
		  }
		  *(undefined8 *)(param1 + 8) = 0;
		  *(undefined8 *)(param1 + 0x28) = 0;
		  *(undefined4 *)(param1 + 0xa8) = 0;
		  *(undefined1 *)(param1 + 0x24) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: Destroy ---
		int DG_Tweening_Plugins_Core_PathCore_Path__Destroy(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  float fVar5;
		  float fVar6;
		  float fVar7;
		  float fVar8;
		  float fVar9;
		  float fVar10;
		  float fVar11;
		  int iVar12;
		  uint uVar13;
		  float fVar14;
		  int iVar15;
		  undefined4 uVar16;
		  undefined4 param2_00;
		  undefined8 uVar17;
		  float *pfVar18;
		  int iVar19;
		  uint uVar20;
		  float fVar21;
		  
		  if (DAT_ram_00a6402c == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Plugins_Core_PathCore_ControlPoint___TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TweenCallback__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_Plugins_Core_PathCore_Path_Draw__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_TweenManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a6402c = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x98);
		  if (iVar3 != 0) {
		    if (*(int *)(param1 + 0x9c) == param2) {
		      return iVar3;
		    }
		    DG_Tweening_Plugins_Core_PathCore_Path__RefreshNonLinearDrawWps(iVar3,iVar3);
		  }
		  iVar3 = *(int *)(param1 + 0xc);
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  pfVar18 = (float *)(iVar3 + 0x10);
		  fVar5 = pfVar18[uVar4 * 3 + -1] - *(float *)(iVar3 + 0x18);
		  fVar6 = pfVar18[uVar4 * 3 + -2] - *(float *)(iVar3 + 0x14);
		  fVar7 = pfVar18[uVar4 * 3 + -3] - *pfVar18;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,uVar4);
		  if (0 < (int)uVar4) {
		    fVar8 = (float)param2;
		    fVar21 = fVar5 * fVar8;
		    fVar14 = fVar6 * fVar8;
		    fVar8 = fVar7 * fVar8;
		    uVar20 = 0;
		    if (uVar4 != 1) {
		      uVar13 = 0;
		      do {
		        iVar1 = uVar20 * 0xc + *(int *)(param1 + 0xc);
		        fVar9 = *(float *)(iVar1 + 0x10);
		        fVar10 = *(float *)(iVar1 + 0x14);
		        pfVar18 = (float *)(iVar3 + 0x10 + uVar20 * 0xc);
		        pfVar18[2] = fVar21 + *(float *)(iVar1 + 0x18);
		        pfVar18[1] = fVar14 + fVar10;
		        *pfVar18 = fVar8 + fVar9;
		        iVar1 = (uVar20 | 1) * 0xc;
		        iVar19 = iVar1 + *(int *)(param1 + 0xc);
		        fVar9 = *(float *)(iVar19 + 0x10);
		        fVar10 = *(float *)(iVar19 + 0x14);
		        pfVar18 = (float *)(iVar1 + iVar3 + 0x10);
		        pfVar18[2] = fVar21 + *(float *)(iVar19 + 0x18);
		        pfVar18[1] = fVar14 + fVar10;
		        *pfVar18 = fVar8 + fVar9;
		        uVar20 = uVar20 + 2;
		        uVar13 = uVar13 + 2;
		      } while (uVar13 != (uVar4 & 0xfffffffe));
		    }
		    if ((uVar4 & 1) != 0) {
		      iVar1 = uVar20 * 0xc + *(int *)(param1 + 0xc);
		      fVar9 = *(float *)(iVar1 + 0x10);
		      fVar10 = *(float *)(iVar1 + 0x14);
		      iVar19 = uVar20 * 0xc + iVar3;
		      *(float *)(iVar19 + 0x18) = fVar21 + *(float *)(iVar1 + 0x18);
		      *(float *)(iVar19 + 0x14) = fVar14 + fVar10;
		      *(float *)(iVar19 + 0x10) = fVar8 + fVar9;
		    }
		  }
		  iVar19 = *(int *)(*(int *)(param1 + 0x1c) + 0xc);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (DG_Tweening_Plugins_Core_PathCore_ControlPoint___TypeInfo,iVar19);
		  if (0 < iVar19) {
		    fVar21 = (float)param2;
		    iVar2 = 0;
		    do {
		      iVar15 = iVar2 * 0x18 + *(int *)(param1 + 0x1c);
		      fVar14 = *(float *)(iVar15 + 0x10);
		      fVar8 = *(float *)(iVar15 + 0x14);
		      fVar9 = *(float *)(iVar15 + 0x18);
		      fVar10 = *(float *)(iVar15 + 0x1c);
		      fVar11 = *(float *)(iVar15 + 0x20);
		      iVar12 = iVar2 * 0x18 + iVar1;
		      *(float *)(iVar12 + 0x24) = fVar5 * fVar21 + *(float *)(iVar15 + 0x24);
		      *(float *)(iVar12 + 0x20) = fVar6 * fVar21 + fVar11;
		      *(float *)(iVar12 + 0x1c) = fVar7 * fVar21 + fVar10;
		      *(float *)(iVar12 + 0x18) = fVar5 * fVar21 + fVar9;
		      *(float *)(iVar12 + 0x14) = fVar6 * fVar21 + fVar8;
		      *(float *)(iVar12 + 0x10) = fVar7 * fVar21 + fVar14;
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != iVar19);
		  }
		  iVar19 = 0;
		  if (*(int *)(param1 + 0xa8) != 0) {
		    uVar4 = 0;
		    uVar20 = *(uint *)(*(int *)(param1 + 0xa8) + 0xc);
		    iVar19 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,uVar20);
		    if (0 < (int)uVar20) {
		      fVar21 = (float)param2;
		      fVar5 = fVar5 * fVar21;
		      fVar6 = fVar6 * fVar21;
		      fVar7 = fVar7 * fVar21;
		      if (uVar20 != 1) {
		        uVar13 = 0;
		        do {
		          iVar2 = uVar4 * 0xc + *(int *)(param1 + 0xa8);
		          fVar21 = *(float *)(iVar2 + 0x10);
		          fVar14 = *(float *)(iVar2 + 0x14);
		          pfVar18 = (float *)(iVar19 + 0x10 + uVar4 * 0xc);
		          pfVar18[2] = fVar5 + *(float *)(iVar2 + 0x18);
		          pfVar18[1] = fVar6 + fVar14;
		          *pfVar18 = fVar7 + fVar21;
		          iVar2 = (uVar4 | 1) * 0xc;
		          iVar15 = iVar2 + *(int *)(param1 + 0xa8);
		          fVar21 = *(float *)(iVar15 + 0x10);
		          fVar14 = *(float *)(iVar15 + 0x14);
		          pfVar18 = (float *)(iVar2 + iVar19 + 0x10);
		          pfVar18[2] = fVar5 + *(float *)(iVar15 + 0x18);
		          pfVar18[1] = fVar6 + fVar14;
		          *pfVar18 = fVar7 + fVar21;
		          uVar4 = uVar4 + 2;
		          uVar13 = uVar13 + 2;
		        } while (uVar13 != (uVar20 & 0xfffffffe));
		      }
		      if ((uVar20 & 1) != 0) {
		        iVar2 = uVar4 * 0xc + *(int *)(param1 + 0xa8);
		        fVar21 = *(float *)(iVar2 + 0x10);
		        fVar14 = *(float *)(iVar2 + 0x14);
		        iVar15 = uVar4 * 0xc + iVar19;
		        *(float *)(iVar15 + 0x18) = fVar5 + *(float *)(iVar2 + 0x18);
		        *(float *)(iVar15 + 0x14) = fVar6 + fVar14;
		        *(float *)(iVar15 + 0x10) = fVar7 + fVar21;
		      }
		    }
		  }
		  iVar2 = unnamed_function_1417(DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo);
		  *(undefined8 *)(iVar2 + 200) = 0x3f8000003f800000;
		  *(undefined4 *)(iVar2 + 0x30) = 0xffffffff;
		  *(undefined8 *)(iVar2 + 0xd0) = 0x3f3333333f800000;
		  *(int *)(param1 + 0x9c) = param2;
		  *(int *)(param1 + 0x98) = iVar2;
		  *(undefined4 *)(iVar2 + 0x10) = *(undefined4 *)(param1 + 0x10);
		  *(undefined4 *)(iVar2 + 0x14) = *(undefined4 *)(param1 + 0x14);
		  uVar16 = *(undefined4 *)(param1 + 0x18);
		  *(int *)(iVar2 + 0x1c) = iVar1;
		  *(int *)(iVar2 + 0xc) = iVar3;
		  *(undefined4 *)(iVar2 + 0x18) = uVar16;
		  if (*(int *)(DG_Tweening_Core_TweenManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_Core_TweenManager_TypeInfo);
		  }
		  if (**(char **)(DG_Tweening_Core_TweenManager_TypeInfo + 0x5c) != '\0') {
		    if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		      func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		    }
		    iVar1 = *(int *)(*(int *)(DG_Tweening_DOTween_TypeInfo + 0x5c) + 0x78);
		    param2_00 = *(undefined4 *)(param1 + 0x98);
		    uVar16 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar16,param2_00,Method_DG_Tweening_Plugins_Core_PathCore_Path_Draw__,0);
		    iVar3 = Method_System_Collections_Generic_List_TweenCallback__Add__;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar4 = *(uint *)(iVar1 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      *(uint *)(iVar1 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(iVar1 + 8) + uVar4 * 4 + 0x10) = uVar16;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,uVar16,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar3 = *(int *)(param1 + 0x98);
		  *(undefined4 *)(iVar3 + 0x20) = *(undefined4 *)(param1 + 0x20);
		  *(undefined4 *)(iVar3 + 8) = *(undefined4 *)(param1 + 8);
		  *(undefined4 *)(iVar3 + 0x28) = *(undefined4 *)(param1 + 0x28);
		  *(undefined4 *)(iVar3 + 0x2c) = *(undefined4 *)(param1 + 0x2c);
		  uVar16 = *(undefined4 *)(param1 + 0xa0);
		  *(int *)(iVar3 + 0xa8) = iVar19;
		  *(undefined4 *)(iVar3 + 0xa0) = uVar16;
		  uVar17 = *(undefined8 *)(param1 + 0xac);
		  *(undefined4 *)(iVar3 + 0xb4) = *(undefined4 *)(param1 + 0xb4);
		  *(undefined8 *)(iVar3 + 0xac) = uVar17;
		  uVar17 = *(undefined8 *)(param1 + 0xc0);
		  iVar3 = *(int *)(param1 + 0x98);
		  *(undefined8 *)(iVar3 + 0xb8) = *(undefined8 *)(param1 + 0xb8);
		  *(undefined8 *)(iVar3 + 0xc0) = uVar17;
		  iVar3 = *(int *)(param1 + 0x98);
		  *(undefined1 *)(iVar3 + 0x24) = 1;
		  return iVar3;
		}
		*/


		/* --- GHIDRA: CloneIncremental ---
		void DG_Tweening_Plugins_Core_PathCore_Path__CloneIncremental
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined8 *puVar2;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  uint uVar6;
		  undefined8 uVar7;
		  uint param2_00;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a6402d == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a6402d = '\x01';
		  }
		  if (param3 != 0) {
		    uVar5 = 0;
		    param2_00 = *(uint *)(param2 + 0xc);
		    uVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,param2_00);
		    *(undefined4 *)(param1 + 0xc) = uVar1;
		    if (0 < (int)param2_00) {
		      if (3 < param2_00) {
		        do {
		          iVar3 = param2 + 0x10;
		          puVar2 = (undefined8 *)(iVar3 + uVar5 * 0xc);
		          uVar7 = *puVar2;
		          iVar4 = *(int *)(param1 + 0xc) + uVar5 * 0xc;
		          *(undefined4 *)(iVar4 + 0x18) = *(undefined4 *)(puVar2 + 1);
		          *(undefined8 *)(iVar4 + 0x10) = uVar7;
		          iVar4 = (uVar5 | 1) * 0xc;
		          puVar2 = (undefined8 *)(iVar3 + iVar4);
		          uVar7 = *puVar2;
		          iVar4 = *(int *)(param1 + 0xc) + iVar4;
		          *(undefined4 *)(iVar4 + 0x18) = *(undefined4 *)(puVar2 + 1);
		          *(undefined8 *)(iVar4 + 0x10) = uVar7;
		          iVar4 = (uVar5 | 2) * 0xc;
		          puVar2 = (undefined8 *)(iVar3 + iVar4);
		          uVar7 = *puVar2;
		          iVar4 = *(int *)(param1 + 0xc) + iVar4;
		          *(undefined4 *)(iVar4 + 0x18) = *(undefined4 *)(puVar2 + 1);
		          *(undefined8 *)(iVar4 + 0x10) = uVar7;
		          iVar4 = (uVar5 | 3) * 0xc;
		          puVar2 = (undefined8 *)(iVar3 + iVar4);
		          uVar7 = *puVar2;
		          iVar4 = *(int *)(param1 + 0xc) + iVar4;
		          *(undefined4 *)(iVar4 + 0x18) = *(undefined4 *)(puVar2 + 1);
		          *(undefined8 *)(iVar4 + 0x10) = uVar7;
		          uVar5 = uVar5 + 4;
		          uVar6 = uVar6 + 4;
		        } while (uVar6 != (param2_00 & 0xfffffffc));
		      }
		      if ((param2_00 & 3) != 0) {
		        uVar6 = 0;
		        do {
		          iVar3 = param2 + uVar5 * 0xc;
		          uVar7 = *(undefined8 *)(iVar3 + 0x10);
		          iVar4 = *(int *)(param1 + 0xc) + uVar5 * 0xc;
		          *(undefined4 *)(iVar4 + 0x18) = *(undefined4 *)(iVar3 + 0x18);
		          *(undefined8 *)(iVar4 + 0x10) = uVar7;
		          uVar5 = uVar5 + 1;
		          uVar6 = uVar6 + 1;
		        } while (uVar6 != (param2_00 & 3));
		      }
		    }
		    return;
		  }
		  *(int *)(param1 + 0xc) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: AssignWaypoints ---
		void DG_Tweening_Plugins_Core_PathCore_Path__AssignWaypoints
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6402e == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Plugins_Core_PathCore_CatmullRomDecoder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Plugins_Core_PathCore_CubicBezierDecoder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Plugins_Core_PathCore_LinearDecoder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo);
		    DAT_ram_00a6402e = '\x01';
		  }
		  *(int *)(param1 + 0x10) = param2;
		  if (param2 == 0) {
		    iVar2 = *(int *)(*(int *)(DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo + 0x5c) + 4);
		    if (iVar2 == 0) {
		      uVar1 = unnamed_function_1417(DG_Tweening_Plugins_Core_PathCore_LinearDecoder_TypeInfo);
		      *(undefined4 *)(*(int *)(DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo + 0x5c) + 4) = uVar1;
		      *(undefined4 *)(param1 + 0xa0) = uVar1;
		      return;
		    }
		  }
		  else if ((param2 == 1) || (param2 != 2)) {
		    iVar2 = **(int **)(DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo + 0x5c);
		    if (iVar2 == 0) {
		      uVar1 = unnamed_function_1417(DG_Tweening_Plugins_Core_PathCore_CatmullRomDecoder_TypeInfo);
		      **(undefined4 **)(DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo + 0x5c) = uVar1;
		      iVar2 = **(int **)(DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo + 0x5c);
		    }
		  }
		  else {
		    iVar2 = *(int *)(*(int *)(DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo + 0x5c) + 8);
		    if (iVar2 == 0) {
		      uVar1 = unnamed_function_1417(DG_Tweening_Plugins_Core_PathCore_CubicBezierDecoder_TypeInfo);
		      *(undefined4 *)(*(int *)(DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo + 0x5c) + 8) = uVar1;
		      *(undefined4 *)(param1 + 0xa0) = uVar1;
		      return;
		    }
		  }
		  *(int *)(param1 + 0xa0) = iVar2;
		  return;
		}
		*/


		/* --- GHIDRA: AssignDecoder ---
		void DG_Tweening_Plugins_Core_PathCore_Path__AssignDecoder(undefined4 param1,undefined4 param2)
		
		{
		  DG_Tweening_Plugins_Core_PathCore_Path__Draw(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: Draw ---
		void DG_Tweening_Plugins_Core_PathCore_Path__Draw
		               (undefined8 *param1,undefined8 *param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a64030 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a64030 = '\x01';
		  }
		  if ((*(byte *)(param3 + 0x3c) & 1) != 0) {
		    param1_00 = *(undefined4 *)(param3 + 0x40);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = func_ii_3812(param1_00,0,0);
		    if (iVar1 == 0) {
		      local_10 = *(undefined4 *)(param2 + 1);
		      local_18 = *param2;
		      UnityEngine_Transform__TransformVector(&local_c,param1_00,&local_18,0);
		      *(undefined4 *)(param1 + 1) = local_4;
		      *param1 = local_c;
		      return;
		    }
		  }
		  *param1 = *param2;
		  *(undefined4 *)(param1 + 1) = *(undefined4 *)(param2 + 1);
		  return;
		}
		*/


		/* --- GHIDRA: Draw ---
		void DG_Tweening_Plugins_Core_PathCore_Path__Draw
		               (undefined8 *param1,undefined8 *param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a64030 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a64030 = '\x01';
		  }
		  if ((*(byte *)(param3 + 0x3c) & 1) != 0) {
		    param1_00 = *(undefined4 *)(param3 + 0x40);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = func_ii_3812(param1_00,0,0);
		    if (iVar1 == 0) {
		      local_10 = *(undefined4 *)(param2 + 1);
		      local_18 = *param2;
		      UnityEngine_Transform__TransformVector(&local_c,param1_00,&local_18,0);
		      *(undefined4 *)(param1 + 1) = local_4;
		      *param1 = local_c;
		      return;
		    }
		  }
		  *param1 = *param2;
		  *(undefined4 *)(param1 + 1) = *(undefined4 *)(param2 + 1);
		  return;
		}
		*/


		/* --- GHIDRA: ConvertToDrawPoint ---
		int DG_Tweening_Plugins_Core_PathCore_Path__ConvertToDrawPoint(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a64031 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_CustomPlugins_PureQuaternionPlugin_TypeInfo);
		    DAT_ram_00a64031 = '\x01';
		  }
		  iVar2 = **(int **)(DG_Tweening_CustomPlugins_PureQuaternionPlugin_TypeInfo + 0x5c);
		  if (iVar2 == 0) {
		    uVar1 = unnamed_function_1417(DG_Tweening_CustomPlugins_PureQuaternionPlugin_TypeInfo);
		    if (DAT_ram_00a64032 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_DG_Tweening_Plugins_Core_ABSTweenPlugin_Quaternion__Quaternion__NoOptions___ctor__
		                );
		      DAT_ram_00a64032 = '\x01';
		    }
		    **(undefined4 **)(DG_Tweening_CustomPlugins_PureQuaternionPlugin_TypeInfo + 0x5c) = uVar1;
		    iVar2 = **(int **)(DG_Tweening_CustomPlugins_PureQuaternionPlugin_TypeInfo + 0x5c);
		  }
		  return iVar2;
		}
		*/

}
