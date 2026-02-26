using System;
using Gameplay.ArtifactDrop.Model;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using Protocol.SmallGames;
using ServicesNamespace;
using Utils;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x0200053A RID: 1338
	[Token(Token = "0x200053A")]
	public class SmallGamesController : AbstractController<SmallGamesModel, Gameplay.SmallGames.Events.SmallGamesEvents>
	{
		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x714E", Offset = "0x714E", VA = "0x714E", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_SmallGames_Controller_SmallGamesController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a582c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_SmallGamesModel__SmallGamesEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_SmallGamesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a582c2 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_SmallGamesModel__SmallGamesEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_SmallGamesService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x714F", Offset = "0x714F", VA = "0x714F")]
		public SmallGamesController(SmallGamesModel model, Gameplay.SmallGames.Events.SmallGamesEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_Controller_SmallGamesController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a582c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_RequestLastDropResultHandler__
		              );
		    DAT_ram_00a582c3 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x150);
		        goto code_r0x80ec92d6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ec92d6:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  piVar5 = *(int **)(iVar6 + 0x10);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x110) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0x114));
		  param1_01 = *(undefined4 *)(iVar6 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_RequestLastDropResultHandler__
		             ,0);
		  param1_00 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(iVar6 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(param1_00,System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x14) = iVar4;
		    uVar3 = System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo;
		    iVar6 = func_ii_1082(param1_00,System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__DismantleArtifact(piVar5,8,0);
		  return;
		}
		*/

		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x7150", Offset = "0x7150", VA = "0x7150")]
		public void RequestLastDrop()
		{
		/* --- GHIDRA: RequestLastDrop ---
		void Gameplay_SmallGames_Controller_SmallGamesController__RequestLastDrop
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a582c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_RequestLastDropResultHandler__
		              );
		    DAT_ram_00a582c4 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x150);
		        goto code_r0x80ec945b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ec945b:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x10);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  param1_01 = *(undefined4 *)(iVar5 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_RequestLastDropResultHandler__
		             ,0);
		  iVar6 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar5 + 0x14) = iVar4;
		    uVar3 = System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo;
		    iVar5 = func_ii_1082(iVar6,System_Action_ArtifactDropModel_ArtifactDrop__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar5 = *param1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar5 + 0x104));
		  Gameplay_SmallGames_Model_SmallGamesModel__SetFreeAttempts
		            (uVar3,*(undefined4 *)(param2 + 0xc),iVar5);
		  Gameplay_SmallGames_Controller_SmallGamesController__ValidateInit(param1,iVar5);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar5 + 0x28);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x7151", Offset = "0x7151", VA = "0x7151")]
		private void RequestLastDropResultHandler(ArtifactDropModel.ArtifactDrop drop)
		{
		/* --- GHIDRA: RequestLastDropResultHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesController__RequestLastDropResultHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a582c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_Controller_SmallGamesController_DropRemovedEventHandler__
		              );
		    DAT_ram_00a582c5 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x150);
		        goto code_r0x80ec978c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ec978c:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  piVar5 = *(int **)(iVar6 + 0x10);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x110) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0x114));
		  param1_01 = *(undefined4 *)(iVar6 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_DropRemovedEventHandler__,0)
		  ;
		  param1_00 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_DropTypes__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(param1_00,System_Action_DropTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x18) = iVar4;
		    uVar3 = System_Action_DropTypes__TypeInfo;
		    iVar6 = func_ii_1082(param1_00,System_Action_DropTypes__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__RequestDrop(piVar5,8,0);
		  return;
		}
		*/

		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x7152", Offset = "0x7152", VA = "0x7152")]
		public void TakeAllDrop()
		{
		/* --- GHIDRA: TakeAllDrop ---
		void Gameplay_SmallGames_Controller_SmallGamesController__TakeAllDrop
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a582c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_Controller_SmallGamesController_DropRemovedEventHandler__
		              );
		    DAT_ram_00a582c6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x150);
		        goto code_r0x80ec9911;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ec9911:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x10);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  param1_01 = *(undefined4 *)(iVar5 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_DropRemovedEventHandler__,0)
		  ;
		  iVar6 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_DropTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar5 + 0x18) = 0;
		    Gameplay_SmallGames_Controller_SmallGamesController___ctor(param1,0);
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar5 + 0x18) = iVar4;
		    uVar3 = System_Action_DropTypes__TypeInfo;
		    iVar5 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		    if (iVar5 != 0) {
		      Gameplay_SmallGames_Controller_SmallGamesController___ctor(param1,iVar6);
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x7153", Offset = "0x7153", VA = "0x7153")]
		private void DropRemovedEventHandler(DropTypes obj)
		{
		/* --- GHIDRA: DropRemovedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesController__DropRemovedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a582c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_Controller_SmallGamesController_DropRemovedEventHandler__
		              );
		    DAT_ram_00a582c7 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x150);
		        goto code_r0x80ec9a95;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ec9a95:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  piVar5 = *(int **)(iVar6 + 0x10);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x110) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0x114));
		  param1_01 = *(undefined4 *)(iVar6 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_DropRemovedEventHandler__,0)
		  ;
		  param1_00 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_DropTypes__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(param1_00,System_Action_DropTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x18) = iVar4;
		    uVar3 = System_Action_DropTypes__TypeInfo;
		    iVar6 = func_ii_1082(param1_00,System_Action_DropTypes__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(param1_00,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_ArtifactDrop_Control_ArtifactDropController__TakeAllDrop(piVar5,8,0);
		  return;
		}
		*/

		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x7154", Offset = "0x7154", VA = "0x7154")]
		public void SellAllDrop()
		{
		/* --- GHIDRA: SellAllDrop ---
		void Gameplay_SmallGames_Controller_SmallGamesController__SellAllDrop(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a582c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_Controller_SmallGamesController_HandleRegisterVisit__);
		    DAT_ram_00a582c8 = '\x01';
		  }
		  uVar1 = ServicesNamespace_SmallGamesService__LaunchWheelsDiamond(*(undefined4 *)(param1 + 0x18),0)
		  ;
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_HandleRegisterVisit__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x7155", Offset = "0x7155", VA = "0x7155")]
		public void RegisterVisit()
		{
		/* --- GHIDRA: RegisterVisit ---
		void Gameplay_SmallGames_Controller_SmallGamesController__RegisterVisit
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_SmallGames_Controller_SmallGamesController__SellAllDrop(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x7156", Offset = "0x7156", VA = "0x7156")]
		private void SmallGamesServiceOnRewardChangedEvent(ProtoRewardChangedEvt evt)
		{
		/* --- GHIDRA: SmallGamesServiceOnRewardChangedEvent ---
		void Gameplay_SmallGames_Controller_SmallGamesController__SmallGamesServiceOnRewardChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a582c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14439);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14438);
		    DAT_ram_00a582c9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(*(int *)(iVar1 + 0x14) + 8) == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_14438,0);
		    return;
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_14439,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(*(int *)(*(int *)(iVar1 + 0x14) + 8) + 0x28) = *(undefined1 *)(param2 + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x7157", Offset = "0x7157", VA = "0x7157")]
		private void SmallGamesServiceOnAdditionalRewardChangedEvent(ProtoAdditionalRewardChangedEvt e)
		{
		/* --- GHIDRA: SmallGamesServiceOnAdditionalRewardChangedEvent ---
		void Gameplay_SmallGames_Controller_SmallGamesController__SmallGamesServiceOnAdditionalRewardChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a582ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_ProtoRegisterVisitAns_TypeInfo);
		    DAT_ram_00a582ca = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_SmallGames_ProtoRegisterVisitAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_SmallGames_ProtoRegisterVisitAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if ((char)param1_01[7] != '\0') {
		    Gameplay_SmallGames_Controller_SmallGamesController___ctor(param1,param1);
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_SmallGames_Model_SmallGamesModel___ctor(param1_00,param1_01,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x7158", Offset = "0x7158", VA = "0x7158")]
		private void HandleRegisterVisit(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleRegisterVisit ---
		void Gameplay_SmallGames_Controller_SmallGamesController__HandleRegisterVisit
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a582cb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_SlotMachineType_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_GetLastJackpotInfoResultHandler__
		              );
		    DAT_ram_00a582cb = '\x01';
		  }
		  uVar1 = ServicesNamespace_SmallGamesService__GetJackpotInfo(*(undefined4 *)(param1 + 0x18),1,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_GetLastJackpotInfoResultHandler__
		             ,0);
		  local_4 = 1;
		  uVar3 = func_ii_1081(Protocol_SmallGames_SlotMachineType_TypeInfo,&local_4);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,uVar2,uVar3,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar1 = ServicesNamespace_SmallGamesService__GetJackpotInfo(*(undefined4 *)(param1 + 0x18),2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_GetLastJackpotInfoResultHandler__
		             ,0);
		  local_8 = 2;
		  uVar3 = func_ii_1081(Protocol_SmallGames_SlotMachineType_TypeInfo,&local_8);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,uVar2,uVar3,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x7159", Offset = "0x7159", VA = "0x7159")]
		public void GetLastJackpotInfos()
		{
		/* --- GHIDRA: GetLastJackpotInfos ---
		void Gameplay_SmallGames_Controller_SmallGamesController__GetLastJackpotInfos
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  int *piVar2;
		  int param2_00;
		  undefined4 param1_02;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a582cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_ProtoGetLastJackpotInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_SlotMachineType_TypeInfo);
		    DAT_ram_00a582cc = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_SmallGames_ProtoGetLastJackpotInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_SmallGames_ProtoGetLastJackpotInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (-1 < param1_01[3]) {
		    piVar2 = *(int **)(param2 + 0xc);
		    if (piVar2 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar2 + 0x20) != *(int *)(Protocol_SmallGames_SlotMachineType_TypeInfo + 0x20)) {
		      System_Activator__CreateInstance(piVar2,Protocol_SmallGames_SlotMachineType_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar2 = (int *)func_ii_15774(piVar2);
		    param2_00 = *piVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (DAT_ram_00a582b0 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo__set_Item__
		                );
		      Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_Model_SmallGamesModel_JackpotInfo_TypeInfo);
		      DAT_ram_00a582b0 = '\x01';
		    }
		    if (param1_01[4] != 0) {
		      param1_02 = *(undefined4 *)(iVar1 + 0x20);
		      param1_00 = unnamed_function_1417
		                            (Gameplay_SmallGames_Model_SmallGamesModel_JackpotInfo_TypeInfo);
		      param3_00 = 2;
		      if (param2_00 != 1) {
		        param3_00 = 4;
		      }
		      Gameplay_SmallGames_Model_SmallGamesModel__GetResourceId
		                (param1_00,param1_01,param3_00,param1_01);
		      System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		                (param1_02,param2_00,param1_00,
		                 Method_System_Collections_Generic_Dictionary_SlotMachineType__SmallGamesModel_JackpotInfo__set_Item__
		                );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x715A", Offset = "0x715A", VA = "0x715A")]
		private void GetLastJackpotInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetLastJackpotInfoResultHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesController__GetLastJackpotInfoResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a582cd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_GetJackpotInfoResultHandler__
		              );
		    DAT_ram_00a582cd = '\x01';
		  }
		  param1_02 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = ServicesNamespace_SmallGamesService__ServerEventHandler
		                        (param1_02,*(undefined4 *)(iVar1 + 0x38),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_GetJackpotInfoResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x715B", Offset = "0x715B", VA = "0x715B")]
		public void GetJackpotInfo()
		{
		/* --- GHIDRA: GetJackpotInfo ---
		void Gameplay_SmallGames_Controller_SmallGamesController__GetJackpotInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a582ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_ProtoGetJackpotInfoAns_TypeInfo);
		    DAT_ram_00a582ce = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_SmallGames_ProtoGetJackpotInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_SmallGames_ProtoGetJackpotInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x40) = param1_00[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x715C", Offset = "0x715C", VA = "0x715C")]
		private void GetJackpotInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetJackpotInfoResultHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesController__GetJackpotInfoResultHandler
		               (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a582cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_LaunchWheelResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_SlotMachineType__uint__uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_SlotMachineType__uint__uint__TypeInfo);
		    DAT_ram_00a582cf = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = 0x2c;
		  if (*(int *)(iVar1 + 0x38) != 1) {
		    iVar4 = 0x30;
		  }
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + iVar4) + 0xc);
		  param1_00 = unnamed_function_1417(System_Tuple_SlotMachineType__uint__uint__TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor
		            (param1_00,param2,param3,uVar3,Method_System_Tuple_SlotMachineType__uint__uint___ctor__)
		  ;
		  if (param2 == 1) {
		    uVar3 = ServicesNamespace_SmallGamesService__GetFreeAttempts(param1[6],param3,0);
		    uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_LaunchWheelResultHandler__
		               ,0);
		    uVar3 = ServicesNamespace_MainService__GetUserStats
		                      (uVar3,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  else {
		    if (param2 != 2) {
		      return;
		    }
		    uVar3 = ServicesNamespace_SmallGamesService__TakeDailyBonus(param1[6],param3,0);
		    uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_LaunchWheelResultHandler__
		               ,0);
		    uVar3 = ServicesNamespace_MainService__GetUserStats
		                      (uVar3,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  DG_Tweening_TweenParams__SetId
		            (uVar3,param1_00,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return;
		}
		*/

		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x715D", Offset = "0x715D", VA = "0x715D")]
		public void LaunchWheel(SlotMachineType slotMachineType, uint scrollCount)
		{
		/* --- GHIDRA: LaunchWheel ---
		void Gameplay_SmallGames_Controller_SmallGamesController__LaunchWheel
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  int param5;
		  int param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a582d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_ProtoLaunchWheelsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_SmallGamesScope_SlotMachineSpinEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_SlotMachineType__uint__uint__get_Item1__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_SlotMachineType__uint__uint__get_Item2__);
		    Mono_Security_ASN1__get_Item(&Method_System_Tuple_SlotMachineType__uint__uint__get_Item3__);
		    Mono_Security_ASN1__get_Item(&System_Tuple_SlotMachineType__uint__uint__TypeInfo);
		    DAT_ram_00a582d0 = '\x01';
		  }
		  piVar2 = *(int **)(param2 + 0x20);
		  if ((piVar2 != (int *)0x0) && (Protocol_SmallGames_ProtoLaunchWheelsAns_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,Protocol_SmallGames_ProtoLaunchWheelsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar2[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  iVar3 = *param1;
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x104));
		    *(int **)(iVar1 + 0x3c) = piVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x40) = piVar2[8];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = 0x2c;
		    if (*(int *)(iVar1 + 0x38) != 1) {
		      iVar3 = 0x30;
		    }
		    if (*(int *)(*(int *)(iVar1 + iVar3) + 0xc) != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar3 = 0x2c;
		      if (*(int *)(iVar1 + 0x38) != 1) {
		        iVar3 = 0x30;
		      }
		      *(int *)(*(int *)(iVar1 + iVar3) + 0xc) = *(int *)(*(int *)(iVar1 + iVar3) + 0xc) + -1;
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),1,*(undefined4 *)(iVar1 + 0x14));
		    }
		    piVar2 = *(int **)(param2 + 0xc);
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar2 + 0xb8) <
		           (uint)*(byte *)(System_Tuple_SlotMachineType__uint__uint__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar2 + 100) +
		                   (uint)*(byte *)(System_Tuple_SlotMachineType__uint__uint__TypeInfo + 0xb8) * 4 +
		                  -4) != System_Tuple_SlotMachineType__uint__uint__TypeInfo)) {
		        System_Activator__CreateInstance(piVar2,System_Tuple_SlotMachineType__uint__uint__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 100) + 0xc);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      iVar3 = piVar2[4];
		      param5 = piVar2[3];
		      param4 = piVar2[2];
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_SmallGamesScope_SlotMachineSpinEventArgs_TypeInfo);
		      Core_Events_Scopes_TournamentsScope_AddBetEventArgs__get_Bet
		                (param1_00,param2_00,param3_00,param4,param5,iVar3,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                      (param1,*(undefined4 *)(iVar3 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x715E", Offset = "0x715E", VA = "0x715E")]
		private void LaunchWheelResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: LaunchWheelResultHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesController__LaunchWheelResultHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts(param1,1,param1);
		  Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts(param1,2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x715F", Offset = "0x715F", VA = "0x715F")]
		public void GetFreeAttempts()
		{
		/* --- GHIDRA: GetFreeAttempts ---
		void Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  int *param1_02;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a582d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_FreeAttemptsInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_SlotMachineType_TypeInfo);
		    DAT_ram_00a582d2 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_SmallGames_FreeAttemptsInfo_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_SmallGames_FreeAttemptsInfo_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_02 + 0x20) == *(int *)(Protocol_SmallGames_SlotMachineType_TypeInfo + 0x20))
		  {
		    puVar1 = (undefined4 *)func_ii_15774(param1_02);
		    param3_00 = *puVar1;
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_SmallGames_Model_SmallGamesModel__SetJackpot(param1_00,param1_01,param3_00,param1);
		    Gameplay_SmallGames_Controller_SmallGamesController__ValidateInit(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x24);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_02,Protocol_SmallGames_SlotMachineType_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: GetFreeAttempts ---
		void Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  int *param1_02;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a582d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_FreeAttemptsInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_SlotMachineType_TypeInfo);
		    DAT_ram_00a582d2 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_SmallGames_FreeAttemptsInfo_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_SmallGames_FreeAttemptsInfo_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_02 + 0x20) == *(int *)(Protocol_SmallGames_SlotMachineType_TypeInfo + 0x20))
		  {
		    puVar1 = (undefined4 *)func_ii_15774(param1_02);
		    param3_00 = *puVar1;
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_SmallGames_Model_SmallGamesModel__SetJackpot(param1_00,param1_01,param3_00,param1);
		    Gameplay_SmallGames_Controller_SmallGamesController__ValidateInit(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x24);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_02,Protocol_SmallGames_SlotMachineType_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x7160", Offset = "0x7160", VA = "0x7160")]
		public void GetFreeAttempts(SlotMachineType type)
		{
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x7161", Offset = "0x7161", VA = "0x7161")]
		private void GetFreeAttemptsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetFreeAttemptsResultHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttemptsResultHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_SmallGames_Model_SmallGamesModel__SetJackpot(param1_00,param2,param3,param1);
		  Gameplay_SmallGames_Controller_SmallGamesController__ValidateInit(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x7162", Offset = "0x7162", VA = "0x7162")]
		private void SetFreeAttempts(FreeAttemptsInfo freeAttempts, SlotMachineType type)
		{
		/* --- GHIDRA: SetFreeAttempts ---
		void Gameplay_SmallGames_Controller_SmallGamesController__SetFreeAttempts
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a582d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_TakeDailyBonusResultHandler__
		              );
		    DAT_ram_00a582d3 = '\x01';
		  }
		  param1_00 = ServicesNamespace_SmallGamesService__RegisterVisit(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_TakeDailyBonusResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x7163", Offset = "0x7163", VA = "0x7163")]
		public void TakeDailyBonus()
		{
		/* --- GHIDRA: TakeDailyBonus ---
		void Gameplay_SmallGames_Controller_SmallGamesController__TakeDailyBonus
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a582d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_ProtoTakeDailyBonusAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6095);
		    DAT_ram_00a582d4 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_SmallGames_ProtoTakeDailyBonusAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_SmallGames_ProtoTakeDailyBonusAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param1_00[3] == -1) {
		    uVar3 = System_Uri___ctor(0);
		    uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6095,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar3,1,uVar4,0);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  *(undefined4 *)(*(int *)(iVar1 + 8) + 0x18) = 1;
		  iVar1 = *(int *)(iVar1 + 0x10);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (0 < *(int *)(*(int *)(*(int *)(iVar1 + 0x14) + 0xc) + 0xc)) {
		    iVar1 = 0;
		    do {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar5 = *(int *)(*(int *)(*(int *)(iVar2 + 0x14) + 0xc) + iVar1 * 4 + 0x10);
		      iVar1 = iVar1 + 1;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (iVar1 == *(int *)(*(int *)(*(int *)(iVar2 + 0x14) + 8) + 0xc)) {
		        *(undefined1 *)(iVar5 + 0x14) = 1;
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		    } while (iVar1 < *(int *)(*(int *)(*(int *)(iVar2 + 0x14) + 0xc) + 0xc));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 100) + 8);
		  if (iVar1 != 0) {
		    uVar3 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar4 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll(uVar4,uVar3,param3_00,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar4,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x7164", Offset = "0x7164", VA = "0x7164")]
		private void TakeDailyBonusResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: TakeDailyBonusResultHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesController__TakeDailyBonusResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a582d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRewardChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAdditionalRewardChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_SmallGamesServiceOnAdditionalRewardChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_SmallGamesServiceOnRewardChangedEvent__
		              );
		    DAT_ram_00a582d5 = '\x01';
		  }
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  Gameplay_SmallGames_Controller_SmallGamesController__SellAllDrop(param1,param1);
		  Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts(param1,1,param1);
		  Gameplay_SmallGames_Controller_SmallGamesController__GetFreeAttempts(param1,2,param1);
		  iVar2 = param1[6];
		  uVar1 = unnamed_function_1417(System_Action_ProtoAdditionalRewardChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_SmallGamesServiceOnAdditionalRewardChangedEvent__
		             ,0);
		  ServicesNamespace_SmallGamesService__get_ServiceId(iVar2,uVar1,0);
		  iVar2 = param1[6];
		  uVar1 = unnamed_function_1417(System_Action_ProtoRewardChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_SmallGamesServiceOnRewardChangedEvent__
		             ,0);
		  ServicesNamespace_SmallGamesService__remove_AdditionalRewardChangedEvent(iVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002000 RID: 8192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x7165", Offset = "0x7165", VA = "0x7165", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_SmallGames_Controller_SmallGamesController__HandleRun(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a582d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRewardChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoAdditionalRewardChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_SmallGamesServiceOnAdditionalRewardChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesController_SmallGamesServiceOnRewardChangedEvent__
		              );
		    DAT_ram_00a582d6 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoAdditionalRewardChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_SmallGamesServiceOnAdditionalRewardChangedEvent__
		             ,0);
		  ServicesNamespace_SmallGamesService__add_AdditionalRewardChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoRewardChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesController_SmallGamesServiceOnRewardChangedEvent__
		             ,0);
		  ServicesNamespace_SmallGamesService__add_RewardChangedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002001")]
		[Address(RVA = "0x7166", Offset = "0x7166", VA = "0x7166", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002002")]
		[Address(RVA = "0x7167", Offset = "0x7167", VA = "0x7167")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_SmallGames_Controller_SmallGamesController__ValidateInit
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a582d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___get_Count__);
		    DAT_ram_00a582d7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(*(int *)(iVar1 + 0x2c) + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = *(int *)(*(int *)(iVar1 + 0x30) + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x38);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),iVar2 + iVar3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = *(int *)(iVar1 + 0x44);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar2 + 0x18) == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x18) + 0xc);
		  }
		  *(undefined4 *)(iVar1 + 0x44) = uVar4;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar3 != *(int *)(iVar1 + 0x44)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x34);
		    if (iVar1 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar2 + 0x44),
		                 *(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002003")]
		[Address(RVA = "0x7168", Offset = "0x7168", VA = "0x7168")]
		public void CheckIfNotificationsNeedToUpdate()
		{
		/* --- GHIDRA: CheckIfNotificationsNeedToUpdate ---
		void Gameplay_SmallGames_Controller_SmallGamesController__CheckIfNotificationsNeedToUpdate
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a582d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView___ctor__
		              );
		    DAT_ram_00a582d8 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__UserInterfaceView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x18")]
		private SmallGamesService _smallGamesService;
	}
}
