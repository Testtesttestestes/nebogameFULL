using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents;
using Gameplay.GameEvents.Control;
using Gameplay.GameEvents.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001168 RID: 4456
	[Token(Token = "0x2001168")]
	public class GameEventsManager : IGameManager, IBaseManager
	{
		// Token: 0x14000288 RID: 648
		// (add) Token: 0x0600692C RID: 26924 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600692D RID: 26925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000288")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600692C")]
			[Address(RVA = "0xB450", Offset = "0xB450", VA = "0xB450", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600692D")]
			[Address(RVA = "0xB451", Offset = "0xB451", VA = "0xB451", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000289 RID: 649
		// (add) Token: 0x0600692E RID: 26926 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600692F RID: 26927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000289")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600692E")]
			[Address(RVA = "0xB452", Offset = "0xB452", VA = "0xB452", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600692F")]
			[Address(RVA = "0xB453", Offset = "0xB453", VA = "0xB453", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06006930 RID: 26928 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006931 RID: 26929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001585")]
		public IGame Game
		{
			[Token(Token = "0x6006930")]
			[Address(RVA = "0xB454", Offset = "0xB454", VA = "0xB454")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006931")]
			[Address(RVA = "0xB455", Offset = "0xB455", VA = "0xB455")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006932")]
		[Address(RVA = "0xB456", Offset = "0xB456", VA = "0xB456")]
		public GameEventsManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameEventsManager___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  float param2_00;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 param5;
		  undefined4 param6;
		  undefined4 uVar9;
		  uint uVar10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a637df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Control_GameEventsController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_GameEventsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_GameEventsManager_HandleFeatureInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_GameEventsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Repo_SourceTagFactoriesRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a637df = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_GameEvents_GameEventsEvents_TypeInfo);
		  *(int *)(param1 + 0x14) = iVar2;
		  uVar6 = *(undefined4 *)(iVar2 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_GameEventsManager_HandleFeatureInitEvent__,0
		            );
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		  iVar8 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar8))
		  {
		    System_Activator__CreateInstance(piVar4,iVar8);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar7 = *(undefined4 *)(param1 + 0x10);
		  uVar10 = 0;
		  uVar3 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Repo_SourceTagFactoriesRepository_TypeInfo);
		  Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository__Init(uVar3,0);
		  uVar6 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository_TypeInfo);
		  Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository__Dispose(uVar6,0);
		  piVar4 = *(int **)(param1 + 0x10);
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0x270);
		        goto code_r0x823020ee;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x36);
		code_r0x823020ee:
		  uVar1 = CONCAT44(in_register_20000004,piVar4);
		  iVar8 = (**(code **)((ulonglong)*puVar5 * 4))(uVar1,puVar5[1]);
		  uVar9 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  param5 = *(undefined4 *)(iVar8 + 0x10);
		  uVar10 = 0;
		  piVar4 = *(int **)(param1 + 0x10);
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + iVar8 + 0x140);
		        goto code_r0x82302176;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82302176:
		  param6 = 0;
		  iVar8 = (**(code **)((ulonglong)*puVar5 * 4))(CONCAT44(uVar9,piVar4),puVar5[1]);
		  if (*(int *)(iVar8 + 0x14) != 0) {
		    param6 = *(undefined4 *)(*(int *)(iVar8 + 0x14) + 8);
		  }
		  iVar8 = unnamed_function_1417(Gameplay_GameEvents_Model_GameEventsModel_TypeInfo);
		  Gameplay_GameEvents_Model_GameEventsModel__Dispose(iVar8,uVar7,uVar3,uVar6,param5,param6,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_TimeUtils__SecToMs(0x5dc,0);
		  local_8 = 0;
		  System_Type__GetProperty(&local_8,param2_00,Method_System_Nullable_float___ctor__);
		  *(undefined8 *)(iVar8 + 0x3c) = local_8;
		  *(int *)(param1 + 0x18) = iVar8;
		  uVar6 = *(undefined4 *)(param1 + 0x14);
		  uVar3 = unnamed_function_1417(Gameplay_GameEvents_Control_GameEventsController_TypeInfo);
		  Gameplay_GameEvents_Control_GameEventsController__Dispose(uVar3,iVar8,uVar6,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  uVar7 = *(undefined4 *)(param1 + 0x18);
		  uVar9 = *(undefined4 *)(param1 + 0x14);
		  uVar6 = unnamed_function_1417
		                    (Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator_TypeInfo);
		  Gameplay_GameEvents_Control_GameEventsEnterPointViewMediator__Dispose(uVar6,uVar7,uVar9,uVar3,0);
		  *(undefined4 *)(param1 + 0x20) = uVar6;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06006933 RID: 26931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006933")]
		[Address(RVA = "0xB457", Offset = "0xB457", VA = "0xB457", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06006934 RID: 26932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001586")]
		public GameEventsController Controller
		{
			[Token(Token = "0x6006934")]
			[Address(RVA = "0xB458", Offset = "0xB458", VA = "0xB458")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006935")]
		[Address(RVA = "0xB459", Offset = "0xB459", VA = "0xB459")]
		public void SetView(UserInterfaceView view)
		{
		/* --- GHIDRA: SetView ---
		void Core_Gameplay_Managers_GameEventsManager__SetView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = Gameplay_GameEvents_Model_GameEventsModel__GetEvents
		                        (*(undefined4 *)(param1 + 0x18),param2,0);
		  Gameplay_GameEvents_Control_GameEventsController__Read(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006936 RID: 26934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006936")]
		[Address(RVA = "0xB45A", Offset = "0xB45A", VA = "0xB45A")]
		public void OpenListView(EventCategoriesDic.Types.Category cat)
		{
		/* --- GHIDRA: OpenListView ---
		void Core_Gameplay_Managers_GameEventsManager__OpenListView(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a637e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_GameEventsManager_HandleFeatureInitEvent__);
		    DAT_ram_00a637e0 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_GameEventsManager_HandleFeatureInitEvent__,0);
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
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006937 RID: 26935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006937")]
		[Address(RVA = "0xB45B", Offset = "0xB45B", VA = "0xB45B")]
		private void HandleFeatureInitEvent()
		{
		/* --- GHIDRA: HandleFeatureInitEvent ---
		void Core_Gameplay_Managers_GameEventsManager__HandleFeatureInitEvent(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x1c),0);
		  piVar1 = *(int **)(param1 + 0x18);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))(piVar1,*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0xec));
		  piVar1 = *(int **)(param1 + 0x20);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))(piVar1,*(undefined4 *)(iVar2 + 0x134));
		  *(undefined4 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar2 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006938 RID: 26936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006938")]
		[Address(RVA = "0xB45C", Offset = "0xB45C", VA = "0xB45C", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_GameEventsManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8427);
		    DAT_ram_00a637e1 = '\x01';
		  }
		  return StringLiteral_8427;
		}
		*/

		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06006939 RID: 26937 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001587")]
		public string Name
		{
			[Token(Token = "0x6006939")]
			[Address(RVA = "0xB45D", Offset = "0xB45D", VA = "0xB45D", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x040037D6 RID: 14294
		[Token(Token = "0x40037D6")]
		[FieldOffset(Offset = "0x14")]
		private GameEventsEvents _events;

		// Token: 0x040037D7 RID: 14295
		[Token(Token = "0x40037D7")]
		[FieldOffset(Offset = "0x18")]
		private GameEventsModel _model;

		// Token: 0x040037D8 RID: 14296
		[Token(Token = "0x40037D8")]
		[FieldOffset(Offset = "0x1C")]
		private GameEventsController _controller;

		// Token: 0x040037D9 RID: 14297
		[Token(Token = "0x40037D9")]
		[FieldOffset(Offset = "0x20")]
		private GameEventsEnterPointViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_GameEventsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637dc = '\x01';
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
		void Core_Gameplay_Managers_GameEventsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637dd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637dd = '\x01';
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
		void Core_Gameplay_Managers_GameEventsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637de = '\x01';
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


		/* --- GHIDRA: get_Controller ---
		void Core_Gameplay_Managers_GameEventsManager__get_Controller
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		            (*(int **)(param1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x164));
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_GameEventsManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637e2 = '\x01';
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

}
