using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Gameplay.Portals;
using Gameplay.Portals.Controller;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001171 RID: 4465
	[Token(Token = "0x2001171")]
	public class PortalsManager : IGameManager, IBaseManager, IPortal, IBalance, IMonsterSource
	{
		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06006975 RID: 26997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001593")]
		public string Name
		{
			[Token(Token = "0x6006975")]
			[Address(RVA = "0xB495", Offset = "0xB495", VA = "0xB495", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000290 RID: 656
		// (add) Token: 0x06006976 RID: 26998 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006977 RID: 26999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000290")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006976")]
			[Address(RVA = "0xB496", Offset = "0xB496", VA = "0xB496", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006977")]
			[Address(RVA = "0xB497", Offset = "0xB497", VA = "0xB497", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000291 RID: 657
		// (add) Token: 0x06006978 RID: 27000 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006979 RID: 27001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000291")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006978")]
			[Address(RVA = "0xB498", Offset = "0xB498", VA = "0xB498", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006979")]
			[Address(RVA = "0xB499", Offset = "0xB499", VA = "0xB499", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x0600697A RID: 27002 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600697B RID: 27003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001594")]
		public PortalsModel Model
		{
			[Token(Token = "0x600697A")]
			[Address(RVA = "0xB49A", Offset = "0xB49A", VA = "0xB49A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600697B")]
			[Address(RVA = "0xB49B", Offset = "0xB49B", VA = "0xB49B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x0600697C RID: 27004 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600697D RID: 27005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001595")]
		public PortalsEvents Events
		{
			[Token(Token = "0x600697C")]
			[Address(RVA = "0xB49C", Offset = "0xB49C", VA = "0xB49C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600697D")]
			[Address(RVA = "0xB49D", Offset = "0xB49D", VA = "0xB49D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x0600697E RID: 27006 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600697F RID: 27007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001596")]
		public PortalsController Controller
		{
			[Token(Token = "0x600697E")]
			[Address(RVA = "0xB49E", Offset = "0xB49E", VA = "0xB49E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600697F")]
			[Address(RVA = "0xB49F", Offset = "0xB49F", VA = "0xB49F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06006980 RID: 27008 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006981 RID: 27009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001597")]
		public IGame Game
		{
			[Token(Token = "0x6006980")]
			[Address(RVA = "0xB4A0", Offset = "0xB4A0", VA = "0xB4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006981")]
			[Address(RVA = "0xB4A1", Offset = "0xB4A1", VA = "0xB4A1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006982")]
		[Address(RVA = "0xB4A2", Offset = "0xB4A2", VA = "0xB4A2")]
		public PortalsManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_PortalsManager___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x18),0);
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 0x18) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006983")]
		[Address(RVA = "0xB4A3", Offset = "0xB4A3", VA = "0xB4A3", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_PortalsManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a63809 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Events_PortalsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_PortalsManager_InitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_PortalsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a63809 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Portals_Events_PortalsEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  piVar5 = *(int **)(param1 + 0x1c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x82304a95;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82304a95:
		  uVar2 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  if (*(int *)(iVar6 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 8);
		  }
		  uVar7 = *(undefined4 *)(param1 + 0x1c);
		  uVar4 = unnamed_function_1417(Gameplay_Portals_Model_PortalsModel_TypeInfo);
		  Gameplay_Portals_Model_PortalsModel__GetTabBarItemData(uVar4,uVar2,uVar7,0);
		  *(undefined4 *)(param1 + 0x10) = uVar4;
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar7 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_PortalsService___);
		  param1_00 = unnamed_function_1417(Gameplay_Portals_Controller_PortalsController_TypeInfo);
		  Gameplay_Portals_Controller_PortalsController__get_PortalsService(param1_00,uVar4,uVar2,uVar7,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  iVar8 = *(int *)(param1 + 0x14);
		  uVar4 = *(undefined4 *)(iVar8 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Core_Gameplay_Managers_PortalsManager_InitEvent__,0);
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar8 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar8 + 8) = piVar5, *piVar5 != iVar6))
		  {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06006984 RID: 27012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006984")]
		[Address(RVA = "0xB4A4", Offset = "0xB4A4", VA = "0xB4A4", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_PortalsManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6380a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_PortalsManager_InitEvent__);
		    DAT_ram_00a6380a = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_PortalsManager_InitEvent__,0);
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
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006985 RID: 27013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006985")]
		[Address(RVA = "0xB4A5", Offset = "0xB4A5", VA = "0xB4A5")]
		private void InitEvent()
		{
		/* --- GHIDRA: InitEvent ---
		undefined4 Core_Gameplay_Managers_PortalsManager__InitEvent(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0x3c);
		}
		*/

		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006986")]
		[Address(RVA = "0xB4A6", Offset = "0xB4A6", VA = "0xB4A6", Slot = "11")]
		public PortalDic GetConfig()
		{
		/* --- GHIDRA: GetConfig ---
		void Core_Gameplay_Managers_PortalsManager__GetConfig
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined8 param2_00;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6380b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_ulong__TrySetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_ulong___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_ulong__get_Task__);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_ulong__TypeInfo);
		    DAT_ram_00a6380b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_ulong__TypeInfo)
		  ;
		  param2_00 = Gameplay_Portals_Model_PortalsModel__set_EntryPointBackTime
		                        (*(undefined4 *)(param2 + 0x10),0);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource_ulong___TrySetCanceled
		            (param1_00,param2_00,
		             Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_ulong__TrySetResult__);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource_ulong___UnsafeGetStatus
		            (&local_18,param1_00,
		             Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_ulong__get_Task__);
		  param1[2] = local_8;
		  param1[1] = local_10;
		  *param1 = local_18;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x000139B0 File Offset: 0x00011BB0
		[Token(Token = "0x6006987")]
		[Address(RVA = "0xB4A7", Offset = "0xB4A7", VA = "0xB4A7", Slot = "12")]
		public UniTask<ulong> GetValue()
		{
		/* --- GHIDRA: GetValue ---
		void Core_Gameplay_Managers_PortalsManager__GetValue
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6380c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_PortalsManager___c__DisplayClass30_0__GetMonster_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_PortalsManager___c__DisplayClass30_0_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_PortalMonsterData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_PortalMonsterData__get_Task__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Cysharp_Threading_Tasks_UniTaskCompletionSource_PortalMonsterData__TypeInfo);
		    DAT_ram_00a6380c = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_PortalsManager___c__DisplayClass30_0_TypeInfo);
		  *(int *)(param2_00 + 0xc) = param2;
		  uVar1 = unnamed_function_1417
		                    (Cysharp_Threading_Tasks_UniTaskCompletionSource_PortalMonsterData__TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = uVar1;
		  uVar1 = Gameplay_Portals_Controller_PortalsController__GetStageInfo
		                    (*(undefined4 *)(param2 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Core_Gameplay_Managers_PortalsManager___c__DisplayClass30_0__GetMonster_b__0__,0
		            );
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource_object___UnsafeGetStatus
		            (&local_c,*(undefined4 *)(param2_00 + 8),
		             Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_PortalMonsterData__get_Task__);
		  *(undefined4 *)(param1 + 1) = local_4;
		  *param1 = local_c;
		  return;
		}
		*/

			return default(UniTask<ulong>);
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x000139C8 File Offset: 0x00011BC8
		[Token(Token = "0x6006988")]
		[Address(RVA = "0xB4A8", Offset = "0xB4A8", VA = "0xB4A8", Slot = "13")]
		public UniTask<PortalMonsterData> GetMonster()
		{
			return default(UniTask<PortalMonsterData>);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_PortalsManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63805 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63805 = '\x01';
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_PortalsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63806 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63806 = '\x01';
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
		void Core_Gameplay_Managers_PortalsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63807 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63807 = '\x01';
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
		void Core_Gameplay_Managers_PortalsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63808 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63808 = '\x01';
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

}
