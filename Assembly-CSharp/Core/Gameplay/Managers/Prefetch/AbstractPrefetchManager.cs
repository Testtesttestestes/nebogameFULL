using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Gameplay.AssetsPrefetch;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Prefetch
{
	// Token: 0x0200119E RID: 4510
	[Token(Token = "0x200119E")]
	public abstract class AbstractPrefetchManager : IGameManager, IBaseManager
	{
		// Token: 0x140002BC RID: 700
		// (add) Token: 0x06006B29 RID: 27433 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B2A RID: 27434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BC")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006B29")]
			[Address(RVA = "0xB62C", Offset = "0xB62C", VA = "0xB62C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B2A")]
			[Address(RVA = "0xB62D", Offset = "0xB62D", VA = "0xB62D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002BD RID: 701
		// (add) Token: 0x06006B2B RID: 27435 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B2C RID: 27436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BD")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006B2B")]
			[Address(RVA = "0xB62E", Offset = "0xB62E", VA = "0xB62E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B2C")]
			[Address(RVA = "0xB62F", Offset = "0xB62F", VA = "0xB62F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06006B2D RID: 27437 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006B2E RID: 27438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015DC")]
		private protected IGame Game
		{
			[Token(Token = "0x6006B2D")]
			[Address(RVA = "0xB630", Offset = "0xB630", VA = "0xB630")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6006B2E")]
			[Address(RVA = "0xB631", Offset = "0xB631", VA = "0xB631")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006B2F RID: 27439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B2F")]
		[Address(RVA = "0xB632", Offset = "0xB632", VA = "0xB632")]
		protected AbstractPrefetchManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int *piVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a651 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDisposable__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDisposable__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDisposable__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDisposable__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IDisposable__GetEnumerator__);
		    DAT_ram_00a5a651 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_List_IDisposable__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_IDisposable__MoveNext__);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81249d1a;
		      }
		      if (iVar2 == 0) goto code_r0x81249d70;
		      piVar4 = local_8._4_4_;
		    } while (local_8._4_4_ == (int *)0x0);
		    iVar5 = *local_8._4_4_;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_IDisposable_TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(iVar5 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x81249cbd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        System_IDisposable_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81249cbd:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar3,piVar4,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81249d1a:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
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
		code_r0x81249d70:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = *(int *)(param1 + 0x14);
		      iVar2 = *(int *)(iVar5 + 0xc);
		      *(undefined4 *)(iVar5 + 0xc) = 0;
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar5 + 8),0,iVar2,0);
		      }
		      *(undefined4 *)(param1 + 0x18) = 0;
		      iVar5 = *(int *)(param1 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x304,&local_18);
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

		// Token: 0x06006B30 RID: 27440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B30")]
		[Address(RVA = "0xB633", Offset = "0xB633", VA = "0xB633", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager__Deinit(int *param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  int *local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a652 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractPrefetchManager__FetchRequiredInternal_d__15___
		              );
		    DAT_ram_00a5a652 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AbstractHTTPService__SetupAuthHeader_d__10_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractPrefetchManager__FetchRequiredInternal_d__15___
		            );
		  if (DAT_ram_00a5a653 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDisposable__AddRange__);
		    DAT_ram_00a5a653 = '\x01';
		  }
		  local_20 = 0;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		            (param1,&local_20,*(undefined4 *)(*param1 + 0x134));
		  func_ii_6335(param1[5],local_20,Method_System_Collections_Generic_List_IDisposable__AddRange__);
		  return;
		}
		*/

		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B31")]
		[Address(RVA = "0xB634", Offset = "0xB634", VA = "0xB634", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a652 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractPrefetchManager__FetchRequiredInternal_d__15___
		              );
		    DAT_ram_00a5a652 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AbstractHTTPService__SetupAuthHeader_d__10_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AbstractPrefetchManager__FetchRequiredInternal_d__15___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B32")]
		[Address(RVA = "0xB635", Offset = "0xB635", VA = "0xB635")]
		private void FetchRequiredInternal()
		{
		/* --- GHIDRA: FetchRequiredInternal ---
		void Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager__FetchRequiredInternal
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a653 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDisposable__AddRange__);
		    DAT_ram_00a5a653 = '\x01';
		  }
		  local_4 = 0;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		            (param1,&local_4,*(undefined4 *)(*param1 + 0x134));
		  func_ii_6335(param1[5],local_4,Method_System_Collections_Generic_List_IDisposable__AddRange__);
		  return;
		}
		*/

		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B33")]
		[Address(RVA = "0xB636", Offset = "0xB636", VA = "0xB636")]
		private void FetchOptionalAssetsInternal()
		{
		/* --- GHIDRA: FetchOptionalAssetsInternal ---
		void Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager__FetchOptionalAssetsInternal
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a654 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager___c_TypeInfo);
		    DAT_ram_00a5a654 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager___c_TypeInfo);
		  **(undefined4 **)(Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06006B34 RID: 27444
		[Token(Token = "0x170015DD")]
		public abstract string Name { [Token(Token = "0x6006B34")] get; }

		// Token: 0x06006B35 RID: 27445
		[Token(Token = "0x6006B35")]
		protected abstract void FetchRequired(out IList<IDisposable> fetchers, out UniTask[] tasks);

		// Token: 0x06006B36 RID: 27446
		[Token(Token = "0x6006B36")]
		protected abstract void PostFetchRequired(AssetsPrefetch[] fetchers);

		// Token: 0x06006B37 RID: 27447
		[Token(Token = "0x6006B37")]
		protected abstract void FetchOptionalAssets(out IList<IDisposable> fetchers);

		// Token: 0x0400389D RID: 14493
		[Token(Token = "0x400389D")]
		[FieldOffset(Offset = "0x10")]
		public readonly CombatGemsAssetsPrefetch CombatGemsAssetsPrefetch;

		// Token: 0x0400389E RID: 14494
		[Token(Token = "0x400389E")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<IDisposable> _assetsFetchers;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a64d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a64d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a64e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a64e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a64f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a64f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: set_Game ---
		void Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager__set_Game
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a650 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDisposable__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDisposable___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IDisposable__TypeInfo);
		    DAT_ram_00a5a650 = '\x01';
		  }
		  *(int **)(param1 + 0x18) = param2;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar3 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar3 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81249a99;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar3);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81249a99:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  param1_00 = unnamed_function_1417(Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch_TypeInfo);
		  Gameplay_AssetsPrefetch_CombatGemsAssetsPrefetch__Dispose(param1_00,uVar2,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  param1_01 = unnamed_function_1417(System_Collections_Generic_List_IDisposable__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,Method_System_Collections_Generic_List_IDisposable___ctor__);
		  iVar4 = Method_System_Collections_Generic_List_IDisposable__Add__;
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_01 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    *(int *)(param1 + 0x14) = param1_01;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_01,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  *(int *)(param1 + 0x14) = param1_01;
		  return;
		}
		*/

}
