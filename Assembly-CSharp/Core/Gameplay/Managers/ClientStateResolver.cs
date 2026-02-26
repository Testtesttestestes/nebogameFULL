using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DefaultNamespace;
using Il2CppDummyDll;
using Protocol.Main;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001150 RID: 4432
	[Token(Token = "0x2001150")]
	public class ClientStateResolver : IGameManager, IBaseManager
	{
		// Token: 0x14000273 RID: 627
		// (add) Token: 0x0600686F RID: 26735 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006870 RID: 26736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000273")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600686F")]
			[Address(RVA = "0xB39A", Offset = "0xB39A", VA = "0xB39A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006870")]
			[Address(RVA = "0xB39B", Offset = "0xB39B", VA = "0xB39B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000274 RID: 628
		// (add) Token: 0x06006871 RID: 26737 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006872 RID: 26738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000274")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006871")]
			[Address(RVA = "0xB39C", Offset = "0xB39C", VA = "0xB39C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006872")]
			[Address(RVA = "0xB39D", Offset = "0xB39D", VA = "0xB39D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001563")]
		public string Name
		{
			[Token(Token = "0x6006873")]
			[Address(RVA = "0xB39E", Offset = "0xB39E", VA = "0xB39E", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06006874 RID: 26740 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006875 RID: 26741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001564")]
		public IGame Game
		{
			[Token(Token = "0x6006874")]
			[Address(RVA = "0xB39F", Offset = "0xB39F", VA = "0xB39F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006875")]
			[Address(RVA = "0xB3A0", Offset = "0xB3A0", VA = "0xB3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006876")]
		[Address(RVA = "0xB3A1", Offset = "0xB3A1", VA = "0xB3A1")]
		public ClientStateResolver(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_ClientStateResolver___ctor(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a5a9fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_ClientStates___);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateResolver_IClientStateHandler_TypeInfo);
		    DAT_ram_00a5a9fd = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar3 + iVar6 * 4 + 0x10);
		      iVar3 = Core_Data_RewardData__get_RewardId
		                        (*(undefined4 *)(iVar4 + 8),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Linq_Enumerable_Contains_ClientStates___);
		      if (iVar3 != 0) {
		        param1_00 = (int *)0x0;
		        iVar4 = func_ii_2006(*(undefined4 *)(iVar4 + 0xc),0);
		        iVar3 = Core_Gameplay_Managers_ClientStateResolver_IClientStateHandler_TypeInfo;
		        uVar5 = *(undefined4 *)(param1 + 0x1c);
		        if ((iVar4 != 0) &&
		           (param1_00 = (int *)func_ii_1082(iVar4,
		                                            Core_Gameplay_Managers_ClientStateResolver_IClientStateHandler_TypeInfo
		                                           ), param1_00 == (int *)0x0)) {
		          System_Activator__CreateInstance(iVar4,iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = *param1_00;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		            if (iVar3 == *piVar7) {
		              puVar2 = (uint *)(iVar4 + piVar7[1] * 8 + 0xc0);
		              goto code_r0x812a7745;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param1_00,iVar3,0);
		code_r0x812a7745:
		        (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar5,param2,puVar2[1]);
		      }
		      iVar6 = iVar6 + 1;
		      iVar3 = *(int *)(param1 + 0x14);
		    } while (iVar6 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006877 RID: 26743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006877")]
		[Address(RVA = "0xB3A2", Offset = "0xB3A2", VA = "0xB3A2")]
		private void HandleClientStateChanged(ProtoGetClientStateAns state)
		{
		/* --- GHIDRA: HandleClientStateChanged ---
		void Core_Gameplay_Managers_ClientStateResolver__HandleClientStateChanged
		               (int param1,undefined4 param2)
		
		{
		  char cVar1;
		  bool bVar2;
		  uint uVar3;
		  uint *puVar4;
		  int iVar5;
		  int param2_00;
		  int iVar6;
		  undefined4 param1_00;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  
		  if (DAT_ram_00a5a9fe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClientStateResolver_ClientStateChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClientStateResolver_SceneManagerOnSceneUnloadedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a9fe = '\x01';
		  }
		  piVar7 = *(int **)(param1 + 0x1c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8 + 4) * 8 + iVar8 + 0x180);
		        goto code_r0x812a7829;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x18);
		code_r0x812a7829:
		  iVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  param2_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo
		                        );
		  iVar8 = Method_Core_Gameplay_Managers_ClientStateResolver_ClientStateChangedEventHandler__;
		  uVar9 = *(undefined4 *)
		           (Method_Core_Gameplay_Managers_ClientStateResolver_ClientStateChangedEventHandler__ + 4);
		  *(int *)(param2_00 + 0x14) =
		       Method_Core_Gameplay_Managers_ClientStateResolver_ClientStateChangedEventHandler__;
		  *(undefined4 *)(param2_00 + 8) = uVar9;
		  *(int *)(param2_00 + 0x10) = param1;
		  cVar1 = *(char *)(iVar8 + 0x2e);
		  *(int *)(param2_00 + 0x20) = param2_00;
		  iVar8 = func_ii_4538(iVar8);
		  if (iVar8 == 0) {
		    if (cVar1 == '\x01') {
		      *(char **)(param2_00 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x54;
		    }
		    else {
		      if (param1 == 0) {
		        uVar9 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar9,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param2_00 + 0xc) = *(undefined4 *)(param2_00 + 8);
		      *(undefined4 *)(param2_00 + 0x20) = *(undefined4 *)(param2_00 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param2_00 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x53;
		  }
		  else {
		    *(undefined4 *)(param2_00 + 0xc) = *(undefined4 *)(param2_00 + 8);
		    *(undefined4 *)(param2_00 + 0x20) = *(undefined4 *)(param2_00 + 0x10);
		  }
		  *(char **)(param2_00 + 0x1c) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x55;
		  if (DAT_ram_00a5a9ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo);
		    DAT_ram_00a5a9ea = '\x01';
		  }
		  iVar8 = *(int *)(iVar5 + 8);
		  while ((piVar7 = (int *)func_ii_7048(iVar8,param2_00,0), piVar7 == (int *)0x0 ||
		         (Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo == *piVar7))
		        ) {
		    iVar6 = func_ii_4329(iVar5 + 8,piVar7,iVar8);
		    bVar2 = iVar6 == iVar8;
		    iVar8 = iVar6;
		    if (bVar2) {
		      uVar9 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		      param1_00 = unnamed_function_1417(System_Action_string__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Core_Gameplay_Managers_ClientStateResolver_SceneManagerOnSceneUnloadedEvent__
		                 ,0);
		      DefaultNamespace_SceneAppManager__remove_SceneLoadedEvent(uVar9,param1_00,0);
		      uVar9 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		      DefaultNamespace_SceneAppManager__UnloadScene(uVar9,*(undefined4 *)(param1 + 0x18),0);
		      *(undefined4 *)(param1 + 0x1c) = 0;
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (piVar7,Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006878")]
		[Address(RVA = "0xB3A3", Offset = "0xB3A3", VA = "0xB3A3", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_ClientStateResolver__Deinit
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a5a9ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClientStateResolver_SceneManagerOnSceneUnloadedEvent__
		              );
		    DAT_ram_00a5a9ff = '\x01';
		  }
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  param1_01 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Core_Gameplay_Managers_ClientStateResolver_SceneManagerOnSceneUnloadedEvent__,0)
		  ;
		  DefaultNamespace_SceneAppManager__add_SceneUnloadedEvent(param1_00,param1_01,0);
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006879 RID: 26745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006879")]
		[Address(RVA = "0xB3A4", Offset = "0xB3A4", VA = "0xB3A4")]
		private void SceneManagerOnSceneUnloadedEvent(string obj)
		{
		/* --- GHIDRA: SceneManagerOnSceneUnloadedEvent ---
		void Core_Gameplay_Managers_ClientStateResolver__SceneManagerOnSceneUnloadedEvent
		               (int param1,undefined4 param2)
		
		{
		  char cVar1;
		  bool bVar2;
		  uint uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  uint *puVar5;
		  int iVar6;
		  int param2_00;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a5aa00 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClientStateResolver_ClientStateChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClientStateResolver_SceneManagerOnSceneLoaded__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_ClientStates__Contains__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5aa00 = '\x01';
		  }
		  uVar4 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  param1_00 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_ClientStateResolver_SceneManagerOnSceneLoaded__,0);
		  Test_TestCameraController___ctor(uVar4,param1_00,0);
		  piVar8 = *(int **)(param1 + 0x1c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar3 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar3 * 8 + 4) * 8 + iVar9 + 0x180);
		        goto code_r0x812a7b1c;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar3);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x18);
		code_r0x812a7b1c:
		  iVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  param2_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo
		                        );
		  iVar9 = Method_Core_Gameplay_Managers_ClientStateResolver_ClientStateChangedEventHandler__;
		  uVar4 = *(undefined4 *)
		           (Method_Core_Gameplay_Managers_ClientStateResolver_ClientStateChangedEventHandler__ + 4);
		  *(int *)(param2_00 + 0x14) =
		       Method_Core_Gameplay_Managers_ClientStateResolver_ClientStateChangedEventHandler__;
		  *(undefined4 *)(param2_00 + 8) = uVar4;
		  *(int *)(param2_00 + 0x10) = param1;
		  cVar1 = *(char *)(iVar9 + 0x2e);
		  *(int *)(param2_00 + 0x20) = param2_00;
		  iVar9 = func_ii_4538(iVar9);
		  if (iVar9 == 0) {
		    if (cVar1 == '\x01') {
		      *(char **)(param2_00 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x54;
		    }
		    else {
		      if (param1 == 0) {
		        uVar4 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar4,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param2_00 + 0xc) = *(undefined4 *)(param2_00 + 8);
		      *(undefined4 *)(param2_00 + 0x20) = *(undefined4 *)(param2_00 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param2_00 + 0xc) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x53;
		  }
		  else {
		    *(undefined4 *)(param2_00 + 0xc) = *(undefined4 *)(param2_00 + 8);
		    *(undefined4 *)(param2_00 + 0x20) = *(undefined4 *)(param2_00 + 0x10);
		  }
		  *(char **)(param2_00 + 0x1c) = s_struct_Uniforms___color__array<v_ram_0000223f + 0x55;
		  if (DAT_ram_00a5a9e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo);
		    DAT_ram_00a5a9e9 = '\x01';
		  }
		  iVar9 = *(int *)(iVar6 + 8);
		  do {
		    piVar8 = (int *)UnityEngine_UI_Image__set_sprite(iVar9,param2_00,0);
		    if ((piVar8 != (int *)0x0) &&
		       (Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo != *piVar8)) {
		      System_Activator__CreateInstance
		                (piVar8,
		                 Core_Gameplay_Managers_ClientStateManager_ClientStateChangedDelegate_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar7 = func_ii_4329(iVar6 + 8,piVar8,iVar9);
		    bVar2 = iVar7 != iVar9;
		    iVar9 = iVar7;
		  } while (bVar2);
		  uVar3 = 0;
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  piVar8 = *(int **)(param1 + 0x1c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar3 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar3 * 8 + 4) * 8 + iVar9 + 0x180);
		        goto code_r0x812a7cc4;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar3);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x18);
		code_r0x812a7cc4:
		  iVar9 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  iVar9 = Core_Data_Skills_SkillData___ctor
		                    (uVar4,*(undefined4 *)(*(int *)(iVar9 + 0xc) + 0xc),
		                     Method_System_Collections_Generic_HashSet_ClientStates__Contains__);
		  if (iVar9 != 0) {
		    uVar4 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar4,*(undefined4 *)(param1 + 0x18),0);
		  }
		  piVar8 = *(int **)(param1 + 0x1c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar3 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar3 * 8 + 4) * 8 + iVar9 + 0x180);
		        goto code_r0x812a7d6f;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar3);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x18);
		code_r0x812a7d6f:
		  iVar9 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  Core_Gameplay_Managers_ClientStateResolver___ctor(param1,*(undefined4 *)(iVar9 + 0xc),puVar5);
		  return;
		}
		*/

		}

		// Token: 0x0600687A RID: 26746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600687A")]
		[Address(RVA = "0xB3A5", Offset = "0xB3A5", VA = "0xB3A5", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ClientStateResolver__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a5aa01 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClientStateResolver_SceneManagerOnSceneLoaded__);
		    DAT_ram_00a5aa01 = '\x01';
		  }
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  param1_01 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Core_Gameplay_Managers_ClientStateResolver_SceneManagerOnSceneLoaded__,0);
		  DefaultNamespace_SceneAppManager__add_SceneLoadedEvent(param1_00,param1_01,0);
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600687B RID: 26747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600687B")]
		[Address(RVA = "0xB3A6", Offset = "0xB3A6", VA = "0xB3A6")]
		private void SceneManagerOnSceneLoaded(string sceneName)
		{
		/* --- GHIDRA: SceneManagerOnSceneLoaded ---
		void Core_Gameplay_Managers_ClientStateResolver__SceneManagerOnSceneLoaded
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Core_Gameplay_Managers_ClientStateResolver___ctor(param1,param3,param3);
		  return;
		}
		*/

		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600687C")]
		[Address(RVA = "0xB3A7", Offset = "0xB3A7", VA = "0xB3A7")]
		private void ClientStateChangedEventHandler(ProtoGetClientStateAns fromState, ProtoGetClientStateAns toState)
		{
		}

		// Token: 0x04003796 RID: 14230
		[Token(Token = "0x4003796")]
		[FieldOffset(Offset = "0x10")]
		private readonly HashSet<ClientStates> _statesForWorldScene;

		// Token: 0x04003797 RID: 14231
		[Token(Token = "0x4003797")]
		[FieldOffset(Offset = "0x14")]
		private readonly ClientStateResolver.AvailHandlerConfig[] _availClientStateHandlers;

		// Token: 0x04003798 RID: 14232
		[Token(Token = "0x4003798")]
		[FieldOffset(Offset = "0x18")]
		private Scenes[] _scenesToLoad;

		// Token: 0x02001151 RID: 4433
		[Token(Token = "0x2001151")]
		private interface IClientStateHandler
		{
			// Token: 0x0600687D RID: 26749
			[Token(Token = "0x600687D")]
			void Handle(IGame game, ProtoGetClientStateAns state);
		}

		// Token: 0x02001152 RID: 4434
		[Token(Token = "0x2001152")]
		private class AvailHandlerConfig
		{
			// Token: 0x0600687E RID: 26750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600687E")]
			[Address(RVA = "0xB3A8", Offset = "0xB3A8", VA = "0xB3A8")]
			public AvailHandlerConfig(ClientStates[] states, Type typeOfHandler)
			{
			}

			// Token: 0x0400379A RID: 14234
			[Token(Token = "0x400379A")]
			[FieldOffset(Offset = "0x8")]
			public readonly ClientStates[] States;

			// Token: 0x0400379B RID: 14235
			[Token(Token = "0x400379B")]
			[FieldOffset(Offset = "0xC")]
			public readonly Type TypeOfHandler;
		}

		// Token: 0x02001153 RID: 4435
		[Token(Token = "0x2001153")]
		private class CombatStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x0600687F RID: 26751 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600687F")]
			[Address(RVA = "0xB3A9", Offset = "0xB3A9", VA = "0xB3A9", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006880 RID: 26752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006880")]
			[Address(RVA = "0xB3AA", Offset = "0xB3AA", VA = "0xB3AA")]
			public CombatStateHandler()
			{
			}
		}

		// Token: 0x02001154 RID: 4436
		[Token(Token = "0x2001154")]
		private class ThemeDuelStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006881 RID: 26753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006881")]
			[Address(RVA = "0xB3AB", Offset = "0xB3AB", VA = "0xB3AB", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006882 RID: 26754 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006882")]
			[Address(RVA = "0xB3AC", Offset = "0xB3AC", VA = "0xB3AC")]
			public ThemeDuelStateHandler()
			{
			}
		}

		// Token: 0x02001155 RID: 4437
		[Token(Token = "0x2001155")]
		private class PortalCombatStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006883 RID: 26755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006883")]
			[Address(RVA = "0xB3AD", Offset = "0xB3AD", VA = "0xB3AD", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006884 RID: 26756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006884")]
			[Address(RVA = "0xB3AE", Offset = "0xB3AE", VA = "0xB3AE")]
			public PortalCombatStateHandler()
			{
			}
		}

		// Token: 0x02001156 RID: 4438
		[Token(Token = "0x2001156")]
		private class ColossusCombatHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006885 RID: 26757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006885")]
			[Address(RVA = "0xB3AF", Offset = "0xB3AF", VA = "0xB3AF", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006886 RID: 26758 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006886")]
			[Address(RVA = "0xB3B0", Offset = "0xB3B0", VA = "0xB3B0")]
			public ColossusCombatHandler()
			{
			}
		}

		// Token: 0x02001157 RID: 4439
		[Token(Token = "0x2001157")]
		private class PartyCombatHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006887 RID: 26759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006887")]
			[Address(RVA = "0xB3B1", Offset = "0xB3B1", VA = "0xB3B1", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006888 RID: 26760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006888")]
			[Address(RVA = "0xB3B2", Offset = "0xB3B2", VA = "0xB3B2")]
			public PartyCombatHandler()
			{
			}
		}

		// Token: 0x02001158 RID: 4440
		[Token(Token = "0x2001158")]
		private class AdeptsTournamentStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006889 RID: 26761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006889")]
			[Address(RVA = "0xB3B3", Offset = "0xB3B3", VA = "0xB3B3", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x0600688A RID: 26762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688A")]
			[Address(RVA = "0xB3B4", Offset = "0xB3B4", VA = "0xB3B4")]
			public AdeptsTournamentStateHandler()
			{
			}
		}

		// Token: 0x02001159 RID: 4441
		[Token(Token = "0x2001159")]
		private class GladiatorsTournamentStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x0600688B RID: 26763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688B")]
			[Address(RVA = "0xB3B5", Offset = "0xB3B5", VA = "0xB3B5", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x0600688C RID: 26764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688C")]
			[Address(RVA = "0xB3B6", Offset = "0xB3B6", VA = "0xB3B6")]
			public GladiatorsTournamentStateHandler()
			{
			}
		}

		// Token: 0x0200115A RID: 4442
		[Token(Token = "0x200115A")]
		private class HordeStateHandler : ClientStateResolver.IClientStateHandler, IDisposable
		{
			// Token: 0x0600688D RID: 26765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688D")]
			[Address(RVA = "0xB3B7", Offset = "0xB3B7", VA = "0xB3B7", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x0600688E RID: 26766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688E")]
			[Address(RVA = "0xB3B8", Offset = "0xB3B8", VA = "0xB3B8")]
			private void CurrentIsleChangedEventHandler(ulong userId)
			{
			}

			// Token: 0x0600688F RID: 26767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600688F")]
			[Address(RVA = "0xB3B9", Offset = "0xB3B9", VA = "0xB3B9", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x06006890 RID: 26768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006890")]
			[Address(RVA = "0xB3BA", Offset = "0xB3BA", VA = "0xB3BA")]
			public HordeStateHandler()
			{
			}

			// Token: 0x0400379C RID: 14236
			[Token(Token = "0x400379C")]
			[FieldOffset(Offset = "0x8")]
			private IGame _game;
		}

		// Token: 0x0200115B RID: 4443
		[Token(Token = "0x200115B")]
		private class DuelStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006891 RID: 26769 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006891")]
			[Address(RVA = "0xB3BB", Offset = "0xB3BB", VA = "0xB3BB", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006892 RID: 26770 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006892")]
			[Address(RVA = "0xB3BC", Offset = "0xB3BC", VA = "0xB3BC")]
			public DuelStateHandler()
			{
			}
		}

		// Token: 0x0200115C RID: 4444
		[Token(Token = "0x200115C")]
		private class WaitingForMinionBattleStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006893 RID: 26771 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006893")]
			[Address(RVA = "0xB3BD", Offset = "0xB3BD", VA = "0xB3BD", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006894 RID: 26772 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006894")]
			[Address(RVA = "0xB3BE", Offset = "0xB3BE", VA = "0xB3BE")]
			public WaitingForMinionBattleStateHandler()
			{
			}
		}

		// Token: 0x0200115D RID: 4445
		[Token(Token = "0x200115D")]
		private class IdleStateHandler : ClientStateResolver.IClientStateHandler
		{
			// Token: 0x06006895 RID: 26773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006895")]
			[Address(RVA = "0xB3BF", Offset = "0xB3BF", VA = "0xB3BF", Slot = "4")]
			public void Handle(IGame game, ProtoGetClientStateAns state)
			{
			}

			// Token: 0x06006896 RID: 26774 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006896")]
			[Address(RVA = "0xB3C0", Offset = "0xB3C0", VA = "0xB3C0")]
			public IdleStateHandler()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_ClientStateResolver__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9f8 = '\x01';
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
		void Core_Gameplay_Managers_ClientStateResolver__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9f9 = '\x01';
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
		void Core_Gameplay_Managers_ClientStateResolver__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9fa = '\x01';
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		undefined4
		Core_Gameplay_Managers_ClientStateResolver__remove_DeinitCompleteEvent
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a9fb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5487);
		    DAT_ram_00a5a9fb = '\x01';
		  }
		  return StringLiteral_5487;
		}
		*/


		/* --- GHIDRA: set_Game ---
		void Core_Gameplay_Managers_ClientStateResolver__set_Game
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a9fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateResolver_AdeptsTournamentStateHandler_var);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ClientStates___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateResolver_ColossusCombatHandler_var);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClientStateResolver_CombatStateHandler_var)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClientStateResolver_DuelStateHandler_var);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateResolver_GladiatorsTournamentStateHandler_var);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ClientStates__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ClientStates___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_ClientStates__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClientStateResolver_HordeStateHandler_var);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClientStateResolver_IdleStateHandler_var);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClientStateResolver_PartyCombatHandler_var)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateResolver_PortalCombatStateHandler_var);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateResolver_ThemeDuelStateHandler_var);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClientStateResolver_WaitingForMinionBattleStateHandler_var);
		    DAT_ram_00a5a9fc = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_ClientStates__TypeInfo);
		  System_Collections_Generic_HashSet_int___get_Count
		            (uVar1,Method_System_Collections_Generic_HashSet_ClientStates___ctor__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,4,Method_System_Collections_Generic_HashSet_ClientStates__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,3,Method_System_Collections_Generic_HashSet_ClientStates__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,6,Method_System_Collections_Generic_HashSet_ClientStates__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,7,Method_System_Collections_Generic_HashSet_ClientStates__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,0xb,Method_System_Collections_Generic_HashSet_ClientStates__Add__);
		  System_Collections_Generic_HashSet_Enumerator_Int32Enum___MoveNext
		            (uVar1,5,Method_System_Collections_Generic_HashSet_ClientStates__Add__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  piVar2 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig___TypeInfo
		                             ,0xb);
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 2;
		  uVar1 = Core_Gameplay_Managers_ClientStateResolver_CombatStateHandler_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar1 = func_ii_2734(uVar1,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[4] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 8;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_PartyCombatHandler_var,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[5] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 10;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_ColossusCombatHandler_var,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[6] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,2);
		  *(undefined8 *)(iVar3 + 0x10) = 0x600000003;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_GladiatorsTournamentStateHandler_var
		                       ,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[7] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 4;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_AdeptsTournamentStateHandler_var,0
		                      );
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[8] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 0xb;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_HordeStateHandler_var,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[9] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 5;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_DuelStateHandler_var,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[10] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 0xc;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_ThemeDuelStateHandler_var,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0xb] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 0xd;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_PortalCombatStateHandler_var,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0xc] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,2);
		  *(undefined4 *)(iVar3 + 0x10) = 1;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_IdleStateHandler_var,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0xd] = iVar4;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Main_ClientStates___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 7;
		  uVar1 = func_ii_2734(Core_Gameplay_Managers_ClientStateResolver_WaitingForMinionBattleStateHandler_var
		                       ,0);
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_ClientStateResolver_AvailHandlerConfig_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(iVar4,iVar3,uVar1,0);
		  if ((iVar4 != 0) && (iVar3 = func_ii_1082(iVar4,*(undefined4 *)(*piVar2 + 0x20)), iVar3 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[0xe] = iVar4;
		  *(int **)(param1 + 0x14) = piVar2;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) = 2;
		  *(int *)(param1 + 0x18) = iVar3;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  return;
		}
		*/

}
