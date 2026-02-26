using System;
using Core.Application;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001123 RID: 4387
	[Token(Token = "0x2001123")]
	public class GameResolver : IGameResolver
	{
		// Token: 0x060066B8 RID: 26296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B8")]
		[Address(RVA = "0xB237", Offset = "0xB237", VA = "0xB237")]
		public GameResolver(IApp app)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_GameResolver___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a923 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGame__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_GameResolver_HandleGameInstanceDeinitEvent__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a923 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_IGame__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Core_Gameplay_GameResolver_HandleGameInstanceDeinitEvent__,0);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x81294c54;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,3);
		code_r0x81294c54:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param1_00,puVar2[1]);
		  uVar1 = 0;
		  param1_01 = *(int **)(param1 + 8);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x160);
		        goto code_r0x81294cd3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,0x14);
		code_r0x81294cd3:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_GameResolver__Resolve(param1,*(undefined4 *)(iVar3 + 0x14),puVar2);
		  return;
		}
		*/

		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B9")]
		[Address(RVA = "0xB238", Offset = "0xB238", VA = "0xB238")]
		private void HandleGameInstanceDeinitEvent(IGame game)
		{
		/* --- GHIDRA: HandleGameInstanceDeinitEvent ---
		void Core_Gameplay_GameResolver__HandleGameInstanceDeinitEvent
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a924 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGame__TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_GameResolver_HandleGameInstanceDeinitEvent__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8439);
		    DAT_ram_00a5a924 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x81294da2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,5);
		code_r0x81294da2:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (iVar3 != 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_8439,0);
		    return;
		  }
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(System_Action_IGame__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Core_Gameplay_GameResolver_HandleGameInstanceDeinitEvent__,0);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x81294e40;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,2);
		code_r0x81294e40:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param1_00,puVar2[1]);
		  uVar1 = 0;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x81294ebc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,8);
		code_r0x81294ebc:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x060066BA RID: 26298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BA")]
		[Address(RVA = "0xB239", Offset = "0xB239", VA = "0xB239", Slot = "4")]
		public void Resolve(IGame game)
		{
		/* --- GHIDRA: Resolve ---
		void Core_Gameplay_GameResolver__Resolve(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a925 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_GameDefault_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_GameTutorialV2_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo)
		    ;
		    DAT_ram_00a5a925 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8128f214;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8128f214:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (iVar4 == 0) {
		    param1_00 = (int *)unnamed_function_1417(Core_Gameplay_GameTutorialV2_TypeInfo);
		    if (DAT_ram_00a5a905 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		      DAT_ram_00a5a905 = '\x01';
		    }
		    iVar4 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		    Gameplay_Combat_Control_Conveyor__Next(iVar4,0);
		    param1_00[8] = iVar4;
		  }
		  else {
		    param1_00 = (int *)unnamed_function_1417(Core_Gameplay_GameDefault_TypeInfo);
		    if (DAT_ram_00a5a905 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		      DAT_ram_00a5a905 = '\x01';
		    }
		    iVar4 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		    Gameplay_Combat_Control_Conveyor__Next(iVar4,0);
		    param1_00[8] = iVar4;
		    piVar3 = *(int **)(param1 + 8);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		          goto code_r0x8128f323;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xc);
		code_r0x8128f323:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    piVar3 = *(int **)(iVar4 + 0x28);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf8);
		          goto code_r0x8128f3a8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,
		                                  Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo,
		                                  7);
		code_r0x8128f3a8:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1_00,puVar2[1]);
		  }
		  uVar1 = 0;
		  uVar5 = *(undefined4 *)(param1 + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf8);
		        goto code_r0x8128f430;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,7);
		code_r0x8128f430:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar5,puVar2[1]);
		  if (DAT_ram_00a5aa02 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a5aa02 = '\x01';
		  }
		  **(int **)(Core_Gameplay_Game_TypeInfo + 0x5c) = (int)param1_00;
		  return;
		}
		*/

		/* --- GHIDRA: Resolve ---
		void Core_Gameplay_GameResolver__Resolve(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a925 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_GameDefault_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_GameTutorialV2_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo)
		    ;
		    DAT_ram_00a5a925 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8128f214;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x8128f214:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (iVar4 == 0) {
		    param1_00 = (int *)unnamed_function_1417(Core_Gameplay_GameTutorialV2_TypeInfo);
		    if (DAT_ram_00a5a905 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		      DAT_ram_00a5a905 = '\x01';
		    }
		    iVar4 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		    Gameplay_Combat_Control_Conveyor__Next(iVar4,0);
		    param1_00[8] = iVar4;
		  }
		  else {
		    param1_00 = (int *)unnamed_function_1417(Core_Gameplay_GameDefault_TypeInfo);
		    if (DAT_ram_00a5a905 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		      DAT_ram_00a5a905 = '\x01';
		    }
		    iVar4 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		    Gameplay_Combat_Control_Conveyor__Next(iVar4,0);
		    param1_00[8] = iVar4;
		    piVar3 = *(int **)(param1 + 8);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		          goto code_r0x8128f323;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xc);
		code_r0x8128f323:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    piVar3 = *(int **)(iVar4 + 0x28);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf8);
		          goto code_r0x8128f3a8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,
		                                  Core_Application_Managers_Connection_IRecoveryConnection_TypeInfo,
		                                  7);
		code_r0x8128f3a8:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1_00,puVar2[1]);
		  }
		  uVar1 = 0;
		  uVar5 = *(undefined4 *)(param1 + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf8);
		        goto code_r0x8128f430;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,7);
		code_r0x8128f430:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar5,puVar2[1]);
		  if (DAT_ram_00a5aa02 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a5aa02 = '\x01';
		  }
		  **(int **)(Core_Gameplay_Game_TypeInfo + 0x5c) = (int)param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060066BB RID: 26299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0xB23A", Offset = "0xB23A", VA = "0xB23A", Slot = "5")]
		public void Resolve(IAuthDataProvider provider)
		{
		}

		// Token: 0x040036E9 RID: 14057
		[Token(Token = "0x40036E9")]
		[FieldOffset(Offset = "0x8")]
		private readonly IApp _app;
	}
}
