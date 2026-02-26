using System;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.World.Controller
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	public class WorldViewMediator : AbstractWorldViewMediator
	{
		// Token: 0x060014E8 RID: 5352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x66AA", Offset = "0x66AA", VA = "0x66AA")]
		public WorldViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Controller_WorldViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5819d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldViewMediator_RequestIsleInformationEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldViewMediator_WorldLocationChangedEvent__);
		    DAT_ram_00a5819d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_World_Controller_WorldViewMediator_WorldLocationChangedEvent__,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar2 + 0x14) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_World_Controller_WorldViewMediator_RequestIsleInformationEvent__,0)
		    ;
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar3 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  piVar5 = (int *)param1[6];
		  if (piVar5 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x140) * 4))
		              (piVar5,param2,*(undefined4 *)(*piVar5 + 0x144));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_World_Controller_WorldViewMediator_WorldLocationChangedEvent__,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar2 + 0x14) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_World_Controller_WorldViewMediator_RequestIsleInformationEvent__,0)
		    ;
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x18) = iVar4;
		    uVar3 = System_Action_ulong__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700036A RID: 874
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036A")]
		public override WorldControllerEvents Events
		{
			[Token(Token = "0x60014E9")]
			[Address(RVA = "0x66AB", Offset = "0x66AB", VA = "0x66AB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x66AC", Offset = "0x66AC", VA = "0x66AC")]
		private void RequestIsleInformationEvent(ulong isleId)
		{
		/* --- GHIDRA: RequestIsleInformationEvent ---
		void Gameplay_World_Controller_WorldViewMediator__RequestIsleInformationEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  int *param1_01;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5819e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a5819e = '\x01';
		  }
		  iVar3 = *(int *)(param1[2] + 0x1c);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(int **)(param1[2] + 0x14);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80eb15d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x80eb15d7:
		  uVar5 = 2;
		  if (iVar3 != 2) {
		    uVar5 = 1;
		  }
		  param2_00 = 0xffffffff;
		  if (iVar3 != 4) {
		    param2_00 = uVar5;
		  }
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Gameplay_World_View_WorldView__CancelCurrentQueue
		            (param1_00,param2_00,(uint)(*(char *)(iVar3 + 0xc) == '\0'),0);
		  return;
		}
		*/

		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x66AD", Offset = "0x66AD", VA = "0x66AD")]
		private void WorldLocationChangedEvent()
		{
		/* --- GHIDRA: WorldLocationChangedEvent ---
		undefined4
		Gameplay_World_Controller_WorldViewMediator__WorldLocationChangedEvent
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar2 = 2;
		  if (param2 != 2) {
		    uVar2 = 1;
		  }
		  uVar1 = 0xffffffff;
		  if (param2 != 4) {
		    uVar1 = uVar2;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x66AE", Offset = "0x66AE", VA = "0x66AE")]
		private WorldLevel GetWorldLevelByLocationType(LocationTypes type)
		{
		/* --- GHIDRA: GetWorldLevelByLocationType ---
		void Gameplay_World_Controller_WorldViewMediator__GetWorldLevelByLocationType
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5819f == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_WorldLevel__WorldLevel__TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&Method_Gameplay_World_Controller_WorldViewMediator_ViewOnWorldLevelChangedEvent__)
		      ;
		      DAT_ram_00a5819f = '\x01';
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = unnamed_function_1417(System_Action_WorldLevel__WorldLevel__TypeInfo);
		    System_Action_Int32Enum__int___Invoke
		              (param1_00,param1,
		               Method_Gameplay_World_Controller_WorldViewMediator_ViewOnWorldLevelChangedEvent__,0);
		    Gameplay_World_View_WorldView__add_WorldLevelChangedEvent(uVar1,param1_00,0);
		  }
		  Gameplay_World_Controller_AbstractWorldViewMediator___ctor(param1,param2,0);
		  piVar3 = (int *)param1[6];
		  if (piVar3 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		              (piVar3,param2,*(undefined4 *)(*piVar3 + 0x164));
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_World_Controller_WorldViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

			return WorldLevel.Unknown;
		}

		// Token: 0x1700036B RID: 875
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036B")]
		public override WorldView View
		{
			[Token(Token = "0x60014ED")]
			[Address(RVA = "0x66AF", Offset = "0x66AF", VA = "0x66AF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x66B0", Offset = "0x66B0", VA = "0x66B0")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_World_Controller_WorldViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int param2_00;
		  int *param1_01;
		  uint uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a581a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldLevel__WorldLevel__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldViewMediator_ViewOnWorldLevelChangedEvent__);
		    DAT_ram_00a581a0 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = unnamed_function_1417(System_Action_WorldLevel__WorldLevel__TypeInfo);
		  System_Action_Int32Enum__int___Invoke
		            (param1_00,param1,
		             Method_Gameplay_World_Controller_WorldViewMediator_ViewOnWorldLevelChangedEvent__,0);
		  Gameplay_World_View_WorldView__remove_MovCompleteEvent(uVar1,param1_00,0);
		  iVar4 = 2;
		  if (*(int *)(param1[2] + 0x1c) != 2) {
		    iVar4 = 1;
		  }
		  param2_00 = -1;
		  if (*(int *)(param1[2] + 0x1c) != 4) {
		    param2_00 = iVar4;
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (param2_00 != *(int *)(iVar4 + 0x18)) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (DAT_ram_00a58280 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_World_View_WorldView_TypeInfo);
		      DAT_ram_00a58280 = '\x01';
		    }
		    if (**(char **)(Gameplay_World_View_WorldView_TypeInfo + 0x5c) == '\0') {
		      uVar3 = 1;
		    }
		    else {
		      uVar3 = 0;
		      param1_01 = *(int **)(param1[2] + 0x14);
		      iVar4 = *param1_01;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar3 * 8))
		          {
		            puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80eb1872;
		          }
		          uVar3 = uVar3 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar3);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_01,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x80eb1872:
		      iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		      uVar3 = (uint)(*(char *)(iVar4 + 0xc) == '\0');
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_World_View_WorldView__CancelCurrentQueue(uVar1,param2_00,uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x66B1", Offset = "0x66B1", VA = "0x66B1")]
		private void SetView()
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x66B2", Offset = "0x66B2", VA = "0x66B2", Slot = "21")]
		public override void Clear()
		{
		/* --- GHIDRA: Clear ---
		void Gameplay_World_Controller_WorldViewMediator__Clear(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  CloudsFly_ClanIsleWorldObjectEngineArgs___ctor(*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x66B3", Offset = "0x66B3", VA = "0x66B3", Slot = "22")]
		protected override void StartMovement()
		{
		/* --- GHIDRA: StartMovement ---
		void Gameplay_World_Controller_WorldViewMediator__StartMovement(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  CloudsFly_CloudBGParallax__StartMove(*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x66B4", Offset = "0x66B4", VA = "0x66B4", Slot = "23")]
		protected override void CompleteMovement()
		{
		/* --- GHIDRA: CompleteMovement ---
		void Gameplay_World_Controller_WorldViewMediator__CompleteMovement
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a581a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldAxisLevelViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldClanLevelViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldUserLevelViewMediator_TypeInfo);
		    DAT_ram_00a581a1 = '\x01';
		  }
		  piVar3 = (int *)param1[6];
		  if (piVar3 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x168) * 4))
		              (piVar3,*(undefined4 *)(*piVar3 + 0x16c));
		    piVar3 = (int *)param1[6];
		    if (piVar3 != (int *)0x0) {
		      (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x130) * 4))
		                (piVar3,*(undefined4 *)(*piVar3 + 0x134));
		    }
		  }
		  param1[6] = 0;
		  if (param3 == -1) {
		    iVar4 = param1[2];
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    piVar3 = (int *)unnamed_function_1417
		                              (Gameplay_World_Controller_WorldAxisLevelViewMediator_TypeInfo);
		    Gameplay_World_Events_WorldEngineEvents___ctor(piVar3,iVar4,uVar1,uVar2,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		              (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x164));
		  }
		  else {
		    if (param3 == 0) {
		      return;
		    }
		    if (param3 == 1) {
		      iVar4 = param1[2];
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x13c));
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      piVar3 = (int *)unnamed_function_1417
		                                (Gameplay_World_Controller_WorldUserLevelViewMediator_TypeInfo);
		      Gameplay_World_Events_WorldEngineEvents___ctor(piVar3,iVar4,uVar1,uVar2,0);
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		                (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x164));
		    }
		    else {
		      if (param3 != 2) {
		        return;
		      }
		      iVar4 = param1[2];
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x13c));
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      piVar3 = (int *)unnamed_function_1417
		                                (Gameplay_World_Controller_WorldClanLevelViewMediator_TypeInfo);
		      Gameplay_World_Events_WorldEngineEvents___ctor(piVar3,iVar4,uVar1,uVar2,0);
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		                (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x164));
		    }
		  }
		  param1[6] = (int)piVar3;
		  return;
		}
		*/

		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x66B5", Offset = "0x66B5", VA = "0x66B5")]
		private void ViewOnWorldLevelChangedEvent(WorldLevel prevWorldLevel, WorldLevel newWorldLevel)
		{
		/* --- GHIDRA: ViewOnWorldLevelChangedEvent ---
		void Gameplay_World_Controller_WorldViewMediator__ViewOnWorldLevelChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a581a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__Dispose__
		              );
		    DAT_ram_00a581a2 = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x18);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__WorldView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x66B6", Offset = "0x66B6", VA = "0x66B6", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_World_Controller_WorldViewMediator__Dispose(int param1,undefined4 param2)
		
		{
		  Gameplay_VortexRating_View_RankView__Awake(param1,*(undefined4 *)(param1 + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x04000B0D RID: 2829
		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x18")]
		private AbstractWorldViewMediator _currentLevelMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_World_Controller_WorldViewMediator__set_Events
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_World_View_WorldView__OnChangeWindows(param1_00,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_World_Controller_WorldViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5819f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldLevel__WorldLevel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldViewMediator_ViewOnWorldLevelChangedEvent__);
		    DAT_ram_00a5819f = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = unnamed_function_1417(System_Action_WorldLevel__WorldLevel__TypeInfo);
		  System_Action_Int32Enum__int___Invoke
		            (param1_01,param1,
		             Method_Gameplay_World_Controller_WorldViewMediator_ViewOnWorldLevelChangedEvent__,0);
		  Gameplay_World_View_WorldView__add_WorldLevelChangedEvent(param1_00,param1_01,0);
		  return;
		}
		*/

}
