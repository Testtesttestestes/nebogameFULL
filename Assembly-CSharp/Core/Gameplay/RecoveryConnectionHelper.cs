using System;
using System.Runtime.CompilerServices;
using Core.Application.Managers;
using Core.Application.Managers.Connection;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.Location;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Utils;

namespace Core.Gameplay
{
	// Token: 0x0200111E RID: 4382
	[Token(Token = "0x200111E")]
	public class RecoveryConnectionHelper : IRecoveryConnection, IDisposable
	{
		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x060066A2 RID: 26274 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060066A3 RID: 26275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E2")]
		[CanBeNull]
		public ILoginProvider AuthLogin
		{
			[Token(Token = "0x60066A2")]
			[Address(RVA = "0xB223", Offset = "0xB223", VA = "0xB223", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066A3")]
			[Address(RVA = "0xB224", Offset = "0xB224", VA = "0xB224", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060066A5 RID: 26277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E3")]
		[CanBeNull]
		public ILocation Location
		{
			[Token(Token = "0x60066A4")]
			[Address(RVA = "0xB225", Offset = "0xB225", VA = "0xB225", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066A5")]
			[Address(RVA = "0xB226", Offset = "0xB226", VA = "0xB226", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060066A7 RID: 26279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E4")]
		[CanBeNull]
		public IClientState ClientState
		{
			[Token(Token = "0x60066A6")]
			[Address(RVA = "0xB227", Offset = "0xB227", VA = "0xB227", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066A7")]
			[Address(RVA = "0xB228", Offset = "0xB228", VA = "0xB228", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060066A9 RID: 26281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E5")]
		[CanBeNull]
		public IGame Game
		{
			[Token(Token = "0x60066A8")]
			[Address(RVA = "0xB229", Offset = "0xB229", VA = "0xB229", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066A9")]
			[Address(RVA = "0xB22A", Offset = "0xB22A", VA = "0xB22A", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AA")]
		[Address(RVA = "0xB22B", Offset = "0xB22B", VA = "0xB22B", Slot = "13")]
		public void Dispose()
		{
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AB")]
		[Address(RVA = "0xB22C", Offset = "0xB22C", VA = "0xB22C")]
		public RecoveryConnectionHelper(PlatformSigninManager platformSignin)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_RecoveryConnectionHelper___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a91b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_RecoveryConnectionHelper__Resolve_d__19___
		              );
		    DAT_ram_00a5a91b = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_RecoveryConnectionHelper__Handler_d__20_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_RecoveryConnectionHelper__Resolve_d__19___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060066AC RID: 26284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AC")]
		[Address(RVA = "0xB22D", Offset = "0xB22D", VA = "0xB22D", Slot = "12")]
		public void Resolve()
		{
		/* --- GHIDRA: Resolve ---
		void Core_Gameplay_RecoveryConnectionHelper__Resolve
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a91c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_RecoveryConnectionHelper__Handler_d__20___
		              );
		    DAT_ram_00a5a91c = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  local_c = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_PreloaderFetcher__Fetch_d__8_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_RecoveryConnectionHelper__Handler_d__20___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060066AD RID: 26285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AD")]
		[Address(RVA = "0xB22E", Offset = "0xB22E", VA = "0xB22E")]
		private void Handler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: Handler ---
		void Core_Gameplay_RecoveryConnectionHelper__Handler
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a91d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_RecoveryConnectionHelper_Handler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a91d = '\x01';
		  }
		  if ((*(int *)(param3 + 0xc) == 0) && (*(int *)(param1 + 0x18) != 0)) {
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_MainService___);
		    uVar2 = ServicesNamespace_MainService__SwapSlots(uVar2,0);
		    piVar4 = *(int **)(param1 + 0x18);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x81290a53;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81290a53:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120);
		          goto code_r0x81290ad7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0xc);
		code_r0x81290ad7:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar2 = DG_Tweening_TweenParams__SetId
		                      (uVar2,*(undefined4 *)(iVar5 + 0x34),
		                       Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,Method_Core_Gameplay_RecoveryConnectionHelper_Handler__,0);
		    ServicesNamespace_MainService__GetUserStats
		              (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x040036DA RID: 14042
		[Token(Token = "0x40036DA")]
		[FieldOffset(Offset = "0x8")]
		private PlatformSigninManager _platformSignin;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Game ---
		void Core_Gameplay_RecoveryConnectionHelper__set_Game(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 8) = 0;
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

}
