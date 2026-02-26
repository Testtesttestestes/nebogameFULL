using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Utils.Timers;

namespace Core.Gameplay.Managers.Skins
{
	// Token: 0x0200118D RID: 4493
	[Token(Token = "0x200118D")]
	public class SkinManager : IGameManager, IBaseManager
	{
		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06006AC2 RID: 27330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015D6")]
		public string Name
		{
			[Token(Token = "0x6006AC2")]
			[Address(RVA = "0xB5D5", Offset = "0xB5D5", VA = "0xB5D5", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002B7 RID: 695
		// (add) Token: 0x06006AC3 RID: 27331 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AC4 RID: 27332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B7")]
		public event Action<SkinManager> SkinChangedEvent
		{
			[Token(Token = "0x6006AC3")]
			[Address(RVA = "0xB5D6", Offset = "0xB5D6", VA = "0xB5D6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AC4")]
			[Address(RVA = "0xB5D7", Offset = "0xB5D7", VA = "0xB5D7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B8 RID: 696
		// (add) Token: 0x06006AC5 RID: 27333 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AC6 RID: 27334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B8")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006AC5")]
			[Address(RVA = "0xB5D8", Offset = "0xB5D8", VA = "0xB5D8", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AC6")]
			[Address(RVA = "0xB5D9", Offset = "0xB5D9", VA = "0xB5D9", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B9 RID: 697
		// (add) Token: 0x06006AC7 RID: 27335 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AC8 RID: 27336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B9")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006AC7")]
			[Address(RVA = "0xB5DA", Offset = "0xB5DA", VA = "0xB5DA", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AC8")]
			[Address(RVA = "0xB5DB", Offset = "0xB5DB", VA = "0xB5DB", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x00013AA0 File Offset: 0x00011CA0
		// (set) Token: 0x06006ACA RID: 27338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D7")]
		public bool IsDisposed
		{
			[Token(Token = "0x6006AC9")]
			[Address(RVA = "0xB5DC", Offset = "0xB5DC", VA = "0xB5DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006ACA")]
			[Address(RVA = "0xB5DD", Offset = "0xB5DD", VA = "0xB5DD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACB")]
		[Address(RVA = "0xB5DE", Offset = "0xB5DE", VA = "0xB5DE")]
		public SkinManager(IGame game, Skin.Factory skinFactory, float nearestPackageDeltaTime)
		{
		/* --- GHIDRA: <TryGetSkins>b__32_0 ---
		void Core_Gameplay_Managers_Skins_SkinManager___TryGetSkins_b__32_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a638d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo);
		    DAT_ram_00a638d4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo);
		  **(undefined4 **)(Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Skins_SkinManager___ctor(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  uint uVar6;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a638c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Skins_SkinManager_HandleDictChangedEvent__);
		    DAT_ram_00a638c9 = '\x01';
		  }
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___SkinManager__HandleDictChangedEvent_d__28_
		            (param1,0);
		  piVar4 = *(int **)(param1 + 0x1c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x82310ae2;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82310ae2:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,
		             Method_Core_Gameplay_Managers_Skins_SkinManager_HandleDictChangedEvent__,0);
		  if (DAT_ram_00a637b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a637b1 = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x1c);
		  while ((piVar4 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0),
		         piVar4 == (int *)0x0 || (System_Action_TypeInfo == *piVar4))) {
		    iVar3 = func_ii_4329(iVar5 + 0x1c,piVar4,param1_00);
		    bVar1 = iVar3 == param1_00;
		    param1_00 = iVar3;
		    if (bVar1) {
		      iVar5 = *(int *)(param1 + 0xc);
		      if (iVar5 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                  (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		      }
		      return;
		    }
		  }
		  System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACC")]
		[Address(RVA = "0xB5DF", Offset = "0xB5DF", VA = "0xB5DF", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Skins_SkinManager__Init(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  uint uVar6;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a638ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Skins_SkinManager_HandleDictChangedEvent__);
		    DAT_ram_00a638ca = '\x01';
		  }
		  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		            (*(undefined4 *)(param1 + 0x14),0);
		  System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x14),0);
		  Core_Gameplay_Managers_Skins_SkinManager__ResetCurrentPackageAndSkins(param1,0);
		  *(undefined4 *)(param1 + 0x28) = 0;
		  Utils_Timers_DelayedCall__SetDelay(*(undefined4 *)(param1 + 0x18),0);
		  piVar4 = *(int **)(param1 + 0x1c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x82311499;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82311499:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,
		             Method_Core_Gameplay_Managers_Skins_SkinManager_HandleDictChangedEvent__,0);
		  if (DAT_ram_00a637b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a637b2 = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x1c);
		  while ((piVar4 = (int *)func_ii_7048(param1_00,param1_01,0), piVar4 == (int *)0x0 ||
		         (System_Action_TypeInfo == *piVar4))) {
		    iVar3 = func_ii_4329(iVar5 + 0x1c,piVar4,param1_00);
		    bVar1 = iVar3 == param1_00;
		    param1_00 = iVar3;
		    if (bVar1) {
		      *(undefined1 *)(param1 + 0x30) = 1;
		      iVar5 = *(int *)(param1 + 0x10);
		      if (iVar5 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                  (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		      }
		      return;
		    }
		  }
		  System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACD")]
		[Address(RVA = "0xB5E0", Offset = "0xB5E0", VA = "0xB5E0", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACE")]
		[Address(RVA = "0xB5E1", Offset = "0xB5E1", VA = "0xB5E1")]
		private void ScheduledCallBack()
		{
		/* --- GHIDRA: ScheduledCallBack ---
		void Core_Gameplay_Managers_Skins_SkinManager__ScheduledCallBack(int param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_Skins_SkinManager__ResetCurrentPackageAndSkins(param1,param1);
		  *(undefined4 *)(param1 + 0x28) = 0;
		  Utils_Timers_DelayedCall__SetDelay(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ACF")]
		[Address(RVA = "0xB5E2", Offset = "0xB5E2", VA = "0xB5E2")]
		private void ResetCurrentPackageAndSkins()
		{
		/* --- GHIDRA: ResetCurrentPackageAndSkins ---
		void Core_Gameplay_Managers_Skins_SkinManager__ResetCurrentPackageAndSkins
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a638cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Enumerator_Skin__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Skin__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Skin__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Skin__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Skin__GetEnumerator__);
		    DAT_ram_00a638cb = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x20),
		             Method_System_Collections_Generic_List_Skin__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_Skin__MoveNext__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x823111bb;
		    }
		    iVar4 = local_18;
		    if (iVar1 == 0) goto code_r0x82311204;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    import::env::invoke_vii
		              (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x1a,local_8._4_4_,auStack_20);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x1b,uVar2,auStack_20)
		    ;
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x823111bb:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar4 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x82311204:
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 0) {
		        iVar4 = *(int *)(param1 + 0x20);
		        iVar1 = *(int *)(iVar4 + 0xc);
		        *(undefined4 *)(iVar4 + 0xc) = 0;
		        *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		        if (0 < iVar1) {
		          func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar1,0);
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x1c,&local_18);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD0")]
		[Address(RVA = "0xB5E3", Offset = "0xB5E3", VA = "0xB5E3")]
		private void ResetCurrentSkins()
		{
		/* --- GHIDRA: ResetCurrentSkins ---
		void Core_Gameplay_Managers_Skins_SkinManager__ResetCurrentSkins
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a638cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_SkinManager__HandleDictChangedEvent_d__28___
		              );
		    DAT_ram_00a638cc = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_RecoveryConnectionHelper__Resolve_d__19_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_SkinManager__HandleDictChangedEvent_d__28___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD1")]
		[Address(RVA = "0xB5E4", Offset = "0xB5E4", VA = "0xB5E4")]
		private void HandleDictChangedEvent()
		{
		/* --- GHIDRA: HandleDictChangedEvent ---
		uint Core_Gameplay_Managers_Skins_SkinManager__HandleDictChangedEvent
		               (int param1,undefined8 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a638ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_SkinPackageDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_SkinPackageDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Skins_SkinManager___c__DisplayClass30_0__TryGetNearest_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Skins_SkinManager___c__DisplayClass30_0_TypeInfo);
		    DAT_ram_00a638ce = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Skins_SkinManager___c__DisplayClass30_0_TypeInfo);
		  *(int *)(iVar2 + 0x10) = param1;
		  *(undefined8 *)(iVar2 + 8) = param2;
		  param1_01 = *(int **)(param1 + 0x1c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x82311372;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82311372:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  param1_02 = *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x14) + 0x328);
		  param1_00 = unnamed_function_1417(System_Func_SkinPackageDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar2,
		             Method_Core_Gameplay_Managers_Skins_SkinManager___c__DisplayClass30_0__TryGetNearest_b__0__
		             ,0);
		  iVar2 = System_Func_object__bool____ctor
		                    (param1_02,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_SkinPackageDic___);
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0x4459", Offset = "0x4459", VA = "0x4459")]
		private void PlanePackage()
		{
		/* --- GHIDRA: PlanePackage ---
		undefined4
		Core_Gameplay_Managers_Skins_SkinManager__PlanePackage
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a14d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__TryGetValue__);
		    DAT_ram_00a5a14d = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x14),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__uint__TryGetValue__);
		  if (iVar1 == 0) {
		    local_4 = 0;
		  }
		  return local_4;
		}
		*/

		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x00013AB8 File Offset: 0x00011CB8
		[Token(Token = "0x6006AD3")]
		[Address(RVA = "0xB5E5", Offset = "0xB5E5", VA = "0xB5E5")]
		private bool TryGetNearest(long timestamp, out SkinPackageDic package)
		{
		/* --- GHIDRA: TryGetNearest ---
		uint Core_Gameplay_Managers_Skins_SkinManager__TryGetNearest
		               (int param1,undefined8 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a638cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_SkinPackageDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_SkinPackageDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Skins_SkinManager___c__DisplayClass31_0__TryGetCurrent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Skins_SkinManager___c__DisplayClass31_0_TypeInfo);
		    DAT_ram_00a638cf = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Skins_SkinManager___c__DisplayClass31_0_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = param2;
		  param1_01 = *(int **)(param1 + 0x1c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x82311013;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82311013:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  param1_02 = *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x14) + 0x328);
		  param1_00 = unnamed_function_1417(System_Func_SkinPackageDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar2,
		             Method_Core_Gameplay_Managers_Skins_SkinManager___c__DisplayClass31_0__TryGetCurrent_b__0__
		             ,0);
		  iVar2 = System_Func_object__bool____ctor
		                    (param1_02,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_SkinPackageDic___);
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x00013AD0 File Offset: 0x00011CD0
		[Token(Token = "0x6006AD4")]
		[Address(RVA = "0xB5E6", Offset = "0xB5E6", VA = "0xB5E6")]
		private bool TryGetCurrent(long timestamp, out SkinPackageDic package)
		{
		/* --- GHIDRA: TryGetCurrent ---
		uint Core_Gameplay_Managers_Skins_SkinManager__TryGetCurrent
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_01;
		  int *param1_02;
		  
		  if (DAT_ram_00a638d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_SkinPackageDic_Types_Skin__Skin___);
		    Mono_Security_ASN1__get_Item(&System_Func_SkinPackageDic_Types_Skin__Skin__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_Skin__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Skin__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Skin__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Skins_SkinManager__TryGetSkins_b__32_0__);
		    DAT_ram_00a638d0 = '\x01';
		  }
		  if (0 < *(int *)(*(int *)(param1 + 0x20) + 0xc)) {
		    *param3 = *(int *)(param1 + 0x20);
		    return 1;
		  }
		  *param3 = 0;
		  if (param2 == 0) {
		    uVar1 = 0;
		  }
		  else {
		    param1_01 = *(undefined4 *)(param2 + 0x38);
		    param1_00 = unnamed_function_1417(System_Func_SkinPackageDic_Types_Skin__Skin__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_00,param1,
		               Method_Core_Gameplay_Managers_Skins_SkinManager__TryGetSkins_b__32_0__,0);
		    iVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (param1_01,param1_00,
		                       Method_System_Linq_Enumerable_Select_SkinPackageDic_Types_Skin__Skin___);
		    if (iVar2 == 0) {
		      uVar1 = 0;
		    }
		    else {
		      uVar1 = 0;
		      func_ii_6335(*(undefined4 *)(param1 + 0x20),iVar2,
		                   Method_System_Collections_Generic_List_Skin__AddRange__);
		      param1_02 = *(int **)(param1 + 0x20);
		      *param3 = (int)param1_02;
		      iVar2 = *param1_02;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_ICollection_Skin__TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x82311768;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_02,System_Collections_Generic_ICollection_Skin__TypeInfo,
		                                    0);
		code_r0x82311768:
		      iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_02,puVar3[1]);
		      uVar1 = (uint)(0 < iVar2);
		    }
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x00013AE8 File Offset: 0x00011CE8
		[Token(Token = "0x6006AD5")]
		[Address(RVA = "0xB5E7", Offset = "0xB5E7", VA = "0xB5E7")]
		private bool TryGetSkins([CanBeNull] SkinPackageDic package, out IList<Skin> skins)
		{
		/* --- GHIDRA: TryGetSkins ---
		int Core_Gameplay_Managers_Skins_SkinManager__TryGetSkins
		              (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a638d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_AssetDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_Skin__AssetDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_AssetDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_Skin__AssetDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Skins_SkinManager___c__TryGetAssets_b__33_0__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo);
		    DAT_ram_00a638d1 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Core_Gameplay_Managers_Skins_SkinManager__TryGetCurrent
		                    (param1,*(undefined4 *)(param1 + 0x28),&local_4,auStack_10);
		  uVar5 = local_4;
		  iVar4 = Method_System_Array_Empty_AssetDic___;
		  if (iVar1 == 0) {
		    iVar3 = *(int *)(Method_System_Array_Empty_AssetDic___ + 0x1c);
		    if (iVar3 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_AssetDic___);
		      iVar3 = *(int *)(iVar4 + 0x1c);
		    }
		    iVar3 = *(int *)(iVar3 + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    if (*(int *)(iVar3 + 0x74) == 0) {
		      func_ii_306000(iVar3);
		    }
		    iVar4 = *(int *)(*(int *)(iVar4 + 0x1c) + 8);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    uVar5 = **(undefined4 **)(iVar4 + 0x5c);
		  }
		  else {
		    if (*(int *)(Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo + 0x5c);
		    iVar4 = puVar2[1];
		    if (iVar4 == 0) {
		      if (*(int *)(Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar2;
		      iVar4 = unnamed_function_1417(System_Func_Skin__AssetDic__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar4,param2_00,
		                 Method_Core_Gameplay_Managers_Skins_SkinManager___c__TryGetAssets_b__33_0__,0);
		      *(int *)(*(int *)(Core_Gameplay_Managers_Skins_SkinManager___c_TypeInfo + 0x5c) + 4) = iVar4;
		    }
		    uVar5 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (uVar5,iVar4,Method_System_Linq_Enumerable_Select_Skin__AssetDic___);
		    uVar5 = func_ii_6295(uVar5,Method_System_Linq_Enumerable_ToArray_AssetDic___);
		  }
		  *param2 = uVar5;
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00013B00 File Offset: 0x00011D00
		[Token(Token = "0x6006AD6")]
		[Address(RVA = "0xB5E8", Offset = "0xB5E8", VA = "0xB5E8")]
		public bool TryGetAssets(out AssetDic[] assets)
		{
		/* --- GHIDRA: TryGetAssets ---
		void Core_Gameplay_Managers_Skins_SkinManager__TryGetAssets(undefined4 param1,undefined4 param2)
		
		{
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___SkinManager__HandleDictChangedEvent_d__28_
		            (param1,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x00013B18 File Offset: 0x00011D18
		[Token(Token = "0x6006AD7")]
		[Address(RVA = "0x37C7", Offset = "0x37C7", VA = "0x37C7")]
		public bool TryGetSkin(string assetName, out Skin skin)
		{
		/* --- GHIDRA: TryGetSkin ---
		void Core_Gameplay_Managers_Skins_SkinManager__TryGetSkin(int param1,int param2,int param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5cdc8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Skin__TypeInfo);
		    DAT_ram_00a5cdc8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  if (param1_00 != param2) {
		    *(int *)(param1 + 0x1c) = param2;
		    if (param2 != 0) {
		      uVar1 = unnamed_function_1417(System_Action_Skin__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar1,param1,*(undefined4 *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x30),0);
		      Core_Gameplay_Managers_Tutorial_Guide_TutorialGuideManger___ctor(param2,uVar1,0);
		    }
		    if (param1_00 != 0) {
		      uVar1 = unnamed_function_1417(System_Action_Skin__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar1,param1,*(undefined4 *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x30),0);
		      Core_Gameplay_Managers_Skins_Skin__add_StopEvent(param1_00,uVar1,0);
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AD8")]
		[Address(RVA = "0xB5E9", Offset = "0xB5E9", VA = "0xB5E9")]
		public void RePlane()
		{
		/* --- GHIDRA: RePlane ---
		undefined4
		Core_Gameplay_Managers_Skins_SkinManager__RePlane(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param3_00;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a638d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a638d3 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x82311a5f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82311a5f:
		  uVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		  uVar2 = Core_Gameplay_Managers_DictManager__CheckSupportedService
		                    (uVar2,*(undefined4 *)(*(int *)(param2 + 0x14) + 0x10),param3_00);
		  uVar2 = Core_Gameplay_Managers_Skins_Skin__IsFit(param3_00,param2,uVar2,param3_00);
		  return uVar2;
		}
		*/

		}

		// Token: 0x04003875 RID: 14453
		[Token(Token = "0x4003875")]
		[FieldOffset(Offset = "0x14")]
		[NotNull]
		private readonly CancellationTokenSource _cancellationTokenSource;

		// Token: 0x04003876 RID: 14454
		[Token(Token = "0x4003876")]
		[FieldOffset(Offset = "0x18")]
		[NotNull]
		private readonly DelayedCall _delayedCall;

		// Token: 0x04003877 RID: 14455
		[Token(Token = "0x4003877")]
		[FieldOffset(Offset = "0x1C")]
		[NotNull]
		private readonly IGame _game;

		// Token: 0x04003878 RID: 14456
		[Token(Token = "0x4003878")]
		[FieldOffset(Offset = "0x20")]
		[NotNull]
		private readonly List<Skin> _currentSkins;

		// Token: 0x04003879 RID: 14457
		[Token(Token = "0x4003879")]
		[FieldOffset(Offset = "0x24")]
		[NotNull]
		private readonly Skin.Factory _skinFactory;

		// Token: 0x0400387A RID: 14458
		[Token(Token = "0x400387A")]
		[FieldOffset(Offset = "0x28")]
		[CanBeNull]
		private SkinPackageDic _currentPackage;

		// Token: 0x0400387B RID: 14459
		[Token(Token = "0x400387B")]
		[FieldOffset(Offset = "0x2C")]
		private readonly float _nearestPackageDeltaTime;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Skins_SkinManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SkinManager__TypeInfo);
		    DAT_ram_00a638c2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_SkinManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SkinManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_SkinChangedEvent ---
		void Core_Gameplay_Managers_Skins_SkinManager__add_SkinChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SkinManager__TypeInfo);
		    DAT_ram_00a638c3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_SkinManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SkinManager__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_SkinChangedEvent ---
		void Core_Gameplay_Managers_Skins_SkinManager__remove_SkinChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638c4 = '\x01';
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_Skins_SkinManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638c5 = '\x01';
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_Skins_SkinManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638c6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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
		void Core_Gameplay_Managers_Skins_SkinManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a638c7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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


		/* --- GHIDRA: set_IsDisposed ---
		void Core_Gameplay_Managers_Skins_SkinManager__set_IsDisposed
		               (int param1,undefined4 param2,undefined4 param3,float param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a638c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_DelayedCall_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Skin___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Skin__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Skins_SkinManager_ScheduledCallBack__);
		    DAT_ram_00a638c8 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(uVar1,0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_Skin__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_Skin___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  *(float *)(param1 + 0x2c) = param4;
		  *(undefined4 *)(param1 + 0x24) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Gameplay_Managers_Skins_SkinManager_ScheduledCallBack__,0);
		  param1_00 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,uVar1,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/

}
