using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Gameplay.Combat.View;
using Gameplay.TutorialV2.Controller;
using Gameplay.TutorialV2.Events;
using Gameplay.TutorialV2.Model;
using Gameplay.TutorialV2.View;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.World;

namespace Core.Gameplay.Managers.Tutorial
{
	// Token: 0x02001184 RID: 4484
	[Token(Token = "0x2001184")]
	public class TutorialManagerV2 : IGameManager, IBaseManager, ITutorialManager
	{
		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06006A7C RID: 27260 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A7D RID: 27261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015CC")]
		public IGame Game
		{
			[Token(Token = "0x6006A7C")]
			[Address(RVA = "0xB595", Offset = "0xB595", VA = "0xB595", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A7D")]
			[Address(RVA = "0xB596", Offset = "0xB596", VA = "0xB596")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7E")]
		[Address(RVA = "0xB597", Offset = "0xB597", VA = "0xB597")]
		public TutorialManagerV2(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Tutorial_TutorialManagerV2___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63898 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_16524);
		    DAT_ram_00a63898 = '\x01';
		  }
		  return StringLiteral_16524;
		}
		*/

		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015CD")]
		public string Name
		{
			[Token(Token = "0x6006A7F")]
			[Address(RVA = "0xB598", Offset = "0xB598", VA = "0xB598", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002B0 RID: 688
		// (add) Token: 0x06006A80 RID: 27264 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A81 RID: 27265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B0")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A80")]
			[Address(RVA = "0xB599", Offset = "0xB599", VA = "0xB599", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A81")]
			[Address(RVA = "0xB59A", Offset = "0xB59A", VA = "0xB59A", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B1 RID: 689
		// (add) Token: 0x06006A82 RID: 27266 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A83 RID: 27267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B1")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A82")]
			[Address(RVA = "0xB59B", Offset = "0xB59B", VA = "0xB59B", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A83")]
			[Address(RVA = "0xB59C", Offset = "0xB59C", VA = "0xB59C", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06006A84 RID: 27268 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A85 RID: 27269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015CE")]
		public TutorialEvents Events
		{
			[Token(Token = "0x6006A84")]
			[Address(RVA = "0xB59D", Offset = "0xB59D", VA = "0xB59D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A85")]
			[Address(RVA = "0xB59E", Offset = "0xB59E", VA = "0xB59E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06006A86 RID: 27270 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A87 RID: 27271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015CF")]
		public TutorialModel Model
		{
			[Token(Token = "0x6006A86")]
			[Address(RVA = "0xB59F", Offset = "0xB59F", VA = "0xB59F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A87")]
			[Address(RVA = "0xB5A0", Offset = "0xB5A0", VA = "0xB5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06006A88 RID: 27272 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A89 RID: 27273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D0")]
		public TutorialController Controller
		{
			[Token(Token = "0x6006A88")]
			[Address(RVA = "0xB5A1", Offset = "0xB5A1", VA = "0xB5A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A89")]
			[Address(RVA = "0xB5A2", Offset = "0xB5A2", VA = "0xB5A2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06006A8A RID: 27274 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A8B RID: 27275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D1")]
		public TutorialViewMediator Mediator
		{
			[Token(Token = "0x6006A8A")]
			[Address(RVA = "0xB5A3", Offset = "0xB5A3", VA = "0xB5A3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A8B")]
			[Address(RVA = "0xB5A4", Offset = "0xB5A4", VA = "0xB5A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8C")]
		[Address(RVA = "0xB5A5", Offset = "0xB5A5", VA = "0xB5A5", Slot = "12")]
		public void SetView(ITutorialView view)
		{
		/* --- GHIDRA: SetView ---
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__SetView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6389e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__get_Mediator__
		              );
		    DAT_ram_00a6389e = '\x01';
		  }
		  piVar1 = *(int **)(*(int *)(*(int *)(param1 + 0x1c) + 0x20) + 0x1c);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x160) * 4))
		            (piVar1,param2,*(undefined4 *)(iVar2 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8D")]
		[Address(RVA = "0xB5A6", Offset = "0xB5A6", VA = "0xB5A6", Slot = "13")]
		public void SetCombatView(OneOnOneCombatView view)
		{
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006A8E")]
		[Address(RVA = "0xB5A7", Offset = "0xB5A7", VA = "0xB5A7", Slot = "14")]
		public UserData GetUser()
		{
			return null;
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006A8F")]
		[Address(RVA = "0xB5A8", Offset = "0xB5A8", VA = "0xB5A8", Slot = "15")]
		public RepeatedField<ProtoGetUserIsleInfoAns.Types.IsleInformation> GetIsles()
		{
		/* --- GHIDRA: GetIsles ---
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__GetIsles
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a6389f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a6389f = '\x01';
		  }
		  uVar2 = Core_Extensions_Dict_PromotionsDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x24),0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8230ce56;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x8230ce56:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  Core_Data_UserData__get_Money(uVar2,*(undefined4 *)(*(int *)(param1 + 0x18) + 0x28),0);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (*(undefined4 *)(param1 + 0x18),uVar2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A90")]
		[Address(RVA = "0xB5A9", Offset = "0xB5A9", VA = "0xB5A9", Slot = "16")]
		public void CreateUser(IUserCache cache)
		{
		/* --- GHIDRA: CreateUser ---
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__CreateUser(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param3;
		  int iVar4;
		  
		  if (DAT_ram_00a638a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_TutorialController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Events_TutorialEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Tutorial_TutorialManagerV2_OnInitCompleteTutorial__);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Model_TutorialModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_TutorialViewMediator_TypeInfo);
		    DAT_ram_00a638a0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_TutorialV2_Events_TutorialEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  uVar2 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417(Gameplay_TutorialV2_Model_TutorialModel_TypeInfo);
		  Gameplay_TutorialV2_Model_TutorialModel__Dispose(uVar1,uVar2,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  uVar2 = unnamed_function_1417(Gameplay_TutorialV2_Controller_TutorialController_TypeInfo);
		  Gameplay_TutorialV2_Controller_TutorialController__Dispose(uVar2,uVar1,uVar3,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  param3 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417(Gameplay_TutorialV2_Controller_TutorialViewMediator_TypeInfo);
		  Gameplay_TutorialV2_Controller_TutorialViewMediator__Dispose(uVar1,uVar3,param3,uVar2,0);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  iVar4 = *(int *)(param1 + 0x14);
		  uVar2 = *(undefined4 *)(iVar4 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_Tutorial_TutorialManagerV2_OnInitCompleteTutorial__,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar1,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar4 + 8) = param1_00, *param1_00 != param2_00)) {
		    System_Activator__CreateInstance(param1_00,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A91")]
		[Address(RVA = "0xB5AA", Offset = "0xB5AA", VA = "0xB5AA", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a638a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Tutorial_TutorialManagerV2_OnInitCompleteTutorial__);
		    DAT_ram_00a638a1 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Tutorial_TutorialManagerV2_OnInitCompleteTutorial__,0);
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

		// Token: 0x06006A92 RID: 27282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A92")]
		[Address(RVA = "0xB5AB", Offset = "0xB5AB", VA = "0xB5AB")]
		private void OnInitCompleteTutorial()
		{
		/* --- GHIDRA: OnInitCompleteTutorial ---
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__OnInitCompleteTutorial
		               (int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  puVar1 = (undefined8 *)(param1 + 0x1c);
		  MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		  iVar2 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)puVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		            (*(int **)(param1 + 0x20),*(undefined4 *)(iVar2 + 0x134));
		  *(undefined8 *)(param1 + 0x14) = 0;
		  *(undefined4 *)(param1 + 8) = 0;
		  *puVar1 = 0;
		  iVar2 = *(int *)(param1 + 0x10);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A93")]
		[Address(RVA = "0xB5AC", Offset = "0xB5AC", VA = "0xB5AC", Slot = "9")]
		public void Deinit()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63899 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63899 = '\x01';
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
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6389a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6389a = '\x01';
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
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6389b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6389b = '\x01';
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
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6389c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6389c = '\x01';
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


		/* --- GHIDRA: set_Mediator ---
		void Core_Gameplay_Managers_Tutorial_TutorialManagerV2__set_Mediator
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6389d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_View_TutorialView_TypeInfo);
		    DAT_ram_00a6389d = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_TutorialV2_View_TutorialView_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_TutorialV2_View_TutorialView_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_TutorialV2_View_TutorialView_TypeInfo)) {
		      System_Activator__CreateInstance(param2,Gameplay_TutorialV2_View_TutorialView_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		            (*(int **)(param1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x164));
		  return;
		}
		*/

}
