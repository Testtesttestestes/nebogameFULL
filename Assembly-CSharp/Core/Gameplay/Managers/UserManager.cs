using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.User.Controller;
using Gameplay.User.Events;
using Gameplay.User.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Utils.Accumulators;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117E RID: 4478
	[Token(Token = "0x200117E")]
	public class UserManager : IGameManager, IBaseManager
	{
		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06006A1F RID: 27167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B7")]
		public string Name
		{
			[Token(Token = "0x6006A1F")]
			[Address(RVA = "0xB53F", Offset = "0xB53F", VA = "0xB53F", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002A8 RID: 680
		// (add) Token: 0x06006A20 RID: 27168 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A21 RID: 27169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A8")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A20")]
			[Address(RVA = "0xB540", Offset = "0xB540", VA = "0xB540", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A21")]
			[Address(RVA = "0xB541", Offset = "0xB541", VA = "0xB541", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A9 RID: 681
		// (add) Token: 0x06006A22 RID: 27170 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A23 RID: 27171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A9")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A22")]
			[Address(RVA = "0xB542", Offset = "0xB542", VA = "0xB542", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A23")]
			[Address(RVA = "0xB543", Offset = "0xB543", VA = "0xB543", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06006A24 RID: 27172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B8")]
		public UserEvents Events
		{
			[Token(Token = "0x6006A24")]
			[Address(RVA = "0xB544", Offset = "0xB544", VA = "0xB544")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06006A25 RID: 27173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B9")]
		public UserModel Model
		{
			[Token(Token = "0x6006A25")]
			[Address(RVA = "0xB545", Offset = "0xB545", VA = "0xB545")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06006A26 RID: 27174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015BA")]
		public UserController Controller
		{
			[Token(Token = "0x6006A26")]
			[Address(RVA = "0xB546", Offset = "0xB546", VA = "0xB546")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06006A27 RID: 27175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015BB")]
		public UserData User
		{
			[Token(Token = "0x6006A27")]
			[Address(RVA = "0x1BC9", Offset = "0x1BC9", VA = "0x1BC9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A28")]
		[Address(RVA = "0xB547", Offset = "0xB547", VA = "0xB547")]
		public UserManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_UserManager___ctor(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a63868 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_UserManager_HandleGetUser__);
		    DAT_ram_00a63868 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x20);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0x158);
		        goto code_r0x82309adb;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x82309adb:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar2,puVar1[1]);
		  piVar2 = *(int **)(iVar3 + 0x18);
		  uVar6 = 0;
		  param1_00 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (param1_00,param1,Method_Core_Gameplay_Managers_UserManager_HandleGetUser__,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		  piVar4 = *(int **)(param1 + 0x20);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x82309b8f;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82309b8f:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  uVar6 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x160);
		        goto code_r0x82309c13;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0x14);
		code_r0x82309c13:
		  iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  *(undefined8 *)(iVar3 + 0x10) = *(undefined8 *)(*(int *)(*(int *)(iVar5 + 0x14) + 0x30) + 8);
		  uVar6 = 0;
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x82309c9f;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x82309c9f:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar2,param1_00,iVar3,puVar1[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A29")]
		[Address(RVA = "0xB548", Offset = "0xB548", VA = "0xB548", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_UserManager__Init
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63869 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_UserData___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_UserManager_UserEventBusHelper_TypeInfo);
		    DAT_ram_00a63869 = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__Count_object_
		                    (param3,Method_System_Linq_Enumerable_First_UserData___);
		  Core_Gameplay_Managers_UserManager__HandleGetUser(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_UserManager_UserEventBusHelper_TypeInfo);
		  Core_Gameplay_Managers_UserManager__Deinit(uVar1,param1,param1);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2A")]
		[Address(RVA = "0xB549", Offset = "0xB549", VA = "0xB549")]
		private void HandleGetUser(long operationIndex, UserData[] data)
		{
		/* --- GHIDRA: HandleGetUser ---
		void Core_Gameplay_Managers_UserManager__HandleGetUser
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param5;
		  undefined4 param1_00;
		  double param6;
		  int *piVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a6386a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_User_Controller_UserController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_User_Events_UserEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_UserManager_ControllerOnInitEvent__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_User_Model_UserModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17355);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24637);
		    DAT_ram_00a6386a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_LocalProps_TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader___c__DisplayClass4_0___LoadBackground_g__SuccessCallback_1_d_
		            (uVar1,StringLiteral_17355,StringLiteral_1773,0);
		  uVar1 = Utils_LocalProps___ctor(uVar1,0);
		  uVar2 = unnamed_function_1417(Gameplay_User_Events_UserEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar8 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x82309e54;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x82309e54:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = *(undefined4 *)(iVar5 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x82309f03;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82309f03:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  param5 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		                     (*(undefined4 *)(*(int *)(iVar5 + 0x14) + 0x14),StringLiteral_24556,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x82309fc3;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82309fc3:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  param6 = Core_Extensions_Dict_DictExt__GetIntParameter
		                     (*(undefined4 *)(*(int *)(iVar5 + 0x14) + 0x14),StringLiteral_24637,0);
		  param1_00 = unnamed_function_1417(Gameplay_User_Model_UserModel_TypeInfo);
		  Gameplay_User_Model_UserModel__Dispose(param1_00,piVar4,uVar2,uVar1,param5,param6,param2,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(Gameplay_User_Controller_UserController_TypeInfo);
		  Gameplay_User_Events_UserEvents___ctor(uVar1,param1_00,uVar2,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  iVar7 = *(int *)(param1 + 0x10);
		  uVar2 = *(undefined4 *)(iVar7 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Gameplay_Managers_UserManager_ControllerOnInitEvent__,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar1,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar7 + 8) = piVar4, *piVar4 != iVar5))
		  {
		    System_Activator__CreateInstance(piVar4,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2B")]
		[Address(RVA = "0xB54A", Offset = "0xB54A", VA = "0xB54A")]
		private void CreateMvc(UserData user)
		{
		/* --- GHIDRA: CreateMvc ---
		void Core_Gameplay_Managers_UserManager__CreateMvc(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6386b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_UserManager_ControllerOnInitEvent__)
		    ;
		    DAT_ram_00a6386b = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_UserManager_ControllerOnInitEvent__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2C")]
		[Address(RVA = "0xB54B", Offset = "0xB54B", VA = "0xB54B")]
		private void ControllerOnInitEvent()
		{
		/* --- GHIDRA: ControllerOnInitEvent ---
		void Core_Gameplay_Managers_UserManager__ControllerOnInitEvent(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    MVC_AbstractController__Run(*(int *)(param1 + 0x18),0);
		    piVar1 = *(int **)(param1 + 0x18);
		    if (piVar1 != (int *)0x0) {
		      (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))
		                (piVar1,*(undefined4 *)(*piVar1 + 0xec));
		    }
		  }
		  piVar1 = *(int **)(param1 + 0x14);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  if (*(int *)(param1 + 0x1c) != 0) {
		    Core_Gameplay_Managers_UserManager_UserEventBusHelper__UserOnOnUserBalanceChangedEvent
		              (*(int *)(param1 + 0x1c),param1);
		  }
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  iVar2 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A2D")]
		[Address(RVA = "0xB54C", Offset = "0xB54C", VA = "0xB54C", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_UserManager__Deinit(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a6386c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UserScope_BaseUserEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_AccountsOnAccountsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_BuyTreeLicenceSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnTriggerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserAprChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserBalanceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserCultChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserExperienceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserGenderChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserLevelChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserLicenseCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserNickChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnUserSkillsChangedEvent__
		              );
		    DAT_ram_00a6386c = '\x01';
		  }
		  *(int *)(param1 + 0xc) = param2;
		  if (*(int *)(param2 + 0x14) != 0) {
		    uVar1 = *(undefined4 *)(*(int *)(param2 + 0x14) + 8);
		  }
		  *(undefined4 *)(param1 + 8) = uVar1;
		  uVar2 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar2,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserBalanceChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserInfoChangedEvent(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(param1 + 8),0);
		  uVar2 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar2,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnTriggerChangedEvent__
		             ,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___Invoke
		            (uVar1,uVar2,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		  uVar2 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserNickChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_BalanceChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnUserSkillsChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserTreeLevelChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417(System_Action_CultDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserCultChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserAprChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserGenderChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserCultChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserAprChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserLevelChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserLevelChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_UserSkillsChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserExperienceChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserNickChangedEvent(uVar2,uVar1,0);
		  uVar1 = func_ii_7504(*(undefined4 *)(param1 + 8),0);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_AccountsOnAccountsChangedEvent__
		             ,0);
		  Core_Data_Accounts_AccountData___ctor(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417(System_Action_uint__uint__TypeInfo);
		  System_Action_PhysicsScene__NativeArray_ModifiableContactPair____Invoke
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_UserOnOnUserLicenseCountChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserExperienceChangedEvent(uVar2,uVar1,0);
		  iVar4 = *(int *)(*(int *)(param1 + 0xc) + 0x10);
		  uVar2 = *(undefined4 *)(iVar4 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_UserManager_UserEventBusHelper_BuyTreeLicenceSuccessEvent__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar4 + 0x18) = param1_00, *param1_00 != iVar3)) {
		    System_Activator__CreateInstance(param1_00,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = System_Uri___ctor(0);
		  iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x38) + 0x10) + 0xc) + 0xc);
		  if (iVar3 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param4 = *(undefined4 *)(param1 + 8);
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar2 = unnamed_function_1417(Core_Events_Scopes_UserScope_BaseUserEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar2,uVar1,param3_00,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04003837 RID: 14391
		[Token(Token = "0x4003837")]
		[FieldOffset(Offset = "0x10")]
		private UserEvents _events;

		// Token: 0x04003838 RID: 14392
		[Token(Token = "0x4003838")]
		[FieldOffset(Offset = "0x14")]
		private UserModel _model;

		// Token: 0x04003839 RID: 14393
		[Token(Token = "0x4003839")]
		[FieldOffset(Offset = "0x18")]
		private UserController _controller;

		// Token: 0x0400383A RID: 14394
		[Token(Token = "0x400383A")]
		[FieldOffset(Offset = "0x1C")]
		private UserManager.UserEventBusHelper _userEventBusHelper;

		// Token: 0x0400383B RID: 14395
		[Token(Token = "0x400383B")]
		[FieldOffset(Offset = "0x20")]
		private IGame _game;

		// Token: 0x0200117F RID: 4479
		[Token(Token = "0x200117F")]
		public class UserEventBusHelper : IDisposable
		{
			// Token: 0x06006A2E RID: 27182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A2E")]
			[Address(RVA = "0xB54D", Offset = "0xB54D", VA = "0xB54D")]
			public UserEventBusHelper(UserManager userManager)
			{
			}

			// Token: 0x06006A2F RID: 27183 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A2F")]
			[Address(RVA = "0xB54E", Offset = "0xB54E", VA = "0xB54E")]
			private void BuyTreeLicenceSuccessEvent()
			{
			}

			// Token: 0x06006A30 RID: 27184 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A30")]
			[Address(RVA = "0xB54F", Offset = "0xB54F", VA = "0xB54F")]
			private void UserOnOnUserLicenseCountChangedEvent(uint arg1, uint arg2)
			{
			}

			// Token: 0x06006A31 RID: 27185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A31")]
			[Address(RVA = "0xB550", Offset = "0xB550", VA = "0xB550")]
			private void AccountsOnAccountsChangedEvent()
			{
			}

			// Token: 0x06006A32 RID: 27186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A32")]
			[Address(RVA = "0xB551", Offset = "0xB551", VA = "0xB551")]
			private void UserOnOnUserExperienceChangedEvent()
			{
			}

			// Token: 0x06006A33 RID: 27187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A33")]
			[Address(RVA = "0xB552", Offset = "0xB552", VA = "0xB552")]
			private void UserOnOnUserLevelChangedEvent()
			{
			}

			// Token: 0x06006A34 RID: 27188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A34")]
			[Address(RVA = "0xB553", Offset = "0xB553", VA = "0xB553")]
			private void UserOnOnUserAprChangedEvent(AprDicWrapper apr)
			{
			}

			// Token: 0x06006A35 RID: 27189 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A35")]
			[Address(RVA = "0xB554", Offset = "0xB554", VA = "0xB554")]
			private void UserOnOnUserGenderChangedEvent()
			{
			}

			// Token: 0x06006A36 RID: 27190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A36")]
			[Address(RVA = "0xB555", Offset = "0xB555", VA = "0xB555")]
			private void UserOnOnUserCultChangedEvent(CultDic obj)
			{
			}

			// Token: 0x06006A37 RID: 27191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A37")]
			[Address(RVA = "0xB556", Offset = "0xB556", VA = "0xB556")]
			private void UserOnUserSkillsChangedEvent()
			{
			}

			// Token: 0x06006A38 RID: 27192 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A38")]
			[Address(RVA = "0xB557", Offset = "0xB557", VA = "0xB557")]
			private void UserOnOnUserNickChangedEvent()
			{
			}

			// Token: 0x06006A39 RID: 27193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A39")]
			[Address(RVA = "0xB558", Offset = "0xB558", VA = "0xB558")]
			private void UserOnOnTriggerChangedEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
			{
			}

			// Token: 0x06006A3A RID: 27194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A3A")]
			[Address(RVA = "0xB559", Offset = "0xB559", VA = "0xB559")]
			private void UserOnOnUserBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
			{
			}

			// Token: 0x06006A3B RID: 27195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006A3B")]
			[Address(RVA = "0xB55A", Offset = "0xB55A", VA = "0xB55A", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0400383C RID: 14396
			[Token(Token = "0x400383C")]
			[FieldOffset(Offset = "0x8")]
			private UserData _user;

			// Token: 0x0400383D RID: 14397
			[Token(Token = "0x400383D")]
			[FieldOffset(Offset = "0xC")]
			private UserManager _userManager;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_UserManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63864 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63864 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_UserManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63865 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63865 = '\x01';
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_UserManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63866 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63866 = '\x01';
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
		void Core_Gameplay_Managers_UserManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63867 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63867 = '\x01';
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


		/* --- GHIDRA: get_User ---
		int Core_Gameplay_Managers_UserManager__get_User(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a607fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_Accumulators_TriggersAccumulator_TypeInfo);
		    DAT_ram_00a607fe = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(Utils_Accumulators_TriggersAccumulator_TypeInfo);
		    Utils_Accumulators_CallAccumulator__RunTimer_d__8__SetStateMachine(param1_00,0.1,0);
		    *(int *)(param1 + 0x3c) = param1_00;
		  }
		  return param1_00;
		}
		*/

}
