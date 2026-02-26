using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.World.Controller;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001181 RID: 4481
	[Token(Token = "0x2001181")]
	public class WorldManager : IGameManager, IBaseManager, IWorldMovementProvider
	{
		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06006A51 RID: 27217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C3")]
		public WorldEngineEvents WorldEngineEvents
		{
			[Token(Token = "0x6006A51")]
			[Address(RVA = "0xB570", Offset = "0xB570", VA = "0xB570")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06006A52 RID: 27218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C4")]
		public WorldControllerEvents Events
		{
			[Token(Token = "0x6006A52")]
			[Address(RVA = "0xB571", Offset = "0xB571", VA = "0xB571")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06006A53 RID: 27219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C5")]
		public WorldController Controller
		{
			[Token(Token = "0x6006A53")]
			[Address(RVA = "0xB572", Offset = "0xB572", VA = "0xB572")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06006A54 RID: 27220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C6")]
		public WorldModel Model
		{
			[Token(Token = "0x6006A54")]
			[Address(RVA = "0xB573", Offset = "0xB573", VA = "0xB573")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002AC RID: 684
		// (add) Token: 0x06006A55 RID: 27221 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A56 RID: 27222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AC")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A55")]
			[Address(RVA = "0xB574", Offset = "0xB574", VA = "0xB574", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A56")]
			[Address(RVA = "0xB575", Offset = "0xB575", VA = "0xB575", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002AD RID: 685
		// (add) Token: 0x06006A57 RID: 27223 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A58 RID: 27224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AD")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A57")]
			[Address(RVA = "0xB576", Offset = "0xB576", VA = "0xB576", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A58")]
			[Address(RVA = "0xB577", Offset = "0xB577", VA = "0xB577", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A59")]
		[Address(RVA = "0xB578", Offset = "0xB578", VA = "0xB578", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_WorldManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 8) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5A")]
		[Address(RVA = "0xB579", Offset = "0xB579", VA = "0xB579", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_WorldManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param5;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a63888 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Events_WorldEngineEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_WorldManager_ControllerOnInitComplete__);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_WorldModel_TypeInfo);
		    DAT_ram_00a63888 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_World_Events_WorldEngineEvents_TypeInfo);
		  *(undefined4 *)(param1 + 8) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x8230bc4c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8230bc4c:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar7;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x148);
		        goto code_r0x8230bcf8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x8230bcf8:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar7;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x8230bda4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8230bda4:
		  param5 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  if (*(int *)(iVar6 + 0x14) != 0) {
		    param5 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 8);
		  }
		  param1_00 = unnamed_function_1417(Gameplay_World_Model_WorldModel_TypeInfo);
		  Gameplay_World_Model_WorldModel__set_LastSuccessIsleAnimationRequest
		            (param1_00,piVar5,uVar2,uVar4,param5,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  uVar4 = *(undefined4 *)(param1 + 0xc);
		  uVar2 = unnamed_function_1417(Gameplay_World_Controller_WorldController_TypeInfo);
		  Gameplay_World_Controller_WorldController__Dispose(uVar2,param1_00,uVar4,0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  iVar8 = *(int *)(param1 + 0xc);
		  uVar4 = *(undefined4 *)(iVar8 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Core_Gameplay_Managers_WorldManager_ControllerOnInitComplete__,0);
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
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5B")]
		[Address(RVA = "0xB57A", Offset = "0xB57A", VA = "0xB57A")]
		private void InitMvc()
		{
		/* --- GHIDRA: InitMvc ---
		void Core_Gameplay_Managers_WorldManager__InitMvc(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a63889 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_WorldManager_ControllerOnInitComplete__);
		    DAT_ram_00a63889 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0xc);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_WorldManager_ControllerOnInitComplete__,
		             0);
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
		  iVar2 = *(int *)(param1 + 0x1c);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5C")]
		[Address(RVA = "0xB57B", Offset = "0xB57B", VA = "0xB57B")]
		private void ControllerOnInitComplete()
		{
		/* --- GHIDRA: ControllerOnInitComplete ---
		undefined4
		Core_Gameplay_Managers_WorldManager__ControllerOnInitComplete
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_World_Controller_WorldController__WorldServiceGoHomeEventHandler
		                    (*(undefined4 *)(param1 + 0x10),param2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x000139F8 File Offset: 0x00011BF8
		[Token(Token = "0x6006A5D")]
		[Address(RVA = "0xB57C", Offset = "0xB57C", VA = "0xB57C")]
		public bool TryAttackMonsterFromCurrentIsle([NotNull] MonsterData monster)
		{
		/* --- GHIDRA: TryAttackMonsterFromCurrentIsle ---
		void Core_Gameplay_Managers_WorldManager__TryAttackMonsterFromCurrentIsle
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_World_Controller_WorldController__TryAttackMonsterFromCurrentIsle
		            (*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A5E")]
		[Address(RVA = "0xB57D", Offset = "0xB57D", VA = "0xB57D")]
		public void KickMonsterFromCurrentIsle()
		{
		/* --- GHIDRA: KickMonsterFromCurrentIsle ---
		undefined4
		Core_Gameplay_Managers_WorldManager__KickMonsterFromCurrentIsle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_World_Controller_WorldController__KickMonsterFromCurrentIsle
		                    (*(undefined4 *)(param1 + 0x10),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x00013A10 File Offset: 0x00011C10
		[Token(Token = "0x6006A5F")]
		[Address(RVA = "0xB57E", Offset = "0xB57E", VA = "0xB57E")]
		public bool TryRequestMonsterForCurrentUserIsle()
		{
		/* --- GHIDRA: TryRequestMonsterForCurrentUserIsle ---
		void Core_Gameplay_Managers_WorldManager__TryRequestMonsterForCurrentUserIsle
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_World_Controller_WorldController__SetCurrentAxisIsleData
		            (*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A60")]
		[Address(RVA = "0xB57F", Offset = "0xB57F", VA = "0xB57F")]
		public void GoHome()
		{
		/* --- GHIDRA: GoHome ---
		void Core_Gameplay_Managers_WorldManager__GoHome(int param1,undefined8 param2,undefined4 param3)
		
		{
		  Gameplay_World_Controller_WorldController__GetClanIsleInfoServiceHandler
		            (*(undefined4 *)(param1 + 0x10),param2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A61")]
		[Address(RVA = "0xB580", Offset = "0xB580", VA = "0xB580")]
		public void GoToUserIsleById(ulong ownerId)
		{
		/* --- GHIDRA: GoToUserIsleById ---
		void Core_Gameplay_Managers_WorldManager__GoToUserIsleById
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  Gameplay_World_Controller_WorldController__GetMonsterInfoServiceHandler
		            (*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A62")]
		[Address(RVA = "0xB581", Offset = "0xB581", VA = "0xB581")]
		public void GoToClanIsleById(ulong clanId)
		{
		/* --- GHIDRA: GoToClanIsleById ---
		void Core_Gameplay_Managers_WorldManager__GoToClanIsleById(int param1,undefined4 param2)
		
		{
		  Gameplay_World_Controller_WorldController__ValidateInit(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A63")]
		[Address(RVA = "0xB582", Offset = "0xB582", VA = "0xB582")]
		public void GoToAxisIsle()
		{
		/* --- GHIDRA: GoToAxisIsle ---
		undefined4 Core_Gameplay_Managers_WorldManager__GoToAxisIsle(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6388a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_17958);
		    DAT_ram_00a6388a = '\x01';
		  }
		  return StringLiteral_17958;
		}
		*/

		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06006A64 RID: 27236 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C7")]
		public string Name
		{
			[Token(Token = "0x6006A64")]
			[Address(RVA = "0xB583", Offset = "0xB583", VA = "0xB583", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06006A65 RID: 27237 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C8")]
		public IUserIslesWorldMovement UserIslesWorldMovement
		{
			[Token(Token = "0x6006A65")]
			[Address(RVA = "0xB584", Offset = "0xB584", VA = "0xB584", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06006A66 RID: 27238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C9")]
		public IClanIslesWorldMovement ClanIslesWorldMovement
		{
			[Token(Token = "0x6006A66")]
			[Address(RVA = "0xB585", Offset = "0xB585", VA = "0xB585", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A67")]
		[Address(RVA = "0xB586", Offset = "0xB586", VA = "0xB586")]
		public WorldManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_WorldManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6388c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8442);
		    DAT_ram_00a6388c = '\x01';
		  }
		  return StringLiteral_8442;
		}
		*/

		}

		// Token: 0x04003845 RID: 14405
		[Token(Token = "0x4003845")]
		[FieldOffset(Offset = "0x8")]
		private WorldEngineEvents _worldEngineEvents;

		// Token: 0x04003847 RID: 14407
		[Token(Token = "0x4003847")]
		[FieldOffset(Offset = "0x10")]
		private WorldController _controller;

		// Token: 0x04003848 RID: 14408
		[Token(Token = "0x4003848")]
		[FieldOffset(Offset = "0x14")]
		private WorldModel _model;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Model ---
		void Core_Gameplay_Managers_WorldManager__get_Model(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63884 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63884 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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
		void Core_Gameplay_Managers_WorldManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63885 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63885 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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
		void Core_Gameplay_Managers_WorldManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63886 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63886 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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
		void Core_Gameplay_Managers_WorldManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63887 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63887 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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
		void Core_Gameplay_Managers_WorldManager__remove_InitCompleteEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_WorldManager__Deinit(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: get_ClanIslesWorldMovement ---
		void Core_Gameplay_Managers_WorldManager__get_ClanIslesWorldMovement(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6388b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Events_WorldControllerEvents_TypeInfo);
		    DAT_ram_00a6388b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_World_Events_WorldControllerEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

}
